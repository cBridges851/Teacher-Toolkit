namespace Toolkit_homepage
{
    partial class Form1
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
            this.buttonTimer = new System.Windows.Forms.Button();
            this.buttonDice = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonProgressBar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.otherToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopwatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBlooms = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTimer
            // 
            this.buttonTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTimer.Location = new System.Drawing.Point(36, 53);
            this.buttonTimer.Name = "buttonTimer";
            this.buttonTimer.Size = new System.Drawing.Size(132, 88);
            this.buttonTimer.TabIndex = 0;
            this.buttonTimer.Text = "Timer";
            this.buttonTimer.UseVisualStyleBackColor = true;
            // 
            // buttonDice
            // 
            this.buttonDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDice.Location = new System.Drawing.Point(227, 53);
            this.buttonDice.Name = "buttonDice";
            this.buttonDice.Size = new System.Drawing.Size(132, 88);
            this.buttonDice.TabIndex = 1;
            this.buttonDice.Text = "Dice";
            this.buttonDice.UseVisualStyleBackColor = true;
            // 
            // buttonReg
            // 
            this.buttonReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReg.Location = new System.Drawing.Point(416, 53);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(134, 88);
            this.buttonReg.TabIndex = 2;
            this.buttonReg.Text = "Register reminder";
            this.buttonReg.UseVisualStyleBackColor = true;
            // 
            // buttonProgressBar
            // 
            this.buttonProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProgressBar.Location = new System.Drawing.Point(608, 53);
            this.buttonProgressBar.Name = "buttonProgressBar";
            this.buttonProgressBar.Size = new System.Drawing.Size(128, 88);
            this.buttonProgressBar.TabIndex = 3;
            this.buttonProgressBar.Text = "Progress Bar";
            this.buttonProgressBar.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otherToolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // otherToolsToolStripMenuItem
            // 
            this.otherToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopwatchToolStripMenuItem});
            this.otherToolsToolStripMenuItem.Name = "otherToolsToolStripMenuItem";
            this.otherToolsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.otherToolsToolStripMenuItem.Text = "Other tools";
            // 
            // stopwatchToolStripMenuItem
            // 
            this.stopwatchToolStripMenuItem.Name = "stopwatchToolStripMenuItem";
            this.stopwatchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopwatchToolStripMenuItem.Text = "Stopwatch";
            // 
            // buttonBlooms
            // 
            this.buttonBlooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBlooms.Location = new System.Drawing.Point(223, 179);
            this.buttonBlooms.Name = "buttonBlooms";
            this.buttonBlooms.Size = new System.Drawing.Size(326, 117);
            this.buttonBlooms.TabIndex = 5;
            this.buttonBlooms.Text = "Blooms";
            this.buttonBlooms.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBlooms);
            this.Controls.Add(this.buttonProgressBar);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonDice);
            this.Controls.Add(this.buttonTimer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTimer;
        private System.Windows.Forms.Button buttonDice;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonProgressBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem otherToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopwatchToolStripMenuItem;
        private System.Windows.Forms.Button buttonBlooms;
    }
}

