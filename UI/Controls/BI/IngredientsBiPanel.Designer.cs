
namespace PanaderiaIkigai.UI.Controls.BI
{
    partial class IngredientsBiPanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.pieChartTopProduct = new LiveCharts.WinForms.PieChart();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Datos de Ingredientes";
            // 
            // pieChartTopProduct
            // 
            this.pieChartTopProduct.Location = new System.Drawing.Point(7, 68);
            this.pieChartTopProduct.Name = "pieChartTopProduct";
            this.pieChartTopProduct.Size = new System.Drawing.Size(368, 190);
            this.pieChartTopProduct.TabIndex = 11;
            this.pieChartTopProduct.Text = "pieChart1";
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.AutoSize = true;
            this.lblTopTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTitle.ForeColor = System.Drawing.Color.White;
            this.lblTopTitle.Location = new System.Drawing.Point(4, 49);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(237, 16);
            this.lblTopTitle.TabIndex = 12;
            this.lblTopTitle.Text = "Top 10 Ingredientes más Usados";
            // 
            // IngredientsBiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.lblTopTitle);
            this.Controls.Add(this.pieChartTopProduct);
            this.Controls.Add(this.label2);
            this.Name = "IngredientsBiPanel";
            this.Size = new System.Drawing.Size(1122, 681);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.PieChart pieChartTopProduct;
        private System.Windows.Forms.Label lblTopTitle;
    }
}
