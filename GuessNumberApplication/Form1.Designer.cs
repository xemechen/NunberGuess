namespace GuessNumberApplication
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CheckNumber = new System.Windows.Forms.Button();
            this.NumberGuessed = new System.Windows.Forms.Label();
            this.ABcheckLabel = new System.Windows.Forms.Label();
            this.CurrentGuessingNumber = new System.Windows.Forms.Label();
            this.GuessingLabel = new System.Windows.Forms.Label();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.AutoRun = new System.Windows.Forms.Button();
            this.Giveup = new System.Windows.Forms.Button();
            this.newGuess = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ResetGuess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckNumber
            // 
            this.CheckNumber.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckNumber.Location = new System.Drawing.Point(372, 39);
            this.CheckNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckNumber.Name = "CheckNumber";
            this.CheckNumber.Size = new System.Drawing.Size(76, 65);
            this.CheckNumber.TabIndex = 27;
            this.CheckNumber.Text = "GO";
            this.CheckNumber.UseVisualStyleBackColor = true;
            this.CheckNumber.Click += new System.EventHandler(this.CheckNumber_Click);
            // 
            // NumberGuessed
            // 
            this.NumberGuessed.BackColor = System.Drawing.Color.Beige;
            this.NumberGuessed.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberGuessed.Location = new System.Drawing.Point(191, 127);
            this.NumberGuessed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NumberGuessed.Name = "NumberGuessed";
            this.NumberGuessed.Size = new System.Drawing.Size(137, 604);
            this.NumberGuessed.TabIndex = 26;
            this.NumberGuessed.Text = "0000";
            this.NumberGuessed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NumberGuessed.Click += new System.EventHandler(this.NumberGuessed_Click);
            // 
            // ABcheckLabel
            // 
            this.ABcheckLabel.BackColor = System.Drawing.Color.Beige;
            this.ABcheckLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABcheckLabel.Location = new System.Drawing.Point(53, 127);
            this.ABcheckLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ABcheckLabel.Name = "ABcheckLabel";
            this.ABcheckLabel.Size = new System.Drawing.Size(152, 604);
            this.ABcheckLabel.TabIndex = 25;
            this.ABcheckLabel.Text = "1.    XAXB";
            this.ABcheckLabel.Click += new System.EventHandler(this.ABcheckLabel_Click);
            // 
            // CurrentGuessingNumber
            // 
            this.CurrentGuessingNumber.BackColor = System.Drawing.Color.LightGreen;
            this.CurrentGuessingNumber.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentGuessingNumber.Location = new System.Drawing.Point(53, 39);
            this.CurrentGuessingNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentGuessingNumber.Name = "CurrentGuessingNumber";
            this.CurrentGuessingNumber.Size = new System.Drawing.Size(275, 65);
            this.CurrentGuessingNumber.TabIndex = 24;
            this.CurrentGuessingNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentGuessingNumber.Click += new System.EventHandler(this.CurrentGuessingNumber_Click);
            // 
            // GuessingLabel
            // 
            this.GuessingLabel.BackColor = System.Drawing.Color.LightGreen;
            this.GuessingLabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessingLabel.Location = new System.Drawing.Point(455, 39);
            this.GuessingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GuessingLabel.Name = "GuessingLabel";
            this.GuessingLabel.Size = new System.Drawing.Size(213, 65);
            this.GuessingLabel.TabIndex = 23;
            this.GuessingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GuessingLabel.Click += new System.EventHandler(this.GuessingLabel_Click);
            // 
            // InputBox
            // 
            this.InputBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputBox.Location = new System.Drawing.Point(455, 127);
            this.InputBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputBox.MaxLength = 4;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(212, 32);
            this.InputBox.TabIndex = 22;
            this.InputBox.Text = "Input N here";
            this.InputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // AutoRun
            // 
            this.AutoRun.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoRun.Location = new System.Drawing.Point(477, 670);
            this.AutoRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AutoRun.Name = "AutoRun";
            this.AutoRun.Size = new System.Drawing.Size(193, 61);
            this.AutoRun.TabIndex = 21;
            this.AutoRun.Text = "Auto Run";
            this.AutoRun.UseVisualStyleBackColor = true;
            this.AutoRun.Click += new System.EventHandler(this.AutoRun_Click);
            // 
            // Giveup
            // 
            this.Giveup.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Giveup.Location = new System.Drawing.Point(477, 559);
            this.Giveup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Giveup.Name = "Giveup";
            this.Giveup.Size = new System.Drawing.Size(193, 61);
            this.Giveup.TabIndex = 20;
            this.Giveup.Text = "Give Up";
            this.Giveup.UseVisualStyleBackColor = true;
            this.Giveup.Click += new System.EventHandler(this.Giveup_Click);
            // 
            // newGuess
            // 
            this.newGuess.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGuess.Location = new System.Drawing.Point(477, 489);
            this.newGuess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newGuess.Name = "newGuess";
            this.newGuess.Size = new System.Drawing.Size(193, 61);
            this.newGuess.TabIndex = 19;
            this.newGuess.Text = "New Guess";
            this.newGuess.UseVisualStyleBackColor = true;
            this.newGuess.Click += new System.EventHandler(this.newGuess_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(604, 364);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(66, 68);
            this.button9.TabIndex = 18;
            this.button9.Text = "3";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(604, 286);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(66, 68);
            this.button6.TabIndex = 17;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(604, 208);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 68);
            this.button3.TabIndex = 16;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(529, 364);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(66, 68);
            this.button8.TabIndex = 15;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(529, 286);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 68);
            this.button5.TabIndex = 14;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(529, 208);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 68);
            this.button2.TabIndex = 13;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(455, 364);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(66, 68);
            this.button7.TabIndex = 11;
            this.button7.Text = "1";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(455, 286);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 68);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(455, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 68);
            this.button1.TabIndex = 10;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ResetGuess
            // 
            this.ResetGuess.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetGuess.Location = new System.Drawing.Point(677, 127);
            this.ResetGuess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResetGuess.Name = "ResetGuess";
            this.ResetGuess.Size = new System.Drawing.Size(40, 46);
            this.ResetGuess.TabIndex = 28;
            this.ResetGuess.Text = "C";
            this.ResetGuess.UseVisualStyleBackColor = true;
            this.ResetGuess.Click += new System.EventHandler(this.ResetGuess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 779);
            this.Controls.Add(this.ResetGuess);
            this.Controls.Add(this.CheckNumber);
            this.Controls.Add(this.NumberGuessed);
            this.Controls.Add(this.ABcheckLabel);
            this.Controls.Add(this.CurrentGuessingNumber);
            this.Controls.Add(this.GuessingLabel);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.AutoRun);
            this.Controls.Add(this.Giveup);
            this.Controls.Add(this.newGuess);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Guess the Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckNumber;
        private System.Windows.Forms.Label NumberGuessed;
        private System.Windows.Forms.Label ABcheckLabel;
        private System.Windows.Forms.Label CurrentGuessingNumber;
        private System.Windows.Forms.Label GuessingLabel;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button AutoRun;
        private System.Windows.Forms.Button Giveup;
        private System.Windows.Forms.Button newGuess;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ResetGuess;
    }
}

