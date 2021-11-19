
namespace PanaderiaIkigai.UI.Controls.Orders
{
    partial class RegisterOrderItemPanel
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
            this.pnlRegisterItem = new System.Windows.Forms.Panel();
            this.lblItemToEditName = new System.Windows.Forms.Label();
            this.numUnitAmount = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnItemEditMode = new System.Windows.Forms.RadioButton();
            this.rBtnItemRegisterMode = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRecipeCode = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtOrderCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.txtRecipeFilter = new System.Windows.Forms.TextBox();
            this.comboBoxFilterRecipe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.txtFilterOrders = new System.Windows.Forms.TextBox();
            this.comboBoxFilterOrders = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.pnlRegisterItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRegisterItem
            // 
            this.pnlRegisterItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.pnlRegisterItem.Controls.Add(this.lblItemToEditName);
            this.pnlRegisterItem.Controls.Add(this.numUnitAmount);
            this.pnlRegisterItem.Controls.Add(this.groupBox2);
            this.pnlRegisterItem.Controls.Add(this.label21);
            this.pnlRegisterItem.Controls.Add(this.btnSaveChanges);
            this.pnlRegisterItem.Controls.Add(this.label18);
            this.pnlRegisterItem.Controls.Add(this.txtRecipeCode);
            this.pnlRegisterItem.Controls.Add(this.label17);
            this.pnlRegisterItem.Controls.Add(this.txtOrderCode);
            this.pnlRegisterItem.Controls.Add(this.label16);
            this.pnlRegisterItem.Controls.Add(this.txtRecipeName);
            this.pnlRegisterItem.Controls.Add(this.label15);
            this.pnlRegisterItem.ForeColor = System.Drawing.Color.White;
            this.pnlRegisterItem.Location = new System.Drawing.Point(4, 570);
            this.pnlRegisterItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRegisterItem.Name = "pnlRegisterItem";
            this.pnlRegisterItem.Size = new System.Drawing.Size(901, 267);
            this.pnlRegisterItem.TabIndex = 36;
            // 
            // lblItemToEditName
            // 
            this.lblItemToEditName.AutoSize = true;
            this.lblItemToEditName.ForeColor = System.Drawing.Color.Yellow;
            this.lblItemToEditName.Location = new System.Drawing.Point(527, 171);
            this.lblItemToEditName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemToEditName.Name = "lblItemToEditName";
            this.lblItemToEditName.Size = new System.Drawing.Size(94, 17);
            this.lblItemToEditName.TabIndex = 43;
            this.lblItemToEditName.Text = "Editando Item";
            this.lblItemToEditName.Visible = false;
            // 
            // numUnitAmount
            // 
            this.numUnitAmount.Location = new System.Drawing.Point(324, 134);
            this.numUnitAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numUnitAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUnitAmount.Name = "numUnitAmount";
            this.numUnitAmount.ReadOnly = true;
            this.numUnitAmount.Size = new System.Drawing.Size(176, 22);
            this.numUnitAmount.TabIndex = 42;
            this.numUnitAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnItemEditMode);
            this.groupBox2.Controls.Add(this.rBtnItemRegisterMode);
            this.groupBox2.Location = new System.Drawing.Point(797, 65);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(100, 123);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modo de Operación";
            // 
            // rBtnItemEditMode
            // 
            this.rBtnItemEditMode.AutoSize = true;
            this.rBtnItemEditMode.Enabled = false;
            this.rBtnItemEditMode.Location = new System.Drawing.Point(9, 73);
            this.rBtnItemEditMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnItemEditMode.Name = "rBtnItemEditMode";
            this.rBtnItemEditMode.Size = new System.Drawing.Size(75, 21);
            this.rBtnItemEditMode.TabIndex = 1;
            this.rBtnItemEditMode.Text = "Edición";
            this.rBtnItemEditMode.UseVisualStyleBackColor = true;
            this.rBtnItemEditMode.CheckedChanged += new System.EventHandler(this.rBtnItemEditMode_CheckedChanged);
            // 
            // rBtnItemRegisterMode
            // 
            this.rBtnItemRegisterMode.AutoSize = true;
            this.rBtnItemRegisterMode.Checked = true;
            this.rBtnItemRegisterMode.Enabled = false;
            this.rBtnItemRegisterMode.Location = new System.Drawing.Point(9, 42);
            this.rBtnItemRegisterMode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rBtnItemRegisterMode.Name = "rBtnItemRegisterMode";
            this.rBtnItemRegisterMode.Size = new System.Drawing.Size(82, 21);
            this.rBtnItemRegisterMode.TabIndex = 0;
            this.rBtnItemRegisterMode.TabStop = true;
            this.rBtnItemRegisterMode.Text = "Registro";
            this.rBtnItemRegisterMode.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label21.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(9, 11);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 19);
            this.label21.TabIndex = 40;
            this.label21.Text = "Datos de Item";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Location = new System.Drawing.Point(797, 206);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(100, 49);
            this.btnSaveChanges.TabIndex = 39;
            this.btnSaveChanges.Text = "Guardar Cambios";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(320, 110);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(170, 19);
            this.label18.TabIndex = 36;
            this.label18.Text = "Cantidad de Unidades";
            // 
            // txtRecipeCode
            // 
            this.txtRecipeCode.Location = new System.Drawing.Point(27, 138);
            this.txtRecipeCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRecipeCode.Name = "txtRecipeCode";
            this.txtRecipeCode.ReadOnly = true;
            this.txtRecipeCode.Size = new System.Drawing.Size(249, 22);
            this.txtRecipeCode.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(27, 110);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(140, 19);
            this.label17.TabIndex = 34;
            this.label17.Text = "Código de Receta";
            // 
            // txtOrderCode
            // 
            this.txtOrderCode.Location = new System.Drawing.Point(27, 65);
            this.txtOrderCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOrderCode.Name = "txtOrderCode";
            this.txtOrderCode.ReadOnly = true;
            this.txtOrderCode.Size = new System.Drawing.Size(249, 22);
            this.txtOrderCode.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(27, 41);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(140, 19);
            this.label16.TabIndex = 32;
            this.label16.Text = "Código de Pedido";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(324, 65);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.ReadOnly = true;
            this.txtRecipeName.Size = new System.Drawing.Size(249, 22);
            this.txtRecipeName.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(320, 41);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 19);
            this.label15.TabIndex = 30;
            this.label15.Text = "Nombre de Receta";
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(1040, 353);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.Size = new System.Drawing.Size(764, 267);
            this.dgvItems.TabIndex = 35;
            this.dgvItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellClick);
            // 
            // txtRecipeFilter
            // 
            this.txtRecipeFilter.Location = new System.Drawing.Point(289, 532);
            this.txtRecipeFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRecipeFilter.Name = "txtRecipeFilter";
            this.txtRecipeFilter.Size = new System.Drawing.Size(228, 22);
            this.txtRecipeFilter.TabIndex = 34;
            this.txtRecipeFilter.TextChanged += new System.EventHandler(this.txtRecipeFilter_TextChanged);
            // 
            // comboBoxFilterRecipe
            // 
            this.comboBoxFilterRecipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterRecipe.FormattingEnabled = true;
            this.comboBoxFilterRecipe.Items.AddRange(new object[] {
            "Nombre",
            "Categoría",
            "Autor"});
            this.comboBoxFilterRecipe.Location = new System.Drawing.Point(100, 532);
            this.comboBoxFilterRecipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFilterRecipe.Name = "comboBoxFilterRecipe";
            this.comboBoxFilterRecipe.Size = new System.Drawing.Size(180, 24);
            this.comboBoxFilterRecipe.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 539);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Filtrar por";
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AllowUserToAddRows = false;
            this.dgvRecipes.AllowUserToDeleteRows = false;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(4, 353);
            this.dgvRecipes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRecipes.MultiSelect = false;
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.ReadOnly = true;
            this.dgvRecipes.RowHeadersWidth = 51;
            this.dgvRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipes.Size = new System.Drawing.Size(1028, 171);
            this.dgvRecipes.TabIndex = 31;
            this.dgvRecipes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecipes_CellClick);
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.ForeColor = System.Drawing.Color.Yellow;
            this.lblDateFormat.Location = new System.Drawing.Point(2007, -1);
            this.lblDateFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(303, 17);
            this.lblDateFormat.TabIndex = 43;
            this.lblDateFormat.Text = "Escriba la Fecha con este formato yyyy-mm-dd";
            this.lblDateFormat.Visible = false;
            // 
            // txtFilterOrders
            // 
            this.txtFilterOrders.Location = new System.Drawing.Point(2023, 23);
            this.txtFilterOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilterOrders.Name = "txtFilterOrders";
            this.txtFilterOrders.Size = new System.Drawing.Size(281, 22);
            this.txtFilterOrders.TabIndex = 42;
            this.txtFilterOrders.TextChanged += new System.EventHandler(this.txtFilterOrders_TextChanged);
            // 
            // comboBoxFilterOrders
            // 
            this.comboBoxFilterOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterOrders.FormattingEnabled = true;
            this.comboBoxFilterOrders.Items.AddRange(new object[] {
            "Nombre de Cliente",
            "Estado de Orden",
            "Fecha de Orden",
            "Fecha de Entrega"});
            this.comboBoxFilterOrders.Location = new System.Drawing.Point(1785, 22);
            this.comboBoxFilterOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxFilterOrders.Name = "comboBoxFilterOrders";
            this.comboBoxFilterOrders.Size = new System.Drawing.Size(228, 24);
            this.comboBoxFilterOrders.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(1693, 23);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 19);
            this.label19.TabIndex = 40;
            this.label19.Text = "Filtrar por";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 28);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 19);
            this.label13.TabIndex = 39;
            this.label13.Text = "Pedidos Registrados";
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvOrders.Location = new System.Drawing.Point(4, 52);
            this.dgvOrders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersWidth = 51;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(2299, 262);
            this.dgvOrders.TabIndex = 38;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Registro de Ítems";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Recetas Disponibles";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(1040, 330);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(130, 19);
            this.label22.TabIndex = 45;
            this.label22.Text = "Items del Pedido";
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnDeleteItem.Enabled = false;
            this.btnDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteItem.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteItem.Location = new System.Drawing.Point(1044, 628);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(207, 39);
            this.btnDeleteItem.TabIndex = 46;
            this.btnDeleteItem.Text = "Eliminar Item";
            this.btnDeleteItem.UseVisualStyleBackColor = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // RegisterOrderItemPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDateFormat);
            this.Controls.Add(this.txtFilterOrders);
            this.Controls.Add(this.comboBoxFilterOrders);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlRegisterItem);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.txtRecipeFilter);
            this.Controls.Add(this.comboBoxFilterRecipe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvRecipes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterOrderItemPanel";
            this.Size = new System.Drawing.Size(2473, 841);
            this.Load += new System.EventHandler(this.RegisterOrderItemPanel_Load);
            this.pnlRegisterItem.ResumeLayout(false);
            this.pnlRegisterItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegisterItem;
        private System.Windows.Forms.NumericUpDown numUnitAmount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnItemEditMode;
        private System.Windows.Forms.RadioButton rBtnItemRegisterMode;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRecipeCode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtOrderCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.TextBox txtRecipeFilter;
        private System.Windows.Forms.ComboBox comboBoxFilterRecipe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.TextBox txtFilterOrders;
        private System.Windows.Forms.ComboBox comboBoxFilterOrders;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Label lblItemToEditName;
    }
}
