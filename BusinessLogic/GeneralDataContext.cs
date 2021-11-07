using PanaderiaIkigai.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PanaderiaIkigai.BusinessLogic
{
    public class GeneralDataContext
    {
        static SQLiteGeneralDataManagement dataAccess = new SQLiteGeneralDataManagement();

        public void WipeDatabase()
        {
            try
            {
                dataAccess.WipeTables();
            }
            catch(SQLiteException sqlEX)
            {
                MessageBox.Show(sqlEX.Message, sqlEX.ErrorCode.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string CopyDatabase()
        {
            try
            {
                string sourceFileRelative = ".\\Data\\Ikigai.db";
                string sourceFileAbsolute = Path.GetFullPath(sourceFileRelative);

                string localLogFileRelative = ".\\Backups\\backup-history-local.txt";
                string localLogFileAbsolute = Path.GetFullPath(localLogFileRelative);

                DateTime timestamp = DateTime.Now;
                var unixStamp = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
                string destinationFileAbsolute = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Ikigai-Backup-" + unixStamp.ToString() + ".db";
                File.Copy(sourceFileAbsolute, destinationFileAbsolute);

                using(StreamWriter sw = File.AppendText(localLogFileRelative))
                {
                    sw.WriteLine("FECHA " + timestamp.ToString() + " CORRESPONDE A " + Path.GetFileName(destinationFileAbsolute));
                }
                MessageBox.Show("Ubicación del Respaldo: " + destinationFileAbsolute, "Respaldo Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDateOfLatestDataAction(1);
                UpdateManualBackupLocation(destinationFileAbsolute);
                return destinationFileAbsolute;
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message, "Error creando respaldo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool BackupToGoogleDrive()
        {
            try
            {
                string sourceFileRelative = ".\\Data\\Ikigai.db";
                string sourceFileAbsolute = Path.GetFullPath(sourceFileRelative);

                string driveLogFileRelative = ".\\Backups\\backup-history-drive.txt";
                string driveLogFileAbsolute = Path.GetFullPath(driveLogFileRelative);

                DateTime timestamp = DateTime.Now;
                var unixStamp = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();

                string destinationFileRelative = ".\\Backups\\Ikigai-Backup-GDRIVE-" + timestamp.ToString("dd-mm-yyyy") + "-" + unixStamp + ".db";
                string destinationFileAbsolute = Path.GetFullPath(destinationFileRelative);
                File.Copy(sourceFileAbsolute, destinationFileAbsolute);

                string driveFileId = null;
                if(File.Exists(destinationFileAbsolute))
                    driveFileId = GoogleDrive.DriveApi.BackupDatabase(destinationFileAbsolute);
                if (driveFileId != null)
                {
                    using (StreamWriter sw = File.AppendText(driveLogFileAbsolute))
                    {
                        sw.WriteLine("RESPALDO CREADO: " + timestamp.ToString() + ". CORRESPONDE A " + unixStamp.ToString());
                    }
                    MessageBox.Show("Identificador del archivo en Google Drive: " + driveFileId, "Respaldo Creado en Google Drive", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;

                }
                else
                {
                    MessageBox.Show("No se ha logrado respaldar a Google Drive", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }



            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error creando respaldo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool StartAutoBackup()
        {
            if (BackupToGoogleDrive())
            {
                UpdateDateOfLatestDataAction(0);
                return true;
            }
                
            else
                return false;
        }

        public bool ChangeDatabaseFile()
        {
            try
            {
                string newDbPath = "";
                OpenFileDialog fileBrowser = new OpenFileDialog();
                string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                fileBrowser.InitialDirectory = myDocumentsPath;
                fileBrowser.Filter = "Archivos de Base de Datos |*.db";
                fileBrowser.FilterIndex = 0;
                fileBrowser.Multiselect = false;
                fileBrowser.CheckFileExists = true;
                fileBrowser.CheckPathExists = true;
                if (fileBrowser.ShowDialog() == DialogResult.OK)
                {
                    newDbPath = fileBrowser.FileName;
                }
                if (!newDbPath.Equals("") && File.Exists(newDbPath))
                {
                    XmlDocument doc = new XmlDocument();

                    doc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

                    foreach (XmlElement elem in doc.DocumentElement)
                    {
                        if (elem.Name == "connectionStrings")
                        {
                            var firstNode = elem.ChildNodes[0];
                            var secondNode = elem.ChildNodes[1];
                            firstNode.Attributes[1].Value = "Data Source = " + newDbPath + ";Version=3;foreign keys=true";
                            secondNode.Attributes[1].Value = "Data Source = " + newDbPath + ";Version=3;";
                        }
                    }
                    doc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

                    ConfigurationManager.RefreshSection("connectionStrings");
                    if (!newDbPath.Equals("") && !TestDatabase())
                        ChangeDatabaseFile();
                    else 
                    { 
                        MessageBox.Show("El archivo de base de datos utilizado actualmente está en \n" + newDbPath, "Archivo de base de datos Cambiado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    return false;
                }
                else
                    throw new FileNotFoundException("El archivo seleccionado no existe");
            }
            catch (FileNotFoundException fileEx)
            {
                MessageBox.Show(fileEx.Message, "No se encuentra el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch(SQLiteException sqlEx)
            {
                MessageBox.Show("El archivo seleccionado no es una base de datos válida.", "Ha ocurrido un Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool TestDatabase()
        {
            if (dataAccess.TestDatabaseConnection())
                return true;
            else
                return false;
        }

        public void ShowDateOfLatestDataAction(TextBox pTextBox, int childNodeIndex)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("./DatesAndLocations.xml");
            string date = "";
            foreach (XmlElement elem in doc.DocumentElement)
            {
                if (elem.Name == "dates")
                {
                    var latestDate = elem.ChildNodes[childNodeIndex];
                    date = DateTime.Parse(latestDate.Attributes[0].Value).ToString("dd-MM-yyyy");
 
                }
            }
            pTextBox.Text = date;
        }

        public string ShowDateOfLatestDataAction(int childNodeIndex)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("./DatesAndLocations.xml");
            string date = "";
            foreach (XmlElement elem in doc.DocumentElement)
            {
                if (elem.Name == "dates")
                {
                    var latestDate = elem.ChildNodes[childNodeIndex];
                    date = DateTime.Parse(latestDate.Attributes[0].Value).ToString("dd-MM-yyyy");

                }
            }
            return date;
        }

        public void UpdateDateOfLatestDataAction(int childNodeIndex)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("./DatesAndLocations.xml");

            foreach (XmlElement elem in doc.DocumentElement)
            {
                if (elem.Name == "dates")
                {
                    var elementToUpdate = elem.ChildNodes[childNodeIndex];
                    elementToUpdate.Attributes[0].Value = DateTime.Now.Date.ToString("dd-MM-yyyy");
                }
            }

            doc.Save("./DatesAndLocations.xml");
            
        }

        public void UpdateManualBackupLocation(string path)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("./DatesAndLocations.xml");
            foreach (XmlElement elem in doc.DocumentElement)
            {
                if (elem.Name == "backupLocations")
                {
                    var elementToUpdate = elem.ChildNodes[0];
                    elementToUpdate.Attributes[0].Value = path;
                }
            }
            doc.Save("./DatesAndLocations.xml");
        }

        public void ShowManualBackupLocation(TextBox pTextbox)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("./DatesAndLocations.xml");
            string path = "";
            foreach (XmlElement elem in doc.DocumentElement)
            {
                if (elem.Name == "backupLocations")
                {
                    var elementToUpdate = elem.ChildNodes[0];
                    path = elementToUpdate.Attributes[0].Value; 
                }
            }
            pTextbox.Text = path;
        }

        public void AttemptAutoBackup()
        {
            DateTime dateOfLastBackup = DateTime.ParseExact(ShowDateOfLatestDataAction(0), "dd-MM-yyyy", CultureInfo.InvariantCulture).Date;
            DateTime currentDate = DateTime.Now.Date;

            if (CheckAutoBackupStatus()) { 
            if ((currentDate - dateOfLastBackup).TotalDays >= 30)
            {
                MessageBox.Show("Han pasado más de 30 días desde el último respaldo en linea.\nSe iniciará un nuevo respaldo", "Respaldo en Progreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (StartAutoBackup())
                {
                    MessageBox.Show("Respaldo Automático Subido a Google Drive.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Respaldo automático ha fallado. Asegurese de tener su sesión de Google Drive abierta", "Ha ocurrido un Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            }
        }

        public bool CheckAutoBackupStatus()
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("./DatesAndLocations.xml");

            foreach (XmlElement elem in doc.DocumentElement)
            {
                if (elem.Name == "autoBackupOn")
                {
                    if (elem.InnerText.Equals("FALSE"))
                        return false;
                    else
                        break;
                }
            }
            return true;
            
        }

        public void ChangeAutoBackupStatus(bool pSwitch)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("./DatesAndLocations.xml");

            foreach (XmlElement elem in doc.DocumentElement)
            {
                if (elem.Name == "autoBackupOn")
                {
                    if (pSwitch)
                        elem.InnerText = "TRUE";
                    else
                        elem.InnerText = "FALSE";

                }
            }
            doc.Save("./DatesAndLocations.xml");

        }
    }

    
}
