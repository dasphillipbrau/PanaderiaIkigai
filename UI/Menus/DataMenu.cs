using PanaderiaIkigai.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
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
            dataContext.CopyDatabase();
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
        }
        private void ShowConnectionString()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConstraintsOff"].ConnectionString;
            txtCurrentDatabase.Text = connectionString;
        }
    }
}
