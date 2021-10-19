
namespace PanaderiaIkigai.Controls.Ingredients
{
    partial class DisplayBaseIngredientPanel
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
            this.dgvBaseIngredients = new System.Windows.Forms.DataGridView();
            this.lblBaseIngredientQuery = new System.Windows.Forms.Label();
            this.txtSearchBaseIngredient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaseIngredients
            // 
            this.dgvBaseIngredients.AllowUserToAddRows = false;
            this.dgvBaseIngredients.AllowUserToDeleteRows = false;
            this.dgvBaseIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaseIngredients.Location = new System.Drawing.Point(15, 109);
            this.dgvBaseIngredients.Name = "dgvBaseIngredients";
            this.dgvBaseIngredients.ReadOnly = true;
            this.dgvBaseIngredients.Size = new System.Drawing.Size(674, 242);
            this.dgvBaseIngredients.TabIndex = 0;
            // 
            // lblBaseIngredientQuery
            // 
            this.lblBaseIngredientQuery.AutoSize = true;
            this.lblBaseIngredientQuery.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseIngredientQuery.Location = new System.Drawing.Point(190, 20);
            this.lblBaseIngredientQuery.Name = "lblBaseIngredientQuery";
            this.lblBaseIngredientQuery.Size = new System.Drawing.Size(317, 24);
            this.lblBaseIngredientQuery.TabIndex = 1;
            this.lblBaseIngredientQuery.Text = "Consulta de Ingredientes base";
            // 
            // txtSearchBaseIngredient
            // 
            this.txtSearchBaseIngredient.Location = new System.Drawing.Point(298, 83);
            this.txtSearchBaseIngredient.Name = "txtSearchBaseIngredient";
            this.txtSearchBaseIngredient.Size = new System.Drawing.Size(172, 20);
            this.txtSearchBaseIngredient.TabIndex = 2;
            this.txtSearchBaseIngredient.TextChanged += new System.EventHandler(this.txtSearchBaseIngredient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar por Nombre";
            // 
            // DisplayBaseIngredientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchBaseIngredient);
            this.Controls.Add(this.lblBaseIngredientQuery);
            this.Controls.Add(this.dgvBaseIngredients);
            this.Name = "DisplayBaseIngredientPanel";
            this.Size = new System.Drawing.Size(707, 442);
            this.Load += new System.EventHandler(this.DisplayBaseIngredientPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaseIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaseIngredients;
        private System.Windows.Forms.Label lblBaseIngredientQuery;
        private System.Windows.Forms.TextBox txtSearchBaseIngredient;
        private System.Windows.Forms.Label label1;
    }
}
