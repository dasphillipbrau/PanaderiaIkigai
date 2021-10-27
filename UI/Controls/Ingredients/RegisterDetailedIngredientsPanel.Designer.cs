
namespace PanaderiaIkigai.UI.Controls.Ingredients
{
    partial class RegisterDetailedIngredientsPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFilterByNameTitle = new System.Windows.Forms.Label();
            this.txtFilterIngredientByName = new System.Windows.Forms.TextBox();
            this.dgvViewBaseIngredients = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveDetailedIngredient = new System.Windows.Forms.Button();
            this.btnSearchBaseIngredient = new System.Windows.Forms.Button();
            this.txtSearchIngredientCode = new System.Windows.Forms.TextBox();
            this.lblSelectIngredientTitle = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtAmountInUnit = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtAmountAvailable = new System.Windows.Forms.TextBox();
            this.comboBoxQuality = new System.Windows.Forms.ComboBox();
            this.lblIngredientBrand = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProviderBrand = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOrigin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAmountInUnit = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUnitPrice = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUnitsAvailable = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblBaseIngredientFound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBaseIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBrand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAmountInUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnitsAvailable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Ingredientes Detallados";
            // 
            // lblFilterByNameTitle
            // 
            this.lblFilterByNameTitle.AutoSize = true;
            this.lblFilterByNameTitle.ForeColor = System.Drawing.Color.White;
            this.lblFilterByNameTitle.Location = new System.Drawing.Point(758, 48);
            this.lblFilterByNameTitle.Name = "lblFilterByNameTitle";
            this.lblFilterByNameTitle.Size = new System.Drawing.Size(90, 13);
            this.lblFilterByNameTitle.TabIndex = 12;
            this.lblFilterByNameTitle.Text = "Filtrar por Nombre";
            // 
            // txtFilterIngredientByName
            // 
            this.txtFilterIngredientByName.Location = new System.Drawing.Point(854, 48);
            this.txtFilterIngredientByName.Name = "txtFilterIngredientByName";
            this.txtFilterIngredientByName.Size = new System.Drawing.Size(155, 20);
            this.txtFilterIngredientByName.TabIndex = 11;
            this.txtFilterIngredientByName.TextChanged += new System.EventHandler(this.txtFilterIngredientByName_TextChanged);
            // 
            // dgvViewBaseIngredients
            // 
            this.dgvViewBaseIngredients.AllowUserToAddRows = false;
            this.dgvViewBaseIngredients.AllowUserToDeleteRows = false;
            this.dgvViewBaseIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewBaseIngredients.GridColor = System.Drawing.Color.White;
            this.dgvViewBaseIngredients.Location = new System.Drawing.Point(18, 78);
            this.dgvViewBaseIngredients.Name = "dgvViewBaseIngredients";
            this.dgvViewBaseIngredients.ReadOnly = true;
            this.dgvViewBaseIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvViewBaseIngredients.Size = new System.Drawing.Size(991, 105);
            this.dgvViewBaseIngredients.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ingredientes Base";
            // 
            // btnSaveDetailedIngredient
            // 
            this.btnSaveDetailedIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSaveDetailedIngredient.Enabled = false;
            this.btnSaveDetailedIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDetailedIngredient.Location = new System.Drawing.Point(21, 483);
            this.btnSaveDetailedIngredient.Name = "btnSaveDetailedIngredient";
            this.btnSaveDetailedIngredient.Size = new System.Drawing.Size(114, 48);
            this.btnSaveDetailedIngredient.TabIndex = 22;
            this.btnSaveDetailedIngredient.Text = "Registrar Ingrediente Detallado";
            this.btnSaveDetailedIngredient.UseVisualStyleBackColor = false;
            this.btnSaveDetailedIngredient.Click += new System.EventHandler(this.btnSaveDetailedIngredient_Click);
            // 
            // btnSearchBaseIngredient
            // 
            this.btnSearchBaseIngredient.Location = new System.Drawing.Point(21, 262);
            this.btnSearchBaseIngredient.Name = "btnSearchBaseIngredient";
            this.btnSearchBaseIngredient.Size = new System.Drawing.Size(153, 24);
            this.btnSearchBaseIngredient.TabIndex = 21;
            this.btnSearchBaseIngredient.Text = "Buscar";
            this.btnSearchBaseIngredient.UseVisualStyleBackColor = true;
            this.btnSearchBaseIngredient.Click += new System.EventHandler(this.btnSearchBaseIngredient_Click);
            // 
            // txtSearchIngredientCode
            // 
            this.txtSearchIngredientCode.Location = new System.Drawing.Point(21, 236);
            this.txtSearchIngredientCode.Name = "txtSearchIngredientCode";
            this.txtSearchIngredientCode.Size = new System.Drawing.Size(153, 20);
            this.txtSearchIngredientCode.TabIndex = 20;
            // 
            // lblSelectIngredientTitle
            // 
            this.lblSelectIngredientTitle.AutoSize = true;
            this.lblSelectIngredientTitle.ForeColor = System.Drawing.Color.White;
            this.lblSelectIngredientTitle.Location = new System.Drawing.Point(18, 220);
            this.lblSelectIngredientTitle.Name = "lblSelectIngredientTitle";
            this.lblSelectIngredientTitle.Size = new System.Drawing.Size(473, 13);
            this.lblSelectIngredientTitle.TabIndex = 19;
            this.lblSelectIngredientTitle.Text = "Escriba el código del Ingrediente Base al cual pertenece el Ingrediente Detallado" +
    " que va a registrar";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(21, 316);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(153, 20);
            this.txtBrand.TabIndex = 23;
            this.txtBrand.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrand_Validating);
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(21, 371);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(153, 20);
            this.txtOrigin.TabIndex = 24;
            this.txtOrigin.Validating += new System.ComponentModel.CancelEventHandler(this.txtOrigin_Validating);
            // 
            // txtAmountInUnit
            // 
            this.txtAmountInUnit.Location = new System.Drawing.Point(21, 422);
            this.txtAmountInUnit.Name = "txtAmountInUnit";
            this.txtAmountInUnit.Size = new System.Drawing.Size(153, 20);
            this.txtAmountInUnit.TabIndex = 25;
            this.txtAmountInUnit.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmountInUnit_Validating);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(218, 316);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(153, 20);
            this.txtUnitPrice.TabIndex = 26;
            this.txtUnitPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnitPrice_Validating);
            // 
            // txtAmountAvailable
            // 
            this.txtAmountAvailable.Location = new System.Drawing.Point(218, 422);
            this.txtAmountAvailable.Name = "txtAmountAvailable";
            this.txtAmountAvailable.Size = new System.Drawing.Size(153, 20);
            this.txtAmountAvailable.TabIndex = 28;
            this.txtAmountAvailable.Validating += new System.ComponentModel.CancelEventHandler(this.txtAmountAvailable_Validating);
            // 
            // comboBoxQuality
            // 
            this.comboBoxQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuality.FormattingEnabled = true;
            this.comboBoxQuality.Location = new System.Drawing.Point(218, 371);
            this.comboBoxQuality.Name = "comboBoxQuality";
            this.comboBoxQuality.Size = new System.Drawing.Size(153, 21);
            this.comboBoxQuality.TabIndex = 30;
            // 
            // lblIngredientBrand
            // 
            this.lblIngredientBrand.AutoSize = true;
            this.lblIngredientBrand.ForeColor = System.Drawing.Color.White;
            this.lblIngredientBrand.Location = new System.Drawing.Point(21, 297);
            this.lblIngredientBrand.Name = "lblIngredientBrand";
            this.lblIngredientBrand.Size = new System.Drawing.Size(110, 13);
            this.lblIngredientBrand.TabIndex = 31;
            this.lblIngredientBrand.Text = "Marca del Ingrediente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Tienda de Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Cantidad en la Unidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(215, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Precio Unitario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(215, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Calidad del Ingrediente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(215, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Unidades en Inventario";
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
            // lblBaseIngredientFound
            // 
            this.lblBaseIngredientFound.AutoSize = true;
            this.lblBaseIngredientFound.ForeColor = System.Drawing.Color.Lime;
            this.lblBaseIngredientFound.Location = new System.Drawing.Point(181, 242);
            this.lblBaseIngredientFound.Name = "lblBaseIngredientFound";
            this.lblBaseIngredientFound.Size = new System.Drawing.Size(35, 13);
            this.lblBaseIngredientFound.TabIndex = 37;
            this.lblBaseIngredientFound.Text = "label8";
            // 
            // RegisterDetailedIngredientsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.lblBaseIngredientFound);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIngredientBrand);
            this.Controls.Add(this.comboBoxQuality);
            this.Controls.Add(this.txtAmountAvailable);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtAmountInUnit);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.btnSaveDetailedIngredient);
            this.Controls.Add(this.btnSearchBaseIngredient);
            this.Controls.Add(this.txtSearchIngredientCode);
            this.Controls.Add(this.lblSelectIngredientTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFilterByNameTitle);
            this.Controls.Add(this.txtFilterIngredientByName);
            this.Controls.Add(this.dgvViewBaseIngredients);
            this.Controls.Add(this.label1);
            this.Name = "RegisterDetailedIngredientsPanel";
            this.Size = new System.Drawing.Size(1028, 560);
            this.Load += new System.EventHandler(this.RegisterDetailedIngredientsPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewBaseIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderBrand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAmountInUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnitsAvailable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFilterByNameTitle;
        private System.Windows.Forms.TextBox txtFilterIngredientByName;
        private System.Windows.Forms.DataGridView dgvViewBaseIngredients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveDetailedIngredient;
        private System.Windows.Forms.Button btnSearchBaseIngredient;
        private System.Windows.Forms.TextBox txtSearchIngredientCode;
        private System.Windows.Forms.Label lblSelectIngredientTitle;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtAmountInUnit;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtAmountAvailable;
        private System.Windows.Forms.ComboBox comboBoxQuality;
        private System.Windows.Forms.Label lblIngredientBrand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProviderBrand;
        private System.Windows.Forms.ErrorProvider errorProviderOrigin;
        private System.Windows.Forms.ErrorProvider errorProviderAmountInUnit;
        private System.Windows.Forms.ErrorProvider errorProviderUnitPrice;
        private System.Windows.Forms.ErrorProvider errorProviderUnitsAvailable;
        private System.Windows.Forms.Label lblBaseIngredientFound;
    }
}
