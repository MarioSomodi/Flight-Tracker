namespace FlightTracker
{
    partial class FlightDetailsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonBackToComboBox = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.comboBoxSearchParam = new System.Windows.Forms.ComboBox();
            this.btnContainer = new System.Windows.Forms.Panel();
            this.btnExportFlightsToTxt = new System.Windows.Forms.Button();
            this.dataGridViewFlightDetails = new System.Windows.Forms.DataGridView();
            this.flightId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfPassangers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmptyList = new System.Windows.Forms.Label();
            this.panelSearch.SuspendLayout();
            this.btnContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.buttonBackToComboBox);
            this.panelSearch.Controls.Add(this.searchLabel);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.comboBoxSearchParam);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1066, 70);
            this.panelSearch.TabIndex = 9;
            // 
            // buttonBackToComboBox
            // 
            this.buttonBackToComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonBackToComboBox.AutoSize = true;
            this.buttonBackToComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.buttonBackToComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToComboBox.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonBackToComboBox.FlatAppearance.BorderSize = 0;
            this.buttonBackToComboBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.buttonBackToComboBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.buttonBackToComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackToComboBox.ForeColor = System.Drawing.Color.White;
            this.buttonBackToComboBox.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonBackToComboBox.Location = new System.Drawing.Point(600, 39);
            this.buttonBackToComboBox.Name = "buttonBackToComboBox";
            this.buttonBackToComboBox.Size = new System.Drawing.Size(41, 24);
            this.buttonBackToComboBox.TabIndex = 14;
            this.buttonBackToComboBox.Text = "Back";
            this.buttonBackToComboBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBackToComboBox.UseVisualStyleBackColor = false;
            this.buttonBackToComboBox.Visible = false;
            this.buttonBackToComboBox.Click += new System.EventHandler(this.buttonBackToComboBox_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(363, 3);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(359, 33);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Choose what to search by";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(441, 42);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(155, 20);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.Visible = false;
            this.textBoxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyUp);
            // 
            // comboBoxSearchParam
            // 
            this.comboBoxSearchParam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSearchParam.FormattingEnabled = true;
            this.comboBoxSearchParam.Items.AddRange(new object[] {
            "Origin country",
            "Destination country",
            "Flight duration",
            "Flight price",
            "Number of passangers"});
            this.comboBoxSearchParam.Location = new System.Drawing.Point(441, 41);
            this.comboBoxSearchParam.Name = "comboBoxSearchParam";
            this.comboBoxSearchParam.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSearchParam.TabIndex = 0;
            this.comboBoxSearchParam.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchParam_SelectedIndexChanged);
            // 
            // btnContainer
            // 
            this.btnContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnContainer.Controls.Add(this.btnExportFlightsToTxt);
            this.btnContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnContainer.Location = new System.Drawing.Point(0, 497);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(1066, 73);
            this.btnContainer.TabIndex = 11;
            // 
            // btnExportFlightsToTxt
            // 
            this.btnExportFlightsToTxt.AutoSize = true;
            this.btnExportFlightsToTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnExportFlightsToTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportFlightsToTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportFlightsToTxt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExportFlightsToTxt.FlatAppearance.BorderSize = 0;
            this.btnExportFlightsToTxt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnExportFlightsToTxt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnExportFlightsToTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportFlightsToTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportFlightsToTxt.ForeColor = System.Drawing.Color.White;
            this.btnExportFlightsToTxt.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnExportFlightsToTxt.Location = new System.Drawing.Point(0, 0);
            this.btnExportFlightsToTxt.Name = "btnExportFlightsToTxt";
            this.btnExportFlightsToTxt.Size = new System.Drawing.Size(1066, 73);
            this.btnExportFlightsToTxt.TabIndex = 3;
            this.btnExportFlightsToTxt.Text = "Export current flights to text file";
            this.btnExportFlightsToTxt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportFlightsToTxt.UseVisualStyleBackColor = false;
            this.btnExportFlightsToTxt.Click += new System.EventHandler(this.btnExportFlightsToTxt_Click);
            // 
            // dataGridViewFlightDetails
            // 
            this.dataGridViewFlightDetails.AllowUserToAddRows = false;
            this.dataGridViewFlightDetails.AllowUserToDeleteRows = false;
            this.dataGridViewFlightDetails.AllowUserToResizeColumns = false;
            this.dataGridViewFlightDetails.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFlightDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlightDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFlightDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFlightDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dataGridViewFlightDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFlightDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFlightDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlightDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flightId,
            this.originCountry,
            this.destinationCountry,
            this.flightDuration,
            this.flightPrice,
            this.numberOfPassangers});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFlightDetails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFlightDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFlightDetails.EnableHeadersVisualStyles = false;
            this.dataGridViewFlightDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.dataGridViewFlightDetails.Location = new System.Drawing.Point(0, 70);
            this.dataGridViewFlightDetails.Name = "dataGridViewFlightDetails";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFlightDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFlightDetails.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFlightDetails.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewFlightDetails.Size = new System.Drawing.Size(1066, 427);
            this.dataGridViewFlightDetails.TabIndex = 12;
            // 
            // flightId
            // 
            this.flightId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.flightId.DataPropertyName = "flightId";
            this.flightId.HeaderText = "Id";
            this.flightId.Name = "flightId";
            this.flightId.ReadOnly = true;
            // 
            // originCountry
            // 
            this.originCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.originCountry.DataPropertyName = "originCountry";
            this.originCountry.HeaderText = "Origin country";
            this.originCountry.Name = "originCountry";
            this.originCountry.ReadOnly = true;
            // 
            // destinationCountry
            // 
            this.destinationCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.destinationCountry.DataPropertyName = "destinationCountry";
            this.destinationCountry.HeaderText = "Destination country";
            this.destinationCountry.Name = "destinationCountry";
            this.destinationCountry.ReadOnly = true;
            // 
            // flightDuration
            // 
            this.flightDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.flightDuration.DataPropertyName = "flightDuration";
            this.flightDuration.HeaderText = "Duration h:m";
            this.flightDuration.Name = "flightDuration";
            this.flightDuration.ReadOnly = true;
            // 
            // flightPrice
            // 
            this.flightPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.flightPrice.DataPropertyName = "flightPrice";
            this.flightPrice.HeaderText = "Price";
            this.flightPrice.Name = "flightPrice";
            this.flightPrice.ReadOnly = true;
            // 
            // numberOfPassangers
            // 
            this.numberOfPassangers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numberOfPassangers.DataPropertyName = "numberOfPassangers";
            this.numberOfPassangers.HeaderText = "Number of passangers";
            this.numberOfPassangers.Name = "numberOfPassangers";
            this.numberOfPassangers.ReadOnly = true;
            // 
            // lblEmptyList
            // 
            this.lblEmptyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmptyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblEmptyList.ForeColor = System.Drawing.Color.White;
            this.lblEmptyList.Location = new System.Drawing.Point(0, 70);
            this.lblEmptyList.Name = "lblEmptyList";
            this.lblEmptyList.Size = new System.Drawing.Size(1066, 427);
            this.lblEmptyList.TabIndex = 13;
            this.lblEmptyList.Text = "You haven\'t added any details for any of the flights.";
            this.lblEmptyList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmptyList.Visible = false;
            // 
            // FlightDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1066, 570);
            this.ControlBox = false;
            this.Controls.Add(this.lblEmptyList);
            this.Controls.Add(this.dataGridViewFlightDetails);
            this.Controls.Add(this.btnContainer);
            this.Controls.Add(this.panelSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlightDetailsForm";
            this.ShowIcon = false;
            this.Text = "Flight Details";
            this.Load += new System.EventHandler(this.FlightDetailsForm_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.btnContainer.ResumeLayout(false);
            this.btnContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlightDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchParam;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button buttonBackToComboBox;
        private System.Windows.Forms.Panel btnContainer;
        private System.Windows.Forms.Button btnExportFlightsToTxt;
        private System.Windows.Forms.DataGridView dataGridViewFlightDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightId;
        private System.Windows.Forms.DataGridViewTextBoxColumn originCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfPassangers;
        private System.Windows.Forms.Label lblEmptyList;
    }
}