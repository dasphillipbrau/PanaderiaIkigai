
namespace PanaderiaIkigai.UI.Menus
{
    partial class DataMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCleanDatabase = new System.Windows.Forms.Button();
            this.btnCreateLocalBackup = new System.Windows.Forms.Button();
            this.btnBackupToGDrive = new System.Windows.Forms.Button();
            this.btnChangeDatabase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGoToMainMenu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastLocalBackupLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastAutoBackupDate = new System.Windows.Forms.TextBox();
            this.txtLastManualBackupDate = new System.Windows.Forms.TextBox();
            this.txtDateOfLastWipe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnEnableAutoBackups = new System.Windows.Forms.RadioButton();
            this.rBtnDisableAutoBackups = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manejo de Datos";
            // 
            // btnCleanDatabase
            // 
            this.btnCleanDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnCleanDatabase.ForeColor = System.Drawing.Color.Beige;
            this.btnCleanDatabase.Location = new System.Drawing.Point(17, 70);
            this.btnCleanDatabase.Name = "btnCleanDatabase";
            this.btnCleanDatabase.Size = new System.Drawing.Size(194, 68);
            this.btnCleanDatabase.TabIndex = 3;
            this.btnCleanDatabase.Text = "Borrar todos los datos";
            this.btnCleanDatabase.UseVisualStyleBackColor = false;
            this.btnCleanDatabase.Click += new System.EventHandler(this.btnCleanDatabase_Click);
            // 
            // btnCreateLocalBackup
            // 
            this.btnCreateLocalBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnCreateLocalBackup.ForeColor = System.Drawing.Color.Beige;
            this.btnCreateLocalBackup.Location = new System.Drawing.Point(17, 158);
            this.btnCreateLocalBackup.Name = "btnCreateLocalBackup";
            this.btnCreateLocalBackup.Size = new System.Drawing.Size(194, 68);
            this.btnCreateLocalBackup.TabIndex = 4;
            this.btnCreateLocalBackup.Text = "Respaldo Local";
            this.btnCreateLocalBackup.UseVisualStyleBackColor = false;
            this.btnCreateLocalBackup.Click += new System.EventHandler(this.btnCreateLocalBackup_Click);
            // 
            // btnBackupToGDrive
            // 
            this.btnBackupToGDrive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnBackupToGDrive.ForeColor = System.Drawing.Color.Beige;
            this.btnBackupToGDrive.Location = new System.Drawing.Point(17, 254);
            this.btnBackupToGDrive.Name = "btnBackupToGDrive";
            this.btnBackupToGDrive.Size = new System.Drawing.Size(194, 68);
            this.btnBackupToGDrive.TabIndex = 5;
            this.btnBackupToGDrive.Text = "Respaldo en Google Drive";
            this.btnBackupToGDrive.UseVisualStyleBackColor = false;
            this.btnBackupToGDrive.Click += new System.EventHandler(this.btnBackupToGDrive_Click);
            // 
            // btnChangeDatabase
            // 
            this.btnChangeDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnChangeDatabase.ForeColor = System.Drawing.Color.Beige;
            this.btnChangeDatabase.Location = new System.Drawing.Point(17, 345);
            this.btnChangeDatabase.Name = "btnChangeDatabase";
            this.btnChangeDatabase.Size = new System.Drawing.Size(194, 68);
            this.btnChangeDatabase.TabIndex = 6;
            this.btnChangeDatabase.Text = "Seleccionar Archivo de Base de Datos";
            this.btnChangeDatabase.UseVisualStyleBackColor = false;
            this.btnChangeDatabase.Click += new System.EventHandler(this.btnChangeDatabase_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Archivo de Base de datos Seleccionado";
            // 
            // txtCurrentDatabase
            // 
            this.txtCurrentDatabase.Location = new System.Drawing.Point(221, 382);
            this.txtCurrentDatabase.Multiline = true;
            this.txtCurrentDatabase.Name = "txtCurrentDatabase";
            this.txtCurrentDatabase.ReadOnly = true;
            this.txtCurrentDatabase.Size = new System.Drawing.Size(568, 31);
            this.txtCurrentDatabase.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha de Último Respaldo Automático";
            // 
            // btnGoToMainMenu
            // 
            this.btnGoToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToMainMenu.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToMainMenu.Location = new System.Drawing.Point(17, 433);
            this.btnGoToMainMenu.Name = "btnGoToMainMenu";
            this.btnGoToMainMenu.Size = new System.Drawing.Size(194, 68);
            this.btnGoToMainMenu.TabIndex = 10;
            this.btnGoToMainMenu.Text = "Volver al Menú Principal";
            this.btnGoToMainMenu.UseVisualStyleBackColor = false;
            this.btnGoToMainMenu.Click += new System.EventHandler(this.btnGoToMainMenu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fecha de Último Respaldo Manual";
            // 
            // txtLastLocalBackupLocation
            // 
            this.txtLastLocalBackupLocation.Location = new System.Drawing.Point(221, 213);
            this.txtLastLocalBackupLocation.Multiline = true;
            this.txtLastLocalBackupLocation.Name = "txtLastLocalBackupLocation";
            this.txtLastLocalBackupLocation.ReadOnly = true;
            this.txtLastLocalBackupLocation.Size = new System.Drawing.Size(568, 25);
            this.txtLastLocalBackupLocation.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha de Última Limpieza Total";
            // 
            // txtLastAutoBackupDate
            // 
            this.txtLastAutoBackupDate.Location = new System.Drawing.Point(224, 271);
            this.txtLastAutoBackupDate.Name = "txtLastAutoBackupDate";
            this.txtLastAutoBackupDate.ReadOnly = true;
            this.txtLastAutoBackupDate.Size = new System.Drawing.Size(130, 20);
            this.txtLastAutoBackupDate.TabIndex = 14;
            // 
            // txtLastManualBackupDate
            // 
            this.txtLastManualBackupDate.Location = new System.Drawing.Point(221, 175);
            this.txtLastManualBackupDate.Name = "txtLastManualBackupDate";
            this.txtLastManualBackupDate.ReadOnly = true;
            this.txtLastManualBackupDate.Size = new System.Drawing.Size(130, 20);
            this.txtLastManualBackupDate.TabIndex = 15;
            // 
            // txtDateOfLastWipe
            // 
            this.txtDateOfLastWipe.Location = new System.Drawing.Point(224, 95);
            this.txtDateOfLastWipe.Name = "txtDateOfLastWipe";
            this.txtDateOfLastWipe.ReadOnly = true;
            this.txtDateOfLastWipe.Size = new System.Drawing.Size(130, 20);
            this.txtDateOfLastWipe.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Ubicación Original del Último Respaldo Manual";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnDisableAutoBackups);
            this.groupBox1.Controls.Add(this.rBtnEnableAutoBackups);
            this.groupBox1.Location = new System.Drawing.Point(421, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 68);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habilitar Respaldos Automáticos";
            // 
            // rBtnEnableAutoBackups
            // 
            this.rBtnEnableAutoBackups.AutoSize = true;
            this.rBtnEnableAutoBackups.Location = new System.Drawing.Point(6, 18);
            this.rBtnEnableAutoBackups.Name = "rBtnEnableAutoBackups";
            this.rBtnEnableAutoBackups.Size = new System.Drawing.Size(63, 17);
            this.rBtnEnableAutoBackups.TabIndex = 0;
            this.rBtnEnableAutoBackups.TabStop = true;
            this.rBtnEnableAutoBackups.Text = "Habilitar";
            this.rBtnEnableAutoBackups.UseVisualStyleBackColor = true;
            this.rBtnEnableAutoBackups.CheckedChanged += new System.EventHandler(this.rBtnEnableAutoBackups_CheckedChanged);
            // 
            // rBtnDisableAutoBackups
            // 
            this.rBtnDisableAutoBackups.AutoSize = true;
            this.rBtnDisableAutoBackups.Location = new System.Drawing.Point(6, 41);
            this.rBtnDisableAutoBackups.Name = "rBtnDisableAutoBackups";
            this.rBtnDisableAutoBackups.Size = new System.Drawing.Size(80, 17);
            this.rBtnDisableAutoBackups.TabIndex = 1;
            this.rBtnDisableAutoBackups.TabStop = true;
            this.rBtnDisableAutoBackups.Text = "Deshabilitar";
            this.rBtnDisableAutoBackups.UseVisualStyleBackColor = true;
            this.rBtnDisableAutoBackups.CheckedChanged += new System.EventHandler(this.rBtnDisableAutoBackups_CheckedChanged);
            // 
            // DataMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(801, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDateOfLastWipe);
            this.Controls.Add(this.txtLastManualBackupDate);
            this.Controls.Add(this.txtLastAutoBackupDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastLocalBackupLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGoToMainMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurrentDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChangeDatabase);
            this.Controls.Add(this.btnBackupToGDrive);
            this.Controls.Add(this.btnCreateLocalBackup);
            this.Controls.Add(this.btnCleanDatabase);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "DataMenu";
            this.Text = "Manejo de Datos";
            this.Load += new System.EventHandler(this.DataMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCleanDatabase;
        private System.Windows.Forms.Button btnCreateLocalBackup;
        private System.Windows.Forms.Button btnBackupToGDrive;
        private System.Windows.Forms.Button btnChangeDatabase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGoToMainMenu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastLocalBackupLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastAutoBackupDate;
        private System.Windows.Forms.TextBox txtLastManualBackupDate;
        private System.Windows.Forms.TextBox txtDateOfLastWipe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnDisableAutoBackups;
        private System.Windows.Forms.RadioButton rBtnEnableAutoBackups;
    }
}