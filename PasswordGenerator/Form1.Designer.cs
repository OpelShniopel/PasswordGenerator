namespace PasswordGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            checkBoxUpperCase = new CheckBox();
            checkBoxLowerCase = new CheckBox();
            checkBoxNumbers = new CheckBox();
            checkBoxSpecialChar = new CheckBox();
            textBoxGeneratedPassword = new TextBox();
            trackBarPasswordLength = new TrackBar();
            buttonGeneratePassword = new Button();
            checkBoxAvoidAmbiguousCharacters = new CheckBox();
            numericUpDownMinNumbers = new NumericUpDown();
            numericUpDownMinSpecial = new NumericUpDown();
            labelMinNumbers = new Label();
            labelMinSpecial = new Label();
            labelPasswordLength = new Label();
            numericUpDownPasswordLength = new NumericUpDown();
            buttonCopy = new Button();
            checkBoxExcludeDuplicateCharacters = new CheckBox();
            checkBoxAllowOtherSymbols = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)trackBarPasswordLength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinNumbers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinSpecial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPasswordLength).BeginInit();
            SuspendLayout();
            // 
            // checkBoxUpperCase
            // 
            checkBoxUpperCase.AutoSize = true;
            checkBoxUpperCase.Checked = true;
            checkBoxUpperCase.CheckState = CheckState.Checked;
            checkBoxUpperCase.Location = new Point(32, 95);
            checkBoxUpperCase.Name = "checkBoxUpperCase";
            checkBoxUpperCase.Size = new Size(46, 19);
            checkBoxUpperCase.TabIndex = 0;
            checkBoxUpperCase.Text = "A-Z";
            checkBoxUpperCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxLowerCase
            // 
            checkBoxLowerCase.AutoSize = true;
            checkBoxLowerCase.Checked = true;
            checkBoxLowerCase.CheckState = CheckState.Checked;
            checkBoxLowerCase.Location = new Point(32, 120);
            checkBoxLowerCase.Name = "checkBoxLowerCase";
            checkBoxLowerCase.Size = new Size(42, 19);
            checkBoxLowerCase.TabIndex = 1;
            checkBoxLowerCase.Text = "a-z";
            checkBoxLowerCase.UseVisualStyleBackColor = true;
            // 
            // checkBoxNumbers
            // 
            checkBoxNumbers.AutoSize = true;
            checkBoxNumbers.Checked = true;
            checkBoxNumbers.CheckState = CheckState.Checked;
            checkBoxNumbers.Location = new Point(32, 145);
            checkBoxNumbers.Name = "checkBoxNumbers";
            checkBoxNumbers.Size = new Size(43, 19);
            checkBoxNumbers.TabIndex = 2;
            checkBoxNumbers.Text = "0-9";
            checkBoxNumbers.UseVisualStyleBackColor = true;
            // 
            // checkBoxSpecialChar
            // 
            checkBoxSpecialChar.AutoSize = true;
            checkBoxSpecialChar.Checked = true;
            checkBoxSpecialChar.CheckState = CheckState.Checked;
            checkBoxSpecialChar.Location = new Point(32, 170);
            checkBoxSpecialChar.Name = "checkBoxSpecialChar";
            checkBoxSpecialChar.Size = new Size(76, 19);
            checkBoxSpecialChar.TabIndex = 3;
            checkBoxSpecialChar.Text = "!@#$%^*";
            checkBoxSpecialChar.UseVisualStyleBackColor = true;
            // 
            // textBoxGeneratedPassword
            // 
            textBoxGeneratedPassword.Location = new Point(32, 12);
            textBoxGeneratedPassword.Name = "textBoxGeneratedPassword";
            textBoxGeneratedPassword.Size = new Size(209, 23);
            textBoxGeneratedPassword.TabIndex = 4;
            textBoxGeneratedPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // trackBarPasswordLength
            // 
            trackBarPasswordLength.Location = new Point(147, 41);
            trackBarPasswordLength.Maximum = 128;
            trackBarPasswordLength.Minimum = 5;
            trackBarPasswordLength.Name = "trackBarPasswordLength";
            trackBarPasswordLength.Size = new Size(256, 45);
            trackBarPasswordLength.TabIndex = 5;
            trackBarPasswordLength.Value = 16;
            trackBarPasswordLength.Scroll += trackBarPasswordLength_Scroll;
            // 
            // buttonGeneratePassword
            // 
            buttonGeneratePassword.Location = new Point(328, 12);
            buttonGeneratePassword.Name = "buttonGeneratePassword";
            buttonGeneratePassword.Size = new Size(75, 23);
            buttonGeneratePassword.TabIndex = 6;
            buttonGeneratePassword.Text = "Generate";
            buttonGeneratePassword.UseVisualStyleBackColor = true;
            buttonGeneratePassword.Click += buttonGeneratePassword_Click;
            // 
            // checkBoxAvoidAmbiguousCharacters
            // 
            checkBoxAvoidAmbiguousCharacters.AutoSize = true;
            checkBoxAvoidAmbiguousCharacters.Checked = true;
            checkBoxAvoidAmbiguousCharacters.CheckState = CheckState.Checked;
            checkBoxAvoidAmbiguousCharacters.Location = new Point(32, 268);
            checkBoxAvoidAmbiguousCharacters.Name = "checkBoxAvoidAmbiguousCharacters";
            checkBoxAvoidAmbiguousCharacters.Size = new Size(177, 19);
            checkBoxAvoidAmbiguousCharacters.TabIndex = 7;
            checkBoxAvoidAmbiguousCharacters.Text = "Avoid ambiguous characters";
            checkBoxAvoidAmbiguousCharacters.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMinNumbers
            // 
            numericUpDownMinNumbers.Location = new Point(147, 210);
            numericUpDownMinNumbers.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDownMinNumbers.Name = "numericUpDownMinNumbers";
            numericUpDownMinNumbers.Size = new Size(28, 23);
            numericUpDownMinNumbers.TabIndex = 8;
            numericUpDownMinNumbers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMinNumbers.ValueChanged += numericUpDownMinNumbers_ValueChanged;
            // 
            // numericUpDownMinSpecial
            // 
            numericUpDownMinSpecial.Location = new Point(147, 239);
            numericUpDownMinSpecial.Maximum = new decimal(new int[] { 9, 0, 0, 0 });
            numericUpDownMinSpecial.Name = "numericUpDownMinSpecial";
            numericUpDownMinSpecial.Size = new Size(29, 23);
            numericUpDownMinSpecial.TabIndex = 9;
            numericUpDownMinSpecial.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownMinSpecial.ValueChanged += numericUpDownMinSpecial_ValueChanged;
            // 
            // labelMinNumbers
            // 
            labelMinNumbers.AutoSize = true;
            labelMinNumbers.Location = new Point(30, 212);
            labelMinNumbers.Name = "labelMinNumbers";
            labelMinNumbers.Size = new Size(110, 15);
            labelMinNumbers.TabIndex = 10;
            labelMinNumbers.Text = "Minimum numbers";
            // 
            // labelMinSpecial
            // 
            labelMinSpecial.AutoSize = true;
            labelMinSpecial.Location = new Point(30, 241);
            labelMinSpecial.Name = "labelMinSpecial";
            labelMinSpecial.Size = new Size(99, 15);
            labelMinSpecial.TabIndex = 11;
            labelMinSpecial.Text = "Minimum special";
            // 
            // labelPasswordLength
            // 
            labelPasswordLength.AutoSize = true;
            labelPasswordLength.Location = new Point(30, 41);
            labelPasswordLength.Name = "labelPasswordLength";
            labelPasswordLength.Size = new Size(44, 15);
            labelPasswordLength.TabIndex = 12;
            labelPasswordLength.Text = "Length";
            // 
            // numericUpDownPasswordLength
            // 
            numericUpDownPasswordLength.Location = new Point(92, 41);
            numericUpDownPasswordLength.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            numericUpDownPasswordLength.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownPasswordLength.Name = "numericUpDownPasswordLength";
            numericUpDownPasswordLength.Size = new Size(38, 23);
            numericUpDownPasswordLength.TabIndex = 13;
            numericUpDownPasswordLength.Value = new decimal(new int[] { 16, 0, 0, 0 });
            numericUpDownPasswordLength.ValueChanged += numericUpDownPasswordLength_ValueChanged;
            // 
            // buttonCopy
            // 
            buttonCopy.Location = new Point(247, 12);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(75, 23);
            buttonCopy.TabIndex = 14;
            buttonCopy.Text = "Copy";
            buttonCopy.UseVisualStyleBackColor = true;
            buttonCopy.Click += buttonCopy_Click;
            // 
            // checkBoxExcludeDuplicateCharacters
            // 
            checkBoxExcludeDuplicateCharacters.AutoSize = true;
            checkBoxExcludeDuplicateCharacters.Location = new Point(158, 92);
            checkBoxExcludeDuplicateCharacters.Name = "checkBoxExcludeDuplicateCharacters";
            checkBoxExcludeDuplicateCharacters.Size = new Size(176, 19);
            checkBoxExcludeDuplicateCharacters.TabIndex = 15;
            checkBoxExcludeDuplicateCharacters.Text = "Exclude duplicate characters";
            checkBoxExcludeDuplicateCharacters.UseVisualStyleBackColor = true;
            // 
            // checkBoxAllowOtherSymbols
            // 
            checkBoxAllowOtherSymbols.AutoSize = true;
            checkBoxAllowOtherSymbols.Location = new Point(158, 117);
            checkBoxAllowOtherSymbols.Name = "checkBoxAllowOtherSymbols";
            checkBoxAllowOtherSymbols.Size = new Size(191, 19);
            checkBoxAllowOtherSymbols.TabIndex = 16;
            checkBoxAllowOtherSymbols.Text = "Allow other symbols (~`[];?,()+)";
            checkBoxAllowOtherSymbols.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(430, 304);
            Controls.Add(checkBoxAllowOtherSymbols);
            Controls.Add(checkBoxExcludeDuplicateCharacters);
            Controls.Add(buttonCopy);
            Controls.Add(numericUpDownPasswordLength);
            Controls.Add(labelPasswordLength);
            Controls.Add(labelMinSpecial);
            Controls.Add(labelMinNumbers);
            Controls.Add(numericUpDownMinSpecial);
            Controls.Add(numericUpDownMinNumbers);
            Controls.Add(checkBoxAvoidAmbiguousCharacters);
            Controls.Add(buttonGeneratePassword);
            Controls.Add(trackBarPasswordLength);
            Controls.Add(textBoxGeneratedPassword);
            Controls.Add(checkBoxSpecialChar);
            Controls.Add(checkBoxNumbers);
            Controls.Add(checkBoxLowerCase);
            Controls.Add(checkBoxUpperCase);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "PassGen V3";
            ((System.ComponentModel.ISupportInitialize)trackBarPasswordLength).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinNumbers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinSpecial).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPasswordLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxUpperCase;
        private CheckBox checkBoxLowerCase;
        private CheckBox checkBoxNumbers;
        private CheckBox checkBoxSpecialChar;
        private TextBox textBoxGeneratedPassword;
        private TrackBar trackBarPasswordLength;
        private Button buttonGeneratePassword;
        private CheckBox checkBoxAvoidAmbiguousCharacters;
        private NumericUpDown numericUpDownMinNumbers;
        private NumericUpDown numericUpDownMinSpecial;
        private Label labelMinNumbers;
        private Label labelMinSpecial;
        private Label labelPasswordLength;
        private NumericUpDown numericUpDownPasswordLength;
        private Button buttonCopy;
        private CheckBox checkBoxExcludeDuplicateCharacters;
        private CheckBox checkBoxAllowOtherSymbols;
    }
}