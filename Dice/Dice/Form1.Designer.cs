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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiceOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiceTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDiceThree)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(356, 461);
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
            this.textBoxDiceOne.Size = new System.Drawing.Size(97, 20);
            this.textBoxDiceOne.TabIndex = 1;
            // 
            // textBoxDiceTwo
            // 
            this.textBoxDiceTwo.Location = new System.Drawing.Point(365, 383);
            this.textBoxDiceTwo.Name = "textBoxDiceTwo";
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
            this.buttonBack.Location = new System.Drawing.Point(861, 22);
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
            this.textBoxDiceThree.Size = new System.Drawing.Size(100, 20);
            this.textBoxDiceThree.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of dice";
            // 
            // radioButtonDiceOne
            // 
            this.radioButtonDiceOne.AutoSize = true;
            this.radioButtonDiceOne.Location = new System.Drawing.Point(157, 57);
            this.radioButtonDiceOne.Name = "radioButtonDiceOne";
            this.radioButtonDiceOne.Size = new System.Drawing.Size(31, 17);
            this.radioButtonDiceOne.TabIndex = 9;
            this.radioButtonDiceOne.TabStop = true;
            this.radioButtonDiceOne.Text = "1";
            this.radioButtonDiceOne.UseVisualStyleBackColor = true;
            this.radioButtonDiceOne.CheckedChanged += new System.EventHandler(this.radioButtonDiceOne_CheckedChanged);
            // 
            // radioButtonDiceTwo
            // 
            this.radioButtonDiceTwo.AutoSize = true;
            this.radioButtonDiceTwo.Location = new System.Drawing.Point(212, 57);
            this.radioButtonDiceTwo.Name = "radioButtonDiceTwo";
            this.radioButtonDiceTwo.Size = new System.Drawing.Size(31, 17);
            this.radioButtonDiceTwo.TabIndex = 10;
            this.radioButtonDiceTwo.TabStop = true;
            this.radioButtonDiceTwo.Text = "2";
            this.radioButtonDiceTwo.UseVisualStyleBackColor = true;
            this.radioButtonDiceTwo.CheckedChanged += new System.EventHandler(this.radioButtonDiceTwo_CheckedChanged);
            // 
            // radioButtonDiceThree
            // 
            this.radioButtonDiceThree.AutoSize = true;
            this.radioButtonDiceThree.Location = new System.Drawing.Point(269, 57);
            this.radioButtonDiceThree.Name = "radioButtonDiceThree";
            this.radioButtonDiceThree.Size = new System.Drawing.Size(31, 17);
            this.radioButtonDiceThree.TabIndex = 11;
            this.radioButtonDiceThree.TabStop = true;
            this.radioButtonDiceThree.Text = "3";
            this.radioButtonDiceThree.UseVisualStyleBackColor = true;
            this.radioButtonDiceThree.CheckedChanged += new System.EventHandler(this.radioButtonDiceThree_CheckedChanged);
            // 
            // Dice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(953, 620);
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
    }
}

