
namespace PanaderiaIkigai.UI.Controls.BI
{
    partial class ProductsBiPanel
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
            this.pieTopProducts = new LiveCharts.WinForms.PieChart();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.btnRecalculatePlots = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.pieLowestProducts = new LiveCharts.WinForms.PieChart();
            this.lblLowest = new System.Windows.Forms.Label();
            this.productEvolution = new LiveCharts.WinForms.CartesianChart();
            this.label1 = new System.Windows.Forms.Label();
            this.pieChartCategories = new LiveCharts.WinForms.PieChart();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Datos de Recetas";
            // 
            // pieTopProducts
            // 
            this.pieTopProducts.Location = new System.Drawing.Point(17, 50);
            this.pieTopProducts.Name = "pieTopProducts";
            this.pieTopProducts.Size = new System.Drawing.Size(526, 262);
            this.pieTopProducts.TabIndex = 10;
            this.pieTopProducts.Text = "pieChart1";
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.AutoSize = true;
            this.lblTopTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTitle.ForeColor = System.Drawing.Color.White;
            this.lblTopTitle.Location = new System.Drawing.Point(14, 31);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(226, 16);
            this.lblTopTitle.TabIndex = 11;
            this.lblTopTitle.Text = "Top 10 Recetas Más Populares";
            // 
            // btnRecalculatePlots
            // 
            this.btnRecalculatePlots.Location = new System.Drawing.Point(468, 626);
            this.btnRecalculatePlots.Name = "btnRecalculatePlots";
            this.btnRecalculatePlots.Size = new System.Drawing.Size(75, 39);
            this.btnRecalculatePlots.TabIndex = 20;
            this.btnRecalculatePlots.Text = "Regenerar Gráficos";
            this.btnRecalculatePlots.UseVisualStyleBackColor = true;
            this.btnRecalculatePlots.Click += new System.EventHandler(this.btnRecalculatePlots_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(259, 626);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 626);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Desde";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(262, 645);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 17;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(17, 645);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 16;
            // 
            // pieLowestProducts
            // 
            this.pieLowestProducts.Location = new System.Drawing.Point(577, 64);
            this.pieLowestProducts.Name = "pieLowestProducts";
            this.pieLowestProducts.Size = new System.Drawing.Size(507, 248);
            this.pieLowestProducts.TabIndex = 22;
            this.pieLowestProducts.Text = "pieChart1";
            // 
            // lblLowest
            // 
            this.lblLowest.AutoSize = true;
            this.lblLowest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowest.ForeColor = System.Drawing.Color.White;
            this.lblLowest.Location = new System.Drawing.Point(574, 30);
            this.lblLowest.Name = "lblLowest";
            this.lblLowest.Size = new System.Drawing.Size(243, 16);
            this.lblLowest.TabIndex = 23;
            this.lblLowest.Text = "Top 10 Recetas Menos Populares";
            // 
            // productEvolution
            // 
            this.productEvolution.Location = new System.Drawing.Point(546, 375);
            this.productEvolution.Name = "productEvolution";
            this.productEvolution.Size = new System.Drawing.Size(573, 254);
            this.productEvolution.TabIndex = 24;
            this.productEvolution.Text = "cartesianChart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(543, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Evolución de las 10 Recetas más Populares";
            // 
            // pieChartCategories
            // 
            this.pieChartCategories.Location = new System.Drawing.Point(20, 375);
            this.pieChartCategories.Name = "pieChartCategories";
            this.pieChartCategories.Size = new System.Drawing.Size(520, 223);
            this.pieChartCategories.TabIndex = 26;
            this.pieChartCategories.Text = "pieChart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Categorías de Recetas más Populares";
            // 
            // ProductsBiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pieChartCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productEvolution);
            this.Controls.Add(this.lblLowest);
            this.Controls.Add(this.pieLowestProducts);
            this.Controls.Add(this.btnRecalculatePlots);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblTopTitle);
            this.Controls.Add(this.pieTopProducts);
            this.Controls.Add(this.label2);
            this.Name = "ProductsBiPanel";
            this.Size = new System.Drawing.Size(1122, 681);
            this.Load += new System.EventHandler(this.ProductsBiPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.PieChart pieTopProducts;
        private System.Windows.Forms.Label lblTopTitle;
        private System.Windows.Forms.Button btnRecalculatePlots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private LiveCharts.WinForms.PieChart pieLowestProducts;
        private System.Windows.Forms.Label lblLowest;
        private LiveCharts.WinForms.CartesianChart productEvolution;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.PieChart pieChartCategories;
        private System.Windows.Forms.Label label3;
    }
}
