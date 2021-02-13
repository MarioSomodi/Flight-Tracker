namespace FlightTracker
{
    partial class Positions
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
            this.dataGridViewPositions = new System.Windows.Forms.DataGridView();
            this.positionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baroAltitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onGround = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trueTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geoAltitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEmptyList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPositions
            // 
            this.dataGridViewPositions.AllowUserToAddRows = false;
            this.dataGridViewPositions.AllowUserToDeleteRows = false;
            this.dataGridViewPositions.AllowUserToResizeColumns = false;
            this.dataGridViewPositions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPositions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPositions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPositions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPositions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dataGridViewPositions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPositions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPositions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionId,
            this.longitude,
            this.latitude,
            this.baroAltitude,
            this.onGround,
            this.trueTrack,
            this.geoAltitude,
            this.positionSource});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPositions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPositions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPositions.EnableHeadersVisualStyles = false;
            this.dataGridViewPositions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.dataGridViewPositions.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPositions.Name = "dataGridViewPositions";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPositions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPositions.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(74)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPositions.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewPositions.Size = new System.Drawing.Size(1050, 531);
            this.dataGridViewPositions.TabIndex = 3;
            // 
            // positionId
            // 
            this.positionId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.positionId.DataPropertyName = "positionId";
            this.positionId.HeaderText = "Flight Id";
            this.positionId.Name = "positionId";
            this.positionId.ReadOnly = true;
            // 
            // longitude
            // 
            this.longitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.longitude.DataPropertyName = "longitude";
            this.longitude.HeaderText = "Longitude";
            this.longitude.Name = "longitude";
            this.longitude.ReadOnly = true;
            // 
            // latitude
            // 
            this.latitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.latitude.DataPropertyName = "latitude";
            this.latitude.HeaderText = "Latitude";
            this.latitude.Name = "latitude";
            this.latitude.ReadOnly = true;
            // 
            // baroAltitude
            // 
            this.baroAltitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.baroAltitude.DataPropertyName = "baroAltitude";
            this.baroAltitude.HeaderText = "Barometric altitude";
            this.baroAltitude.Name = "baroAltitude";
            this.baroAltitude.ReadOnly = true;
            // 
            // onGround
            // 
            this.onGround.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.onGround.DataPropertyName = "onGround";
            this.onGround.HeaderText = "On ground";
            this.onGround.Name = "onGround";
            this.onGround.ReadOnly = true;
            // 
            // trueTrack
            // 
            this.trueTrack.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.trueTrack.DataPropertyName = "trueTrack";
            this.trueTrack.HeaderText = "True track";
            this.trueTrack.Name = "trueTrack";
            this.trueTrack.ReadOnly = true;
            // 
            // geoAltitude
            // 
            this.geoAltitude.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.geoAltitude.DataPropertyName = "geoAltitude";
            this.geoAltitude.HeaderText = "Geometric altitude";
            this.geoAltitude.Name = "geoAltitude";
            this.geoAltitude.ReadOnly = true;
            // 
            // positionSource
            // 
            this.positionSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.positionSource.DataPropertyName = "positionSource";
            this.positionSource.HeaderText = "Position source";
            this.positionSource.Name = "positionSource";
            this.positionSource.ReadOnly = true;
            // 
            // lblEmptyList
            // 
            this.lblEmptyList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmptyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblEmptyList.ForeColor = System.Drawing.Color.White;
            this.lblEmptyList.Location = new System.Drawing.Point(0, 0);
            this.lblEmptyList.Name = "lblEmptyList";
            this.lblEmptyList.Size = new System.Drawing.Size(1050, 531);
            this.lblEmptyList.TabIndex = 14;
            this.lblEmptyList.Text = "You haven\'t choosen the country to gather the flights for, so there are no positi" +
    "ons aswell";
            this.lblEmptyList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmptyList.Visible = false;
            // 
            // Positions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1050, 531);
            this.ControlBox = false;
            this.Controls.Add(this.lblEmptyList);
            this.Controls.Add(this.dataGridViewPositions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Positions";
            this.ShowIcon = false;
            this.Text = "Positions";
            this.Load += new System.EventHandler(this.Positions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPositions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPositions;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn baroAltitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn onGround;
        private System.Windows.Forms.DataGridViewTextBoxColumn trueTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn geoAltitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionSource;
        private System.Windows.Forms.Label lblEmptyList;
    }
}