using PanaderiaIkigai.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaIkigai.UI.Menus
{
    public partial class DataMenu : Form
    {
        static GeneralDataContext dataContext = new GeneralDataContext();
        public DataMenu()
        {
            InitializeComponent();
        }

        private void btnCleanDatabase_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("ADVERTENCIA: Está a punto de borrar todos los datos de la base de datos." +
                "\nAsegurese de crear un respaldo antes de esta operación\n\n¿PROCEDER?", "Confirme Operación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dataContext.WipeDatabase();
                MessageBox.Show("La base de datos ha sido limpiada", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCreateLocalBackup_Click(object sender, EventArgs e)
        {
            var localBackupPath = dataContext.CopyDatabase();
            if (localBackupPath != null) {
                dataContext.ShowManualBackupLocation(txtLastLocalBackupLocation);
                txtLastManualBackupDate.Text = dataContext.ShowDateOfLatestDataAction(1);
            }
        }

        private void btnBackupToGDrive_Click(object sender, EventArgs e)
        {
            dataContext.BackupToGoogleDrive();
        }

        private void btnChangeDatabase_Click(object sender, EventArgs e)
        {
            if (dataContext.ChangeDatabaseFile())
                ShowConnectionString();
        }

        private void DataMenu_Load(object sender, EventArgs e)
        {
            ShowConnectionString();
            dataContext.ShowDateOfLatestDataAction(txtLastAutoBackupDate, 0);
            dataContext.ShowDateOfLatestDataAction(txtLastManualBackupDate, 1);
            dataContext.ShowDateOfLatestDataAction(txtDateOfLastWipe, 2);
            dataContext.ShowManualBackupLocation(txtLastLocalBackupLocation);
            if (dataContext.CheckAutoBackupStatus())
            {
                rBtnEnableAutoBackups.Checked = true;
            }
            else
            {
                rBtnDisableAutoBackups.Checked = true;
            }

        }
        private void ShowConnectionString()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConstraintsOff"].ConnectionString;
            txtCurrentDatabase.Text = connectionString;
        }

        private void btnGoToMainMenu_Click(object sender, EventArgs e)
        {
            if (dataContext.TestDatabase())
                Close();
            else
            {
                if(MessageBox.Show("El archivo que ha seleccionado como base de datos es inválido." +
                    "\n¿Está seguro que desea volver al Menú Principal?" +
                    "\nNo podrá acceder a ningun menú de la aplicación excepto este.", "Confirme Operación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void rBtnEnableAutoBackups_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnEnableAutoBackups.Checked)
            {
                dataContext.ChangeAutoBackupStatus(true);
            }
        }

        private void rBtnDisableAutoBackups_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtnEnableAutoBackups.Checked)
            {
                dataContext.ChangeAutoBackupStatus(false);
            }
        }
    }
}
