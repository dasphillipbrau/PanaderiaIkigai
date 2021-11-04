
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnProductsPurchased = new System.Windows.Forms.RadioButton();
            this.rBtnAmountInvested = new System.Windows.Forms.RadioButton();
            this.btnRecalculatePlots = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.pieLowestProducts = new LiveCharts.WinForms.PieChart();
            this.lblLowest = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
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
            this.pieTopProducts.Location = new System.Drawing.Point(17, 94);
            this.pieTopProducts.Name = "pieTopProducts";
            this.pieTopProducts.Size = new System.Drawing.Size(366, 185);
            this.pieTopProducts.TabIndex = 10;
            this.pieTopProducts.Text = "pieChart1";
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.AutoSize = true;
            this.lblTopTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTitle.ForeColor = System.Drawing.Color.White;
            this.lblTopTitle.Location = new System.Drawing.Point(14, 64);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(238, 16);
            this.lblTopTitle.TabIndex = 11;
            this.lblTopTitle.Text = "Top 10 Productos Más Populares";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnProductsPurchased);
            this.groupBox1.Controls.Add(this.rBtnAmountInvested);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(468, 565);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 100);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterio";
            // 
            // rBtnProductsPurchased
            // 
            this.rBtnProductsPurchased.AutoSize = true;
            this.rBtnProductsPurchased.Location = new System.Drawing.Point(7, 61);
            this.rBtnProductsPurchased.Name = "rBtnProductsPurchased";
            this.rBtnProductsPurchased.Size = new System.Drawing.Size(129, 17);
            this.rBtnProductsPurchased.TabIndex = 1;
            this.rBtnProductsPurchased.Text = "Productos Comprados";
            this.rBtnProductsPurchased.UseVisualStyleBackColor = true;
            // 
            // rBtnAmountInvested
            // 
            this.rBtnAmountInvested.AutoSize = true;
            this.rBtnAmountInvested.Checked = true;
            this.rBtnAmountInvested.Location = new System.Drawing.Point(7, 20);
            this.rBtnAmountInvested.Name = "rBtnAmountInvested";
            this.rBtnAmountInvested.Size = new System.Drawing.Size(99, 17);
            this.rBtnAmountInvested.TabIndex = 0;
            this.rBtnAmountInvested.TabStop = true;
            this.rBtnAmountInvested.Text = "Monto Invertido";
            this.rBtnAmountInvested.UseVisualStyleBackColor = true;
            // 
            // btnRecalculatePlots
            // 
            this.btnRecalculatePlots.Location = new System.Drawing.Point(624, 626);
            this.btnRecalculatePlots.Name = "btnRecalculatePlots";
            this.btnRecalculatePlots.Size = new System.Drawing.Size(75, 39);
            this.btnRecalculatePlots.TabIndex = 20;
            this.btnRecalculatePlots.Text = "Regenerar Gráficos";
            this.btnRecalculatePlots.UseVisualStyleBackColor = true;
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
            this.pieLowestProducts.Location = new System.Drawing.Point(575, 94);
            this.pieLowestProducts.Name = "pieLowestProducts";
            this.pieLowestProducts.Size = new System.Drawing.Size(366, 185);
            this.pieLowestProducts.TabIndex = 22;
            this.pieLowestProducts.Text = "pieChart1";
            // 
            // lblLowest
            // 
            this.lblLowest.AutoSize = true;
            this.lblLowest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowest.ForeColor = System.Drawing.Color.White;
            this.lblLowest.Location = new System.Drawing.Point(621, 64);
            this.lblLowest.Name = "lblLowest";
            this.lblLowest.Size = new System.Drawing.Size(255, 16);
            this.lblLowest.TabIndex = 23;
            this.lblLowest.Text = "Top 10 Productos Menos Populares";
            // 
            // ProductsBiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.lblLowest);
            this.Controls.Add(this.pieLowestProducts);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.PieChart pieTopProducts;
        private System.Windows.Forms.Label lblTopTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnProductsPurchased;
        private System.Windows.Forms.RadioButton rBtnAmountInvested;
        private System.Windows.Forms.Button btnRecalculatePlots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private LiveCharts.WinForms.PieChart pieLowestProducts;
        private System.Windows.Forms.Label lblLowest;
    }
}
