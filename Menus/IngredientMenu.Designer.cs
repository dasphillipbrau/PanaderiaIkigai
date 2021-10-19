
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
            this.btnOpenEditBaseIngredient = new System.Windows.Forms.Button();
            this.btnQueryBaseIngredients = new System.Windows.Forms.Button();
            this.btnOpenRegisterBasePanel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.btnOpenEditBaseIngredient);
            this.panel1.Controls.Add(this.btnQueryBaseIngredients);
            this.panel1.Controls.Add(this.btnOpenRegisterBasePanel);
            this.panel1.Location = new System.Drawing.Point(13, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 442);
            this.panel1.TabIndex = 1;
            // 
            // btnOpenEditBaseIngredient
            // 
            this.btnOpenEditBaseIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnOpenEditBaseIngredient.ForeColor = System.Drawing.Color.Beige;
            this.btnOpenEditBaseIngredient.Location = new System.Drawing.Point(3, 199);
            this.btnOpenEditBaseIngredient.Name = "btnOpenEditBaseIngredient";
            this.btnOpenEditBaseIngredient.Size = new System.Drawing.Size(194, 68);
            this.btnOpenEditBaseIngredient.TabIndex = 2;
            this.btnOpenEditBaseIngredient.Text = "Editar Ingredientes Base y Unidades";
            this.btnOpenEditBaseIngredient.UseVisualStyleBackColor = false;
            this.btnOpenEditBaseIngredient.Click += new System.EventHandler(this.btnOpenEditBaseIngredient_Click);
            // 
            // btnQueryBaseIngredients
            // 
            this.btnQueryBaseIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.btnQueryBaseIngredients.ForeColor = System.Drawing.Color.Beige;
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
            // IngredientMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(974, 540);
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
        private System.Windows.Forms.Button btnOpenEditBaseIngredient;
        private System.Windows.Forms.Button btnQueryBaseIngredients;
        private System.Windows.Forms.Button btnOpenRegisterBasePanel;
    }
}
