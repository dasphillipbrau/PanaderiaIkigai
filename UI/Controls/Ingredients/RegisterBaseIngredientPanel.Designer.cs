
namespace PanaderiaIkigai.Controls
{
    partial class BaseIngredientPanel
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
            this.lblIngredientRegistration = new System.Windows.Forms.Label();
            this.lblIngredientName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMeasuringUnit = new System.Windows.Forms.Label();
            this.btnRegisterBaseIngredient = new System.Windows.Forms.Button();
            this.lblBaseIngredientNameValidation = new System.Windows.Forms.Label();
            this.lblBaseIngredientUnitValidation = new System.Windows.Forms.Label();
            this.lblUnitName = new System.Windows.Forms.Label();
            this.lblMeasuringUnitTitle = new System.Windows.Forms.Label();
            this.txtUnitName = new System.Windows.Forms.TextBox();
            this.btnRegisterUnit = new System.Windows.Forms.Button();
            this.comboBoxUnits = new System.Windows.Forms.ComboBox();
            this.lblUnitRegisterValidation = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngredientRegistration
            // 
            this.lblIngredientRegistration.AutoSize = true;
            this.lblIngredientRegistration.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientRegistration.ForeColor = System.Drawing.Color.White;
            this.lblIngredientRegistration.Location = new System.Drawing.Point(42, 24);
            this.lblIngredientRegistration.Name = "lblIngredientRegistration";
            this.lblIngredientRegistration.Size = new System.Drawing.Size(314, 24);
            this.lblIngredientRegistration.TabIndex = 0;
            this.lblIngredientRegistration.Text = "Registro de Ingredientes Base";
            // 
            // lblIngredientName
            // 
            this.lblIngredientName.AutoSize = true;
            this.lblIngredientName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.lblIngredientName.ForeColor = System.Drawing.Color.Beige;
            this.lblIngredientName.Location = new System.Drawing.Point(40, 74);
            this.lblIngredientName.Name = "lblIngredientName";
            this.lblIngredientName.Size = new System.Drawing.Size(115, 13);
            this.lblIngredientName.TabIndex = 1;
            this.lblIngredientName.Text = "Nombre de Ingrediente";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(41, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblMeasuringUnit
            // 
            this.lblMeasuringUnit.AutoSize = true;
            this.lblMeasuringUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.lblMeasuringUnit.ForeColor = System.Drawing.Color.Beige;
            this.lblMeasuringUnit.Location = new System.Drawing.Point(40, 127);
            this.lblMeasuringUnit.Name = "lblMeasuringUnit";
            this.lblMeasuringUnit.Size = new System.Drawing.Size(94, 13);
            this.lblMeasuringUnit.TabIndex = 3;
            this.lblMeasuringUnit.Text = "Unidad de Medida";
            // 
            // btnRegisterBaseIngredient
            // 
            this.btnRegisterBaseIngredient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.btnRegisterBaseIngredient.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterBaseIngredient.ForeColor = System.Drawing.Color.White;
            this.btnRegisterBaseIngredient.Location = new System.Drawing.Point(8, 124);
            this.btnRegisterBaseIngredient.Name = "btnRegisterBaseIngredient";
            this.btnRegisterBaseIngredient.Size = new System.Drawing.Size(154, 51);
            this.btnRegisterBaseIngredient.TabIndex = 5;
            this.btnRegisterBaseIngredient.Text = "Registrar Ingrediente Base";
            this.btnRegisterBaseIngredient.UseVisualStyleBackColor = false;
            this.btnRegisterBaseIngredient.Click += new System.EventHandler(this.btnRegisterBaseIngredient_Click);
            // 
            // lblBaseIngredientNameValidation
            // 
            this.lblBaseIngredientNameValidation.AutoSize = true;
            this.lblBaseIngredientNameValidation.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseIngredientNameValidation.ForeColor = System.Drawing.Color.Red;
            this.lblBaseIngredientNameValidation.Location = new System.Drawing.Point(233, 90);
            this.lblBaseIngredientNameValidation.Name = "lblBaseIngredientNameValidation";
            this.lblBaseIngredientNameValidation.Size = new System.Drawing.Size(0, 13);
            this.lblBaseIngredientNameValidation.TabIndex = 6;
            this.lblBaseIngredientNameValidation.Visible = false;
            // 
            // lblBaseIngredientUnitValidation
            // 
            this.lblBaseIngredientUnitValidation.AutoSize = true;
            this.lblBaseIngredientUnitValidation.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseIngredientUnitValidation.ForeColor = System.Drawing.Color.Red;
            this.lblBaseIngredientUnitValidation.Location = new System.Drawing.Point(233, 144);
            this.lblBaseIngredientUnitValidation.Name = "lblBaseIngredientUnitValidation";
            this.lblBaseIngredientUnitValidation.Size = new System.Drawing.Size(0, 13);
            this.lblBaseIngredientUnitValidation.TabIndex = 7;
            this.lblBaseIngredientUnitValidation.UseMnemonic = false;
            this.lblBaseIngredientUnitValidation.Visible = false;
            // 
            // lblUnitName
            // 
            this.lblUnitName.AutoSize = true;
            this.lblUnitName.ForeColor = System.Drawing.Color.Beige;
            this.lblUnitName.Location = new System.Drawing.Point(2, 28);
            this.lblUnitName.Name = "lblUnitName";
            this.lblUnitName.Size = new System.Drawing.Size(160, 13);
            this.lblUnitName.TabIndex = 8;
            this.lblUnitName.Text = "Nombre de la Unidad de Medida";
            // 
            // lblMeasuringUnitTitle
            // 
            this.lblMeasuringUnitTitle.AutoSize = true;
            this.lblMeasuringUnitTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeasuringUnitTitle.ForeColor = System.Drawing.Color.White;
            this.lblMeasuringUnitTitle.Location = new System.Drawing.Point(42, 318);
            this.lblMeasuringUnitTitle.Name = "lblMeasuringUnitTitle";
            this.lblMeasuringUnitTitle.Size = new System.Drawing.Size(335, 24);
            this.lblMeasuringUnitTitle.TabIndex = 9;
            this.lblMeasuringUnitTitle.Text = "Registro de Unidades de Medida";
            // 
            // txtUnitName
            // 
            this.txtUnitName.Location = new System.Drawing.Point(5, 54);
            this.txtUnitName.Name = "txtUnitName";
            this.txtUnitName.Size = new System.Drawing.Size(188, 20);
            this.txtUnitName.TabIndex = 10;
            // 
            // btnRegisterUnit
            // 
            this.btnRegisterUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.btnRegisterUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUnit.ForeColor = System.Drawing.Color.White;
            this.btnRegisterUnit.Location = new System.Drawing.Point(20, 89);
            this.btnRegisterUnit.Name = "btnRegisterUnit";
            this.btnRegisterUnit.Size = new System.Drawing.Size(142, 51);
            this.btnRegisterUnit.TabIndex = 11;
            this.btnRegisterUnit.Text = "Registrar Unidad";
            this.btnRegisterUnit.UseVisualStyleBackColor = false;
            this.btnRegisterUnit.Click += new System.EventHandler(this.btnRegisterUnit_Click);
            // 
            // comboBoxUnits
            // 
            this.comboBoxUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnits.FormattingEnabled = true;
            this.comboBoxUnits.Location = new System.Drawing.Point(41, 156);
            this.comboBoxUnits.Name = "comboBoxUnits";
            this.comboBoxUnits.Size = new System.Drawing.Size(185, 21);
            this.comboBoxUnits.TabIndex = 12;
            // 
            // lblUnitRegisterValidation
            // 
            this.lblUnitRegisterValidation.AutoSize = true;
            this.lblUnitRegisterValidation.ForeColor = System.Drawing.Color.Red;
            this.lblUnitRegisterValidation.Location = new System.Drawing.Point(203, 54);
            this.lblUnitRegisterValidation.Name = "lblUnitRegisterValidation";
            this.lblUnitRegisterValidation.Size = new System.Drawing.Size(0, 13);
            this.lblUnitRegisterValidation.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.panel2.Controls.Add(this.lblUnitRegisterValidation);
            this.panel2.Controls.Add(this.txtUnitName);
            this.panel2.Controls.Add(this.btnRegisterUnit);
            this.panel2.Controls.Add(this.lblUnitName);
            this.panel2.Location = new System.Drawing.Point(38, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(974, 143);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(147)))));
            this.panel3.Controls.Add(this.btnRegisterBaseIngredient);
            this.panel3.Location = new System.Drawing.Point(38, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(974, 178);
            this.panel3.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(565, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 22;
            this.label1.UseMnemonic = false;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(565, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 21;
            this.label2.Visible = false;
            // 
            // BaseIngredientPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxUnits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMeasuringUnitTitle);
            this.Controls.Add(this.lblBaseIngredientUnitValidation);
            this.Controls.Add(this.lblBaseIngredientNameValidation);
            this.Controls.Add(this.lblMeasuringUnit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblIngredientName);
            this.Controls.Add(this.lblIngredientRegistration);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "BaseIngredientPanel";
            this.Size = new System.Drawing.Size(1028, 560);
            this.Load += new System.EventHandler(this.BaseIngredientPanel_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngredientRegistration;
        private System.Windows.Forms.Label lblIngredientName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMeasuringUnit;
        private System.Windows.Forms.Button btnRegisterBaseIngredient;
        private System.Windows.Forms.Label lblBaseIngredientNameValidation;
        private System.Windows.Forms.Label lblBaseIngredientUnitValidation;
        private System.Windows.Forms.Label lblUnitName;
        private System.Windows.Forms.Label lblMeasuringUnitTitle;
        private System.Windows.Forms.TextBox txtUnitName;
        private System.Windows.Forms.Button btnRegisterUnit;
        private System.Windows.Forms.ComboBox comboBoxUnits;
        private System.Windows.Forms.Label lblUnitRegisterValidation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
