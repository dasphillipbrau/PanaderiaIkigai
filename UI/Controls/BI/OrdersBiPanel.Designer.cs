
namespace PanaderiaIkigai.UI.Controls.BI
{
    partial class OrdersBiPanel
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
            this.chartOrdersByMonth = new LiveCharts.WinForms.CartesianChart();
            this.btnRecalculatePlots = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.pieStatus = new LiveCharts.WinForms.PieChart();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartRevenueByStatus = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Datos de Pedidos";
            // 
            // chartOrdersByMonth
            // 
            this.chartOrdersByMonth.Location = new System.Drawing.Point(7, 56);
            this.chartOrdersByMonth.Name = "chartOrdersByMonth";
            this.chartOrdersByMonth.Size = new System.Drawing.Size(1089, 244);
            this.chartOrdersByMonth.TabIndex = 12;
            this.chartOrdersByMonth.Text = "chartOrdersByMonth";
            // 
            // btnRecalculatePlots
            // 
            this.btnRecalculatePlots.Location = new System.Drawing.Point(458, 628);
            this.btnRecalculatePlots.Name = "btnRecalculatePlots";
            this.btnRecalculatePlots.Size = new System.Drawing.Size(75, 39);
            this.btnRecalculatePlots.TabIndex = 25;
            this.btnRecalculatePlots.Text = "Regenerar Gráficos";
            this.btnRecalculatePlots.UseVisualStyleBackColor = true;
            this.btnRecalculatePlots.Click += new System.EventHandler(this.btnRecalculatePlots_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(249, 628);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 628);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Desde";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(252, 647);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 22;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(7, 647);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 21;
            // 
            // pieStatus
            // 
            this.pieStatus.Location = new System.Drawing.Point(584, 387);
            this.pieStatus.Name = "pieStatus";
            this.pieStatus.Size = new System.Drawing.Size(512, 280);
            this.pieStatus.TabIndex = 26;
            this.pieStatus.Text = "pieChart1";
            // 
            // lblTopTitle
            // 
            this.lblTopTitle.AutoSize = true;
            this.lblTopTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopTitle.ForeColor = System.Drawing.Color.White;
            this.lblTopTitle.Location = new System.Drawing.Point(7, 37);
            this.lblTopTitle.Name = "lblTopTitle";
            this.lblTopTitle.Size = new System.Drawing.Size(294, 16);
            this.lblTopTitle.TabIndex = 27;
            this.lblTopTitle.Text = "Pedidos por mes en el año Seleccionado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(581, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Distribución de Estados de Pedidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(7, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Monto Facturado por Estado de Pedido";
            // 
            // chartRevenueByStatus
            // 
            this.chartRevenueByStatus.Location = new System.Drawing.Point(10, 368);
            this.chartRevenueByStatus.Name = "chartRevenueByStatus";
            this.chartRevenueByStatus.Size = new System.Drawing.Size(474, 240);
            this.chartRevenueByStatus.TabIndex = 29;
            this.chartRevenueByStatus.Text = "chartsRevenueByStatus";
            // 
            // OrdersBiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartRevenueByStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTopTitle);
            this.Controls.Add(this.pieStatus);
            this.Controls.Add(this.btnRecalculatePlots);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.chartOrdersByMonth);
            this.Controls.Add(this.label2);
            this.Name = "OrdersBiPanel";
            this.Size = new System.Drawing.Size(1122, 681);
            this.Load += new System.EventHandler(this.OrdersBiPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.CartesianChart chartOrdersByMonth;
        private System.Windows.Forms.Button btnRecalculatePlots;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private LiveCharts.WinForms.PieChart pieStatus;
        private System.Windows.Forms.Label lblTopTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private LiveCharts.WinForms.CartesianChart chartRevenueByStatus;
    }
}
