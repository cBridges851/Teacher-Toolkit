﻿namespace ProgressBarAlternate
{
    partial class IndividualProgress
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.domainUpDownLevel = new System.Windows.Forms.DomainUpDown();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createGroupProgressBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelError = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(59, 350);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(134, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // domainUpDownLevel
            // 
            this.domainUpDownLevel.Items.Add("Expert");
            this.domainUpDownLevel.Items.Add("Could teach someone else");
            this.domainUpDownLevel.Items.Add("Really confident");
            this.domainUpDownLevel.Items.Add("Getting there!");
            this.domainUpDownLevel.Items.Add("I am fairly confident I can understand this");
            this.domainUpDownLevel.Items.Add("I feel I could do an OK job");
            this.domainUpDownLevel.Items.Add("Novice");
            this.domainUpDownLevel.Location = new System.Drawing.Point(245, 350);
            this.domainUpDownLevel.Name = "domainUpDownLevel";
            this.domainUpDownLevel.Size = new System.Drawing.Size(260, 20);
            this.domainUpDownLevel.TabIndex = 1;
            this.domainUpDownLevel.Text = "Novice";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOutput.Location = new System.Drawing.Point(15, 36);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(490, 289);
            this.textBoxOutput.TabIndex = 2;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAddStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStudent.ForeColor = System.Drawing.SystemColors.Info;
            this.buttonAddStudent.Location = new System.Drawing.Point(214, 411);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(88, 38);
            this.buttonAddStudent.TabIndex = 3;
            this.buttonAddStudent.Text = "Add Student";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.ButtonAddStudent_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 353);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(41, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.createGroupProgressBarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGroupToolStripMenuItem,
            this.openGroupToolStripMenuItem,
            this.saveGroupToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGroupToolStripMenuItem
            // 
            this.newGroupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newGroupToolStripMenuItem.Name = "newGroupToolStripMenuItem";
            this.newGroupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newGroupToolStripMenuItem.Text = "New Group";
            this.newGroupToolStripMenuItem.Click += new System.EventHandler(this.NewGroupToolStripMenuItem_Click);
            // 
            // openGroupToolStripMenuItem
            // 
            this.openGroupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.openGroupToolStripMenuItem.Name = "openGroupToolStripMenuItem";
            this.openGroupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openGroupToolStripMenuItem.Text = "Open Group";
            // 
            // saveGroupToolStripMenuItem
            // 
            this.saveGroupToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.saveGroupToolStripMenuItem.Name = "saveGroupToolStripMenuItem";
            this.saveGroupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveGroupToolStripMenuItem.Text = "Save Group";
            // 
            // createGroupProgressBarToolStripMenuItem
            // 
            this.createGroupProgressBarToolStripMenuItem.Name = "createGroupProgressBarToolStripMenuItem";
            this.createGroupProgressBarToolStripMenuItem.Size = new System.Drawing.Size(157, 20);
            this.createGroupProgressBarToolStripMenuItem.Text = "Create Group Progress Bar";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.BackColor = System.Drawing.Color.Red;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(193, 383);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 18);
            this.labelError.TabIndex = 6;
            // 
            // IndividualProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(517, 460);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.domainUpDownLevel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IndividualProgress";
            this.Text = "Individual Progress";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DomainUpDown domainUpDownLevel;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createGroupProgressBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGroupToolStripMenuItem;
        private System.Windows.Forms.Label labelError;
    }
}

