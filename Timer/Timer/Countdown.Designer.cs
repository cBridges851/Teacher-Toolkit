namespace Timer
{
    partial class Countdown
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
            this.progressBarCountdown = new System.Windows.Forms.ProgressBar();
            this.textBoxNameOfCountdown = new System.Windows.Forms.TextBox();
            this.labelTimeOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBarCountdown
            // 
            this.progressBarCountdown.ForeColor = System.Drawing.Color.DarkMagenta;
            this.progressBarCountdown.Location = new System.Drawing.Point(12, 180);
            this.progressBarCountdown.Name = "progressBarCountdown";
            this.progressBarCountdown.Size = new System.Drawing.Size(776, 37);
            this.progressBarCountdown.TabIndex = 0;
            this.progressBarCountdown.Value = 100;
            // 
            // textBoxNameOfCountdown
            // 
            this.textBoxNameOfCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameOfCountdown.Location = new System.Drawing.Point(287, 12);
            this.textBoxNameOfCountdown.Name = "textBoxNameOfCountdown";
            this.textBoxNameOfCountdown.Size = new System.Drawing.Size(208, 29);
            this.textBoxNameOfCountdown.TabIndex = 1;
            this.textBoxNameOfCountdown.Text = "Countdown 1";
            this.textBoxNameOfCountdown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTimeOutput
            // 
            this.labelTimeOutput.AutoSize = true;
            this.labelTimeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeOutput.Location = new System.Drawing.Point(276, 61);
            this.labelTimeOutput.Name = "labelTimeOutput";
            this.labelTimeOutput.Size = new System.Drawing.Size(231, 108);
            this.labelTimeOutput.TabIndex = 2;
            this.labelTimeOutput.Text = "0:00";
            // 
            // Countdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 231);
            this.Controls.Add(this.labelTimeOutput);
            this.Controls.Add(this.textBoxNameOfCountdown);
            this.Controls.Add(this.progressBarCountdown);
            this.Name = "Countdown";
            this.Text = "Countdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarCountdown;
        private System.Windows.Forms.TextBox textBoxNameOfCountdown;
        private System.Windows.Forms.Label labelTimeOutput;
    }
}