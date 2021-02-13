namespace FlightTracker
{
    partial class Countries
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
            this.btnSelectCountries = new System.Windows.Forms.Button();
            this.btnRefreshCountries = new System.Windows.Forms.Button();
            this.btnContainer = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.textBoxSearchCountries = new System.Windows.Forms.TextBox();
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.CountryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectCountry = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnContainer.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectCountries
            // 
            this.btnSelectCountries.AutoSize = true;
            this.btnSelectCountries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnSelectCountries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectCountries.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelectCountries.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSelectCountries.FlatAppearance.BorderSize = 0;
            this.btnSelectCountries.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnSelectCountries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnSelectCountries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCountries.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCountries.ForeColor = System.Drawing.Color.White;
            this.btnSelectCountries.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSelectCountries.Location = new System.Drawing.Point(533, 0);
            this.btnSelectCountries.Name = "btnSelectCountries";
            this.btnSelectCountries.Size = new System.Drawing.Size(533, 73);
            this.btnSelectCountries.TabIndex = 2;
            this.btnSelectCountries.Text = "Select countries";
            this.btnSelectCountries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectCountries.UseVisualStyleBackColor = false;
            this.btnSelectCountries.Click += new System.EventHandler(this.btnSelectCountries_Click);
            // 
            // btnRefreshCountries
            // 
            this.btnRefreshCountries.AutoSize = true;
            this.btnRefreshCountries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnRefreshCountries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshCountries.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefreshCountries.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRefreshCountries.FlatAppearance.BorderSize = 0;
            this.btnRefreshCountries.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnRefreshCountries.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnRefreshCountries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshCountries.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCountries.ForeColor = System.Drawing.Color.White;
            this.btnRefreshCountries.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnRefreshCountries.Location = new System.Drawing.Point(0, 0);
            this.btnRefreshCountries.Name = "btnRefreshCountries";
            this.btnRefreshCountries.Size = new System.Drawing.Size(533, 73);
            this.btnRefreshCountries.TabIndex = 3;
            this.btnRefreshCountries.Text = "Refresh countries";
            this.btnRefreshCountries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshCountries.UseVisualStyleBackColor = false;
            this.btnRefreshCountries.Click += new System.EventHandler(this.btnRefreshCountries_Click);
            // 
            // btnContainer
            // 
            this.btnContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            this.btnContainer.Controls.Add(this.btnRefreshCountries);
            this.btnContainer.Controls.Add(this.btnSelectCountries);
            this.btnContainer.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnContainer.Location = new System.Drawing.Point(0, 497);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(1066, 73);
            this.btnContainer.TabIndex = 5;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.searchLabel);
            this.panelSearch.Controls.Add(this.textBoxSearchCountries);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(1066, 63);
            this.panelSearch.TabIndex = 6;
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(343, 6);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(359, 28);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search by country name";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxSearchCountries
            // 
            this.textBoxSearchCountries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchCountries.Location = new System.Drawing.Point(421, 37);
            this.textBoxSearchCountries.Name = "textBoxSearchCountries";
            this.textBoxSearchCountries.Size = new System.Drawing.Size(200, 20);
            this.textBoxSearchCountries.TabIndex = 0;
            this.textBoxSearchCountries.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxSearchCountries_KeyUp);
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.AllowUserToAddRows = false;
            this.dataGridViewCountries.AllowUserToDeleteRows = false;
            this.dataGridViewCountries.AllowUserToResizeColumns = false;
            this.dataGridViewCountries.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCountries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCountries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCountries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCountries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dataGridViewCountries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCountries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CountryId,
            this.CountryName,
            this.SelectCountry});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCountries.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCountries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCountries.EnableHeadersVisualStyles = false;
            this.dataGridViewCountries.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.dataGridViewCountries.Location = new System.Drawing.Point(0, 63);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCountries.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCountries.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCountries.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCountries.Size = new System.Drawing.Size(1066, 434);
            this.dataGridViewCountries.TabIndex = 7;
            this.dataGridViewCountries.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCountries_CellClick);
            this.dataGridViewCountries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCountries_CellContentClick);
            this.dataGridViewCountries.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCountries_CellValueChanged);
            // 
            // CountryId
            // 
            this.CountryId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CountryId.DataPropertyName = "CountryId";
            this.CountryId.FillWeight = 18F;
            this.CountryId.HeaderText = "Id";
            this.CountryId.Name = "CountryId";
            this.CountryId.ReadOnly = true;
            // 
            // CountryName
            // 
            this.CountryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CountryName.DataPropertyName = "CountryName";
            this.CountryName.HeaderText = "Name";
            this.CountryName.Name = "CountryName";
            this.CountryName.ReadOnly = true;
            // 
            // SelectCountry
            // 
            this.SelectCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SelectCountry.DataPropertyName = "lolol";
            this.SelectCountry.FalseValue = "false";
            this.SelectCountry.FillWeight = 18F;
            this.SelectCountry.HeaderText = "Select country";
            this.SelectCountry.IndeterminateValue = "false";
            this.SelectCountry.Name = "SelectCountry";
            this.SelectCountry.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SelectCountry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SelectCountry.TrueValue = "true";
            // 
            // Countries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1066, 570);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewCountries);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.btnContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Countries";
            this.ShowIcon = false;
            this.Text = "Countries";
            this.Load += new System.EventHandler(this.Countries_Load);
            this.btnContainer.ResumeLayout(false);
            this.btnContainer.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectCountries;
        private System.Windows.Forms.Button btnRefreshCountries;
        private System.Windows.Forms.Panel btnContainer;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox textBoxSearchCountries;
        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountryName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCountry;
        private System.Windows.Forms.Label searchLabel;
    }
}