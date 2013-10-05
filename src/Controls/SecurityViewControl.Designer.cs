namespace Rampage.Controls
{
    partial class SecurityViewControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSecurity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartSecurity)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSecurity
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSecurity.ChartAreas.Add(chartArea2);
            this.chartSecurity.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartSecurity.Legends.Add(legend2);
            this.chartSecurity.Location = new System.Drawing.Point(0, 0);
            this.chartSecurity.Name = "chartSecurity";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSecurity.Series.Add(series2);
            this.chartSecurity.Size = new System.Drawing.Size(367, 322);
            this.chartSecurity.TabIndex = 0;
            this.chartSecurity.Text = "Security";
            // 
            // SecurityViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartSecurity);
            this.Name = "SecurityViewControl";
            this.Size = new System.Drawing.Size(367, 322);
            this.Load += new System.EventHandler(this.SecurityViewControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSecurity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSecurity;
    }
}
