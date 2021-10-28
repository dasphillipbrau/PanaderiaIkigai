
namespace PanaderiaIkigai.UI.Menus
{
    partial class RecipeMenu
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
            this.btnOpenRegisterBasePanel = new System.Windows.Forms.Button();
            this.panelHolder = new System.Windows.Forms.Panel();
            this.btnGoToEditRecipe = new System.Windows.Forms.Button();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.panelNavigation.Controls.Add(this.btnGoToEditRecipe);
            this.panelNavigation.Controls.Add(this.btnOpenRegisterBasePanel);
            this.panelNavigation.Location = new System.Drawing.Point(12, 12);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(200, 616);
            this.panelNavigation.TabIndex = 1;
            // 
            // btnOpenRegisterBasePanel
            // 
            this.btnOpenRegisterBasePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnOpenRegisterBasePanel.ForeColor = System.Drawing.Color.Beige;
            this.btnOpenRegisterBasePanel.Location = new System.Drawing.Point(3, 25);
            this.btnOpenRegisterBasePanel.Name = "btnOpenRegisterBasePanel";
            this.btnOpenRegisterBasePanel.Size = new System.Drawing.Size(194, 68);
            this.btnOpenRegisterBasePanel.TabIndex = 1;
            this.btnOpenRegisterBasePanel.Text = "Registrar Recetas y Categorías";
            this.btnOpenRegisterBasePanel.UseVisualStyleBackColor = false;
            this.btnOpenRegisterBasePanel.Click += new System.EventHandler(this.btnOpenRegisterBasePanel_Click);
            // 
            // panelHolder
            // 
            this.panelHolder.Location = new System.Drawing.Point(218, 5);
            this.panelHolder.Name = "panelHolder";
            this.panelHolder.Size = new System.Drawing.Size(1234, 633);
            this.panelHolder.TabIndex = 2;
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
            this.btnGoToEditRecipe.Click += new System.EventHandler(this.btnGoToEditRecipe_Click);
            // 
            // RecipeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1464, 640);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelHolder);
            this.Name = "RecipeMenu";
            this.Text = "RecipeMenu";
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnOpenRegisterBasePanel;
        private System.Windows.Forms.Panel panelHolder;
        private System.Windows.Forms.Button btnGoToEditRecipe;
    }
}