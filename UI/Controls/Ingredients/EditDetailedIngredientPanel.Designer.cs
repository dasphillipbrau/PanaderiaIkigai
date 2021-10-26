
namespace PanaderiaIkigai.UI.Controls.Ingredients
{
    partial class EditDetailedIngredientPanel
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
            this.dgvDisplayDetailedIngredients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayDetailedIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayDetailedIngredients
            // 
            this.dgvDisplayDetailedIngredients.AllowUserToAddRows = false;
            this.dgvDisplayDetailedIngredients.AllowUserToDeleteRows = false;
            this.dgvDisplayDetailedIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayDetailedIngredients.Location = new System.Drawing.Point(3, 46);
            this.dgvDisplayDetailedIngredients.Name = "dgvDisplayDetailedIngredients";
            this.dgvDisplayDetailedIngredients.ReadOnly = true;
            this.dgvDisplayDetailedIngredients.Size = new System.Drawing.Size(701, 220);
            this.dgvDisplayDetailedIngredients.TabIndex = 0;
            // 
            // EditDetailedIngredientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.dgvDisplayDetailedIngredients);
            this.Name = "EditDetailedIngredientPanel";
            this.Size = new System.Drawing.Size(707, 442);
            this.Load += new System.EventHandler(this.EditDetailedIngredientPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayDetailedIngredients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayDetailedIngredients;
    }
}
