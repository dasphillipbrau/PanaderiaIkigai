
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
            this.components = new System.ComponentModel.Container();
            this.dgvDisplayDetailedIngredients = new System.Windows.Forms.DataGridView();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.lblFilterByName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameFilter = new System.Windows.Forms.TextBox();
            this.txtCodeFilter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchIngredientCode = new System.Windows.Forms.TextBox();
            this.btnSearchDetailedIngredient = new System.Windows.Forms.Button();
            this.lblingredientFound = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountInUnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUnitsAvailable = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxQuality = new System.Windows.Forms.ComboBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.errorProviderBrand = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOrigin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAmountInUnit = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUnitPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUnitsAvailable = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDeleteBaseIngredient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayDetailedIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAmountInUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnitsAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDisplayDetailedIngredients
            // 
            this.dgvDisplayDetailedIngredients.AllowUserToAddRows = false;
            this.dgvDisplayDetailedIngredients.AllowUserToDeleteRows = false;
            this.dgvDisplayDetailedIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisplayDetailedIngredients.Location = new System.Drawing.Point(3, 63);
            this.dgvDisplayDetailedIngredients.Name = "dgvDisplayDetailedIngredients";
            this.dgvDisplayDetailedIngredients.ReadOnly = true;
            this.dgvDisplayDetailedIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisplayDetailedIngredients.Size = new System.Drawing.Size(1022, 220);
            this.dgvDisplayDetailedIngredients.TabIndex = 0;
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.ForeColor = System.Drawing.Color.White;
            this.lblMenuTitle.Location = new System.Drawing.Point(4, 15);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(332, 22);
            this.lblMenuTitle.TabIndex = 1;
            this.lblMenuTitle.Text = "Edición de Ingredientes Detallados";
            // 
            // lblFilterByName
            // 
            this.lblFilterByName.AutoSize = true;
            this.lblFilterByName.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterByName.ForeColor = System.Drawing.Color.White;
            this.lblFilterByName.Location = new System.Drawing.Point(276, 286);
            this.lblFilterByName.Name = "lblFilterByName";
            this.lblFilterByName.Size = new System.Drawing.Size(236, 16);
            this.lblFilterByName.TabIndex = 2;
            this.lblFilterByName.Text = "Filtrar por Nombre de Ingrediente Base";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar por Código de Ingrediente Detallado";
            // 
            // txtNameFilter
            // 
            this.txtNameFilter.Location = new System.Drawing.Point(307, 305);
            this.txtNameFilter.Name = "txtNameFilter";
            this.txtNameFilter.Size = new System.Drawing.Size(169, 20);
            this.txtNameFilter.TabIndex = 4;
            this.txtNameFilter.TextChanged += new System.EventHandler(this.txtNameFilter_TextChanged);
            // 
            // txtCodeFilter
            // 
            this.txtCodeFilter.Location = new System.Drawing.Point(52, 305);
            this.txtCodeFilter.Name = "txtCodeFilter";
            this.txtCodeFilter.Size = new System.Drawing.Size(169, 20);
            this.txtCodeFilter.TabIndex = 5;
            this.txtCodeFilter.TextChanged += new System.EventHandler(this.txtCodeFilter_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digitar Código de Ingrediente por Editar";
            // 
            // txtSearchIngredientCode
            // 
            this.txtSearchIngredientCode.Location = new System.Drawing.Point(8, 378);
            this.txtSearchIngredientCode.Name = "txtSearchIngredientCode";
            this.txtSearchIngredientCode.Size = new System.Drawing.Size(233, 20);
            this.txtSearchIngredientCode.TabIndex = 7;
            // 
            // btnSearchDetailedIngredient
            // 
            this.btnSearchDetailedIngredient.Location = new System.Drawing.Point(8, 404);
            this.btnSearchDetailedIngredient.Name = "btnSearchDetailedIngredient";
            this.btnSearchDetailedIngredient.Size = new System.Drawing.Size(95, 23);
            this.btnSearchDetailedIngredient.TabIndex = 8;
            this.btnSearchDetailedIngredient.Text = "Buscar";
            this.btnSearchDetailedIngredient.UseVisualStyleBackColor = true;
            this.btnSearchDetailedIngredient.Click += new System.EventHandler(this.btnSearchDetailedIngredient_Click);
            // 
            // lblingredientFound
            // 
            this.lblingredientFound.AutoSize = true;
            this.lblingredientFound.ForeColor = System.Drawing.Color.Lime;
            this.lblingredientFound.Location = new System.Drawing.Point(5, 439);
            this.lblingredientFound.Name = "lblingredientFound";
            this.lblingredientFound.Size = new System.Drawing.Size(35, 13);
            this.lblingredientFound.TabIndex = 9;
            this.lblingredientFound.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(304, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Marca de Ingrediente";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(307, 377);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(127, 20);
            this.txtBrand.TabIndex = 11;
            this.txtBrand.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrand_Validating);
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(307, 429);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(127, 20);
            this.txtOrigin.TabIndex = 13;
            this.txtOrigin.Validating += new System.ComponentModel.CancelEventHandler(this.txtOrigin_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(304, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tienda de Origen";
            // 
            // txtAmountInUnit
            // 
            this.txtAmountInUnit.Location = new System.Drawing.Point(307, 486);
            this.txtAmountInUnit.Name = "txtAmountInUnit";
            this.txtAmountInUnit.Size = new System.Drawing.Size(127, 20);
            this.txtAmountInUnit.TabIndex = 15;
            this.txtAmountInUnit.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmountInUnit_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(304, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cantidad en Unidad";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(510, 377);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(127, 20);
            this.txtUnitPrice.TabIndex = 17;
            this.txtUnitPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnitPrice_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(507, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Precio Unitario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(507, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Calidad";
            // 
            // txtUnitsAvailable
            // 
            this.txtUnitsAvailable.Location = new System.Drawing.Point(510, 486);
            this.txtUnitsAvailable.Name = "txtUnitsAvailable";
            this.txtUnitsAvailable.Size = new System.Drawing.Size(127, 20);
            this.txtUnitsAvailable.TabIndex = 21;
            this.txtUnitsAvailable.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnitsAvailable_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(507, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Cantidad Disponible";
            // 
            // comboBoxQuality
            // 
            this.comboBoxQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuality.FormattingEnabled = true;
            this.comboBoxQuality.Location = new System.Drawing.Point(510, 431);
            this.comboBoxQuality.Name = "comboBoxQuality";
            this.comboBoxQuality.Size = new System.Drawing.Size(127, 21);
            this.comboBoxQuality.TabIndex = 22;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Location = new System.Drawing.Point(109, 404);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(132, 23);
            this.btnSaveChanges.TabIndex = 23;
            this.btnSaveChanges.Text = "Guardar Cambios";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // errorProviderBrand
            // 
            this.errorProviderBrand.ContainerControl = this;
            // 
            // errorProviderOrigin
            // 
            this.errorProviderOrigin.ContainerControl = this;
            // 
            // errorProviderAmountInUnit
            // 
            this.errorProviderAmountInUnit.ContainerControl = this;
            // 
            // errorProviderUnitPrice
            // 
            this.errorProviderUnitPrice.ContainerControl = this;
            // 
            // errorProviderUnitsAvailable
            // 
            this.errorProviderUnitsAvailable.ContainerControl = this;
            // 
            // btnDeleteBaseIngredient
            // 
            this.btnDeleteBaseIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnDeleteBaseIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBaseIngredient.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteBaseIngredient.Location = new System.Drawing.Point(870, 293);
            this.btnDeleteBaseIngredient.Name = "btnDeleteBaseIngredient";
            this.btnDeleteBaseIngredient.Size = new System.Drawing.Size(155, 32);
            this.btnDeleteBaseIngredient.TabIndex = 24;
            this.btnDeleteBaseIngredient.Text = "Eliminar Ingrediente";
            this.btnDeleteBaseIngredient.UseVisualStyleBackColor = false;
            this.btnDeleteBaseIngredient.Click += new System.EventHandler(this.btnDeleteBaseIngredient_Click);
            // 
            // EditDetailedIngredientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.btnDeleteBaseIngredient);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.comboBoxQuality);
            this.Controls.Add(this.txtUnitsAvailable);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAmountInUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblingredientFound);
            this.Controls.Add(this.btnSearchDetailedIngredient);
            this.Controls.Add(this.txtSearchIngredientCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodeFilter);
            this.Controls.Add(this.txtNameFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFilterByName);
            this.Controls.Add(this.lblMenuTitle);
            this.Controls.Add(this.dgvDisplayDetailedIngredients);
            this.Name = "EditDetailedIngredientPanel";
            this.Size = new System.Drawing.Size(1028, 560);
            this.Load += new System.EventHandler(this.EditDetailedIngredientPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisplayDetailedIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAmountInUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnitsAvailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisplayDetailedIngredients;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Label lblFilterByName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameFilter;
        private System.Windows.Forms.TextBox txtCodeFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchIngredientCode;
        private System.Windows.Forms.Button btnSearchDetailedIngredient;
        private System.Windows.Forms.Label lblingredientFound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAmountInUnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUnitsAvailable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxQuality;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ErrorProvider errorProviderBrand;
        private System.Windows.Forms.ErrorProvider errorProviderOrigin;
        private System.Windows.Forms.ErrorProvider errorProviderAmountInUnit;
        private System.Windows.Forms.ErrorProvider errorProviderUnitPrice;
        private System.Windows.Forms.ErrorProvider errorProviderUnitsAvailable;
        private System.Windows.Forms.Button btnDeleteBaseIngredient;
    }
}
