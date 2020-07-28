namespace CountdownApp
{
    partial class CountdownForm
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
            this.ConsonantButton = new System.Windows.Forms.Button();
            this.VowelButton = new System.Windows.Forms.Button();
            this.LettersTextbox = new System.Windows.Forms.TextBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.TimeLeftTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AnswerTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bestAnswerText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConsonantButton
            // 
            this.ConsonantButton.Location = new System.Drawing.Point(107, 152);
            this.ConsonantButton.Name = "ConsonantButton";
            this.ConsonantButton.Size = new System.Drawing.Size(99, 23);
            this.ConsonantButton.TabIndex = 0;
            this.ConsonantButton.Text = "Consonant";
            this.ConsonantButton.UseVisualStyleBackColor = true;
            this.ConsonantButton.Click += new System.EventHandler(this.ConsonantButton_Click);
            // 
            // VowelButton
            // 
            this.VowelButton.Location = new System.Drawing.Point(222, 152);
            this.VowelButton.Name = "VowelButton";
            this.VowelButton.Size = new System.Drawing.Size(87, 23);
            this.VowelButton.TabIndex = 1;
            this.VowelButton.Text = "Vowel";
            this.VowelButton.UseVisualStyleBackColor = true;
            this.VowelButton.Click += new System.EventHandler(this.VowelButton_Click);
            // 
            // LettersTextbox
            // 
            this.LettersTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LettersTextbox.Location = new System.Drawing.Point(87, 94);
            this.LettersTextbox.Multiline = true;
            this.LettersTextbox.Name = "LettersTextbox";
            this.LettersTextbox.ReadOnly = true;
            this.LettersTextbox.Size = new System.Drawing.Size(346, 42);
            this.LettersTextbox.TabIndex = 2;
            this.LettersTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(358, 152);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 3;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(508, 113);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(75, 23);
            this.RestartButton.TabIndex = 4;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // TimeLeftTextBox
            // 
            this.TimeLeftTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TimeLeftTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLeftTextBox.ForeColor = System.Drawing.Color.Red;
            this.TimeLeftTextBox.Location = new System.Drawing.Point(499, 13);
            this.TimeLeftTextBox.Multiline = true;
            this.TimeLeftTextBox.Name = "TimeLeftTextBox";
            this.TimeLeftTextBox.ReadOnly = true;
            this.TimeLeftTextBox.Size = new System.Drawing.Size(100, 27);
            this.TimeLeftTextBox.TabIndex = 5;
            this.TimeLeftTextBox.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time left";
            // 
            // AnswerTextbox
            // 
            this.AnswerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerTextbox.Location = new System.Drawing.Point(87, 209);
            this.AnswerTextbox.Multiline = true;
            this.AnswerTextbox.Name = "AnswerTextbox";
            this.AnswerTextbox.ReadOnly = true;
            this.AnswerTextbox.Size = new System.Drawing.Size(346, 113);
            this.AnswerTextbox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Answer";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Green;
            this.textBox2.Location = new System.Drawing.Point(87, 13);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(338, 68);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Select five consonants and three vowels and complete the longest word you can thi" +
    "nk of with these letters";
            // 
            // bestAnswerText
            // 
            this.bestAnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestAnswerText.Location = new System.Drawing.Point(158, 346);
            this.bestAnswerText.Multiline = true;
            this.bestAnswerText.Name = "bestAnswerText";
            this.bestAnswerText.ReadOnly = true;
            this.bestAnswerText.Size = new System.Drawing.Size(275, 28);
            this.bestAnswerText.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Best answer";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(456, 299);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(127, 23);
            this.submitButton.TabIndex = 12;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // CountdownForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 386);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bestAnswerText);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnswerTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLeftTextBox);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.LettersTextbox);
            this.Controls.Add(this.VowelButton);
            this.Controls.Add(this.ConsonantButton);
            this.Name = "CountdownForm";
            this.Text = "Countdown";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConsonantButton;
        private System.Windows.Forms.Button VowelButton;
        private System.Windows.Forms.TextBox LettersTextbox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.TextBox TimeLeftTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AnswerTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox bestAnswerText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitButton;
    }
}

