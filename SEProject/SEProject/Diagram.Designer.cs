namespace SEProject
{
    partial class Diagram
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1_diagram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_nazwa_szablonu = new System.Windows.Forms.Label();
            this.button_zapisz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1_diagram)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1_diagram
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1_diagram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1_diagram.Legends.Add(legend1);
            this.chart1_diagram.Location = new System.Drawing.Point(81, 62);
            this.chart1_diagram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1_diagram.Name = "chart1_diagram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1_diagram.Series.Add(series1);
            this.chart1_diagram.Size = new System.Drawing.Size(907, 478);
            this.chart1_diagram.TabIndex = 0;
            this.chart1_diagram.Text = "chart1";
            this.chart1_diagram.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label_nazwa_szablonu
            // 
            this.label_nazwa_szablonu.AutoSize = true;
            this.label_nazwa_szablonu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_nazwa_szablonu.Location = new System.Drawing.Point(228, 11);
            this.label_nazwa_szablonu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nazwa_szablonu.Name = "label_nazwa_szablonu";
            this.label_nazwa_szablonu.Size = new System.Drawing.Size(0, 24);
            this.label_nazwa_szablonu.TabIndex = 1;
            // 
            // button_zapisz
            // 
            this.button_zapisz.Location = new System.Drawing.Point(857, 399);
            this.button_zapisz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(100, 28);
            this.button_zapisz.TabIndex = 2;
            this.button_zapisz.Text = "Zapisz";
            this.button_zapisz.UseVisualStyleBackColor = true;
            this.button_zapisz.Click += new System.EventHandler(this.button_zapisz_Click);
            // 
            // Diagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button_zapisz);
            this.Controls.Add(this.label_nazwa_szablonu);
            this.Controls.Add(this.chart1_diagram);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Diagram";
            this.Text = "Diagram";
            this.Load += new System.EventHandler(this.Diagram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1_diagram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1_diagram;
        private System.Windows.Forms.Label label_nazwa_szablonu;
        private System.Windows.Forms.Button button_zapisz;
    }
}