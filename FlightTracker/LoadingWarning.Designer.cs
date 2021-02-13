namespace FlightTracker
{
    partial class LoadingWarning
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
            this.lblGathering = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGathering
            // 
            this.lblGathering.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGathering.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGathering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGathering.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblGathering.ForeColor = System.Drawing.Color.White;
            this.lblGathering.Location = new System.Drawing.Point(0, 0);
            this.lblGathering.Name = "lblGathering";
            this.lblGathering.Size = new System.Drawing.Size(313, 165);
            this.lblGathering.TabIndex = 3;
            this.lblGathering.Text = "Gathering flights..";
            this.lblGathering.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadingWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(313, 165);
            this.Controls.Add(this.lblGathering);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingWarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoadingWarning";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblGathering;
    }
}