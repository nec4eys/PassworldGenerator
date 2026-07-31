namespace PassworldGenerator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uppercaseCheck = new CheckBox();
            passworldLength = new NumericUpDown();
            lowercaseCheck = new CheckBox();
            numbersCheck = new CheckBox();
            symbolsCheck = new CheckBox();
            resultText = new TextBox();
            copyButton = new Button();
            generateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)passworldLength).BeginInit();
            SuspendLayout();
            // 
            // uppercaseCheck
            // 
            uppercaseCheck.AutoSize = true;
            uppercaseCheck.Location = new Point(12, 41);
            uppercaseCheck.Name = "uppercaseCheck";
            uppercaseCheck.Size = new Size(119, 19);
            uppercaseCheck.TabIndex = 0;
            uppercaseCheck.Text = "Uppercase Letters";
            uppercaseCheck.UseVisualStyleBackColor = true;
            // 
            // passworldLength
            // 
            passworldLength.Location = new Point(12, 12);
            passworldLength.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            passworldLength.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            passworldLength.Name = "passworldLength";
            passworldLength.Size = new Size(120, 23);
            passworldLength.TabIndex = 1;
            passworldLength.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // lowercaseCheck
            // 
            lowercaseCheck.AutoSize = true;
            lowercaseCheck.Location = new Point(12, 66);
            lowercaseCheck.Name = "lowercaseCheck";
            lowercaseCheck.Size = new Size(119, 19);
            lowercaseCheck.TabIndex = 2;
            lowercaseCheck.Text = "Lowercase Letters";
            lowercaseCheck.UseVisualStyleBackColor = true;
            // 
            // numbersCheck
            // 
            numbersCheck.AutoSize = true;
            numbersCheck.Location = new Point(12, 91);
            numbersCheck.Name = "numbersCheck";
            numbersCheck.Size = new Size(75, 19);
            numbersCheck.TabIndex = 3;
            numbersCheck.Text = "Numbers";
            numbersCheck.UseVisualStyleBackColor = true;
            // 
            // symbolsCheck
            // 
            symbolsCheck.AutoSize = true;
            symbolsCheck.Location = new Point(12, 116);
            symbolsCheck.Name = "symbolsCheck";
            symbolsCheck.Size = new Size(71, 19);
            symbolsCheck.TabIndex = 4;
            symbolsCheck.Text = "Symbols";
            symbolsCheck.UseVisualStyleBackColor = true;
            // 
            // resultText
            // 
            resultText.Location = new Point(12, 141);
            resultText.Multiline = true;
            resultText.Name = "resultText";
            resultText.ReadOnly = true;
            resultText.Size = new Size(169, 107);
            resultText.TabIndex = 5;
            // 
            // copyButton
            // 
            copyButton.Location = new Point(106, 250);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(75, 23);
            copyButton.TabIndex = 6;
            copyButton.Text = "Copy";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += CopyText;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(12, 250);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(75, 23);
            generateButton.TabIndex = 7;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += GenerateText;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(189, 285);
            Controls.Add(generateButton);
            Controls.Add(copyButton);
            Controls.Add(resultText);
            Controls.Add(symbolsCheck);
            Controls.Add(numbersCheck);
            Controls.Add(lowercaseCheck);
            Controls.Add(passworldLength);
            Controls.Add(uppercaseCheck);
            Name = "MainForm";
            Text = "Generator";
            ((System.ComponentModel.ISupportInitialize)passworldLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox uppercaseCheck;
        private NumericUpDown passworldLength;
        private CheckBox lowercaseCheck;
        private CheckBox numbersCheck;
        private CheckBox symbolsCheck;
        private TextBox resultText;
        private Button copyButton;
        private Button generateButton;
    }
}
