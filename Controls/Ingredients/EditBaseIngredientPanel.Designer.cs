
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEditIngredientValidation = new System.Windows.Forms.Label();
            this.lblEditUnitTitle = new System.Windows.Forms.Label();
            this.btnDeleteUnit = new System.Windows.Forms.Button();
            this.btnEditUnit = new System.Windows.Forms.Button();
            this.txtEditUnit = new System.Windows.Forms.TextBox();
            this.comboBoxSelectUnit = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectBaseIngredient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaseIngredientQuery
            // 
            this.lblBaseIngredientQuery.AutoSize = true;
            this.lblBaseIngredientQuery.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseIngredientQuery.ForeColor = System.Drawing.Color.Beige;
            this.lblBaseIngredientQuery.Location = new System.Drawing.Point(190, 20);
            this.lblBaseIngredientQuery.Name = "lblBaseIngredientQuery";
            this.lblBaseIngredientQuery.Size = new System.Drawing.Size(302, 24);
            this.lblBaseIngredientQuery.TabIndex = 1;
            this.lblBaseIngredientQuery.Text = "Edición de Ingredientes base";
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
            this.panel1.Location = new System.Drawing.Point(17, 284);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 143);
            this.panel1.TabIndex = 2;
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
            // comboBoxSelectBaseIngredient
            // 
            this.comboBoxSelectBaseIngredient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectBaseIngredient.FormattingEnabled = true;
            this.comboBoxSelectBaseIngredient.Location = new System.Drawing.Point(17, 77);
            this.comboBoxSelectBaseIngredient.Name = "comboBoxSelectBaseIngredient";
            this.comboBoxSelectBaseIngredient.Size = new System.Drawing.Size(178, 21);
            this.comboBoxSelectBaseIngredient.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione un Ingrediente";
            // 
            // EditBaseIngredientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSelectBaseIngredient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBaseIngredientQuery);
            this.Name = "EditBaseIngredientPanel";
            this.Size = new System.Drawing.Size(707, 442);
            this.Load += new System.EventHandler(this.DisplayBaseIngredientPanel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBaseIngredientQuery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEditIngredientValidation;
        private System.Windows.Forms.Label lblEditUnitTitle;
        private System.Windows.Forms.Button btnDeleteUnit;
        private System.Windows.Forms.Button btnEditUnit;
        private System.Windows.Forms.TextBox txtEditUnit;
        private System.Windows.Forms.ComboBox comboBoxSelectUnit;
        private System.Windows.Forms.ComboBox comboBoxSelectBaseIngredient;
        private System.Windows.Forms.Label label1;
    }
}
