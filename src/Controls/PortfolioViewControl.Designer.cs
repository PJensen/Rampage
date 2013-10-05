namespace Rampage.Controls
{
    partial class PortfolioViewControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxPortfolioItems = new System.Windows.Forms.ListBox();
            this.propertyGridPortfolio = new System.Windows.Forms.PropertyGrid();
            this.tabControlPortfolioView = new System.Windows.Forms.TabControl();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
            this.chartOverview = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.portfolioDataRetrieverComponent = new Rampage.Components.PortfolioDataRetrieverComponent(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControlPortfolioView.SuspendLayout();
            this.tabPageOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOverview)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tabControlPortfolioView);
            this.splitContainerMain.Panel2.Controls.Add(this.statusStrip);
            this.splitContainerMain.Size = new System.Drawing.Size(619, 411);
            this.splitContainerMain.SplitterDistance = 135;
            this.splitContainerMain.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxPortfolioItems, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.propertyGridPortfolio, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.1573F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.8427F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(135, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBoxPortfolioItems
            // 
            this.listBoxPortfolioItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxPortfolioItems.FormattingEnabled = true;
            this.listBoxPortfolioItems.Location = new System.Drawing.Point(3, 3);
            this.listBoxPortfolioItems.Name = "listBoxPortfolioItems";
            this.listBoxPortfolioItems.Size = new System.Drawing.Size(129, 298);
            this.listBoxPortfolioItems.TabIndex = 0;
            this.listBoxPortfolioItems.SelectedIndexChanged += new System.EventHandler(this.listBoxPortfolioItems_SelectedIndexChanged);
            // 
            // propertyGridPortfolio
            // 
            this.propertyGridPortfolio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridPortfolio.Location = new System.Drawing.Point(3, 307);
            this.propertyGridPortfolio.Name = "propertyGridPortfolio";
            this.propertyGridPortfolio.Size = new System.Drawing.Size(129, 101);
            this.propertyGridPortfolio.TabIndex = 1;
            // 
            // tabControlPortfolioView
            // 
            this.tabControlPortfolioView.Controls.Add(this.tabPageOverview);
            this.tabControlPortfolioView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPortfolioView.Location = new System.Drawing.Point(0, 0);
            this.tabControlPortfolioView.Name = "tabControlPortfolioView";
            this.tabControlPortfolioView.SelectedIndex = 0;
            this.tabControlPortfolioView.Size = new System.Drawing.Size(480, 389);
            this.tabControlPortfolioView.TabIndex = 1;
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.Controls.Add(this.chartOverview);
            this.tabPageOverview.Location = new System.Drawing.Point(4, 22);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverview.Size = new System.Drawing.Size(472, 363);
            this.tabPageOverview.TabIndex = 0;
            this.tabPageOverview.Text = "Overview";
            this.tabPageOverview.ToolTipText = "The overview for this portfolio";
            this.tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // chartOverview
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOverview.ChartAreas.Add(chartArea1);
            this.chartOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartOverview.Legends.Add(legend1);
            this.chartOverview.Location = new System.Drawing.Point(3, 3);
            this.chartOverview.Name = "chartOverview";
            this.chartOverview.Size = new System.Drawing.Size(466, 357);
            this.chartOverview.TabIndex = 0;
            this.chartOverview.Text = "Overview";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 389);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(480, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(200, 16);
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel.Text = "Initializing ...";
            // 
            // portfolioDataRetrieverComponent
            // 
            this.portfolioDataRetrieverComponent.OnDataRetrieved += new System.EventHandler<Rampage.Components.PortfolioDataRetrieverComponent.PortfolioDataRetievedEventArgs>(this.portfolioDataRetrieverComponent_OnDataRetrieved);
            // 
            // PortfolioViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerMain);
            this.Name = "PortfolioViewControl";
            this.Size = new System.Drawing.Size(619, 411);
            this.Load += new System.EventHandler(this.PortfolioViewControl_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControlPortfolioView.ResumeLayout(false);
            this.tabPageOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOverview)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxPortfolioItems;
        private System.Windows.Forms.PropertyGrid propertyGridPortfolio;
        private Components.PortfolioDataRetrieverComponent portfolioDataRetrieverComponent;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TabControl tabControlPortfolioView;
        private System.Windows.Forms.TabPage tabPageOverview;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOverview;

    }
}
