
namespace PanaderiaIkigai.UI.Menus
{
    partial class ClientsMenu
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
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnGoToMainMenu = new System.Windows.Forms.Button();
            this.btnGoToEditClient = new System.Windows.Forms.Button();
            this.btnGoToRegisterClientPanel = new System.Windows.Forms.Button();
            this.panelHolder = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToViewClients = new System.Windows.Forms.Button();
            this.btnGoToViewClientOrderHistory = new System.Windows.Forms.Button();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.panelNavigation.Controls.Add(this.btnGoToViewClientOrderHistory);
            this.panelNavigation.Controls.Add(this.btnGoToViewClients);
            this.panelNavigation.Controls.Add(this.btnGoToMainMenu);
            this.panelNavigation.Controls.Add(this.btnGoToEditClient);
            this.panelNavigation.Controls.Add(this.btnGoToRegisterClientPanel);
            this.panelNavigation.Location = new System.Drawing.Point(12, 35);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(200, 593);
            this.panelNavigation.TabIndex = 2;
            // 
            // btnGoToMainMenu
            // 
            this.btnGoToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToMainMenu.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToMainMenu.Location = new System.Drawing.Point(3, 364);
            this.btnGoToMainMenu.Name = "btnGoToMainMenu";
            this.btnGoToMainMenu.Size = new System.Drawing.Size(194, 68);
            this.btnGoToMainMenu.TabIndex = 4;
            this.btnGoToMainMenu.Text = "Volver al Menú Principal";
            this.btnGoToMainMenu.UseVisualStyleBackColor = false;
            this.btnGoToMainMenu.Click += new System.EventHandler(this.btnGoToMainMenu_Click);
            // 
            // btnGoToEditClient
            // 
            this.btnGoToEditClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToEditClient.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToEditClient.Location = new System.Drawing.Point(3, 128);
            this.btnGoToEditClient.Name = "btnGoToEditClient";
            this.btnGoToEditClient.Size = new System.Drawing.Size(194, 68);
            this.btnGoToEditClient.TabIndex = 2;
            this.btnGoToEditClient.Text = "Editar Clientes";
            this.btnGoToEditClient.UseVisualStyleBackColor = false;
            this.btnGoToEditClient.Click += new System.EventHandler(this.btnGoToEditRecipe_Click);
            // 
            // btnGoToRegisterClientPanel
            // 
            this.btnGoToRegisterClientPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToRegisterClientPanel.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToRegisterClientPanel.Location = new System.Drawing.Point(3, 25);
            this.btnGoToRegisterClientPanel.Name = "btnGoToRegisterClientPanel";
            this.btnGoToRegisterClientPanel.Size = new System.Drawing.Size(194, 68);
            this.btnGoToRegisterClientPanel.TabIndex = 1;
            this.btnGoToRegisterClientPanel.Text = "Registrar Clientes";
            this.btnGoToRegisterClientPanel.UseVisualStyleBackColor = false;
            this.btnGoToRegisterClientPanel.Click += new System.EventHandler(this.btnGoToRegisterClientPanel_Click);
            // 
            // panelHolder
            // 
            this.panelHolder.Location = new System.Drawing.Point(218, 12);
            this.panelHolder.Name = "panelHolder";
            this.panelHolder.Size = new System.Drawing.Size(888, 633);
            this.panelHolder.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menú de Clientes";
            // 
            // btnGoToViewClients
            // 
            this.btnGoToViewClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToViewClients.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToViewClients.Location = new System.Drawing.Point(3, 212);
            this.btnGoToViewClients.Name = "btnGoToViewClients";
            this.btnGoToViewClients.Size = new System.Drawing.Size(194, 68);
            this.btnGoToViewClients.TabIndex = 5;
            this.btnGoToViewClients.Text = "Consulta de Clientes";
            this.btnGoToViewClients.UseVisualStyleBackColor = false;
            this.btnGoToViewClients.Click += new System.EventHandler(this.btnGoToViewClients_Click);
            // 
            // btnGoToViewClientOrderHistory
            // 
            this.btnGoToViewClientOrderHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToViewClientOrderHistory.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToViewClientOrderHistory.Location = new System.Drawing.Point(3, 286);
            this.btnGoToViewClientOrderHistory.Name = "btnGoToViewClientOrderHistory";
            this.btnGoToViewClientOrderHistory.Size = new System.Drawing.Size(194, 68);
            this.btnGoToViewClientOrderHistory.TabIndex = 6;
            this.btnGoToViewClientOrderHistory.Text = "Historial de Ordenes de Clientes";
            this.btnGoToViewClientOrderHistory.UseVisualStyleBackColor = false;
            this.btnGoToViewClientOrderHistory.Click += new System.EventHandler(this.btnGoToViewClientOrderHistory_Click);
            // 
            // ClientsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1118, 640);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelHolder);
            this.Controls.Add(this.panelNavigation);
            this.Name = "ClientsMenu";
            this.Text = "Menú de Clientes";
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnGoToMainMenu;
        private System.Windows.Forms.Button btnGoToEditClient;
        private System.Windows.Forms.Button btnGoToRegisterClientPanel;
        private System.Windows.Forms.Panel panelHolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToViewClientOrderHistory;
        private System.Windows.Forms.Button btnGoToViewClients;
    }
}