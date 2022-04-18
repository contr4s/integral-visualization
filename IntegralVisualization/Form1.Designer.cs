
namespace IntegralVisualization
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.compute = new System.Windows.Forms.Button();
            this.partitionRate = new System.Windows.Forms.MaskedTextBox();
            this.pointSelection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.integaralText = new System.Windows.Forms.Label();
            this.inaccuracyText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "f(x)";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Legend = "Legend1";
            series2.Name = "Integral Sum";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(802, 452);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // compute
            // 
            this.compute.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.compute.Location = new System.Drawing.Point(640, 146);
            this.compute.Name = "compute";
            this.compute.Size = new System.Drawing.Size(148, 48);
            this.compute.TabIndex = 1;
            this.compute.Text = "compute";
            this.compute.UseVisualStyleBackColor = true;
            this.compute.Click += new System.EventHandler(this.Compute);
            // 
            // partitionRate
            // 
            this.partitionRate.Location = new System.Drawing.Point(738, 93);
            this.partitionRate.Mask = "0000000";
            this.partitionRate.Name = "partitionRate";
            this.partitionRate.Size = new System.Drawing.Size(50, 20);
            this.partitionRate.TabIndex = 2;
            this.partitionRate.Text = "10";
            this.partitionRate.ValidatingType = typeof(int);
            // 
            // pointSelection
            // 
            this.pointSelection.FormattingEnabled = true;
            this.pointSelection.Location = new System.Drawing.Point(724, 119);
            this.pointSelection.Name = "pointSelection";
            this.pointSelection.Size = new System.Drawing.Size(64, 21);
            this.pointSelection.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(637, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Partition rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Point Selection:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(687, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Results:";
            // 
            // integaralText
            // 
            this.integaralText.AutoSize = true;
            this.integaralText.Location = new System.Drawing.Point(673, 284);
            this.integaralText.Name = "integaralText";
            this.integaralText.Size = new System.Drawing.Size(54, 13);
            this.integaralText.TabIndex = 8;
            this.integaralText.Text = "Integral = ";
            // 
            // inaccuracyText
            // 
            this.inaccuracyText.AutoSize = true;
            this.inaccuracyText.Location = new System.Drawing.Point(676, 301);
            this.inaccuracyText.Name = "inaccuracyText";
            this.inaccuracyText.Size = new System.Drawing.Size(69, 13);
            this.inaccuracyText.TabIndex = 9;
            this.inaccuracyText.Text = "Inaccuracy =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.inaccuracyText);
            this.Controls.Add(this.integaralText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pointSelection);
            this.Controls.Add(this.partitionRate);
            this.Controls.Add(this.compute);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button compute;
        private System.Windows.Forms.MaskedTextBox partitionRate;
        private System.Windows.Forms.ComboBox pointSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label integaralText;
        private System.Windows.Forms.Label inaccuracyText;
    }
}

