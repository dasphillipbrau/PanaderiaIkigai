
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
            this.btnCleanDatabase.Location = new System.Drawing.Point(17, 67);
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
            this.btnCreateLocalBackup.Location = new System.Drawing.Point(17, 170);
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
            this.btnBackupToGDrive.Location = new System.Drawing.Point(17, 267);
            this.btnBackupToGDrive.Name = "btnBackupToGDrive";
            this.btnBackupToGDrive.Size = new System.Drawing.Size(194, 68);
            this.btnBackupToGDrive.TabIndex = 5;
            this.btnBackupToGDrive.Text = "Respaldo en Google Drive";
            this.btnBackupToGDrive.UseVisualStyleBackColor = false;
            this.btnBackupToGDrive.Click += new System.EventHandler(this.btnBackupToGDrive_Click);
            // 
            // DataMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBackupToGDrive);
            this.Controls.Add(this.btnCreateLocalBackup);
            this.Controls.Add(this.btnCleanDatabase);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "DataMenu";
            this.Text = "Manejo de Datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCleanDatabase;
        private System.Windows.Forms.Button btnCreateLocalBackup;
        private System.Windows.Forms.Button btnBackupToGDrive;
    }
}