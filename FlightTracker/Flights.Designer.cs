namespace FlightTracker
{
    partial class Flights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flights));
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            this.VMflightId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VMicao24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VMcallSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VMoriginCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VMvelocity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VMverticalRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VMsquawk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addFlightDetails = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelAddDetails = new System.Windows.Forms.Panel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblErrorMinutes = new System.Windows.Forms.Label();
            this.lblErrorNumOfPassangers = new System.Windows.Forms.Label();
            this.lblErrorFlightPrice = new System.Windows.Forms.Label();
            this.lblErrorHours = new System.Windows.Forms.Label();
            this.lblErrorDestinationCountry = new System.Windows.Forms.Label();
            this.buttonBackToComboBox = new System.Windows.Forms.Button();
            this.textBoxNewCountry = new System.Windows.Forms.TextBox();
            this.numericUpDownNumOfPassangers = new System.Windows.Forms.NumericUpDown();
            this.lblNumOfPassangers = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.lblFlightDuration = new System.Windows.Forms.Label();
            this.comboBoxCountries = new System.Windows.Forms.ComboBox();
            this.lblDestinationCountry = new System.Windows.Forms.Label();
            this.btnContainer = new System.Windows.Forms.Panel();
            this.btnAddFlightDetails = new System.Windows.Forms.Button();
            this.panelCountryOfOrigin = new System.Windows.Forms.Panel();
            this.lblCountryOfOrigin = new System.Windows.Forms.Label();
            this.panelFlightId = new System.Windows.Forms.Panel();
            this.lblFlightId = new System.Windows.Forms.Label();
            this.lblFlightsEmpty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            this.panelAddDetails.SuspendLayout();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfPassangers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.btnContainer.SuspendLayout();
            this.panelCountryOfOrigin.SuspendLayout();
            this.panelFlightId.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFlights
            // 
            this.dataGridViewFlights.AllowUserToAddRows = false;
            this.dataGridViewFlights.AllowUserToDeleteRows = false;
            this.dataGridViewFlights.AllowUserToResizeColumns = false;
            this.dataGridViewFlights.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFlights.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFlights.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewFlights.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dataGridViewFlights.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFlights.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlights.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VMflightId,
            this.VMicao24,
            this.VMcallSign,
            this.VMoriginCountry,
            this.VMvelocity,
            this.VMverticalRate,
            this.VMsquawk,
            this.addFlightDetails});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFlights.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFlights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFlights.EnableHeadersVisualStyles = false;
            this.dataGridViewFlights.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.dataGridViewFlights.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFlights.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFlights.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFlights.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewFlights.Size = new System.Drawing.Size(1066, 570);
            this.dataGridViewFlights.TabIndex = 2;
            this.dataGridViewFlights.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFlights_CellClick);
            // 
            // VMflightId
            // 
            this.VMflightId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VMflightId.DataPropertyName = "VMflightId";
            this.VMflightId.HeaderText = "Id";
            this.VMflightId.Name = "VMflightId";
            this.VMflightId.ReadOnly = true;
            // 
            // VMicao24
            // 
            this.VMicao24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VMicao24.DataPropertyName = "VMicao24";
            this.VMicao24.HeaderText = "Icao24";
            this.VMicao24.Name = "VMicao24";
            this.VMicao24.ReadOnly = true;
            // 
            // VMcallSign
            // 
            this.VMcallSign.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VMcallSign.DataPropertyName = "VMcallSign";
            this.VMcallSign.HeaderText = "Call sign";
            this.VMcallSign.Name = "VMcallSign";
            this.VMcallSign.ReadOnly = true;
            // 
            // VMoriginCountry
            // 
            this.VMoriginCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VMoriginCountry.DataPropertyName = "VMoriginCountry";
            this.VMoriginCountry.HeaderText = "Origin country";
            this.VMoriginCountry.Name = "VMoriginCountry";
            this.VMoriginCountry.ReadOnly = true;
            // 
            // VMvelocity
            // 
            this.VMvelocity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VMvelocity.DataPropertyName = "VMvelocity";
            this.VMvelocity.HeaderText = "Velocity";
            this.VMvelocity.Name = "VMvelocity";
            this.VMvelocity.ReadOnly = true;
            // 
            // VMverticalRate
            // 
            this.VMverticalRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VMverticalRate.DataPropertyName = "VMverticalRate";
            this.VMverticalRate.HeaderText = "Vertical rate";
            this.VMverticalRate.Name = "VMverticalRate";
            this.VMverticalRate.ReadOnly = true;
            // 
            // VMsquawk
            // 
            this.VMsquawk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.VMsquawk.DataPropertyName = "VMsquawk";
            this.VMsquawk.HeaderText = "Squawk";
            this.VMsquawk.Name = "VMsquawk";
            this.VMsquawk.ReadOnly = true;
            // 
            // addFlightDetails
            // 
            this.addFlightDetails.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addFlightDetails.HeaderText = "Add details";
            this.addFlightDetails.Image = ((System.Drawing.Image)(resources.GetObject("addFlightDetails.Image")));
            this.addFlightDetails.Name = "addFlightDetails";
            this.addFlightDetails.ReadOnly = true;
            this.addFlightDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panelAddDetails
            // 
            this.panelAddDetails.Controls.Add(this.panelInput);
            this.panelAddDetails.Controls.Add(this.btnContainer);
            this.panelAddDetails.Controls.Add(this.panelCountryOfOrigin);
            this.panelAddDetails.Controls.Add(this.panelFlightId);
            this.panelAddDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddDetails.Location = new System.Drawing.Point(0, 0);
            this.panelAddDetails.Name = "panelAddDetails";
            this.panelAddDetails.Size = new System.Drawing.Size(1066, 570);
            this.panelAddDetails.TabIndex = 3;
            this.panelAddDetails.Visible = false;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.lblErrorMinutes);
            this.panelInput.Controls.Add(this.lblErrorNumOfPassangers);
            this.panelInput.Controls.Add(this.lblErrorFlightPrice);
            this.panelInput.Controls.Add(this.lblErrorHours);
            this.panelInput.Controls.Add(this.lblErrorDestinationCountry);
            this.panelInput.Controls.Add(this.buttonBackToComboBox);
            this.panelInput.Controls.Add(this.textBoxNewCountry);
            this.panelInput.Controls.Add(this.numericUpDownNumOfPassangers);
            this.panelInput.Controls.Add(this.lblNumOfPassangers);
            this.panelInput.Controls.Add(this.lblPrice);
            this.panelInput.Controls.Add(this.numericUpDownPrice);
            this.panelInput.Controls.Add(this.lblMinutes);
            this.panelInput.Controls.Add(this.lblHours);
            this.panelInput.Controls.Add(this.numericUpDownMinutes);
            this.panelInput.Controls.Add(this.numericUpDownHours);
            this.panelInput.Controls.Add(this.lblFlightDuration);
            this.panelInput.Controls.Add(this.comboBoxCountries);
            this.panelInput.Controls.Add(this.lblDestinationCountry);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(0, 84);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(1066, 413);
            this.panelInput.TabIndex = 7;
            // 
            // lblErrorMinutes
            // 
            this.lblErrorMinutes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblErrorMinutes.AutoSize = true;
            this.lblErrorMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMinutes.ForeColor = System.Drawing.Color.White;
            this.lblErrorMinutes.Location = new System.Drawing.Point(540, 175);
            this.lblErrorMinutes.Name = "lblErrorMinutes";
            this.lblErrorMinutes.Size = new System.Drawing.Size(34, 15);
            this.lblErrorMinutes.TabIndex = 18;
            this.lblErrorMinutes.Text = "Error";
            this.lblErrorMinutes.Visible = false;
            // 
            // lblErrorNumOfPassangers
            // 
            this.lblErrorNumOfPassangers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorNumOfPassangers.AutoSize = true;
            this.lblErrorNumOfPassangers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNumOfPassangers.ForeColor = System.Drawing.Color.White;
            this.lblErrorNumOfPassangers.Location = new System.Drawing.Point(431, 341);
            this.lblErrorNumOfPassangers.Name = "lblErrorNumOfPassangers";
            this.lblErrorNumOfPassangers.Size = new System.Drawing.Size(34, 15);
            this.lblErrorNumOfPassangers.TabIndex = 17;
            this.lblErrorNumOfPassangers.Text = "Error";
            this.lblErrorNumOfPassangers.Visible = false;
            // 
            // lblErrorFlightPrice
            // 
            this.lblErrorFlightPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorFlightPrice.AutoSize = true;
            this.lblErrorFlightPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFlightPrice.ForeColor = System.Drawing.Color.White;
            this.lblErrorFlightPrice.Location = new System.Drawing.Point(431, 258);
            this.lblErrorFlightPrice.Name = "lblErrorFlightPrice";
            this.lblErrorFlightPrice.Size = new System.Drawing.Size(34, 15);
            this.lblErrorFlightPrice.TabIndex = 16;
            this.lblErrorFlightPrice.Text = "Error";
            this.lblErrorFlightPrice.Visible = false;
            // 
            // lblErrorHours
            // 
            this.lblErrorHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorHours.AutoSize = true;
            this.lblErrorHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorHours.ForeColor = System.Drawing.Color.White;
            this.lblErrorHours.Location = new System.Drawing.Point(431, 175);
            this.lblErrorHours.Name = "lblErrorHours";
            this.lblErrorHours.Size = new System.Drawing.Size(34, 15);
            this.lblErrorHours.TabIndex = 15;
            this.lblErrorHours.Text = "Error";
            this.lblErrorHours.Visible = false;
            // 
            // lblErrorDestinationCountry
            // 
            this.lblErrorDestinationCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblErrorDestinationCountry.AutoSize = true;
            this.lblErrorDestinationCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDestinationCountry.ForeColor = System.Drawing.Color.White;
            this.lblErrorDestinationCountry.Location = new System.Drawing.Point(431, 91);
            this.lblErrorDestinationCountry.Name = "lblErrorDestinationCountry";
            this.lblErrorDestinationCountry.Size = new System.Drawing.Size(34, 15);
            this.lblErrorDestinationCountry.TabIndex = 14;
            this.lblErrorDestinationCountry.Text = "Error";
            this.lblErrorDestinationCountry.Visible = false;
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
            this.buttonBackToComboBox.Location = new System.Drawing.Point(593, 68);
            this.buttonBackToComboBox.Name = "buttonBackToComboBox";
            this.buttonBackToComboBox.Size = new System.Drawing.Size(41, 24);
            this.buttonBackToComboBox.TabIndex = 13;
            this.buttonBackToComboBox.Text = "Back";
            this.buttonBackToComboBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBackToComboBox.UseVisualStyleBackColor = false;
            this.buttonBackToComboBox.Visible = false;
            this.buttonBackToComboBox.Click += new System.EventHandler(this.buttonBackToComboBox_Click);
            // 
            // textBoxNewCountry
            // 
            this.textBoxNewCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewCountry.Location = new System.Drawing.Point(432, 70);
            this.textBoxNewCountry.Name = "textBoxNewCountry";
            this.textBoxNewCountry.Size = new System.Drawing.Size(155, 20);
            this.textBoxNewCountry.TabIndex = 12;
            this.textBoxNewCountry.Visible = false;
            // 
            // numericUpDownNumOfPassangers
            // 
            this.numericUpDownNumOfPassangers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownNumOfPassangers.Location = new System.Drawing.Point(432, 318);
            this.numericUpDownNumOfPassangers.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownNumOfPassangers.Name = "numericUpDownNumOfPassangers";
            this.numericUpDownNumOfPassangers.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownNumOfPassangers.TabIndex = 11;
            // 
            // lblNumOfPassangers
            // 
            this.lblNumOfPassangers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumOfPassangers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumOfPassangers.ForeColor = System.Drawing.Color.White;
            this.lblNumOfPassangers.Location = new System.Drawing.Point(0, 273);
            this.lblNumOfPassangers.Name = "lblNumOfPassangers";
            this.lblNumOfPassangers.Size = new System.Drawing.Size(1066, 42);
            this.lblNumOfPassangers.TabIndex = 10;
            this.lblNumOfPassangers.Text = "Number of passangers";
            this.lblNumOfPassangers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(0, 190);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(1066, 42);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Flight price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(432, 235);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownPrice.TabIndex = 8;
            // 
            // lblMinutes
            // 
            this.lblMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutes.ForeColor = System.Drawing.Color.White;
            this.lblMinutes.Location = new System.Drawing.Point(635, 140);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(428, 42);
            this.lblMinutes.TabIndex = 7;
            this.lblMinutes.Text = "Minutes";
            this.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHours
            // 
            this.lblHours.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.ForeColor = System.Drawing.Color.White;
            this.lblHours.Location = new System.Drawing.Point(-4, 140);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(426, 42);
            this.lblHours.TabIndex = 5;
            this.lblHours.Text = "Hours";
            this.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numericUpDownMinutes.AutoSize = true;
            this.numericUpDownMinutes.Location = new System.Drawing.Point(541, 152);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinutes.MinimumSize = new System.Drawing.Size(20, 0);
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.Size = new System.Drawing.Size(91, 20);
            this.numericUpDownMinutes.TabIndex = 6;
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownHours.AutoSize = true;
            this.numericUpDownHours.Location = new System.Drawing.Point(432, 152);
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(92, 20);
            this.numericUpDownHours.TabIndex = 5;
            // 
            // lblFlightDuration
            // 
            this.lblFlightDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlightDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightDuration.ForeColor = System.Drawing.Color.White;
            this.lblFlightDuration.Location = new System.Drawing.Point(0, 106);
            this.lblFlightDuration.Name = "lblFlightDuration";
            this.lblFlightDuration.Size = new System.Drawing.Size(1066, 42);
            this.lblFlightDuration.TabIndex = 4;
            this.lblFlightDuration.Text = "Flight duration";
            this.lblFlightDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCountries
            // 
            this.comboBoxCountries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxCountries.FormattingEnabled = true;
            this.comboBoxCountries.Location = new System.Drawing.Point(432, 70);
            this.comboBoxCountries.Name = "comboBoxCountries";
            this.comboBoxCountries.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCountries.TabIndex = 2;
            this.comboBoxCountries.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountries_SelectedIndexChanged);
            this.comboBoxCountries.Leave += new System.EventHandler(this.comboBoxCountries_Leave);
            // 
            // lblDestinationCountry
            // 
            this.lblDestinationCountry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDestinationCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinationCountry.ForeColor = System.Drawing.Color.White;
            this.lblDestinationCountry.Location = new System.Drawing.Point(0, 21);
            this.lblDestinationCountry.Name = "lblDestinationCountry";
            this.lblDestinationCountry.Size = new System.Drawing.Size(1066, 42);
            this.lblDestinationCountry.TabIndex = 1;
            this.lblDestinationCountry.Text = "Destination country";
            this.lblDestinationCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnContainer
            // 
            this.btnContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnContainer.Controls.Add(this.btnAddFlightDetails);
            this.btnContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnContainer.Location = new System.Drawing.Point(0, 497);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(1066, 73);
            this.btnContainer.TabIndex = 6;
            // 
            // btnAddFlightDetails
            // 
            this.btnAddFlightDetails.AutoSize = true;
            this.btnAddFlightDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnAddFlightDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFlightDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddFlightDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddFlightDetails.FlatAppearance.BorderSize = 0;
            this.btnAddFlightDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnAddFlightDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnAddFlightDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFlightDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlightDetails.ForeColor = System.Drawing.Color.White;
            this.btnAddFlightDetails.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAddFlightDetails.Location = new System.Drawing.Point(0, 0);
            this.btnAddFlightDetails.Name = "btnAddFlightDetails";
            this.btnAddFlightDetails.Size = new System.Drawing.Size(1066, 73);
            this.btnAddFlightDetails.TabIndex = 3;
            this.btnAddFlightDetails.Text = "Add details";
            this.btnAddFlightDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddFlightDetails.UseVisualStyleBackColor = false;
            this.btnAddFlightDetails.Click += new System.EventHandler(this.btnAddFlightDetails_Click);
            // 
            // panelCountryOfOrigin
            // 
            this.panelCountryOfOrigin.Controls.Add(this.lblCountryOfOrigin);
            this.panelCountryOfOrigin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCountryOfOrigin.Location = new System.Drawing.Point(0, 42);
            this.panelCountryOfOrigin.Name = "panelCountryOfOrigin";
            this.panelCountryOfOrigin.Size = new System.Drawing.Size(1066, 42);
            this.panelCountryOfOrigin.TabIndex = 1;
            // 
            // lblCountryOfOrigin
            // 
            this.lblCountryOfOrigin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountryOfOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryOfOrigin.ForeColor = System.Drawing.Color.White;
            this.lblCountryOfOrigin.Location = new System.Drawing.Point(0, 0);
            this.lblCountryOfOrigin.Name = "lblCountryOfOrigin";
            this.lblCountryOfOrigin.Size = new System.Drawing.Size(1066, 42);
            this.lblCountryOfOrigin.TabIndex = 1;
            this.lblCountryOfOrigin.Text = "Origin country";
            this.lblCountryOfOrigin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFlightId
            // 
            this.panelFlightId.Controls.Add(this.lblFlightId);
            this.panelFlightId.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFlightId.Location = new System.Drawing.Point(0, 0);
            this.panelFlightId.Name = "panelFlightId";
            this.panelFlightId.Size = new System.Drawing.Size(1066, 42);
            this.panelFlightId.TabIndex = 0;
            // 
            // lblFlightId
            // 
            this.lblFlightId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFlightId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightId.ForeColor = System.Drawing.Color.White;
            this.lblFlightId.Location = new System.Drawing.Point(0, 0);
            this.lblFlightId.Name = "lblFlightId";
            this.lblFlightId.Size = new System.Drawing.Size(1066, 42);
            this.lblFlightId.TabIndex = 0;
            this.lblFlightId.Text = "Id";
            this.lblFlightId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlightsEmpty
            // 
            this.lblFlightsEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFlightsEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.lblFlightsEmpty.ForeColor = System.Drawing.Color.White;
            this.lblFlightsEmpty.Location = new System.Drawing.Point(0, 0);
            this.lblFlightsEmpty.Name = "lblFlightsEmpty";
            this.lblFlightsEmpty.Size = new System.Drawing.Size(1066, 570);
            this.lblFlightsEmpty.TabIndex = 20;
            this.lblFlightsEmpty.Text = "You haven\'t choosen the country for which to gather the flights.";
            this.lblFlightsEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFlightsEmpty.Visible = false;
            // 
            // Flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1066, 570);
            this.ControlBox = false;
            this.Controls.Add(this.panelAddDetails);
            this.Controls.Add(this.lblFlightsEmpty);
            this.Controls.Add(this.dataGridViewFlights);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Flights";
            this.ShowIcon = false;
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.Flights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            this.panelAddDetails.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfPassangers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.btnContainer.ResumeLayout(false);
            this.btnContainer.PerformLayout();
            this.panelCountryOfOrigin.ResumeLayout(false);
            this.panelFlightId.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFlights;
        private System.Windows.Forms.DataGridViewTextBoxColumn VMflightId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VMicao24;
        private System.Windows.Forms.DataGridViewTextBoxColumn VMcallSign;
        private System.Windows.Forms.DataGridViewTextBoxColumn VMoriginCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn VMvelocity;
        private System.Windows.Forms.DataGridViewTextBoxColumn VMverticalRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn VMsquawk;
        private System.Windows.Forms.DataGridViewImageColumn addFlightDetails;
        private System.Windows.Forms.Panel panelAddDetails;
        private System.Windows.Forms.Panel panelCountryOfOrigin;
        private System.Windows.Forms.Label lblCountryOfOrigin;
        private System.Windows.Forms.Panel panelFlightId;
        private System.Windows.Forms.Label lblFlightId;
        private System.Windows.Forms.Panel btnContainer;
        private System.Windows.Forms.Button btnAddFlightDetails;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblFlightDuration;
        private System.Windows.Forms.ComboBox comboBoxCountries;
        private System.Windows.Forms.Label lblDestinationCountry;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label lblNumOfPassangers;
        private System.Windows.Forms.NumericUpDown numericUpDownNumOfPassangers;
        private System.Windows.Forms.TextBox textBoxNewCountry;
        private System.Windows.Forms.Button buttonBackToComboBox;
        private System.Windows.Forms.Label lblErrorHours;
        private System.Windows.Forms.Label lblErrorDestinationCountry;
        private System.Windows.Forms.Label lblErrorNumOfPassangers;
        private System.Windows.Forms.Label lblErrorFlightPrice;
        private System.Windows.Forms.Label lblErrorMinutes;
        private System.Windows.Forms.Label lblFlightsEmpty;
    }
}