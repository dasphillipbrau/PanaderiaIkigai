﻿
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnQueryBaseIngredients = new System.Windows.Forms.Button();
            this.btnOpenRegisterBasePanel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú de Ingredientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnQueryBaseIngredients);
            this.panel1.Controls.Add(this.btnOpenRegisterBasePanel);
            this.panel1.Location = new System.Drawing.Point(13, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 442);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.button3.Location = new System.Drawing.Point(3, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 68);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnQueryBaseIngredients
            // 
            this.btnQueryBaseIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnQueryBaseIngredients.Location = new System.Drawing.Point(3, 111);
            this.btnQueryBaseIngredients.Name = "btnQueryBaseIngredients";
            this.btnQueryBaseIngredients.Size = new System.Drawing.Size(194, 68);
            this.btnQueryBaseIngredients.TabIndex = 1;
            this.btnQueryBaseIngredients.Text = "Consultar Ingredientes Base Registrados";
            this.btnQueryBaseIngredients.UseVisualStyleBackColor = false;
            this.btnQueryBaseIngredients.Click += new System.EventHandler(this.btnQueryBaseIngredients_Click);
            // 
            // btnOpenRegisterBasePanel
            // 
            this.btnOpenRegisterBasePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnOpenRegisterBasePanel.Location = new System.Drawing.Point(3, 21);
            this.btnOpenRegisterBasePanel.Name = "btnOpenRegisterBasePanel";
            this.btnOpenRegisterBasePanel.Size = new System.Drawing.Size(194, 68);
            this.btnOpenRegisterBasePanel.TabIndex = 0;
            this.btnOpenRegisterBasePanel.Text = "Registrar un Ingrediente Base";
            this.btnOpenRegisterBasePanel.UseVisualStyleBackColor = false;
            this.btnOpenRegisterBasePanel.Click += new System.EventHandler(this.btnOpenRegisterBasePanel_Click);
            // 
            // IngredientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "IngredientMenu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnQueryBaseIngredients;
        private System.Windows.Forms.Button btnOpenRegisterBasePanel;
    }
}
