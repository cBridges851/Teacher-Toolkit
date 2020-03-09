namespace Timer
{
    partial class TimeUpMessage
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
            this.labelTimeUp = new System.Windows.Forms.Label();
            this.buttonTimeUpClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTimeUp
            // 
            this.labelTimeUp.AutoSize = true;
            this.labelTimeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeUp.Location = new System.Drawing.Point(21, 65);
            this.labelTimeUp.Name = "labelTimeUp";
            this.labelTimeUp.Size = new System.Drawing.Size(364, 73);
            this.labelTimeUp.TabIndex = 0;
            this.labelTimeUp.Text = "TIME\'S UP!";
            // 
            // buttonTimeUpClose
            // 
            this.buttonTimeUpClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimeUpClose.Location = new System.Drawing.Point(156, 158);
            this.buttonTimeUpClose.Name = "buttonTimeUpClose";
            this.buttonTimeUpClose.Size = new System.Drawing.Size(90, 41);
            this.buttonTimeUpClose.TabIndex = 1;
            this.buttonTimeUpClose.Text = "Close";
            this.buttonTimeUpClose.UseVisualStyleBackColor = true;
            this.buttonTimeUpClose.Click += new System.EventHandler(this.ButtonTimeUpClose_Click);
            // 
            // TimeUpMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 245);
            this.Controls.Add(this.buttonTimeUpClose);
            this.Controls.Add(this.labelTimeUp);
            this.Name = "TimeUpMessage";
            this.Text = "Time\'s Up!";
            this.Load += new System.EventHandler(this.TimeUpMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTimeUp;
        private System.Windows.Forms.Button buttonTimeUpClose;
    }
}