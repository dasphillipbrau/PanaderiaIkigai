
namespace PanaderiaIkigai.UI.Menus
{
    partial class OrdersMenu
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
            this.btnGoToRegisterOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHolder = new System.Windows.Forms.Panel();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.panelNavigation.Controls.Add(this.btnGoToMainMenu);
            this.panelNavigation.Controls.Add(this.btnGoToEditClient);
            this.panelNavigation.Controls.Add(this.btnGoToRegisterOrder);
            this.panelNavigation.Location = new System.Drawing.Point(12, 40);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(200, 588);
            this.panelNavigation.TabIndex = 3;
            // 
            // btnGoToMainMenu
            // 
            this.btnGoToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToMainMenu.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToMainMenu.Location = new System.Drawing.Point(3, 312);
            this.btnGoToMainMenu.Name = "btnGoToMainMenu";
            this.btnGoToMainMenu.Size = new System.Drawing.Size(194, 68);
            this.btnGoToMainMenu.TabIndex = 4;
            this.btnGoToMainMenu.Text = "Volver al Menú Principal";
            this.btnGoToMainMenu.UseVisualStyleBackColor = false;
            // 
            // btnGoToEditClient
            // 
            this.btnGoToEditClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToEditClient.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToEditClient.Location = new System.Drawing.Point(3, 128);
            this.btnGoToEditClient.Name = "btnGoToEditClient";
            this.btnGoToEditClient.Size = new System.Drawing.Size(194, 68);
            this.btnGoToEditClient.TabIndex = 2;
            this.btnGoToEditClient.Text = "Consultar y Editar Clientes";
            this.btnGoToEditClient.UseVisualStyleBackColor = false;
            // 
            // btnGoToRegisterOrder
            // 
            this.btnGoToRegisterOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToRegisterOrder.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToRegisterOrder.Location = new System.Drawing.Point(3, 25);
            this.btnGoToRegisterOrder.Name = "btnGoToRegisterOrder";
            this.btnGoToRegisterOrder.Size = new System.Drawing.Size(194, 68);
            this.btnGoToRegisterOrder.TabIndex = 1;
            this.btnGoToRegisterOrder.Text = "Registrar o Editar Orden";
            this.btnGoToRegisterOrder.UseVisualStyleBackColor = false;
            this.btnGoToRegisterOrder.Click += new System.EventHandler(this.btnGoToRegisterOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menú de Ordenes";
            // 
            // panelHolder
            // 
            this.panelHolder.Location = new System.Drawing.Point(218, 40);
            this.panelHolder.Name = "panelHolder";
            this.panelHolder.Size = new System.Drawing.Size(1855, 683);
            this.panelHolder.TabIndex = 5;
            // 
            // OrdersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(2100, 729);
            this.Controls.Add(this.panelHolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelNavigation);
            this.Name = "OrdersMenu";
            this.Text = "Menú de Ordenes";
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnGoToMainMenu;
        private System.Windows.Forms.Button btnGoToEditClient;
        private System.Windows.Forms.Button btnGoToRegisterOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelHolder;
    }
}