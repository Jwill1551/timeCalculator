namespace timeCalc
{
    partial class timeCalc
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.Label();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.enterBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(245, 72);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(236, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Enter in a value below: ";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(101, 231);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(102, 25);
            this.secondsLabel.TabIndex = 1;
            this.secondsLabel.Text = "Seconds:";
            // 
            // outputBox
            // 
            this.outputBox.AutoSize = true;
            this.outputBox.Location = new System.Drawing.Point(121, 348);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(82, 25);
            this.outputBox.TabIndex = 2;
            this.outputBox.Text = "Output:";
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(238, 231);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(100, 31);
            this.secondsTextBox.TabIndex = 3;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(238, 348);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(100, 31);
            this.outputTextBox.TabIndex = 4;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(592, 631);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(137, 60);
            this.enterBtn.TabIndex = 5;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(12, 631);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(137, 60);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(303, 631);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(137, 60);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // timeCalc
            // 
            this.ClientSize = new System.Drawing.Size(741, 703);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "timeCalc";
            this.Text = "Time Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox hourBox;
        private System.Windows.Forms.Label spaceLabel1;
        private System.Windows.Forms.TextBox minuteBox;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondsInputBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox daysBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label outputBox;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}

