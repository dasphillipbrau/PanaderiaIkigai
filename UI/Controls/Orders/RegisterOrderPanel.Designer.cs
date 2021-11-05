
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
            this.errorProviderOrderNotes = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderOrderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDeliveryDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtFilterOrders = new System.Windows.Forms.TextBox();
            this.comboBoxFilterOrders = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDateFormat = new System.Windows.Forms.Label();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.lblEditingOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.pnlRegisterOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrepPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxPercentage)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registro de Pedidos";
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(629, 328);
            this.dgvClients.MultiSelect = false;
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(807, 150);
            this.dgvClients.TabIndex = 1;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(626, 309);
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
            this.label3.Location = new System.Drawing.Point(631, 483);
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
            this.comboBoxFilterClients.Location = new System.Drawing.Point(700, 484);
            this.comboBoxFilterClients.Name = "comboBoxFilterClients";
            this.comboBoxFilterClients.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilterClients.TabIndex = 4;
            // 
            // txtFilterClient
            // 
            this.txtFilterClient.Location = new System.Drawing.Point(827, 485);
            this.txtFilterClient.Name = "txtFilterClient";
            this.txtFilterClient.Size = new System.Drawing.Size(212, 20);
            this.txtFilterClient.TabIndex = 5;
            this.txtFilterClient.TextChanged += new System.EventHandler(this.txtFilterClient_TextChanged);
            // 
            // txtClientAddress
            // 
            this.txtClientAddress.Location = new System.Drawing.Point(1442, 328);
            this.txtClientAddress.Multiline = true;
            this.txtClientAddress.Name = "txtClientAddress";
            this.txtClientAddress.ReadOnly = true;
            this.txtClientAddress.Size = new System.Drawing.Size(251, 150);
            this.txtClientAddress.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1439, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dirección de Cliente Seleccionado";
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
            this.dgvOrders.Size = new System.Drawing.Size(1724, 213);
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
            this.label13.Size = new System.Drawing.Size(128, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Pedidos Registrados";
            // 
            // pnlRegisterOrder
            // 
            this.pnlRegisterOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.pnlRegisterOrder.Controls.Add(this.lblEditingOrder);
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
            this.pnlRegisterOrder.Location = new System.Drawing.Point(8, 275);
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
            this.rBtnOrderEditMode.Enabled = false;
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
            this.rBtnOrderRegisterMode.Enabled = false;
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
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.btnDeleteOrder.Enabled = false;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteOrder.Location = new System.Drawing.Point(827, 266);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(155, 32);
            this.btnDeleteOrder.TabIndex = 36;
            this.btnDeleteOrder.Text = "Eliminar Pedido";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // lblEditingOrder
            // 
            this.lblEditingOrder.AutoSize = true;
            this.lblEditingOrder.ForeColor = System.Drawing.Color.Yellow;
            this.lblEditingOrder.Location = new System.Drawing.Point(521, 136);
            this.lblEditingOrder.Name = "lblEditingOrder";
            this.lblEditingOrder.Size = new System.Drawing.Size(35, 13);
            this.lblEditingOrder.TabIndex = 44;
            this.lblEditingOrder.Text = "label5";
            this.lblEditingOrder.Visible = false;
            // 
            // RegisterOrderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.lblDateFormat);
            this.Controls.Add(this.txtFilterOrders);
            this.Controls.Add(this.comboBoxFilterOrders);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvOrders);
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
            this.Size = new System.Drawing.Size(1744, 535);
            this.Load += new System.EventHandler(this.RegisterOrderPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.pnlRegisterOrder.ResumeLayout(false);
            this.pnlRegisterOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrepPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxPercentage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnOrderEditMode;
        private System.Windows.Forms.RadioButton rBtnOrderRegisterMode;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown numTaxPercentage;
        private System.Windows.Forms.NumericUpDown numPrepPrice;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ErrorProvider errorProviderOrderNotes;
        private System.Windows.Forms.ErrorProvider errorProviderOrderDate;
        private System.Windows.Forms.ErrorProvider errorProviderDeliveryDate;
        private System.Windows.Forms.TextBox txtFilterOrders;
        private System.Windows.Forms.ComboBox comboBoxFilterOrders;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblDateFormat;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Label lblEditingOrder;
    }
}
