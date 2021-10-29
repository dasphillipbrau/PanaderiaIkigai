
namespace PanaderiaIkigai
{
    partial class MainMenu
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
            this.btnGoToIngredientMenu = new System.Windows.Forms.Button();
            this.IkigaiTitle = new System.Windows.Forms.Label();
            this.mainMenuControlsPanel = new System.Windows.Forms.Panel();
            this.btnGoToRecipeMenu = new System.Windows.Forms.Button();
            this.mainMenuControlsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGoToIngredientMenu
            // 
            this.btnGoToIngredientMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToIngredientMenu.FlatAppearance.BorderSize = 0;
            this.btnGoToIngredientMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToIngredientMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoToIngredientMenu.Location = new System.Drawing.Point(21, 3);
            this.btnGoToIngredientMenu.Name = "btnGoToIngredientMenu";
            this.btnGoToIngredientMenu.Size = new System.Drawing.Size(193, 54);
            this.btnGoToIngredientMenu.TabIndex = 0;
            this.btnGoToIngredientMenu.Text = "Menú de Ingredientes";
            this.btnGoToIngredientMenu.UseVisualStyleBackColor = false;
            this.btnGoToIngredientMenu.Click += new System.EventHandler(this.btnGoToIngredientMenu_Click);
            // 
            // IkigaiTitle
            // 
            this.IkigaiTitle.AutoSize = true;
            this.IkigaiTitle.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IkigaiTitle.ForeColor = System.Drawing.Color.White;
            this.IkigaiTitle.Location = new System.Drawing.Point(190, 29);
            this.IkigaiTitle.Name = "IkigaiTitle";
            this.IkigaiTitle.Size = new System.Drawing.Size(428, 33);
            this.IkigaiTitle.TabIndex = 1;
            this.IkigaiTitle.Text = "Sistema de Administración de Panadería Ikigai";
            // 
            // mainMenuControlsPanel
            // 
            this.mainMenuControlsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.mainMenuControlsPanel.Controls.Add(this.btnGoToRecipeMenu);
            this.mainMenuControlsPanel.Controls.Add(this.btnGoToIngredientMenu);
            this.mainMenuControlsPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainMenuControlsPanel.Location = new System.Drawing.Point(12, 83);
            this.mainMenuControlsPanel.Name = "mainMenuControlsPanel";
            this.mainMenuControlsPanel.Size = new System.Drawing.Size(776, 299);
            this.mainMenuControlsPanel.TabIndex = 2;
            // 
            // btnGoToRecipeMenu
            // 
            this.btnGoToRecipeMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToRecipeMenu.FlatAppearance.BorderSize = 0;
            this.btnGoToRecipeMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToRecipeMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoToRecipeMenu.Location = new System.Drawing.Point(21, 222);
            this.btnGoToRecipeMenu.Name = "btnGoToRecipeMenu";
            this.btnGoToRecipeMenu.Size = new System.Drawing.Size(193, 54);
            this.btnGoToRecipeMenu.TabIndex = 1;
            this.btnGoToRecipeMenu.Text = "Menú de Recetas";
            this.btnGoToRecipeMenu.UseVisualStyleBackColor = false;
            this.btnGoToRecipeMenu.Click += new System.EventHandler(this.btnGoToRecipeMenu_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IkigaiTitle);
            this.Controls.Add(this.mainMenuControlsPanel);
            this.Name = "MainMenu";
            this.Text = "Panadería Ikigai";
            this.mainMenuControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToIngredientMenu;
        private System.Windows.Forms.Label IkigaiTitle;
        private System.Windows.Forms.Panel mainMenuControlsPanel;
        private System.Windows.Forms.Button btnGoToRecipeMenu;
    }
}

