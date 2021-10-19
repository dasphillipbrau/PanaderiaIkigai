
namespace PanaderiaIkigai.Controls.Ingredients
{
    partial class EditBaseIngredientPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEditUnitTitle = new System.Windows.Forms.Label();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.btnEditUnit = new System.Windows.Forms.Button();
            this.txtEditUnit = new System.Windows.Forms.TextBox();
            this.comboBoxSelectUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEditBaseIngredients = new System.Windows.Forms.DataGridView();
            this.btnEditBaseIngredient = new System.Windows.Forms.Button();
            this.btnDeleteBaseIngredient = new System.Windows.Forms.Button();
            this.txtFilterIngredientByName = new System.Windows.Forms.TextBox();
            this.lblFilterByNameTitle = new System.Windows.Forms.Label();
            this.comboBoxSelectIngredient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEditIngredientValidation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditBaseIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.lblEditIngredientValidation);
            this.panel1.Controls.Add(this.lblEditUnitTitle);
            this.panel1.Controls.Add(this.btnDeleteUnit);
            this.panel1.Controls.Add(this.btnEditUnit);
            this.panel1.Controls.Add(this.txtEditUnit);
            this.panel1.Controls.Add(this.comboBoxSelectUnit);
            this.panel1.Location = new System.Drawing.Point(20, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 143);
            this.panel1.TabIndex = 1;
            // 
            // lblEditUnitTitle
            // 
            this.lblEditUnitTitle.AutoSize = true;
            this.lblEditUnitTitle.ForeColor = System.Drawing.Color.Beige;
            this.lblEditUnitTitle.Location = new System.Drawing.Point(104, 4);
            this.lblEditUnitTitle.Name = "lblEditUnitTitle";
            this.lblEditUnitTitle.Size = new System.Drawing.Size(105, 13);
            this.lblEditUnitTitle.TabIndex = 4;
            this.lblEditUnitTitle.Text = "Edicion de Unidades";
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.Location = new System.Drawing.Point(195, 93);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(117, 24);
            this.btnDeleteUnit.TabIndex = 3;
            this.btnDeleteUnit.Text = "Eliminar Unidad";
            this.btnDeleteUnit.UseVisualStyleBackColor = true;
            // 
            // btnEditUnit
            // 
            this.btnEditUnit.Location = new System.Drawing.Point(195, 63);
            this.btnEditUnit.Name = "btnEditUnit";
            this.btnEditUnit.Size = new System.Drawing.Size(117, 24);
            this.btnEditUnit.TabIndex = 2;
            this.btnEditUnit.Text = "Editar Unidad";
            this.btnEditUnit.UseVisualStyleBackColor = true;
            this.btnEditUnit.Click += new System.EventHandler(this.btnEditUnit_Click);
            // 
            // txtEditUnit
            // 
            this.txtEditUnit.Location = new System.Drawing.Point(4, 72);
            this.txtEditUnit.Name = "txtEditUnit";
            this.txtEditUnit.Size = new System.Drawing.Size(174, 20);
            this.txtEditUnit.TabIndex = 1;
            // 
            // comboBoxSelectUnit
            // 
            this.comboBoxSelectUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectUnit.FormattingEnabled = true;
            this.comboBoxSelectUnit.Location = new System.Drawing.Point(3, 42);
            this.comboBoxSelectUnit.Name = "comboBoxSelectUnit";
            this.comboBoxSelectUnit.Size = new System.Drawing.Size(175, 21);
            this.comboBoxSelectUnit.TabIndex = 0;
            this.comboBoxSelectUnit.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectUnit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Edición de Ingredientes Base";
            // 
            // dgvEditBaseIngredients
            // 
            this.dgvEditBaseIngredients.AllowUserToAddRows = false;
            this.dgvEditBaseIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditBaseIngredients.Location = new System.Drawing.Point(24, 53);
            this.dgvEditBaseIngredients.Name = "dgvEditBaseIngredients";
            this.dgvEditBaseIngredients.Size = new System.Drawing.Size(659, 226);
            this.dgvEditBaseIngredients.TabIndex = 3;
            // 
            // btnEditBaseIngredient
            // 
            this.btnEditBaseIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnEditBaseIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBaseIngredient.ForeColor = System.Drawing.Color.Beige;
            this.btnEditBaseIngredient.Location = new System.Drawing.Point(528, 296);
            this.btnEditBaseIngredient.Name = "btnEditBaseIngredient";
            this.btnEditBaseIngredient.Size = new System.Drawing.Size(155, 51);
            this.btnEditBaseIngredient.TabIndex = 4;
            this.btnEditBaseIngredient.Text = "Editar Ingrediente";
            this.btnEditBaseIngredient.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBaseIngredient
            // 
            this.btnDeleteBaseIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnDeleteBaseIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBaseIngredient.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteBaseIngredient.Location = new System.Drawing.Point(528, 368);
            this.btnDeleteBaseIngredient.Name = "btnDeleteBaseIngredient";
            this.btnDeleteBaseIngredient.Size = new System.Drawing.Size(155, 51);
            this.btnDeleteBaseIngredient.TabIndex = 5;
            this.btnDeleteBaseIngredient.Text = "Eliminar Ingrediente";
            this.btnDeleteBaseIngredient.UseVisualStyleBackColor = false;
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
            this.comboBoxSelectIngredient.Location = new System.Drawing.Point(342, 325);
            this.comboBoxSelectIngredient.Name = "comboBoxSelectIngredient";
            this.comboBoxSelectIngredient.Size = new System.Drawing.Size(180, 21);
            this.comboBoxSelectIngredient.TabIndex = 8;
            this.comboBoxSelectIngredient.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectIngredient_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(342, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccionar Ingrediente";
            // 
            // lblEditIngredientValidation
            // 
            this.lblEditIngredientValidation.AutoSize = true;
            this.lblEditIngredientValidation.ForeColor = System.Drawing.Color.Red;
            this.lblEditIngredientValidation.Location = new System.Drawing.Point(3, 99);
            this.lblEditIngredientValidation.Name = "lblEditIngredientValidation";
            this.lblEditIngredientValidation.Size = new System.Drawing.Size(0, 13);
            this.lblEditIngredientValidation.TabIndex = 5;
            // 
            // EditBaseIngredientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSelectIngredient);
            this.Controls.Add(this.lblFilterByNameTitle);
            this.Controls.Add(this.txtFilterIngredientByName);
            this.Controls.Add(this.btnDeleteBaseIngredient);
            this.Controls.Add(this.btnEditBaseIngredient);
            this.Controls.Add(this.dgvEditBaseIngredients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "EditBaseIngredientPanel";
            this.Size = new System.Drawing.Size(707, 442);
            this.Load += new System.EventHandler(this.EditBaseIngredientPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditBaseIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEditUnitTitle;
        private System.Windows.Forms.Button btnDeleteUnit;
        private System.Windows.Forms.Button btnEditUnit;
        private System.Windows.Forms.TextBox txtEditUnit;
        private System.Windows.Forms.ComboBox comboBoxSelectUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEditBaseIngredients;
        private System.Windows.Forms.Button btnEditBaseIngredient;
        private System.Windows.Forms.Button btnDeleteBaseIngredient;
        private System.Windows.Forms.TextBox txtFilterIngredientByName;
        private System.Windows.Forms.Label lblFilterByNameTitle;
        private System.Windows.Forms.ComboBox comboBoxSelectIngredient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEditIngredientValidation;
    }
}
