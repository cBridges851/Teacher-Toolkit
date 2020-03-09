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
            this.components = new System.ComponentModel.Container();
            this.textBoxNameOfCountdown = new System.Windows.Forms.TextBox();
            this.labelTimeOutput = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonPauseResume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNameOfCountdown
            // 
            this.textBoxNameOfCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameOfCountdown.Location = new System.Drawing.Point(179, 12);
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
            this.labelTimeOutput.Location = new System.Drawing.Point(75, 44);
            this.labelTimeOutput.Name = "labelTimeOutput";
            this.labelTimeOutput.Size = new System.Drawing.Size(417, 108);
            this.labelTimeOutput.TabIndex = 2;
            this.labelTimeOutput.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // buttonPauseResume
            // 
            this.buttonPauseResume.BackColor = System.Drawing.Color.Red;
            this.buttonPauseResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPauseResume.Location = new System.Drawing.Point(217, 163);
            this.buttonPauseResume.Name = "buttonPauseResume";
            this.buttonPauseResume.Size = new System.Drawing.Size(114, 36);
            this.buttonPauseResume.TabIndex = 3;
            this.buttonPauseResume.Text = "Pause";
            this.buttonPauseResume.UseVisualStyleBackColor = false;
            this.buttonPauseResume.Click += new System.EventHandler(this.ButtonPauseResume_Click);
            // 
            // Countdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(549, 211);
            this.Controls.Add(this.buttonPauseResume);
            this.Controls.Add(this.labelTimeOutput);
            this.Controls.Add(this.textBoxNameOfCountdown);
            this.Name = "Countdown";
            this.Text = "Countdown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNameOfCountdown;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label labelTimeOutput;
        private System.Windows.Forms.Button buttonPauseResume;
    }
}