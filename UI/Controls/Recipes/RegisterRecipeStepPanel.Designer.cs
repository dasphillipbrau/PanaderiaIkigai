
namespace PanaderiaIkigai.UI.Controls.Recipes
{
    partial class RegisterRecipeStepPanel
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
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.comboBoxSelectFilter = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSteps = new System.Windows.Forms.DataGridView();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIngredientName = new System.Windows.Forms.Label();
            this.dgvIngredients = new System.Windows.Forms.DataGridView();
            this.txtFilterIngredient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIngredientPercentage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProviderPercentage = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDeleteStep = new System.Windows.Forms.Button();
            this.txtIngredientName = new System.Windows.Forms.TextBox();
            this.txtPrepNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxOperationMode = new System.Windows.Forms.GroupBox();
            this.rBtnRegistration = new System.Windows.Forms.RadioButton();
            this.rBtnEdition = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPercentage)).BeginInit();
            this.groupBoxOperationMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(678, 19);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(165, 20);
            this.txtFilter.TabIndex = 29;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // comboBoxSelectFilter
            // 
            this.comboBoxSelectFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectFilter.FormattingEnabled = true;
            this.comboBoxSelectFilter.Location = new System.Drawing.Point(551, 16);
            this.comboBoxSelectFilter.Name = "comboBoxSelectFilter";
            this.comboBoxSelectFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectFilter.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(495, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Filtrar por";
            // 
            // dgvRecipes
            // 
            this.dgvRecipes.AllowUserToAddRows = false;
            this.dgvRecipes.AllowUserToDeleteRows = false;
            this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipes.Location = new System.Drawing.Point(27, 45);
            this.dgvRecipes.Name = "dgvRecipes";
            this.dgvRecipes.ReadOnly = true;
            this.dgvRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipes.Size = new System.Drawing.Size(816, 163);
            this.dgvRecipes.TabIndex = 25;
            this.dgvRecipes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecipes_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 22);
            this.label1.TabIndex = 26;
            this.label1.Text = "Panel de Pasos de Receta";
            // 
            // dgvSteps
            // 
            this.dgvSteps.AllowUserToAddRows = false;
            this.dgvSteps.AllowUserToDeleteRows = false;
            this.dgvSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSteps.Location = new System.Drawing.Point(27, 254);
            this.dgvSteps.Name = "dgvSteps";
            this.dgvSteps.ReadOnly = true;
            this.dgvSteps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSteps.Size = new System.Drawing.Size(797, 150);
            this.dgvSteps.TabIndex = 30;
            this.dgvSteps.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSteps_CellClick);
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(27, 438);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.ReadOnly = true;
            this.txtRecipeName.Size = new System.Drawing.Size(153, 20);
            this.txtRecipeName.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre de Receta";
            // 
            // lblIngredientName
            // 
            this.lblIngredientName.AutoSize = true;
            this.lblIngredientName.ForeColor = System.Drawing.Color.White;
            this.lblIngredientName.Location = new System.Drawing.Point(24, 476);
            this.lblIngredientName.Name = "lblIngredientName";
            this.lblIngredientName.Size = new System.Drawing.Size(115, 13);
            this.lblIngredientName.TabIndex = 33;
            this.lblIngredientName.Text = "Nombre de Ingrediente";
            // 
            // dgvIngredients
            // 
            this.dgvIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredients.Location = new System.Drawing.Point(830, 254);
            this.dgvIngredients.Name = "dgvIngredients";
            this.dgvIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngredients.Size = new System.Drawing.Size(346, 150);
            this.dgvIngredients.TabIndex = 35;
            this.dgvIngredients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredients_CellClick);
            // 
            // txtFilterIngredient
            // 
            this.txtFilterIngredient.Location = new System.Drawing.Point(923, 411);
            this.txtFilterIngredient.Name = "txtFilterIngredient";
            this.txtFilterIngredient.Size = new System.Drawing.Size(165, 20);
            this.txtFilterIngredient.TabIndex = 36;
            this.txtFilterIngredient.TextChanged += new System.EventHandler(this.txtFilterIngredient_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(827, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Filtrar por Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Pasos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(827, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ingredientes";
            // 
            // txtIngredientPercentage
            // 
            this.txtIngredientPercentage.Location = new System.Drawing.Point(249, 438);
            this.txtIngredientPercentage.Name = "txtIngredientPercentage";
            this.txtIngredientPercentage.ReadOnly = true;
            this.txtIngredientPercentage.Size = new System.Drawing.Size(153, 20);
            this.txtIngredientPercentage.TabIndex = 41;
            this.txtIngredientPercentage.Validating += new System.ComponentModel.CancelEventHandler(this.txtIngredientPercentage_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(246, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Proporción de Ingrediente";
            // 
            // errorProviderPercentage
            // 
            this.errorProviderPercentage.ContainerControl = this;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.Lime;
            this.btnSaveChanges.Location = new System.Drawing.Point(249, 493);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(153, 23);
            this.btnSaveChanges.TabIndex = 42;
            this.btnSaveChanges.Text = "Registrar Paso";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDeleteStep
            // 
            this.btnDeleteStep.BackColor = System.Drawing.Color.Red;
            this.btnDeleteStep.Enabled = false;
            this.btnDeleteStep.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteStep.Location = new System.Drawing.Point(746, 411);
            this.btnDeleteStep.Name = "btnDeleteStep";
            this.btnDeleteStep.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStep.TabIndex = 43;
            this.btnDeleteStep.Text = "Borrar Paso";
            this.btnDeleteStep.UseVisualStyleBackColor = false;
            this.btnDeleteStep.Click += new System.EventHandler(this.btnDeleteStep_Click);
            // 
            // txtIngredientName
            // 
            this.txtIngredientName.Location = new System.Drawing.Point(27, 493);
            this.txtIngredientName.Name = "txtIngredientName";
            this.txtIngredientName.ReadOnly = true;
            this.txtIngredientName.Size = new System.Drawing.Size(153, 20);
            this.txtIngredientName.TabIndex = 34;
            // 
            // txtPrepNotes
            // 
            this.txtPrepNotes.Location = new System.Drawing.Point(850, 45);
            this.txtPrepNotes.Multiline = true;
            this.txtPrepNotes.Name = "txtPrepNotes";
            this.txtPrepNotes.ReadOnly = true;
            this.txtPrepNotes.Size = new System.Drawing.Size(326, 163);
            this.txtPrepNotes.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(388, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Recetas";
            // 
            // groupBoxOperationMode
            // 
            this.groupBoxOperationMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.groupBoxOperationMode.Controls.Add(this.rBtnEdition);
            this.groupBoxOperationMode.Controls.Add(this.rBtnRegistration);
            this.groupBoxOperationMode.ForeColor = System.Drawing.Color.White;
            this.groupBoxOperationMode.Location = new System.Drawing.Point(427, 438);
            this.groupBoxOperationMode.Name = "groupBoxOperationMode";
            this.groupBoxOperationMode.Size = new System.Drawing.Size(148, 75);
            this.groupBoxOperationMode.TabIndex = 46;
            this.groupBoxOperationMode.TabStop = false;
            this.groupBoxOperationMode.Text = "Modo de Operación";
            // 
            // rBtnRegistration
            // 
            this.rBtnRegistration.AutoSize = true;
            this.rBtnRegistration.Checked = true;
            this.rBtnRegistration.Location = new System.Drawing.Point(7, 20);
            this.rBtnRegistration.Name = "rBtnRegistration";
            this.rBtnRegistration.Size = new System.Drawing.Size(109, 17);
            this.rBtnRegistration.TabIndex = 0;
            this.rBtnRegistration.TabStop = true;
            this.rBtnRegistration.Text = "Modo de Registro";
            this.rBtnRegistration.UseVisualStyleBackColor = true;
            this.rBtnRegistration.CheckedChanged += new System.EventHandler(this.rBtnRegistration_CheckedChanged);
            // 
            // rBtnEdition
            // 
            this.rBtnEdition.AutoSize = true;
            this.rBtnEdition.Location = new System.Drawing.Point(7, 43);
            this.rBtnEdition.Name = "rBtnEdition";
            this.rBtnEdition.Size = new System.Drawing.Size(105, 17);
            this.rBtnEdition.TabIndex = 1;
            this.rBtnEdition.Text = "Modo de Edición";
            this.rBtnEdition.UseVisualStyleBackColor = true;
            this.rBtnEdition.CheckedChanged += new System.EventHandler(this.rBtnEdition_CheckedChanged);
            // 
            // RegisterRecipeStepPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.groupBoxOperationMode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrepNotes);
            this.Controls.Add(this.btnDeleteStep);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.txtIngredientPercentage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilterIngredient);
            this.Controls.Add(this.dgvIngredients);
            this.Controls.Add(this.txtIngredientName);
            this.Controls.Add(this.lblIngredientName);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSteps);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.comboBoxSelectFilter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvRecipes);
            this.Controls.Add(this.label1);
            this.Name = "RegisterRecipeStepPanel";
            this.Size = new System.Drawing.Size(1179, 561);
            this.Load += new System.EventHandler(this.RegisterRecipeStepPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSteps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPercentage)).EndInit();
            this.groupBoxOperationMode.ResumeLayout(false);
            this.groupBoxOperationMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox comboBoxSelectFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSteps;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIngredientName;
        private System.Windows.Forms.DataGridView dgvIngredients;
        private System.Windows.Forms.TextBox txtFilterIngredient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIngredientPercentage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProviderPercentage;
        private System.Windows.Forms.Button btnDeleteStep;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtIngredientName;
        private System.Windows.Forms.TextBox txtPrepNotes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxOperationMode;
        private System.Windows.Forms.RadioButton rBtnEdition;
        private System.Windows.Forms.RadioButton rBtnRegistration;
    }
}
