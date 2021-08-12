
namespace V_SemesterProject
{
    partial class WaitingForm
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
            this.loading_lb = new System.Windows.Forms.Label();
            this.WaitingText_lb = new System.Windows.Forms.Label();
            this.waitingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loading_lb
            // 
            this.loading_lb.Image = global::V_SemesterProject.Properties.Resources.Pulse_1s_200px;
            this.loading_lb.Location = new System.Drawing.Point(140, 38);
            this.loading_lb.Name = "loading_lb";
            this.loading_lb.Size = new System.Drawing.Size(211, 147);
            this.loading_lb.TabIndex = 0;
            // 
            // WaitingText_lb
            // 
            this.WaitingText_lb.AutoSize = true;
            this.WaitingText_lb.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaitingText_lb.ForeColor = System.Drawing.Color.Lavender;
            this.WaitingText_lb.Location = new System.Drawing.Point(119, 204);
            this.WaitingText_lb.Name = "WaitingText_lb";
            this.WaitingText_lb.Size = new System.Drawing.Size(0, 28);
            this.WaitingText_lb.TabIndex = 1;
            // 
            // waitingLabel
            // 
            this.waitingLabel.Font = new System.Drawing.Font("Bradley Hand ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingLabel.ForeColor = System.Drawing.Color.Yellow;
            this.waitingLabel.Location = new System.Drawing.Point(99, 218);
            this.waitingLabel.Name = "waitingLabel";
            this.waitingLabel.Size = new System.Drawing.Size(304, 26);
            this.waitingLabel.TabIndex = 2;
            this.waitingLabel.Text = "Loading";
            this.waitingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WaitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(503, 265);
            this.Controls.Add(this.waitingLabel);
            this.Controls.Add(this.WaitingText_lb);
            this.Controls.Add(this.loading_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "=====";
            this.Load += new System.EventHandler(this.LoadingProgressForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loading_lb;
        private System.Windows.Forms.Label WaitingText_lb;
        private System.Windows.Forms.Label waitingLabel;
    }
}