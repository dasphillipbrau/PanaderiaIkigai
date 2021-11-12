
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
            this.btnGoToDataManagement = new System.Windows.Forms.Button();
            this.btnGoToBiMenu = new System.Windows.Forms.Button();
            this.btnGoToOrdersMenu = new System.Windows.Forms.Button();
            this.btnGoToClientsMenu = new System.Windows.Forms.Button();
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
            this.mainMenuControlsPanel.Controls.Add(this.btnGoToDataManagement);
            this.mainMenuControlsPanel.Controls.Add(this.btnGoToBiMenu);
            this.mainMenuControlsPanel.Controls.Add(this.btnGoToOrdersMenu);
            this.mainMenuControlsPanel.Controls.Add(this.btnGoToClientsMenu);
            this.mainMenuControlsPanel.Controls.Add(this.btnGoToRecipeMenu);
            this.mainMenuControlsPanel.Controls.Add(this.btnGoToIngredientMenu);
            this.mainMenuControlsPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainMenuControlsPanel.Location = new System.Drawing.Point(12, 83);
            this.mainMenuControlsPanel.Name = "mainMenuControlsPanel";
            this.mainMenuControlsPanel.Size = new System.Drawing.Size(776, 299);
            this.mainMenuControlsPanel.TabIndex = 2;
            // 
            // btnGoToDataManagement
            // 
            this.btnGoToDataManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToDataManagement.FlatAppearance.BorderSize = 0;
            this.btnGoToDataManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToDataManagement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoToDataManagement.Location = new System.Drawing.Point(288, 222);
            this.btnGoToDataManagement.Name = "btnGoToDataManagement";
            this.btnGoToDataManagement.Size = new System.Drawing.Size(193, 54);
            this.btnGoToDataManagement.TabIndex = 5;
            this.btnGoToDataManagement.Text = "Menú de Manejo de Datos";
            this.btnGoToDataManagement.UseVisualStyleBackColor = false;
            this.btnGoToDataManagement.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGoToBiMenu
            // 
            this.btnGoToBiMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToBiMenu.FlatAppearance.BorderSize = 0;
            this.btnGoToBiMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToBiMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoToBiMenu.Location = new System.Drawing.Point(288, 3);
            this.btnGoToBiMenu.Name = "btnGoToBiMenu";
            this.btnGoToBiMenu.Size = new System.Drawing.Size(193, 54);
            this.btnGoToBiMenu.TabIndex = 4;
            this.btnGoToBiMenu.Text = "Menú de Inteligencia de Negocios";
            this.btnGoToBiMenu.UseVisualStyleBackColor = false;
            this.btnGoToBiMenu.Click += new System.EventHandler(this.btnGoToBiMenu_Click);
            // 
            // btnGoToOrdersMenu
            // 
            this.btnGoToOrdersMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToOrdersMenu.FlatAppearance.BorderSize = 0;
            this.btnGoToOrdersMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToOrdersMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoToOrdersMenu.Location = new System.Drawing.Point(561, 222);
            this.btnGoToOrdersMenu.Name = "btnGoToOrdersMenu";
            this.btnGoToOrdersMenu.Size = new System.Drawing.Size(193, 54);
            this.btnGoToOrdersMenu.TabIndex = 3;
            this.btnGoToOrdersMenu.Text = "Menú de Pedidos";
            this.btnGoToOrdersMenu.UseVisualStyleBackColor = false;
            this.btnGoToOrdersMenu.Click += new System.EventHandler(this.btnGoToOrdersMenu_Click);
            // 
            // btnGoToClientsMenu
            // 
            this.btnGoToClientsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnGoToClientsMenu.FlatAppearance.BorderSize = 0;
            this.btnGoToClientsMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToClientsMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoToClientsMenu.Location = new System.Drawing.Point(561, 3);
            this.btnGoToClientsMenu.Name = "btnGoToClientsMenu";
            this.btnGoToClientsMenu.Size = new System.Drawing.Size(193, 54);
            this.btnGoToClientsMenu.TabIndex = 2;
            this.btnGoToClientsMenu.Text = "Menú de Clientes";
            this.btnGoToClientsMenu.UseVisualStyleBackColor = false;
            this.btnGoToClientsMenu.Click += new System.EventHandler(this.btnOpenClientsMenu_Click);
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
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.mainMenuControlsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToIngredientMenu;
        private System.Windows.Forms.Label IkigaiTitle;
        private System.Windows.Forms.Panel mainMenuControlsPanel;
        private System.Windows.Forms.Button btnGoToRecipeMenu;
        private System.Windows.Forms.Button btnGoToClientsMenu;
        private System.Windows.Forms.Button btnGoToOrdersMenu;
        private System.Windows.Forms.Button btnGoToBiMenu;
        private System.Windows.Forms.Button btnGoToDataManagement;
    }
}

