
namespace PanaderiaIkigai.UI.Controls.Recipes
{
    partial class EditRecipePanel
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
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxRecipeImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AllowUserToAddRows = false;
            this.dgvRecipes.AllowUserToDeleteRows = false;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(34, 50);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.ReadOnly = true;
            this.dgvRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipes.Size = new System.Drawing.Size(843, 230);
            this.dgvRecipes.TabIndex = 0;
            this.dgvRecipes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecipes_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Editar Recetas y Categorías";
            // 
            // pictureBoxRecipeImage
            // 
            this.pictureBoxRecipeImage.Location = new System.Drawing.Point(884, 50);
            this.pictureBoxRecipeImage.Name = "pictureBoxRecipeImage";
            this.pictureBoxRecipeImage.Size = new System.Drawing.Size(292, 230);
            this.pictureBoxRecipeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRecipeImage.TabIndex = 2;
            this.pictureBoxRecipeImage.TabStop = false;
            // 
            // EditRecipePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.pictureBoxRecipeImage);
            this.Controls.Add(this.dgvRecipes);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "EditRecipePanel";
            this.Size = new System.Drawing.Size(1179, 561);
            this.Load += new System.EventHandler(this.EditRecipePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipeImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxRecipeImage;
    }
}
