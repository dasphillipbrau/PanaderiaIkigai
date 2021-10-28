
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
            this.components = new System.ComponentModel.Container();
            this.dgvRecipes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxRecipeImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnitsAvailable = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEditRecipeCategory = new System.Windows.Forms.ComboBox();
            this.txtIngredientAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnDeleteImage = new System.Windows.Forms.Button();
            this.txtPrepNotes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblImgFound = new System.Windows.Forms.Label();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCategoryName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAuthorName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUnitsAvailable = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIngredientAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.lblIngredientImage = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSelectFilter = new System.Windows.Forms.ComboBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnSaveCategoryChanges = new System.Windows.Forms.Button();
            this.lblCategoryValidation = new System.Windows.Forms.Label();
            this.txtNewNameForCategory = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxCurrentCategories = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAuthorName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnitsAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIngredientAmount)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(379, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultar y Editar Recetas o Categorías";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre de Receta";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(37, 349);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(153, 20);
            this.txtName.TabIndex = 4;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de Categoría";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(37, 448);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.ReadOnly = true;
            this.txtAuthorName.Size = new System.Drawing.Size(153, 20);
            this.txtAuthorName.TabIndex = 8;
            this.txtAuthorName.Validating += new System.ComponentModel.CancelEventHandler(this.txtAuthorName_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre de Autor";
            // 
            // txtUnitsAvailable
            // 
            this.txtUnitsAvailable.Location = new System.Drawing.Point(37, 500);
            this.txtUnitsAvailable.Name = "txtUnitsAvailable";
            this.txtUnitsAvailable.ReadOnly = true;
            this.txtUnitsAvailable.Size = new System.Drawing.Size(153, 20);
            this.txtUnitsAvailable.TabIndex = 10;
            this.txtUnitsAvailable.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnitsAvailable_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Unidades Disponibles";
            // 
            // comboBoxEditRecipeCategory
            // 
            this.comboBoxEditRecipeCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEditRecipeCategory.Enabled = false;
            this.comboBoxEditRecipeCategory.FormattingEnabled = true;
            this.comboBoxEditRecipeCategory.Location = new System.Drawing.Point(37, 399);
            this.comboBoxEditRecipeCategory.Name = "comboBoxEditRecipeCategory";
            this.comboBoxEditRecipeCategory.Size = new System.Drawing.Size(153, 21);
            this.comboBoxEditRecipeCategory.TabIndex = 11;
            this.comboBoxEditRecipeCategory.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxEditRecipeCategory_Validating);
            // 
            // txtIngredientAmount
            // 
            this.txtIngredientAmount.Location = new System.Drawing.Point(261, 349);
            this.txtIngredientAmount.Name = "txtIngredientAmount";
            this.txtIngredientAmount.ReadOnly = true;
            this.txtIngredientAmount.Size = new System.Drawing.Size(160, 20);
            this.txtIngredientAmount.TabIndex = 13;
            this.txtIngredientAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtIngredientAmount_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(258, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad de Ingrediente Principal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(258, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Imagen";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Enabled = false;
            this.btnBrowseImage.Location = new System.Drawing.Point(261, 396);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(160, 23);
            this.btnBrowseImage.TabIndex = 15;
            this.btnBrowseImage.Text = "Buscar Imagen";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.BackColor = System.Drawing.Color.Red;
            this.btnDeleteImage.Enabled = false;
            this.btnDeleteImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteImage.ForeColor = System.Drawing.Color.White;
            this.btnDeleteImage.Location = new System.Drawing.Point(884, 286);
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(160, 23);
            this.btnDeleteImage.TabIndex = 16;
            this.btnDeleteImage.Text = "Borrar Imagen";
            this.btnDeleteImage.UseVisualStyleBackColor = false;
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // txtPrepNotes
            // 
            this.txtPrepNotes.Location = new System.Drawing.Point(464, 349);
            this.txtPrepNotes.Multiline = true;
            this.txtPrepNotes.Name = "txtPrepNotes";
            this.txtPrepNotes.ReadOnly = true;
            this.txtPrepNotes.Size = new System.Drawing.Size(413, 171);
            this.txtPrepNotes.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(461, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Notas de Preparación";
            // 
            // lblImgFound
            // 
            this.lblImgFound.AutoSize = true;
            this.lblImgFound.ForeColor = System.Drawing.Color.Lime;
            this.lblImgFound.Location = new System.Drawing.Point(261, 426);
            this.lblImgFound.Name = "lblImgFound";
            this.lblImgFound.Size = new System.Drawing.Size(100, 13);
            this.lblImgFound.TabIndex = 19;
            this.lblImgFound.Text = "Imagen Encontrada";
            this.lblImgFound.Visible = false;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderCategoryName
            // 
            this.errorProviderCategoryName.ContainerControl = this;
            // 
            // errorProviderAuthorName
            // 
            this.errorProviderAuthorName.ContainerControl = this;
            // 
            // errorProviderUnitsAvailable
            // 
            this.errorProviderUnitsAvailable.ContainerControl = this;
            // 
            // errorProviderIngredientAmount
            // 
            this.errorProviderIngredientAmount.ContainerControl = this;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Location = new System.Drawing.Point(261, 497);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(160, 23);
            this.btnSaveChanges.TabIndex = 20;
            this.btnSaveChanges.Text = "Guardar Cambios";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblIngredientImage
            // 
            this.lblIngredientImage.AutoSize = true;
            this.lblIngredientImage.ForeColor = System.Drawing.Color.White;
            this.lblIngredientImage.Location = new System.Drawing.Point(881, 24);
            this.lblIngredientImage.Name = "lblIngredientImage";
            this.lblIngredientImage.Size = new System.Drawing.Size(113, 13);
            this.lblIngredientImage.TabIndex = 21;
            this.lblIngredientImage.Text = "Imagen de Ingrediente";
            this.lblIngredientImage.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(502, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Filtrar por";
            // 
            // comboBoxSelectFilter
            // 
            this.comboBoxSelectFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectFilter.FormattingEnabled = true;
            this.comboBoxSelectFilter.Location = new System.Drawing.Point(558, 21);
            this.comboBoxSelectFilter.Name = "comboBoxSelectFilter";
            this.comboBoxSelectFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectFilter.TabIndex = 23;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(685, 24);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(165, 20);
            this.txtFilter.TabIndex = 24;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.btnDeleteCategory);
            this.panel1.Controls.Add(this.btnSaveCategoryChanges);
            this.panel1.Controls.Add(this.lblCategoryValidation);
            this.panel1.Controls.Add(this.txtNewNameForCategory);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.comboBoxCurrentCategories);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(884, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 171);
            this.panel1.TabIndex = 25;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(218, 120);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(71, 41);
            this.btnDeleteCategory.TabIndex = 29;
            this.btnDeleteCategory.Text = "Eliminar Categoría";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnSaveCategoryChanges
            // 
            this.btnSaveCategoryChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveCategoryChanges.Location = new System.Drawing.Point(218, 73);
            this.btnSaveCategoryChanges.Name = "btnSaveCategoryChanges";
            this.btnSaveCategoryChanges.Size = new System.Drawing.Size(71, 41);
            this.btnSaveCategoryChanges.TabIndex = 28;
            this.btnSaveCategoryChanges.Text = "Guardar Cambios";
            this.btnSaveCategoryChanges.UseVisualStyleBackColor = false;
            this.btnSaveCategoryChanges.Click += new System.EventHandler(this.btnSaveCategoryChanges_Click);
            // 
            // lblCategoryValidation
            // 
            this.lblCategoryValidation.AutoSize = true;
            this.lblCategoryValidation.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryValidation.Location = new System.Drawing.Point(10, 134);
            this.lblCategoryValidation.Name = "lblCategoryValidation";
            this.lblCategoryValidation.Size = new System.Drawing.Size(100, 13);
            this.lblCategoryValidation.TabIndex = 26;
            this.lblCategoryValidation.Text = "Imagen Encontrada";
            this.lblCategoryValidation.Visible = false;
            // 
            // txtNewNameForCategory
            // 
            this.txtNewNameForCategory.Location = new System.Drawing.Point(6, 99);
            this.txtNewNameForCategory.Name = "txtNewNameForCategory";
            this.txtNewNameForCategory.Size = new System.Drawing.Size(145, 20);
            this.txtNewNameForCategory.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Editar nombre de Categoría";
            // 
            // comboBoxCurrentCategories
            // 
            this.comboBoxCurrentCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCurrentCategories.FormattingEnabled = true;
            this.comboBoxCurrentCategories.Location = new System.Drawing.Point(6, 47);
            this.comboBoxCurrentCategories.Name = "comboBoxCurrentCategories";
            this.comboBoxCurrentCategories.Size = new System.Drawing.Size(145, 21);
            this.comboBoxCurrentCategories.TabIndex = 27;
            this.comboBoxCurrentCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCurrentCategories_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Edición de Categorías";
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.BackColor = System.Drawing.Color.Red;
            this.btnDeleteRecipe.Enabled = false;
            this.btnDeleteRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecipe.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRecipe.Location = new System.Drawing.Point(717, 286);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(160, 23);
            this.btnDeleteRecipe.TabIndex = 26;
            this.btnDeleteRecipe.Text = "Borrar Receta";
            this.btnDeleteRecipe.UseVisualStyleBackColor = false;
            this.btnDeleteRecipe.Click += new System.EventHandler(this.btnDeleteRecipe_Click);
            // 
            // EditRecipePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.comboBoxSelectFilter);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblIngredientImage);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.lblImgFound);
            this.Controls.Add(this.txtPrepNotes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeleteImage);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtIngredientAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxEditRecipeCategory);
            this.Controls.Add(this.txtUnitsAvailable);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxRecipeImage);
            this.Controls.Add(this.dgvRecipes);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "EditRecipePanel";
            this.Size = new System.Drawing.Size(1179, 561);
            this.Load += new System.EventHandler(this.EditRecipePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRecipeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAuthorName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnitsAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIngredientAmount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecipes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxRecipeImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitsAvailable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxEditRecipeCategory;
        private System.Windows.Forms.TextBox txtIngredientAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnDeleteImage;
        private System.Windows.Forms.TextBox txtPrepNotes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblImgFound;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.Label lblIngredientImage;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ErrorProvider errorProviderCategoryName;
        private System.Windows.Forms.ErrorProvider errorProviderAuthorName;
        private System.Windows.Forms.ErrorProvider errorProviderUnitsAvailable;
        private System.Windows.Forms.ErrorProvider errorProviderIngredientAmount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox comboBoxSelectFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnSaveCategoryChanges;
        private System.Windows.Forms.Label lblCategoryValidation;
        private System.Windows.Forms.TextBox txtNewNameForCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxCurrentCategories;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDeleteRecipe;
    }
}
