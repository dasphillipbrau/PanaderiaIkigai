
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
            this.lblBaseIngredientQuery = new System.Windows.Forms.Label();
            this.lblSelectIngredientTitle = new System.Windows.Forms.Label();
            this.dgvViewBaseIngredients = new System.Windows.Forms.DataGridView();
            this.lblFilterByNameTitle = new System.Windows.Forms.Label();
            this.txtFilterIngredientByName = new System.Windows.Forms.TextBox();
            this.txtSearchIngredientCode = new System.Windows.Forms.TextBox();
            this.btnSearchIngredient = new System.Windows.Forms.Button();
            this.lblIngredientName = new System.Windows.Forms.Label();
            this.txtNewIngredientName = new System.Windows.Forms.TextBox();
            this.lblEditIngredientNameValidation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.lblEditIngredientValidation = new System.Windows.Forms.Label();
            this.lblEditUnitTitle = new System.Windows.Forms.Label();
            this.btnEditUnit = new System.Windows.Forms.Button();
            this.txtEditUnit = new System.Windows.Forms.TextBox();
            this.comboBoxSelectUnitToEdit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSelectUnitForIngredientEdit = new System.Windows.Forms.ComboBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.lblUnitNameForIngredientEditValidation = new System.Windows.Forms.Label();
            this.btnDeleteBaseIngredient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBaseIngredients)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaseIngredientQuery
            // 
            this.lblBaseIngredientQuery.AutoSize = true;
            this.lblBaseIngredientQuery.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseIngredientQuery.ForeColor = System.Drawing.Color.Beige;
            this.lblBaseIngredientQuery.Location = new System.Drawing.Point(16, 19);
            this.lblBaseIngredientQuery.Name = "lblBaseIngredientQuery";
            this.lblBaseIngredientQuery.Size = new System.Drawing.Size(302, 24);
            this.lblBaseIngredientQuery.TabIndex = 1;
            this.lblBaseIngredientQuery.Text = "Edición de Ingredientes base";
            // 
            // lblSelectIngredientTitle
            // 
            this.lblSelectIngredientTitle.AutoSize = true;
            this.lblSelectIngredientTitle.ForeColor = System.Drawing.Color.White;
            this.lblSelectIngredientTitle.Location = new System.Drawing.Point(17, 255);
            this.lblSelectIngredientTitle.Name = "lblSelectIngredientTitle";
            this.lblSelectIngredientTitle.Size = new System.Drawing.Size(242, 13);
            this.lblSelectIngredientTitle.TabIndex = 4;
            this.lblSelectIngredientTitle.Text = "Escriba el código del ingrediente que desea editar";
            // 
            // dgvViewBaseIngredients
            // 
            this.dgvViewBaseIngredients.AllowUserToAddRows = false;
            this.dgvViewBaseIngredients.AllowUserToDeleteRows = false;
            this.dgvViewBaseIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBaseIngredients.GridColor = System.Drawing.Color.White;
            this.dgvViewBaseIngredients.Location = new System.Drawing.Point(20, 84);
            this.dgvViewBaseIngredients.Name = "dgvViewBaseIngredients";
            this.dgvViewBaseIngredients.ReadOnly = true;
            this.dgvViewBaseIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewBaseIngredients.Size = new System.Drawing.Size(991, 150);
            this.dgvViewBaseIngredients.TabIndex = 5;
            // 
            // lblFilterByNameTitle
            // 
            this.lblFilterByNameTitle.AutoSize = true;
            this.lblFilterByNameTitle.ForeColor = System.Drawing.Color.White;
            this.lblFilterByNameTitle.Location = new System.Drawing.Point(760, 58);
            this.lblFilterByNameTitle.Name = "lblFilterByNameTitle";
            this.lblFilterByNameTitle.Size = new System.Drawing.Size(90, 13);
            this.lblFilterByNameTitle.TabIndex = 9;
            this.lblFilterByNameTitle.Text = "Filtrar por Nombre";
            // 
            // txtFilterIngredientByName
            // 
            this.txtFilterIngredientByName.Location = new System.Drawing.Point(856, 58);
            this.txtFilterIngredientByName.Name = "txtFilterIngredientByName";
            this.txtFilterIngredientByName.Size = new System.Drawing.Size(155, 20);
            this.txtFilterIngredientByName.TabIndex = 8;
            this.txtFilterIngredientByName.TextChanged += new System.EventHandler(this.txtFilterIngredientByName_TextChanged_1);
            // 
            // txtSearchIngredientCode
            // 
            this.txtSearchIngredientCode.Location = new System.Drawing.Point(20, 271);
            this.txtSearchIngredientCode.Name = "txtSearchIngredientCode";
            this.txtSearchIngredientCode.Size = new System.Drawing.Size(153, 20);
            this.txtSearchIngredientCode.TabIndex = 10;
            // 
            // btnSearchIngredient
            // 
            this.btnSearchIngredient.Location = new System.Drawing.Point(20, 297);
            this.btnSearchIngredient.Name = "btnSearchIngredient";
            this.btnSearchIngredient.Size = new System.Drawing.Size(75, 35);
            this.btnSearchIngredient.TabIndex = 11;
            this.btnSearchIngredient.Text = "Buscar";
            this.btnSearchIngredient.UseVisualStyleBackColor = true;
            this.btnSearchIngredient.Click += new System.EventHandler(this.btnSearchIngredient_Click);
            // 
            // lblIngredientName
            // 
            this.lblIngredientName.AutoSize = true;
            this.lblIngredientName.ForeColor = System.Drawing.Color.White;
            this.lblIngredientName.Location = new System.Drawing.Point(17, 335);
            this.lblIngredientName.Name = "lblIngredientName";
            this.lblIngredientName.Size = new System.Drawing.Size(115, 13);
            this.lblIngredientName.TabIndex = 12;
            this.lblIngredientName.Text = "Nombre de Ingrediente";
            // 
            // txtNewIngredientName
            // 
            this.txtNewIngredientName.Location = new System.Drawing.Point(20, 352);
            this.txtNewIngredientName.Name = "txtNewIngredientName";
            this.txtNewIngredientName.Size = new System.Drawing.Size(153, 20);
            this.txtNewIngredientName.TabIndex = 13;
            // 
            // lblEditIngredientNameValidation
            // 
            this.lblEditIngredientNameValidation.AutoSize = true;
            this.lblEditIngredientNameValidation.ForeColor = System.Drawing.Color.Red;
            this.lblEditIngredientNameValidation.Location = new System.Drawing.Point(180, 352);
            this.lblEditIngredientNameValidation.Name = "lblEditIngredientNameValidation";
            this.lblEditIngredientNameValidation.Size = new System.Drawing.Size(0, 13);
            this.lblEditIngredientNameValidation.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.btnDeleteUnit);
            this.panel1.Controls.Add(this.lblEditIngredientValidation);
            this.panel1.Controls.Add(this.lblEditUnitTitle);
            this.panel1.Controls.Add(this.btnEditUnit);
            this.panel1.Controls.Add(this.txtEditUnit);
            this.panel1.Controls.Add(this.comboBoxSelectUnitToEdit);
            this.panel1.Location = new System.Drawing.Point(696, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 143);
            this.panel1.TabIndex = 15;
            // 
            // btnDeleteUnit
            // 
            this.btnDeleteUnit.Location = new System.Drawing.Point(195, 92);
            this.btnDeleteUnit.Name = "btnDeleteUnit";
            this.btnDeleteUnit.Size = new System.Drawing.Size(117, 48);
            this.btnDeleteUnit.TabIndex = 3;
            this.btnDeleteUnit.Text = "Eliminar Unidad";
            this.btnDeleteUnit.UseVisualStyleBackColor = true;
            this.btnDeleteUnit.Click += new System.EventHandler(this.btnDeleteUnit_Click);
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
            // btnEditUnit
            // 
            this.btnEditUnit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditUnit.Location = new System.Drawing.Point(195, 36);
            this.btnEditUnit.Name = "btnEditUnit";
            this.btnEditUnit.Size = new System.Drawing.Size(117, 48);
            this.btnEditUnit.TabIndex = 2;
            this.btnEditUnit.Text = "Editar Unidad";
            this.btnEditUnit.UseVisualStyleBackColor = true;
            this.btnEditUnit.Click += new System.EventHandler(this.btnEditUnit_Click);
            // 
            // txtEditUnit
            // 
            this.txtEditUnit.Location = new System.Drawing.Point(3, 72);
            this.txtEditUnit.Name = "txtEditUnit";
            this.txtEditUnit.Size = new System.Drawing.Size(175, 20);
            this.txtEditUnit.TabIndex = 1;
            // 
            // comboBoxSelectUnitToEdit
            // 
            this.comboBoxSelectUnitToEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectUnitToEdit.FormattingEnabled = true;
            this.comboBoxSelectUnitToEdit.Location = new System.Drawing.Point(3, 42);
            this.comboBoxSelectUnitToEdit.Name = "comboBoxSelectUnitToEdit";
            this.comboBoxSelectUnitToEdit.Size = new System.Drawing.Size(175, 21);
            this.comboBoxSelectUnitToEdit.TabIndex = 0;
            this.comboBoxSelectUnitToEdit.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectUnitToEdit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Unidad de Medida";
            // 
            // comboBoxSelectUnitForIngredientEdit
            // 
            this.comboBoxSelectUnitForIngredientEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectUnitForIngredientEdit.FormattingEnabled = true;
            this.comboBoxSelectUnitForIngredientEdit.Location = new System.Drawing.Point(20, 401);
            this.comboBoxSelectUnitForIngredientEdit.Name = "comboBoxSelectUnitForIngredientEdit";
            this.comboBoxSelectUnitForIngredientEdit.Size = new System.Drawing.Size(153, 21);
            this.comboBoxSelectUnitForIngredientEdit.TabIndex = 17;
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Enabled = false;
            this.btnSaveEdit.Location = new System.Drawing.Point(101, 297);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(72, 35);
            this.btnSaveEdit.TabIndex = 18;
            this.btnSaveEdit.Text = "Guardar Cambios";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // lblUnitNameForIngredientEditValidation
            // 
            this.lblUnitNameForIngredientEditValidation.AutoSize = true;
            this.lblUnitNameForIngredientEditValidation.ForeColor = System.Drawing.Color.Red;
            this.lblUnitNameForIngredientEditValidation.Location = new System.Drawing.Point(180, 401);
            this.lblUnitNameForIngredientEditValidation.Name = "lblUnitNameForIngredientEditValidation";
            this.lblUnitNameForIngredientEditValidation.Size = new System.Drawing.Size(0, 13);
            this.lblUnitNameForIngredientEditValidation.TabIndex = 19;
            // 
            // btnDeleteBaseIngredient
            // 
            this.btnDeleteBaseIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnDeleteBaseIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBaseIngredient.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteBaseIngredient.Location = new System.Drawing.Point(452, 240);
            this.btnDeleteBaseIngredient.Name = "btnDeleteBaseIngredient";
            this.btnDeleteBaseIngredient.Size = new System.Drawing.Size(155, 32);
            this.btnDeleteBaseIngredient.TabIndex = 20;
            this.btnDeleteBaseIngredient.Text = "Eliminar Ingrediente";
            this.btnDeleteBaseIngredient.UseVisualStyleBackColor = false;
            this.btnDeleteBaseIngredient.Click += new System.EventHandler(this.btnDeleteBaseIngredient_Click);
            this.btnDeleteBaseIngredient.MouseHover += new System.EventHandler(this.btnDeleteBaseIngredient_MouseHover);
            // 
            // EditBaseIngredientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.btnDeleteBaseIngredient);
            this.Controls.Add(this.lblUnitNameForIngredientEditValidation);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.comboBoxSelectUnitForIngredientEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEditIngredientNameValidation);
            this.Controls.Add(this.txtNewIngredientName);
            this.Controls.Add(this.lblIngredientName);
            this.Controls.Add(this.btnSearchIngredient);
            this.Controls.Add(this.txtSearchIngredientCode);
            this.Controls.Add(this.lblFilterByNameTitle);
            this.Controls.Add(this.txtFilterIngredientByName);
            this.Controls.Add(this.dgvViewBaseIngredients);
            this.Controls.Add(this.lblSelectIngredientTitle);
            this.Controls.Add(this.lblBaseIngredientQuery);
            this.Name = "EditBaseIngredientPanel";
            this.Size = new System.Drawing.Size(1028, 560);
            this.Load += new System.EventHandler(this.DisplayBaseIngredientPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBaseIngredients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBaseIngredientQuery;
        private System.Windows.Forms.Label lblSelectIngredientTitle;
        private System.Windows.Forms.DataGridView dgvViewBaseIngredients;
        private System.Windows.Forms.Label lblFilterByNameTitle;
        private System.Windows.Forms.TextBox txtFilterIngredientByName;
        private System.Windows.Forms.TextBox txtSearchIngredientCode;
        private System.Windows.Forms.Button btnSearchIngredient;
        private System.Windows.Forms.Label lblIngredientName;
        private System.Windows.Forms.TextBox txtNewIngredientName;
        private System.Windows.Forms.Label lblEditIngredientNameValidation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteUnit;
        private System.Windows.Forms.Label lblEditIngredientValidation;
        private System.Windows.Forms.Label lblEditUnitTitle;
        private System.Windows.Forms.Button btnEditUnit;
        private System.Windows.Forms.TextBox txtEditUnit;
        private System.Windows.Forms.ComboBox comboBoxSelectUnitToEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSelectUnitForIngredientEdit;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Label lblUnitNameForIngredientEditValidation;
        private System.Windows.Forms.Button btnDeleteBaseIngredient;
    }
}
