
namespace PanaderiaIkigai.UI.Controls.Orders
{
    partial class RegisterOrderPanel
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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFilterClients = new System.Windows.Forms.ComboBox();
            this.txtFilterClient = new System.Windows.Forms.TextBox();
            this.txtClientAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRecipeFilter = new System.Windows.Forms.TextBox();
            this.comboBoxFilterRecipe = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlRegisterOrder = new System.Windows.Forms.Panel();
            this.numPrepPrice = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.numTaxPercentage = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnOrderEditMode = new System.Windows.Forms.RadioButton();
            this.rBtnOrderRegisterMode = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.btnSaveOrderChanges = new System.Windows.Forms.Button();
            this.dateDelivery = new System.Windows.Forms.DateTimePicker();
            this.dateOrder = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxOrderStatus = new System.Windows.Forms.ComboBox();
            this.txtPrepNotes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.pnlRegisterItem = new System.Windows.Forms.Panel();
            this.numUnitAmount = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnItemEditMode = new System.Windows.Forms.RadioButton();
            this.rBtnItemRegisterMode = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txtRecipeCode = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtOrderCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.errorProviderOrderNotes = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOrderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDeliveryDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFilterOrders = new System.Windows.Forms.TextBox();
            this.comboBoxFilterOrders = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDateFormat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlRegisterOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrepPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxPercentage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.pnlRegisterItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitAmount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrderNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeliveryDate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Ordenes";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(8, 283);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(615, 150);
            this.dgvClients.TabIndex = 1;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clientes Registrados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(196, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filtrar por";
            // 
            // comboBoxFilterClients
            // 
            this.comboBoxFilterClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilterClients.FormattingEnabled = true;
            this.comboBoxFilterClients.Items.AddRange(new object[] {
            "Nombre",
            "Código",
            "Teléfono",
            "E-Mail",
            "Dirección"});
            this.comboBoxFilterClients.Location = new System.Drawing.Point(265, 435);
            this.comboBoxFilterClients.Name = "comboBoxFilterClients";
            this.comboBoxFilterClients.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterClients.TabIndex = 4;
            // 
            // txtFilterClient
            // 
            this.txtFilterClient.Location = new System.Drawing.Point(392, 436);
            this.txtFilterClient.Name = "txtFilterClient";
            this.txtFilterClient.Size = new System.Drawing.Size(212, 20);
            this.txtFilterClient.TabIndex = 5;
            this.txtFilterClient.TextChanged += new System.EventHandler(this.txtFilterClient_TextChanged);
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(629, 283);
            this.txtClientAddress.Multiline = true;
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.ReadOnly = true;
            this.txtClientAddress.Size = new System.Drawing.Size(443, 116);
            this.txtClientAddress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(626, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección de Cliente Seleccionado";
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AllowUserToAddRows = false;
            this.dgvRecipes.AllowUserToDeleteRows = false;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(1081, 283);
            this.dgvRecipes.MultiSelect = false;
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.ReadOnly = true;
            this.dgvRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipes.Size = new System.Drawing.Size(771, 139);
            this.dgvRecipes.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1078, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Recetas Disponibles";
            // 
            // txtRecipeFilter
            // 
            this.txtRecipeFilter.Location = new System.Drawing.Point(1420, 428);
            this.txtRecipeFilter.Name = "txtRecipeFilter";
            this.txtRecipeFilter.Size = new System.Drawing.Size(172, 20);
            this.txtRecipeFilter.TabIndex = 12;
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
            this.comboBoxFilterRecipe.Location = new System.Drawing.Point(1278, 428);
            this.comboBoxFilterRecipe.Name = "comboBoxFilterRecipe";
            this.comboBoxFilterRecipe.Size = new System.Drawing.Size(136, 21);
            this.comboBoxFilterRecipe.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1209, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Filtrar por";
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvOrders.Location = new System.Drawing.Point(8, 47);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(1727, 213);
            this.dgvOrders.TabIndex = 26;
            this.dgvOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_CellClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(5, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Ordenes Registradas";
            // 
            // pnlRegisterOrder
            // 
            this.pnlRegisterOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.pnlRegisterOrder.Controls.Add(this.numPrepPrice);
            this.pnlRegisterOrder.Controls.Add(this.label23);
            this.pnlRegisterOrder.Controls.Add(this.numTaxPercentage);
            this.pnlRegisterOrder.Controls.Add(this.groupBox1);
            this.pnlRegisterOrder.Controls.Add(this.label20);
            this.pnlRegisterOrder.Controls.Add(this.btnSaveOrderChanges);
            this.pnlRegisterOrder.Controls.Add(this.dateDelivery);
            this.pnlRegisterOrder.Controls.Add(this.dateOrder);
            this.pnlRegisterOrder.Controls.Add(this.label12);
            this.pnlRegisterOrder.Controls.Add(this.label11);
            this.pnlRegisterOrder.Controls.Add(this.comboBoxOrderStatus);
            this.pnlRegisterOrder.Controls.Add(this.txtPrepNotes);
            this.pnlRegisterOrder.Controls.Add(this.label10);
            this.pnlRegisterOrder.Controls.Add(this.label9);
            this.pnlRegisterOrder.Controls.Add(this.label8);
            this.pnlRegisterOrder.Controls.Add(this.txtClientName);
            this.pnlRegisterOrder.Controls.Add(this.label7);
            this.pnlRegisterOrder.Location = new System.Drawing.Point(8, 461);
            this.pnlRegisterOrder.Name = "pnlRegisterOrder";
            this.pnlRegisterOrder.Size = new System.Drawing.Size(615, 217);
            this.pnlRegisterOrder.TabIndex = 28;
            // 
            // numPrepPrice
            // 
            this.numPrepPrice.DecimalPlaces = 2;
            this.numPrepPrice.Location = new System.Drawing.Point(268, 144);
            this.numPrepPrice.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numPrepPrice.Name = "numPrepPrice";
            this.numPrepPrice.Size = new System.Drawing.Size(120, 20);
            this.numPrepPrice.TabIndex = 43;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(263, 120);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(146, 16);
            this.label23.TabIndex = 42;
            this.label23.Text = "Costo de Mano de Obra";
            // 
            // numTaxPercentage
            // 
            this.numTaxPercentage.DecimalPlaces = 2;
            this.numTaxPercentage.Location = new System.Drawing.Point(23, 143);
            this.numTaxPercentage.Name = "numTaxPercentage";
            this.numTaxPercentage.Size = new System.Drawing.Size(120, 20);
            this.numTaxPercentage.TabIndex = 41;
            this.numTaxPercentage.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnOrderEditMode);
            this.groupBox1.Controls.Add(this.rBtnOrderRegisterMode);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(521, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(75, 100);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de Operación";
            // 
            // rBtnOrderEditMode
            // 
            this.rBtnOrderEditMode.AutoSize = true;
            this.rBtnOrderEditMode.Location = new System.Drawing.Point(7, 66);
            this.rBtnOrderEditMode.Name = "rBtnOrderEditMode";
            this.rBtnOrderEditMode.Size = new System.Drawing.Size(60, 17);
            this.rBtnOrderEditMode.TabIndex = 1;
            this.rBtnOrderEditMode.Text = "Edición";
            this.rBtnOrderEditMode.UseVisualStyleBackColor = true;
            this.rBtnOrderEditMode.CheckedChanged += new System.EventHandler(this.rBtnOrderEditInsertMode_CheckedChanged);
            // 
            // rBtnOrderRegisterMode
            // 
            this.rBtnOrderRegisterMode.AutoSize = true;
            this.rBtnOrderRegisterMode.Checked = true;
            this.rBtnOrderRegisterMode.Location = new System.Drawing.Point(7, 36);
            this.rBtnOrderRegisterMode.Name = "rBtnOrderRegisterMode";
            this.rBtnOrderRegisterMode.Size = new System.Drawing.Size(64, 17);
            this.rBtnOrderRegisterMode.TabIndex = 0;
            this.rBtnOrderRegisterMode.TabStop = true;
            this.rBtnOrderRegisterMode.Text = "Registro";
            this.rBtnOrderRegisterMode.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(3, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 16);
            this.label20.TabIndex = 39;
            this.label20.Text = "Datos de Orden";
            // 
            // btnSaveOrderChanges
            // 
            this.btnSaveOrderChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveOrderChanges.Enabled = false;
            this.btnSaveOrderChanges.Location = new System.Drawing.Point(521, 167);
            this.btnSaveOrderChanges.Name = "btnSaveOrderChanges";
            this.btnSaveOrderChanges.Size = new System.Drawing.Size(75, 40);
            this.btnSaveOrderChanges.TabIndex = 38;
            this.btnSaveOrderChanges.Text = "Guardar Cambios";
            this.btnSaveOrderChanges.UseVisualStyleBackColor = false;
            this.btnSaveOrderChanges.Click += new System.EventHandler(this.btnSaveOrderChanges_Click);
            // 
            // dateDelivery
            // 
            this.dateDelivery.Enabled = false;
            this.dateDelivery.Location = new System.Drawing.Point(266, 187);
            this.dateDelivery.Name = "dateDelivery";
            this.dateDelivery.Size = new System.Drawing.Size(200, 20);
            this.dateDelivery.TabIndex = 37;
            this.dateDelivery.Validating += new System.ComponentModel.CancelEventHandler(this.dateDelivery_Validating);
            // 
            // dateOrder
            // 
            this.dateOrder.Enabled = false;
            this.dateOrder.Location = new System.Drawing.Point(23, 187);
            this.dateOrder.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateOrder.MinDate = new System.DateTime(2021, 10, 30, 0, 0, 0, 0);
            this.dateOrder.Name = "dateOrder";
            this.dateOrder.Size = new System.Drawing.Size(200, 20);
            this.dateOrder.TabIndex = 36;
            this.dateOrder.Value = new System.DateTime(2021, 10, 30, 13, 2, 45, 0);
            this.dateOrder.Validating += new System.ComponentModel.CancelEventHandler(this.dateOrder_Validating);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(263, 167);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Fecha de Entrega";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(20, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Fecha de Pedido";
            // 
            // comboBoxOrderStatus
            // 
            this.comboBoxOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrderStatus.Enabled = false;
            this.comboBoxOrderStatus.FormattingEnabled = true;
            this.comboBoxOrderStatus.Items.AddRange(new object[] {
            "Pendiente",
            "En Progreso",
            "Entrega Pendiente",
            "Completada",
            "Cancelada"});
            this.comboBoxOrderStatus.Location = new System.Drawing.Point(21, 95);
            this.comboBoxOrderStatus.Name = "comboBoxOrderStatus";
            this.comboBoxOrderStatus.Size = new System.Drawing.Size(188, 21);
            this.comboBoxOrderStatus.TabIndex = 33;
            // 
            // txtPrepNotes
            // 
            this.txtPrepNotes.Location = new System.Drawing.Point(268, 29);
            this.txtPrepNotes.Multiline = true;
            this.txtPrepNotes.Name = "txtPrepNotes";
            this.txtPrepNotes.ReadOnly = true;
            this.txtPrepNotes.Size = new System.Drawing.Size(198, 87);
            this.txtPrepNotes.TabIndex = 32;
            this.txtPrepNotes.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(263, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 31;
            this.label10.Text = "Notas de Entrega";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(18, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Porcentaje de Impuesto por aplicar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Estado de Orden";
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(21, 53);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.ReadOnly = true;
            this.txtClientName.Size = new System.Drawing.Size(188, 20);
            this.txtClientName.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nombre de Cliente";
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(629, 461);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(573, 217);
            this.dgvItems.TabIndex = 29;
            this.dgvItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellClick);
            // 
            // pnlRegisterItem
            // 
            this.pnlRegisterItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.pnlRegisterItem.Controls.Add(this.numUnitAmount);
            this.pnlRegisterItem.Controls.Add(this.groupBox2);
            this.pnlRegisterItem.Controls.Add(this.label21);
            this.pnlRegisterItem.Controls.Add(this.button1);
            this.pnlRegisterItem.Controls.Add(this.label18);
            this.pnlRegisterItem.Controls.Add(this.txtRecipeCode);
            this.pnlRegisterItem.Controls.Add(this.label17);
            this.pnlRegisterItem.Controls.Add(this.txtOrderCode);
            this.pnlRegisterItem.Controls.Add(this.label16);
            this.pnlRegisterItem.Controls.Add(this.txtRecipeName);
            this.pnlRegisterItem.Controls.Add(this.label15);
            this.pnlRegisterItem.Controls.Add(this.txtItemCode);
            this.pnlRegisterItem.Controls.Add(this.label14);
            this.pnlRegisterItem.ForeColor = System.Drawing.Color.White;
            this.pnlRegisterItem.Location = new System.Drawing.Point(1209, 461);
            this.pnlRegisterItem.Name = "pnlRegisterItem";
            this.pnlRegisterItem.Size = new System.Drawing.Size(526, 217);
            this.pnlRegisterItem.TabIndex = 30;
            // 
            // numUnitAmount
            // 
            this.numUnitAmount.Location = new System.Drawing.Point(243, 108);
            this.numUnitAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUnitAmount.Name = "numUnitAmount";
            this.numUnitAmount.ReadOnly = true;
            this.numUnitAmount.Size = new System.Drawing.Size(132, 20);
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
            this.groupBox2.Location = new System.Drawing.Point(448, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 100);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modo de Operación";
            // 
            // rBtnItemEditMode
            // 
            this.rBtnItemEditMode.AutoSize = true;
            this.rBtnItemEditMode.Location = new System.Drawing.Point(7, 59);
            this.rBtnItemEditMode.Name = "rBtnItemEditMode";
            this.rBtnItemEditMode.Size = new System.Drawing.Size(60, 17);
            this.rBtnItemEditMode.TabIndex = 1;
            this.rBtnItemEditMode.Text = "Edición";
            this.rBtnItemEditMode.UseVisualStyleBackColor = true;
            // 
            // rBtnItemRegisterMode
            // 
            this.rBtnItemRegisterMode.AutoSize = true;
            this.rBtnItemRegisterMode.Checked = true;
            this.rBtnItemRegisterMode.Location = new System.Drawing.Point(7, 34);
            this.rBtnItemRegisterMode.Name = "rBtnItemRegisterMode";
            this.rBtnItemRegisterMode.Size = new System.Drawing.Size(64, 17);
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
            this.label21.Location = new System.Drawing.Point(7, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 16);
            this.label21.TabIndex = 40;
            this.label21.Text = "Datos de Item";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(448, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 39;
            this.button1.Text = "Guardar Cambios";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(240, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 16);
            this.label18.TabIndex = 36;
            this.label18.Text = "Cantidad de Unidades";
            // 
            // txtRecipeCode
            // 
            this.txtRecipeCode.Location = new System.Drawing.Point(20, 162);
            this.txtRecipeCode.Name = "txtRecipeCode";
            this.txtRecipeCode.ReadOnly = true;
            this.txtRecipeCode.Size = new System.Drawing.Size(188, 20);
            this.txtRecipeCode.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(17, 143);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(111, 16);
            this.label17.TabIndex = 34;
            this.label17.Text = "Código de Receta";
            // 
            // txtOrderCode
            // 
            this.txtOrderCode.Location = new System.Drawing.Point(20, 109);
            this.txtOrderCode.Name = "txtOrderCode";
            this.txtOrderCode.ReadOnly = true;
            this.txtOrderCode.Size = new System.Drawing.Size(188, 20);
            this.txtOrderCode.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(15, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 16);
            this.label16.TabIndex = 32;
            this.label16.Text = "Código de Orden";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(243, 53);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.ReadOnly = true;
            this.txtRecipeName.Size = new System.Drawing.Size(188, 20);
            this.txtRecipeName.TabIndex = 31;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(240, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 16);
            this.label15.TabIndex = 30;
            this.label15.Text = "Nombre de Receta";
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(20, 53);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(188, 20);
            this.txtItemCode.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(15, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Código de Item";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(629, 442);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(105, 16);
            this.label22.TabIndex = 31;
            this.label22.Text = "Items del Pedido";
            // 
            // errorProviderOrderNotes
            // 
            this.errorProviderOrderNotes.ContainerControl = this;
            // 
            // errorProviderOrderDate
            // 
            this.errorProviderOrderDate.ContainerControl = this;
            // 
            // errorProviderDeliveryDate
            // 
            this.errorProviderDeliveryDate.ContainerControl = this;
            // 
            // txtFilterOrders
            // 
            this.txtFilterOrders.Location = new System.Drawing.Point(1522, 24);
            this.txtFilterOrders.Name = "txtFilterOrders";
            this.txtFilterOrders.Size = new System.Drawing.Size(212, 20);
            this.txtFilterOrders.TabIndex = 34;
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
            this.comboBoxFilterOrders.Location = new System.Drawing.Point(1344, 23);
            this.comboBoxFilterOrders.Name = "comboBoxFilterOrders";
            this.comboBoxFilterOrders.Size = new System.Drawing.Size(172, 21);
            this.comboBoxFilterOrders.TabIndex = 33;
            this.comboBoxFilterOrders.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilterOrders_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(1275, 24);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 16);
            this.label19.TabIndex = 32;
            this.label19.Text = "Filtrar por";
            // 
            // lblDateFormat
            // 
            this.lblDateFormat.AutoSize = true;
            this.lblDateFormat.ForeColor = System.Drawing.Color.Yellow;
            this.lblDateFormat.Location = new System.Drawing.Point(1510, 4);
            this.lblDateFormat.Name = "lblDateFormat";
            this.lblDateFormat.Size = new System.Drawing.Size(225, 13);
            this.lblDateFormat.TabIndex = 35;
            this.lblDateFormat.Text = "Escriba la Fecha con este formato yyyy-mm-dd";
            this.lblDateFormat.Visible = false;
            // 
            // RegisterOrderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.lblDateFormat);
            this.Controls.Add(this.txtFilterOrders);
            this.Controls.Add(this.comboBoxFilterOrders);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pnlRegisterItem);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.txtRecipeFilter);
            this.Controls.Add(this.comboBoxFilterRecipe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvRecipes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClientAddress);
            this.Controls.Add(this.txtFilterClient);
            this.Controls.Add(this.comboBoxFilterClients);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlRegisterOrder);
            this.Name = "RegisterOrderPanel";
            this.Size = new System.Drawing.Size(1855, 683);
            this.Load += new System.EventHandler(this.RegisterOrderPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlRegisterOrder.ResumeLayout(false);
            this.pnlRegisterOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrepPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxPercentage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnlRegisterItem.ResumeLayout(false);
            this.pnlRegisterItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitAmount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrderNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOrderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeliveryDate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFilterClients;
        private System.Windows.Forms.TextBox txtFilterClient;
        private System.Windows.Forms.TextBox txtClientAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRecipeFilter;
        private System.Windows.Forms.ComboBox comboBoxFilterRecipe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlRegisterOrder;
        private System.Windows.Forms.Button btnSaveOrderChanges;
        private System.Windows.Forms.DateTimePicker dateDelivery;
        private System.Windows.Forms.DateTimePicker dateOrder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxOrderStatus;
        private System.Windows.Forms.TextBox txtPrepNotes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Panel pnlRegisterItem;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRecipeCode;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtOrderCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnOrderEditMode;
        private System.Windows.Forms.RadioButton rBtnOrderRegisterMode;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnItemEditMode;
        private System.Windows.Forms.RadioButton rBtnItemRegisterMode;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numTaxPercentage;
        private System.Windows.Forms.NumericUpDown numUnitAmount;
        private System.Windows.Forms.NumericUpDown numPrepPrice;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ErrorProvider errorProviderOrderNotes;
        private System.Windows.Forms.ErrorProvider errorProviderOrderDate;
        private System.Windows.Forms.ErrorProvider errorProviderDeliveryDate;
        private System.Windows.Forms.TextBox txtFilterOrders;
        private System.Windows.Forms.ComboBox comboBoxFilterOrders;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblDateFormat;
    }
}
