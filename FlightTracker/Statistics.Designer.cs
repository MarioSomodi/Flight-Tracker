namespace FlightTracker
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblStatisticsTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelVelocity = new System.Windows.Forms.Panel();
            this.chartVelocity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelNumOfFlights = new System.Windows.Forms.Panel();
            this.lblNumOfFlights = new System.Windows.Forms.Label();
            this.panelTitle.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelVelocity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartVelocity)).BeginInit();
            this.panelNumOfFlights.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblStatisticsTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1050, 54);
            this.panelTitle.TabIndex = 0;
            // 
            // lblStatisticsTitle
            // 
            this.lblStatisticsTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatisticsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lblStatisticsTitle.ForeColor = System.Drawing.Color.White;
            this.lblStatisticsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblStatisticsTitle.Name = "lblStatisticsTitle";
            this.lblStatisticsTitle.Size = new System.Drawing.Size(1050, 54);
            this.lblStatisticsTitle.TabIndex = 0;
            this.lblStatisticsTitle.Text = "Statistics";
            this.lblStatisticsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelVelocity);
            this.panelContent.Controls.Add(this.panelNumOfFlights);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 54);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1050, 477);
            this.panelContent.TabIndex = 1;
            // 
            // panelVelocity
            // 
            this.panelVelocity.Controls.Add(this.chartVelocity);
            this.panelVelocity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVelocity.Location = new System.Drawing.Point(0, 54);
            this.panelVelocity.Name = "panelVelocity";
            this.panelVelocity.Size = new System.Drawing.Size(1050, 423);
            this.panelVelocity.TabIndex = 2;
            // 
            // chartVelocity
            // 
            this.chartVelocity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.chartVelocity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chartVelocity.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.chartVelocity.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chartVelocity.BorderSkin.BorderColor = System.Drawing.Color.White;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = -60;
            chartArea1.Area3DStyle.WallWidth = 2;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.Name = "ChartArea1";
            this.chartVelocity.ChartAreas.Add(chartArea1);
            this.chartVelocity.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            legend1.BackSecondaryColor = System.Drawing.Color.White;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.chartVelocity.Legends.Add(legend1);
            this.chartVelocity.Location = new System.Drawing.Point(0, 0);
            this.chartVelocity.Name = "chartVelocity";
            this.chartVelocity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.chartVelocity.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))),
        System.Drawing.Color.Silver,
        System.Drawing.Color.Red,
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Yellow,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Aqua,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Fuchsia,
        System.Drawing.Color.Gray,
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Maroon,
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Olive,
        System.Drawing.Color.Green,
        System.Drawing.Color.Teal,
        System.Drawing.Color.Navy,
        System.Drawing.Color.Purple,
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.Maroon,
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.LightPink,
        System.Drawing.Color.Pink,
        System.Drawing.Color.Crimson,
        System.Drawing.Color.PaleVioletRed,
        System.Drawing.Color.LavenderBlush,
        System.Drawing.Color.HotPink,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.MediumVioletRed,
        System.Drawing.Color.Orchid,
        System.Drawing.Color.Magenta,
        System.Drawing.Color.Fuchsia,
        System.Drawing.Color.DarkMagenta,
        System.Drawing.Color.Purple,
        System.Drawing.Color.Violet,
        System.Drawing.Color.Plum,
        System.Drawing.Color.Thistle,
        System.Drawing.Color.MediumOrchid,
        System.Drawing.Color.DarkViolet,
        System.Drawing.Color.DarkOrchid,
        System.Drawing.Color.Indigo,
        System.Drawing.Color.BlueViolet,
        System.Drawing.Color.LightSkyBlue,
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.PowderBlue,
        System.Drawing.Color.CadetBlue,
        System.Drawing.Color.DarkTurquoise,
        System.Drawing.Color.Cyan,
        System.Drawing.Color.Aqua,
        System.Drawing.Color.DarkCyan,
        System.Drawing.Color.DarkSlateGray,
        System.Drawing.Color.Aquamarine,
        System.Drawing.Color.MintCream,
        System.Drawing.Color.MediumAquamarine,
        System.Drawing.Color.MediumSpringGreen,
        System.Drawing.Color.MediumSeaGreen,
        System.Drawing.Color.SpringGreen,
        System.Drawing.Color.SeaGreen,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Green,
        System.Drawing.Color.DarkGreen,
        System.Drawing.Color.PaleGreen,
        System.Drawing.Color.LimeGreen,
        System.Drawing.Color.ForestGreen,
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.DarkSeaGreen,
        System.Drawing.Color.LawnGreen,
        System.Drawing.Color.Chartreuse,
        System.Drawing.Color.GreenYellow,
        System.Drawing.Color.DarkOliveGreen,
        System.Drawing.Color.YellowGreen,
        System.Drawing.Color.OliveDrab,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.LightGoldenrodYellow,
        System.Drawing.Color.Gold,
        System.Drawing.Color.DarkGoldenrod,
        System.Drawing.Color.Tan,
        System.Drawing.Color.MistyRose};
            this.chartVelocity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.ChartArea = "ChartArea1";
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.LabelBorderWidth = 50;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartVelocity.Series.Add(series1);
            this.chartVelocity.Size = new System.Drawing.Size(1050, 423);
            this.chartVelocity.TabIndex = 0;
            this.chartVelocity.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "Velocity";
            this.chartVelocity.Titles.Add(title1);
            // 
            // panelNumOfFlights
            // 
            this.panelNumOfFlights.Controls.Add(this.lblNumOfFlights);
            this.panelNumOfFlights.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNumOfFlights.Location = new System.Drawing.Point(0, 0);
            this.panelNumOfFlights.Name = "panelNumOfFlights";
            this.panelNumOfFlights.Size = new System.Drawing.Size(1050, 54);
            this.panelNumOfFlights.TabIndex = 1;
            // 
            // lblNumOfFlights
            // 
            this.lblNumOfFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumOfFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNumOfFlights.ForeColor = System.Drawing.Color.White;
            this.lblNumOfFlights.Location = new System.Drawing.Point(0, 0);
            this.lblNumOfFlights.Name = "lblNumOfFlights";
            this.lblNumOfFlights.Size = new System.Drawing.Size(1050, 54);
            this.lblNumOfFlights.TabIndex = 0;
            this.lblNumOfFlights.Text = "Number of flights that we track: ";
            this.lblNumOfFlights.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1050, 531);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTitle);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelVelocity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartVelocity)).EndInit();
            this.panelNumOfFlights.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblStatisticsTitle;
        private System.Windows.Forms.Panel panelNumOfFlights;
        private System.Windows.Forms.Label lblNumOfFlights;
        private System.Windows.Forms.Panel panelVelocity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVelocity;
    }
}