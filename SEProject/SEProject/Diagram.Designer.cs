﻿namespace SEProject
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1_diagram)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1_diagram
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1_diagram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1_diagram.Legends.Add(legend1);
            this.chart1_diagram.Location = new System.Drawing.Point(61, 29);
            this.chart1_diagram.Name = "chart1_diagram";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1_diagram.Series.Add(series1);
            this.chart1_diagram.Size = new System.Drawing.Size(680, 388);
            this.chart1_diagram.TabIndex = 0;
            this.chart1_diagram.Text = "chart1";
            this.chart1_diagram.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Diagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1_diagram);
            this.Name = "Diagram";
            this.Text = "Diagram";
            ((System.ComponentModel.ISupportInitialize)(this.chart1_diagram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1_diagram;
    }
}