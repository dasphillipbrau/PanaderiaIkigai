using PanaderiaIkigai.Data;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void CopyDatabase()
        {
            try
            {
                string sourceFileRelative = ".\\Data\\Ikigai.db";
                string sourceFileAbsolute = Path.GetFullPath(sourceFileRelative);

                string localLogFileRelative = ".\\Backups\\backup-history-local.txt";
                string localLogFileAbsolute = Path.GetFullPath(localLogFileRelative);

                DateTime timestamp = DateTime.Now;
                var unixStamp = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();

                string destinationFileRelative = ".\\Backups\\Ikigai-Backup-" + unixStamp.ToString() + ".db";
                System.Diagnostics.Debug.WriteLine(destinationFileRelative);
                string destinationFileAbsolute = Path.GetFullPath(destinationFileRelative);
                File.Copy(sourceFileAbsolute, destinationFileAbsolute);

                

                using(StreamWriter sw = File.AppendText(localLogFileRelative))
                {
                    sw.WriteLine("FECHA " + timestamp.ToString() + " CORRESPONDE A " + Path.GetFileName(destinationFileAbsolute));
                }
                MessageBox.Show("Ubicación del Respaldo: " + destinationFileAbsolute, "Respaldo Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message, "Error creando respaldo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BackupToGoogleDrive()
        {
            try
            {
                string sourceFileRelative = ".\\Data\\Ikigai.db";
                string sourceFileAbsolute = Path.GetFullPath(sourceFileRelative);

                string driveLogFileRelative = ".\\Backups\\backup-history-drive.txt";
                string driveLogFileAbsolute = Path.GetFullPath(driveLogFileRelative);

                DateTime timestamp = DateTime.Now;
                var unixStamp = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();

                string destinationFileRelative = ".\\Backups\\Ikigai-Backup-GDRIVE-" + unixStamp.ToString() + ".db";
                string destinationFileAbsolute = Path.GetFullPath(destinationFileRelative);
                File.Copy(sourceFileAbsolute, destinationFileAbsolute);
                var driveFileId = GoogleDrive.DriveApi.BackupDatabase(destinationFileAbsolute);
                if (driveFileId != null)
                {
                    using (StreamWriter sw = File.AppendText(driveLogFileAbsolute))
                    {
                        sw.WriteLine("FECHA " + timestamp.ToString() + " CORRESPONDE A " + Path.GetFileName(destinationFileAbsolute));
                    }
                    MessageBox.Show("Identificador del archivo en Google Drive: " + driveFileId, "Respaldo Creado en Google Drive", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se ha logrado respaldar a Google Drive", "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Error creando respaldo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ha ocurrido un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    
}
