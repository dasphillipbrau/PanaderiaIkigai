
namespace PanaderiaIkigai.UI.Controls.Recipes
{
    partial class RegisterRecipePanel
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
            this.lblPanelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCategoryRegistration = new System.Windows.Forms.Panel();
            this.txtRegisterCategory = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.lblCategoryRegistrationValidation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRecipeAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnitsAvailable = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMainIngredientAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPreparationNotes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.btnSaveRecipe = new System.Windows.Forms.Button();
            this.errorProviderRecipeName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCategoryName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAuthor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUnitsAvailable = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderIngredientAmount = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBrowseImg = new System.Windows.Forms.Button();
            this.lblImgFound = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelCategoryRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRecipeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCategoryName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnitsAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIngredientAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPanelTitle
            // 
            this.lblPanelTitle.AutoSize = true;
            this.lblPanelTitle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelTitle.Location = new System.Drawing.Point(26, 20);
            this.lblPanelTitle.Name = "lblPanelTitle";
            this.lblPanelTitle.Size = new System.Drawing.Size(195, 22);
            this.lblPanelTitle.TabIndex = 0;
            this.lblPanelTitle.Text = "Registro de Recetas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.lblImgFound);
            this.panel1.Controls.Add(this.btnBrowseImg);
            this.panel1.Controls.Add(this.btnSaveRecipe);
            this.panel1.Controls.Add(this.comboBoxCategory);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPreparationNotes);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMainIngredientAmount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtUnitsAvailable);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtRecipeAuthor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtRecipeName);
            this.panel1.Location = new System.Drawing.Point(30, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 245);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro de Categorías";
            // 
            // panelCategoryRegistration
            // 
            this.panelCategoryRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.panelCategoryRegistration.Controls.Add(this.lblCategoryRegistrationValidation);
            this.panelCategoryRegistration.Controls.Add(this.btnSaveCategory);
            this.panelCategoryRegistration.Controls.Add(this.lblCategoryName);
            this.panelCategoryRegistration.Controls.Add(this.txtRegisterCategory);
            this.panelCategoryRegistration.Location = new System.Drawing.Point(30, 368);
            this.panelCategoryRegistration.Name = "panelCategoryRegistration";
            this.panelCategoryRegistration.Size = new System.Drawing.Size(1127, 157);
            this.panelCategoryRegistration.TabIndex = 2;
            // 
            // txtRegisterCategory
            // 
            this.txtRegisterCategory.Location = new System.Drawing.Point(19, 37);
            this.txtRegisterCategory.Name = "txtRegisterCategory";
            this.txtRegisterCategory.Size = new System.Drawing.Size(172, 20);
            this.txtRegisterCategory.TabIndex = 0;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(19, 18);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(109, 13);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Nombre de Categoría";
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.btnSaveCategory.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCategory.ForeColor = System.Drawing.Color.White;
            this.btnSaveCategory.Location = new System.Drawing.Point(19, 64);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(109, 55);
            this.btnSaveCategory.TabIndex = 2;
            this.btnSaveCategory.Text = "Guardar Categoría";
            this.btnSaveCategory.UseVisualStyleBackColor = false;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // lblCategoryRegistrationValidation
            // 
            this.lblCategoryRegistrationValidation.AutoSize = true;
            this.lblCategoryRegistrationValidation.ForeColor = System.Drawing.Color.Red;
            this.lblCategoryRegistrationValidation.Location = new System.Drawing.Point(197, 40);
            this.lblCategoryRegistrationValidation.Name = "lblCategoryRegistrationValidation";
            this.lblCategoryRegistrationValidation.Size = new System.Drawing.Size(114, 13);
            this.lblCategoryRegistrationValidation.TabIndex = 3;
            this.lblCategoryRegistrationValidation.Text = "Mensaje de Validación";
            this.lblCategoryRegistrationValidation.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de Receta";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(19, 31);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(172, 20);
            this.txtRecipeName.TabIndex = 4;
            this.txtRecipeName.Validating += new System.ComponentModel.CancelEventHandler(this.txtRecipeName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre de Categoría";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Autor de Receta";
            // 
            // txtRecipeAuthor
            // 
            this.txtRecipeAuthor.Location = new System.Drawing.Point(19, 148);
            this.txtRecipeAuthor.Name = "txtRecipeAuthor";
            this.txtRecipeAuthor.Size = new System.Drawing.Size(172, 20);
            this.txtRecipeAuthor.TabIndex = 8;
            this.txtRecipeAuthor.Validating += new System.ComponentModel.CancelEventHandler(this.txtRecipeAuthor_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Unidades Disponibles";
            // 
            // txtUnitsAvailable
            // 
            this.txtUnitsAvailable.Location = new System.Drawing.Point(256, 31);
            this.txtUnitsAvailable.Name = "txtUnitsAvailable";
            this.txtUnitsAvailable.Size = new System.Drawing.Size(172, 20);
            this.txtUnitsAvailable.TabIndex = 10;
            this.txtUnitsAvailable.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnitsAvailable_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cantidad de Ingrediente Principal";
            // 
            // txtMainIngredientAmount
            // 
            this.txtMainIngredientAmount.Location = new System.Drawing.Point(256, 88);
            this.txtMainIngredientAmount.Name = "txtMainIngredientAmount";
            this.txtMainIngredientAmount.Size = new System.Drawing.Size(172, 20);
            this.txtMainIngredientAmount.TabIndex = 12;
            this.txtMainIngredientAmount.Validating += new System.ComponentModel.CancelEventHandler(this.txtMainIngredientAmount_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Notas de Preparación";
            // 
            // txtPreparationNotes
            // 
            this.txtPreparationNotes.Location = new System.Drawing.Point(493, 31);
            this.txtPreparationNotes.Multiline = true;
            this.txtPreparationNotes.Name = "txtPreparationNotes";
            this.txtPreparationNotes.Size = new System.Drawing.Size(554, 187);
            this.txtPreparationNotes.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Imagen de Receta";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(19, 88);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(172, 21);
            this.comboBoxCategory.TabIndex = 17;
            this.comboBoxCategory.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxCategory_Validating);
            // 
            // btnSaveRecipe
            // 
            this.btnSaveRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.btnSaveRecipe.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRecipe.ForeColor = System.Drawing.Color.White;
            this.btnSaveRecipe.Location = new System.Drawing.Point(19, 187);
            this.btnSaveRecipe.Name = "btnSaveRecipe";
            this.btnSaveRecipe.Size = new System.Drawing.Size(109, 55);
            this.btnSaveRecipe.TabIndex = 4;
            this.btnSaveRecipe.Text = "Guardar Receta";
            this.btnSaveRecipe.UseVisualStyleBackColor = false;
            this.btnSaveRecipe.Click += new System.EventHandler(this.btnSaveRecipe_Click);
            // 
            // errorProviderRecipeName
            // 
            this.errorProviderRecipeName.ContainerControl = this;
            // 
            // errorProviderCategoryName
            // 
            this.errorProviderCategoryName.ContainerControl = this;
            // 
            // errorProviderAuthor
            // 
            this.errorProviderAuthor.ContainerControl = this;
            // 
            // errorProviderUnitsAvailable
            // 
            this.errorProviderUnitsAvailable.ContainerControl = this;
            // 
            // errorProviderIngredientAmount
            // 
            this.errorProviderIngredientAmount.ContainerControl = this;
            // 
            // btnBrowseImg
            // 
            this.btnBrowseImg.ForeColor = System.Drawing.Color.Black;
            this.btnBrowseImg.Location = new System.Drawing.Point(256, 146);
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.Size = new System.Drawing.Size(172, 23);
            this.btnBrowseImg.TabIndex = 18;
            this.btnBrowseImg.Text = "Buscar Imagen";
            this.btnBrowseImg.UseVisualStyleBackColor = true;
            this.btnBrowseImg.Click += new System.EventHandler(this.btnBrowseImg_Click);
            // 
            // lblImgFound
            // 
            this.lblImgFound.AutoSize = true;
            this.lblImgFound.ForeColor = System.Drawing.Color.Lime;
            this.lblImgFound.Location = new System.Drawing.Point(256, 176);
            this.lblImgFound.Name = "lblImgFound";
            this.lblImgFound.Size = new System.Drawing.Size(99, 13);
            this.lblImgFound.TabIndex = 19;
            this.lblImgFound.Text = "Imagen encontrada";
            this.lblImgFound.Visible = false;
            // 
            // RegisterRecipePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.panelCategoryRegistration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPanelTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RegisterRecipePanel";
            this.Size = new System.Drawing.Size(1179, 561);
            this.Load += new System.EventHandler(this.RegisterRecipePanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCategoryRegistration.ResumeLayout(false);
            this.panelCategoryRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRecipeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCategoryName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUnitsAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderIngredientAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPanelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrowseImg;
        private System.Windows.Forms.Button btnSaveRecipe;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPreparationNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMainIngredientAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnitsAvailable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRecipeAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelCategoryRegistration;
        private System.Windows.Forms.Label lblCategoryRegistrationValidation;
        private System.Windows.Forms.Button btnSaveCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtRegisterCategory;
        private System.Windows.Forms.ErrorProvider errorProviderRecipeName;
        private System.Windows.Forms.ErrorProvider errorProviderCategoryName;
        private System.Windows.Forms.ErrorProvider errorProviderAuthor;
        private System.Windows.Forms.ErrorProvider errorProviderUnitsAvailable;
        private System.Windows.Forms.ErrorProvider errorProviderIngredientAmount;
        private System.Windows.Forms.Label lblImgFound;
    }
}
