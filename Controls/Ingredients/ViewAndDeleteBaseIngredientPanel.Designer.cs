
namespace PanaderiaIkigai.Controls.Ingredients
{
    partial class ViewAndDeleteBaseIngredientPanel
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
            this.dgvEditBaseIngredients = new System.Windows.Forms.DataGridView();
            this.btnDeleteBaseIngredient = new System.Windows.Forms.Button();
            this.txtFilterIngredientByName = new System.Windows.Forms.TextBox();
            this.lblFilterByNameTitle = new System.Windows.Forms.Label();
            this.comboBoxSelectIngredient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditBaseIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta de Ingredientes Base";
            // 
            // dgvEditBaseIngredients
            // 
            this.dgvEditBaseIngredients.AllowUserToAddRows = false;
            this.dgvEditBaseIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditBaseIngredients.Location = new System.Drawing.Point(24, 53);
            this.dgvEditBaseIngredients.Name = "dgvEditBaseIngredients";
            this.dgvEditBaseIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditBaseIngredients.Size = new System.Drawing.Size(659, 226);
            this.dgvEditBaseIngredients.TabIndex = 3;
            // 
            // btnDeleteBaseIngredient
            // 
            this.btnDeleteBaseIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnDeleteBaseIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBaseIngredient.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteBaseIngredient.Location = new System.Drawing.Point(280, 296);
            this.btnDeleteBaseIngredient.Name = "btnDeleteBaseIngredient";
            this.btnDeleteBaseIngredient.Size = new System.Drawing.Size(155, 51);
            this.btnDeleteBaseIngredient.TabIndex = 5;
            this.btnDeleteBaseIngredient.Text = "Eliminar Ingrediente";
            this.btnDeleteBaseIngredient.UseVisualStyleBackColor = false;
            this.btnDeleteBaseIngredient.Click += new System.EventHandler(this.btnDeleteBaseIngredient_Click);
            // 
            // txtFilterIngredientByName
            // 
            this.txtFilterIngredientByName.Location = new System.Drawing.Point(528, 27);
            this.txtFilterIngredientByName.Name = "txtFilterIngredientByName";
            this.txtFilterIngredientByName.Size = new System.Drawing.Size(155, 20);
            this.txtFilterIngredientByName.TabIndex = 6;
            this.txtFilterIngredientByName.TextChanged += new System.EventHandler(this.txtFilterIngredientByName_TextChanged);
            // 
            // lblFilterByNameTitle
            // 
            this.lblFilterByNameTitle.AutoSize = true;
            this.lblFilterByNameTitle.ForeColor = System.Drawing.Color.White;
            this.lblFilterByNameTitle.Location = new System.Drawing.Point(432, 27);
            this.lblFilterByNameTitle.Name = "lblFilterByNameTitle";
            this.lblFilterByNameTitle.Size = new System.Drawing.Size(90, 13);
            this.lblFilterByNameTitle.TabIndex = 7;
            this.lblFilterByNameTitle.Text = "Filtrar por Nombre";
            // 
            // comboBoxSelectIngredient
            // 
            this.comboBoxSelectIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectIngredient.FormattingEnabled = true;
            this.comboBoxSelectIngredient.Location = new System.Drawing.Point(24, 326);
            this.comboBoxSelectIngredient.Name = "comboBoxSelectIngredient";
            this.comboBoxSelectIngredient.Size = new System.Drawing.Size(180, 21);
            this.comboBoxSelectIngredient.TabIndex = 8;
            this.comboBoxSelectIngredient.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectIngredient_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccionar Ingrediente";
            // 
            // ViewAndDeleteBaseIngredientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSelectIngredient);
            this.Controls.Add(this.lblFilterByNameTitle);
            this.Controls.Add(this.txtFilterIngredientByName);
            this.Controls.Add(this.btnDeleteBaseIngredient);
            this.Controls.Add(this.dgvEditBaseIngredients);
            this.Controls.Add(this.label1);
            this.Name = "ViewAndDeleteBaseIngredientPanel";
            this.Size = new System.Drawing.Size(707, 442);
            this.Load += new System.EventHandler(this.EditBaseIngredientPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditBaseIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEditBaseIngredients;
        private System.Windows.Forms.Button btnDeleteBaseIngredient;
        private System.Windows.Forms.TextBox txtFilterIngredientByName;
        private System.Windows.Forms.Label lblFilterByNameTitle;
        private System.Windows.Forms.ComboBox comboBoxSelectIngredient;
        private System.Windows.Forms.Label label2;
    }
}
