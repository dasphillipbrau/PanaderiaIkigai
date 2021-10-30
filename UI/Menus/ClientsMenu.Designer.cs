
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
            this.btnGoToRecipeSteps = new System.Windows.Forms.Button();
            this.btnGoToEditRecipe = new System.Windows.Forms.Button();
            this.btnGoToRegisterClientPanel = new System.Windows.Forms.Button();
            this.panelHolder = new System.Windows.Forms.Panel();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.panelNavigation.Controls.Add(this.btnGoToMainMenu);
            this.panelNavigation.Controls.Add(this.btnGoToRecipeSteps);
            this.panelNavigation.Controls.Add(this.btnGoToEditRecipe);
            this.panelNavigation.Controls.Add(this.btnGoToRegisterClientPanel);
            this.panelNavigation.Location = new System.Drawing.Point(12, 12);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(200, 616);
            this.panelNavigation.TabIndex = 2;
            // 
            // btnGoToMainMenu
            // 
            this.btnGoToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToMainMenu.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToMainMenu.Location = new System.Drawing.Point(3, 314);
            this.btnGoToMainMenu.Name = "btnGoToMainMenu";
            this.btnGoToMainMenu.Size = new System.Drawing.Size(194, 68);
            this.btnGoToMainMenu.TabIndex = 4;
            this.btnGoToMainMenu.Text = "Volver al Menú Principal";
            this.btnGoToMainMenu.UseVisualStyleBackColor = false;
            // 
            // btnGoToRecipeSteps
            // 
            this.btnGoToRecipeSteps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToRecipeSteps.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToRecipeSteps.Location = new System.Drawing.Point(3, 229);
            this.btnGoToRecipeSteps.Name = "btnGoToRecipeSteps";
            this.btnGoToRecipeSteps.Size = new System.Drawing.Size(194, 68);
            this.btnGoToRecipeSteps.TabIndex = 3;
            this.btnGoToRecipeSteps.Text = "Pasos de Recetas";
            this.btnGoToRecipeSteps.UseVisualStyleBackColor = false;
            // 
            // btnGoToEditRecipe
            // 
            this.btnGoToEditRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToEditRecipe.ForeColor = System.Drawing.Color.Beige;
            this.btnGoToEditRecipe.Location = new System.Drawing.Point(3, 128);
            this.btnGoToEditRecipe.Name = "btnGoToEditRecipe";
            this.btnGoToEditRecipe.Size = new System.Drawing.Size(194, 68);
            this.btnGoToEditRecipe.TabIndex = 2;
            this.btnGoToEditRecipe.Text = "Editar Recetas y Categorías";
            this.btnGoToEditRecipe.UseVisualStyleBackColor = false;
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
            this.panelHolder.Size = new System.Drawing.Size(698, 633);
            this.panelHolder.TabIndex = 3;
            // 
            // ClientsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(921, 640);
            this.Controls.Add(this.panelHolder);
            this.Controls.Add(this.panelNavigation);
            this.Name = "ClientsMenu";
            this.Text = "ClientsMenu";
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnGoToMainMenu;
        private System.Windows.Forms.Button btnGoToRecipeSteps;
        private System.Windows.Forms.Button btnGoToEditRecipe;
        private System.Windows.Forms.Button btnGoToRegisterClientPanel;
        private System.Windows.Forms.Panel panelHolder;
    }
}