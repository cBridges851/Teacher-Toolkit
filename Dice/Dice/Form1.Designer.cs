namespace Dice
{
    partial class Dice
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxDiceOne = new System.Windows.Forms.TextBox();
            this.textBoxDiceTwo = new System.Windows.Forms.TextBox();
            this.pictureBoxDiceOne = new System.Windows.Forms.PictureBox();
            this.pictureBoxDiceTwo = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxDiceThree = new System.Windows.Forms.PictureBox();
            this.textBoxDiceThree = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonDiceOne = new System.Windows.Forms.RadioButton();
            this.radioButtonDiceTwo = new System.Windows.Forms.RadioButton();
            this.radioButtonDiceThree = new System.Windows.Forms.RadioButton();
            this.textBoxLastRollThree = new System.Windows.Forms.TextBox();
            this.textBoxLastRollTwo = new System.Windows.Forms.TextBox();
            this.textBoxLastRollOne = new System.Windows.Forms.TextBox();
            this.currentRollTwoLabel = new System.Windows.Forms.Label();
            this.currentRollThreeLabel = new System.Windows.Forms.Label();
            this.currentRollOneLabel = new System.Windows.Forms.Label();
            this.lastRollOneLabel = new System.Windows.Forms.Label();
            this.lastRollTwoLabel = new System.Windows.Forms.Label();
            this.lastRollThreeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiceOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiceTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiceThree)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(354, 461);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(121, 33);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBoxDiceOne
            // 
            this.textBoxDiceOne.Location = new System.Drawing.Point(91, 383);
            this.textBoxDiceOne.Name = "textBoxDiceOne";
            this.textBoxDiceOne.ReadOnly = true;
            this.textBoxDiceOne.Size = new System.Drawing.Size(97, 20);
            this.textBoxDiceOne.TabIndex = 1;
            // 
            // textBoxDiceTwo
            // 
            this.textBoxDiceTwo.Location = new System.Drawing.Point(365, 383);
            this.textBoxDiceTwo.Name = "textBoxDiceTwo";
            this.textBoxDiceTwo.ReadOnly = true;
            this.textBoxDiceTwo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiceTwo.TabIndex = 2;
            // 
            // pictureBoxDiceOne
            // 
            this.pictureBoxDiceOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDiceOne.Location = new System.Drawing.Point(27, 107);
            this.pictureBoxDiceOne.Name = "pictureBoxDiceOne";
            this.pictureBoxDiceOne.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxDiceOne.TabIndex = 3;
            this.pictureBoxDiceOne.TabStop = false;
            // 
            // pictureBoxDiceTwo
            // 
            this.pictureBoxDiceTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDiceTwo.Location = new System.Drawing.Point(289, 107);
            this.pictureBoxDiceTwo.Name = "pictureBoxDiceTwo";
            this.pictureBoxDiceTwo.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxDiceTwo.TabIndex = 4;
            this.pictureBoxDiceTwo.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(732, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // pictureBoxDiceThree
            // 
            this.pictureBoxDiceThree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDiceThree.Location = new System.Drawing.Point(551, 107);
            this.pictureBoxDiceThree.Name = "pictureBoxDiceThree";
            this.pictureBoxDiceThree.Size = new System.Drawing.Size(256, 256);
            this.pictureBoxDiceThree.TabIndex = 6;
            this.pictureBoxDiceThree.TabStop = false;
            // 
            // textBoxDiceThree
            // 
            this.textBoxDiceThree.Location = new System.Drawing.Point(633, 383);
            this.textBoxDiceThree.Name = "textBoxDiceThree";
            this.textBoxDiceThree.ReadOnly = true;
            this.textBoxDiceThree.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiceThree.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of dice";
            // 
            // radioButtonDiceOne
            // 
            this.radioButtonDiceOne.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDiceOne.Location = new System.Drawing.Point(123, 40);
            this.radioButtonDiceOne.Name = "radioButtonDiceOne";
            this.radioButtonDiceOne.Size = new System.Drawing.Size(65, 40);
            this.radioButtonDiceOne.TabIndex = 9;
            this.radioButtonDiceOne.TabStop = true;
            this.radioButtonDiceOne.Text = "       1";
            this.radioButtonDiceOne.UseVisualStyleBackColor = true;
            this.radioButtonDiceOne.CheckedChanged += new System.EventHandler(this.radioButtonDiceOne_CheckedChanged);
            // 
            // radioButtonDiceTwo
            // 
            this.radioButtonDiceTwo.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDiceTwo.Location = new System.Drawing.Point(207, 40);
            this.radioButtonDiceTwo.Name = "radioButtonDiceTwo";
            this.radioButtonDiceTwo.Size = new System.Drawing.Size(65, 40);
            this.radioButtonDiceTwo.TabIndex = 10;
            this.radioButtonDiceTwo.TabStop = true;
            this.radioButtonDiceTwo.Text = "       2";
            this.radioButtonDiceTwo.UseVisualStyleBackColor = true;
            this.radioButtonDiceTwo.CheckedChanged += new System.EventHandler(this.radioButtonDiceTwo_CheckedChanged);
            // 
            // radioButtonDiceThree
            // 
            this.radioButtonDiceThree.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonDiceThree.BackColor = System.Drawing.Color.Red;
            this.radioButtonDiceThree.Location = new System.Drawing.Point(289, 40);
            this.radioButtonDiceThree.Name = "radioButtonDiceThree";
            this.radioButtonDiceThree.Size = new System.Drawing.Size(65, 40);
            this.radioButtonDiceThree.TabIndex = 11;
            this.radioButtonDiceThree.TabStop = true;
            this.radioButtonDiceThree.Text = "       3";
            this.radioButtonDiceThree.UseVisualStyleBackColor = false;
            this.radioButtonDiceThree.CheckedChanged += new System.EventHandler(this.radioButtonDiceThree_CheckedChanged);
            // 
            // textBoxLastRollThree
            // 
            this.textBoxLastRollThree.Location = new System.Drawing.Point(633, 423);
            this.textBoxLastRollThree.Name = "textBoxLastRollThree";
            this.textBoxLastRollThree.ReadOnly = true;
            this.textBoxLastRollThree.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastRollThree.TabIndex = 12;
            // 
            // textBoxLastRollTwo
            // 
            this.textBoxLastRollTwo.Location = new System.Drawing.Point(365, 423);
            this.textBoxLastRollTwo.Name = "textBoxLastRollTwo";
            this.textBoxLastRollTwo.ReadOnly = true;
            this.textBoxLastRollTwo.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastRollTwo.TabIndex = 13;
            // 
            // textBoxLastRollOne
            // 
            this.textBoxLastRollOne.Location = new System.Drawing.Point(94, 423);
            this.textBoxLastRollOne.Name = "textBoxLastRollOne";
            this.textBoxLastRollOne.ReadOnly = true;
            this.textBoxLastRollOne.Size = new System.Drawing.Size(97, 20);
            this.textBoxLastRollOne.TabIndex = 14;
            // 
            // currentRollTwoLabel
            // 
            this.currentRollTwoLabel.Location = new System.Drawing.Point(362, 366);
            this.currentRollTwoLabel.Name = "currentRollTwoLabel";
            this.currentRollTwoLabel.Size = new System.Drawing.Size(103, 14);
            this.currentRollTwoLabel.TabIndex = 15;
            this.currentRollTwoLabel.Text = "Current Roll:";
            this.currentRollTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentRollThreeLabel
            // 
            this.currentRollThreeLabel.Location = new System.Drawing.Point(630, 366);
            this.currentRollThreeLabel.Name = "currentRollThreeLabel";
            this.currentRollThreeLabel.Size = new System.Drawing.Size(103, 14);
            this.currentRollThreeLabel.TabIndex = 16;
            this.currentRollThreeLabel.Text = "Current Roll:";
            this.currentRollThreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentRollOneLabel
            // 
            this.currentRollOneLabel.Location = new System.Drawing.Point(91, 366);
            this.currentRollOneLabel.Name = "currentRollOneLabel";
            this.currentRollOneLabel.Size = new System.Drawing.Size(97, 14);
            this.currentRollOneLabel.TabIndex = 17;
            this.currentRollOneLabel.Text = "Current Roll:";
            this.currentRollOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastRollOneLabel
            // 
            this.lastRollOneLabel.Location = new System.Drawing.Point(91, 406);
            this.lastRollOneLabel.Name = "lastRollOneLabel";
            this.lastRollOneLabel.Size = new System.Drawing.Size(97, 14);
            this.lastRollOneLabel.TabIndex = 18;
            this.lastRollOneLabel.Text = "Last Roll:";
            this.lastRollOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastRollTwoLabel
            // 
            this.lastRollTwoLabel.Location = new System.Drawing.Point(362, 406);
            this.lastRollTwoLabel.Name = "lastRollTwoLabel";
            this.lastRollTwoLabel.Size = new System.Drawing.Size(103, 14);
            this.lastRollTwoLabel.TabIndex = 19;
            this.lastRollTwoLabel.Text = "Last Roll:";
            this.lastRollTwoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastRollThreeLabel
            // 
            this.lastRollThreeLabel.Location = new System.Drawing.Point(630, 406);
            this.lastRollThreeLabel.Name = "lastRollThreeLabel";
            this.lastRollThreeLabel.Size = new System.Drawing.Size(103, 14);
            this.lastRollThreeLabel.TabIndex = 20;
            this.lastRollThreeLabel.Text = "Last Roll:";
            this.lastRollThreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Dice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 523);
            this.Controls.Add(this.lastRollThreeLabel);
            this.Controls.Add(this.lastRollTwoLabel);
            this.Controls.Add(this.lastRollOneLabel);
            this.Controls.Add(this.currentRollOneLabel);
            this.Controls.Add(this.currentRollThreeLabel);
            this.Controls.Add(this.currentRollTwoLabel);
            this.Controls.Add(this.textBoxLastRollOne);
            this.Controls.Add(this.textBoxLastRollTwo);
            this.Controls.Add(this.textBoxLastRollThree);
            this.Controls.Add(this.radioButtonDiceThree);
            this.Controls.Add(this.radioButtonDiceTwo);
            this.Controls.Add(this.radioButtonDiceOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDiceThree);
            this.Controls.Add(this.pictureBoxDiceThree);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxDiceTwo);
            this.Controls.Add(this.pictureBoxDiceOne);
            this.Controls.Add(this.textBoxDiceTwo);
            this.Controls.Add(this.textBoxDiceOne);
            this.Controls.Add(this.buttonStart);
            this.Name = "Dice";
            this.Text = "Dice";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiceOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiceTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiceThree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxDiceOne;
        private System.Windows.Forms.TextBox textBoxDiceTwo;
        private System.Windows.Forms.PictureBox pictureBoxDiceOne;
        private System.Windows.Forms.PictureBox pictureBoxDiceTwo;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxDiceThree;
        private System.Windows.Forms.TextBox textBoxDiceThree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonDiceOne;
        private System.Windows.Forms.RadioButton radioButtonDiceTwo;
        private System.Windows.Forms.RadioButton radioButtonDiceThree;
        private System.Windows.Forms.TextBox textBoxLastRollThree;
        private System.Windows.Forms.TextBox textBoxLastRollTwo;
        private System.Windows.Forms.TextBox textBoxLastRollOne;
        private System.Windows.Forms.Label currentRollTwoLabel;
        private System.Windows.Forms.Label currentRollThreeLabel;
        private System.Windows.Forms.Label currentRollOneLabel;
        private System.Windows.Forms.Label lastRollOneLabel;
        private System.Windows.Forms.Label lastRollTwoLabel;
        private System.Windows.Forms.Label lastRollThreeLabel;
    }
}

