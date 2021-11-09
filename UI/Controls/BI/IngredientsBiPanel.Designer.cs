
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
            this.pieChartTopIngredient = new LiveCharts.WinForms.PieChart();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pieChartLowestIngredient = new LiveCharts.WinForms.PieChart();
            this.chartCurrentInvestment = new LiveCharts.WinForms.CartesianChart();
            this.label3 = new System.Windows.Forms.Label();
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
            // pieChartTopIngredient
            // 
            this.pieChartTopIngredient.Location = new System.Drawing.Point(7, 68);
            this.pieChartTopIngredient.Name = "pieChartTopIngredient";
            this.pieChartTopIngredient.Size = new System.Drawing.Size(368, 190);
            this.pieChartTopIngredient.TabIndex = 11;
            this.pieChartTopIngredient.Text = "pieChart1";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(555, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Top 10 Ingredientes menos Usados";
            // 
            // pieChartLowestIngredient
            // 
            this.pieChartLowestIngredient.Location = new System.Drawing.Point(558, 68);
            this.pieChartLowestIngredient.Name = "pieChartLowestIngredient";
            this.pieChartLowestIngredient.Size = new System.Drawing.Size(368, 190);
            this.pieChartLowestIngredient.TabIndex = 13;
            this.pieChartLowestIngredient.Text = "pieChart1";
            // 
            // chartCurrentInvestment
            // 
            this.chartCurrentInvestment.Location = new System.Drawing.Point(7, 333);
            this.chartCurrentInvestment.Name = "chartCurrentInvestment";
            this.chartCurrentInvestment.Size = new System.Drawing.Size(824, 240);
            this.chartCurrentInvestment.TabIndex = 15;
            this.chartCurrentInvestment.Text = "cartesianChart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(467, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Inversión Promedio Actual para los 10 ingredientes más populares";
            // 
            // IngredientsBiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartCurrentInvestment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pieChartLowestIngredient);
            this.Controls.Add(this.lblTopTitle);
            this.Controls.Add(this.pieChartTopIngredient);
            this.Controls.Add(this.label2);
            this.Name = "IngredientsBiPanel";
            this.Size = new System.Drawing.Size(1122, 681);
            this.Load += new System.EventHandler(this.IngredientsBiPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.PieChart pieChartTopIngredient;
        private System.Windows.Forms.Label lblTopTitle;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.PieChart pieChartLowestIngredient;
        private LiveCharts.WinForms.CartesianChart chartCurrentInvestment;
        private System.Windows.Forms.Label label3;
    }
}
