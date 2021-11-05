
namespace PanaderiaIkigai.UI.Menus
{
    partial class BiMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnGoToMainMenu = new System.Windows.Forms.Button();
            this.btnGoToProductBi = new System.Windows.Forms.Button();
            this.btnGoToClientBI = new System.Windows.Forms.Button();
            this.panelHolder = new System.Windows.Forms.Panel();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inteligencia de Negocios";
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.panelNavigation.Controls.Add(this.btnGoToMainMenu);
            this.panelNavigation.Controls.Add(this.btnGoToProductBi);
            this.panelNavigation.Controls.Add(this.btnGoToClientBI);
            this.panelNavigation.Location = new System.Drawing.Point(12, 33);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(200, 682);
            this.panelNavigation.TabIndex = 5;
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
            this.btnGoToMainMenu.Click += new System.EventHandler(this.btnGoToMainMenu_Click);
            // 
            // btnGoToProductBi
            // 
            this.btnGoToProductBi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToProductBi.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToProductBi.Location = new System.Drawing.Point(3, 128);
            this.btnGoToProductBi.Name = "btnGoToProductBi";
            this.btnGoToProductBi.Size = new System.Drawing.Size(194, 68);
            this.btnGoToProductBi.TabIndex = 2;
            this.btnGoToProductBi.Text = "Datos de Receta";
            this.btnGoToProductBi.UseVisualStyleBackColor = false;
            this.btnGoToProductBi.Click += new System.EventHandler(this.btnGoToProductBi_Click);
            // 
            // btnGoToClientBI
            // 
            this.btnGoToClientBI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToClientBI.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToClientBI.Location = new System.Drawing.Point(4, 21);
            this.btnGoToClientBI.Name = "btnGoToClientBI";
            this.btnGoToClientBI.Size = new System.Drawing.Size(194, 68);
            this.btnGoToClientBI.TabIndex = 1;
            this.btnGoToClientBI.Text = "Datos de Clientes";
            this.btnGoToClientBI.UseVisualStyleBackColor = false;
            this.btnGoToClientBI.Click += new System.EventHandler(this.btnGoToClientBI_Click);
            // 
            // panelHolder
            // 
            this.panelHolder.Location = new System.Drawing.Point(219, 33);
            this.panelHolder.Name = "panelHolder";
            this.panelHolder.Size = new System.Drawing.Size(1123, 682);
            this.panelHolder.TabIndex = 6;
            // 
            // BiMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1354, 718);
            this.Controls.Add(this.panelHolder);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.label2);
            this.Name = "BiMenu";
            this.Load += new System.EventHandler(this.BI_Menu_Load);
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnGoToMainMenu;
        private System.Windows.Forms.Button btnGoToProductBi;
        private System.Windows.Forms.Button btnGoToClientBI;
        private System.Windows.Forms.Panel panelHolder;
    }
}
