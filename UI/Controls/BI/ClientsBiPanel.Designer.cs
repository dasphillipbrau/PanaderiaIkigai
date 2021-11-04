
namespace PanaderiaIkigai.UI.Controls.BI
{
    partial class ClientsBiPanel
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartTopClientExpenses = new LiveCharts.WinForms.CartesianChart();
            this.label2 = new System.Windows.Forms.Label();
            this.chartLowestExpenses = new LiveCharts.WinForms.CartesianChart();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRecalculatePlots = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(524, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Top 10 Peores Clientes Según Monto Invertido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Top 10 Mejores Clientes Según Monto Invertido";
            // 
            // chartTopClientExpenses
            // 
            this.chartTopClientExpenses.ForeColor = System.Drawing.Color.White;
            this.chartTopClientExpenses.Location = new System.Drawing.Point(16, 68);
            this.chartTopClientExpenses.Name = "chartTopClientExpenses";
            this.chartTopClientExpenses.Size = new System.Drawing.Size(444, 244);
            this.chartTopClientExpenses.TabIndex = 5;
            this.chartTopClientExpenses.Text = "cartesianChartClientSpending";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datos de Clientes";
            // 
            // chartLowestExpenses
            // 
            this.chartLowestExpenses.Location = new System.Drawing.Point(527, 68);
            this.chartLowestExpenses.Name = "chartLowestExpenses";
            this.chartLowestExpenses.Size = new System.Drawing.Size(444, 244);
            this.chartLowestExpenses.TabIndex = 9;
            this.chartLowestExpenses.Text = "chartLowestClientExpenses";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(15, 641);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 10;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(260, 641);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 622);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Desde";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(257, 622);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hasta";
            // 
            // btnRecalculatePlots
            // 
            this.btnRecalculatePlots.Location = new System.Drawing.Point(466, 622);
            this.btnRecalculatePlots.Name = "btnRecalculatePlots";
            this.btnRecalculatePlots.Size = new System.Drawing.Size(75, 39);
            this.btnRecalculatePlots.TabIndex = 14;
            this.btnRecalculatePlots.Text = "Regenerar Gráficos";
            this.btnRecalculatePlots.UseVisualStyleBackColor = true;
            this.btnRecalculatePlots.Click += new System.EventHandler(this.btnRecalculatePlots_Click);
            // 
            // ClientsBiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(103)))));
            this.Controls.Add(this.btnRecalculatePlots);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.chartLowestExpenses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartTopClientExpenses);
            this.Name = "ClientsBiPanel";
            this.Size = new System.Drawing.Size(1122, 681);
            this.Load += new System.EventHandler(this.ClientsBiPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.CartesianChart chartTopClientExpenses;
        private System.Windows.Forms.Label label2;
        private LiveCharts.WinForms.CartesianChart chartLowestExpenses;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRecalculatePlots;
    }
}
