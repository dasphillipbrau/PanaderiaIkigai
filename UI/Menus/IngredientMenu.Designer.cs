
namespace PanaderiaIkigai.Menus
{
    partial class IngredientMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenuStrip = new System.Windows.Forms.Panel();
            this.btnGoToEditDetailedIngredients = new System.Windows.Forms.Button();
            this.btnGoToRegisterDetailedIngredient = new System.Windows.Forms.Button();
            this.btnGoToEditBaseIngredient = new System.Windows.Forms.Button();
            this.btnOpenRegisterBasePanel = new System.Windows.Forms.Button();
            this.panelMenuHolders = new System.Windows.Forms.Panel();
            this.btnGoToMainMenu = new System.Windows.Forms.Button();
            this.panelMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú de Ingredientes";
            // 
            // panelMenuStrip
            // 
            this.panelMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.panelMenuStrip.Controls.Add(this.btnGoToMainMenu);
            this.panelMenuStrip.Controls.Add(this.btnGoToEditDetailedIngredients);
            this.panelMenuStrip.Controls.Add(this.btnGoToRegisterDetailedIngredient);
            this.panelMenuStrip.Controls.Add(this.btnGoToEditBaseIngredient);
            this.panelMenuStrip.Controls.Add(this.btnOpenRegisterBasePanel);
            this.panelMenuStrip.Location = new System.Drawing.Point(13, 63);
            this.panelMenuStrip.Name = "panelMenuStrip";
            this.panelMenuStrip.Size = new System.Drawing.Size(200, 561);
            this.panelMenuStrip.TabIndex = 1;
            // 
            // btnGoToEditDetailedIngredients
            // 
            this.btnGoToEditDetailedIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToEditDetailedIngredients.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToEditDetailedIngredients.Location = new System.Drawing.Point(3, 261);
            this.btnGoToEditDetailedIngredients.Name = "btnGoToEditDetailedIngredients";
            this.btnGoToEditDetailedIngredients.Size = new System.Drawing.Size(194, 68);
            this.btnGoToEditDetailedIngredients.TabIndex = 3;
            this.btnGoToEditDetailedIngredients.Text = "Consultar y Editar Ingredientes Detallados";
            this.btnGoToEditDetailedIngredients.UseVisualStyleBackColor = false;
            this.btnGoToEditDetailedIngredients.Click += new System.EventHandler(this.btnGoToEditDetailedIngredients_Click);
            // 
            // btnGoToRegisterDetailedIngredient
            // 
            this.btnGoToRegisterDetailedIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToRegisterDetailedIngredient.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToRegisterDetailedIngredient.Location = new System.Drawing.Point(3, 187);
            this.btnGoToRegisterDetailedIngredient.Name = "btnGoToRegisterDetailedIngredient";
            this.btnGoToRegisterDetailedIngredient.Size = new System.Drawing.Size(194, 68);
            this.btnGoToRegisterDetailedIngredient.TabIndex = 2;
            this.btnGoToRegisterDetailedIngredient.Text = "Registrar Ingrediente Detallado";
            this.btnGoToRegisterDetailedIngredient.UseVisualStyleBackColor = false;
            this.btnGoToRegisterDetailedIngredient.Click += new System.EventHandler(this.btnGoToRegisterDetailedIngredient_Click);
            // 
            // btnGoToEditBaseIngredient
            // 
            this.btnGoToEditBaseIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToEditBaseIngredient.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToEditBaseIngredient.Location = new System.Drawing.Point(3, 111);
            this.btnGoToEditBaseIngredient.Name = "btnGoToEditBaseIngredient";
            this.btnGoToEditBaseIngredient.Size = new System.Drawing.Size(194, 68);
            this.btnGoToEditBaseIngredient.TabIndex = 1;
            this.btnGoToEditBaseIngredient.Text = "Consultar y Editar Ingredientes Base o Unidades";
            this.btnGoToEditBaseIngredient.UseVisualStyleBackColor = false;
            this.btnGoToEditBaseIngredient.Click += new System.EventHandler(this.btnQueryBaseIngredients_Click);
            // 
            // btnOpenRegisterBasePanel
            // 
            this.btnOpenRegisterBasePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnOpenRegisterBasePanel.ForeColor = System.Drawing.Color.Beige;
            this.btnOpenRegisterBasePanel.Location = new System.Drawing.Point(3, 21);
            this.btnOpenRegisterBasePanel.Name = "btnOpenRegisterBasePanel";
            this.btnOpenRegisterBasePanel.Size = new System.Drawing.Size(194, 68);
            this.btnOpenRegisterBasePanel.TabIndex = 0;
            this.btnOpenRegisterBasePanel.Text = "Registrar un Ingrediente Base o Unidad";
            this.btnOpenRegisterBasePanel.UseVisualStyleBackColor = false;
            this.btnOpenRegisterBasePanel.Click += new System.EventHandler(this.btnOpenRegisterBasePanel_Click);
            // 
            // panelMenuHolders
            // 
            this.panelMenuHolders.Location = new System.Drawing.Point(220, 28);
            this.panelMenuHolders.Name = "panelMenuHolders";
            this.panelMenuHolders.Size = new System.Drawing.Size(1186, 606);
            this.panelMenuHolders.TabIndex = 2;
            // 
            // btnGoToMainMenu
            // 
            this.btnGoToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToMainMenu.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToMainMenu.Location = new System.Drawing.Point(3, 335);
            this.btnGoToMainMenu.Name = "btnGoToMainMenu";
            this.btnGoToMainMenu.Size = new System.Drawing.Size(194, 68);
            this.btnGoToMainMenu.TabIndex = 4;
            this.btnGoToMainMenu.Text = "Volver al Menú Principal";
            this.btnGoToMainMenu.UseVisualStyleBackColor = false;
            this.btnGoToMainMenu.Click += new System.EventHandler(this.btnGoToMainMenu_Click);
            // 
            // IngredientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1418, 646);
            this.Controls.Add(this.panelMenuHolders);
            this.Controls.Add(this.panelMenuStrip);
            this.Controls.Add(this.label1);
            this.Name = "IngredientMenu";
            this.panelMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenuStrip;
        private System.Windows.Forms.Button btnGoToEditBaseIngredient;
        private System.Windows.Forms.Button btnOpenRegisterBasePanel;
        private System.Windows.Forms.Button btnGoToRegisterDetailedIngredient;
        private System.Windows.Forms.Button btnGoToEditDetailedIngredients;
        private System.Windows.Forms.Panel panelMenuHolders;
        private System.Windows.Forms.Button btnGoToMainMenu;
    }
}
