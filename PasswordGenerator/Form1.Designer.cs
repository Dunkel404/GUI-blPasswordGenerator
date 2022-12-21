namespace PasswordGenerator
{
    partial class RandomPassGenerator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SymbolsCheck = new System.Windows.Forms.CheckBox();
            this.NumericCheck = new System.Windows.Forms.CheckBox();
            this.LowerCheck = new System.Windows.Forms.CheckBox();
            this.UpperCheck = new System.Windows.Forms.CheckBox();
            this.OutputTxt = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LengthTxt = new System.Windows.Forms.TextBox();
            this.QuantityTxt = new System.Windows.Forms.TextBox();
            this.GenBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 60);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SymbolsCheck);
            this.groupBox1.Controls.Add(this.NumericCheck);
            this.groupBox1.Controls.Add(this.LowerCheck);
            this.groupBox1.Controls.Add(this.UpperCheck);
            this.groupBox1.Controls.Add(this.OutputTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LengthTxt);
            this.groupBox1.Controls.Add(this.QuantityTxt);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 461);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PassGen";
            // 
            // SymbolsCheck
            // 
            this.SymbolsCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SymbolsCheck.AutoSize = true;
            this.SymbolsCheck.Checked = true;
            this.SymbolsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SymbolsCheck.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SymbolsCheck.Location = new System.Drawing.Point(473, 429);
            this.SymbolsCheck.Name = "SymbolsCheck";
            this.SymbolsCheck.Size = new System.Drawing.Size(69, 26);
            this.SymbolsCheck.TabIndex = 9;
            this.SymbolsCheck.Text = "#@!";
            this.SymbolsCheck.UseVisualStyleBackColor = true;
            // 
            // NumericCheck
            // 
            this.NumericCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericCheck.AutoSize = true;
            this.NumericCheck.Checked = true;
            this.NumericCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NumericCheck.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumericCheck.Location = new System.Drawing.Point(473, 396);
            this.NumericCheck.Name = "NumericCheck";
            this.NumericCheck.Size = new System.Drawing.Size(64, 26);
            this.NumericCheck.TabIndex = 8;
            this.NumericCheck.Text = "0-9";
            this.NumericCheck.UseVisualStyleBackColor = true;
            // 
            // LowerCheck
            // 
            this.LowerCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LowerCheck.AutoSize = true;
            this.LowerCheck.Checked = true;
            this.LowerCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LowerCheck.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LowerCheck.Location = new System.Drawing.Point(473, 363);
            this.LowerCheck.Name = "LowerCheck";
            this.LowerCheck.Size = new System.Drawing.Size(61, 26);
            this.LowerCheck.TabIndex = 7;
            this.LowerCheck.Text = "a-z";
            this.LowerCheck.UseVisualStyleBackColor = true;
            // 
            // UpperCheck
            // 
            this.UpperCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpperCheck.AutoSize = true;
            this.UpperCheck.Checked = true;
            this.UpperCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UpperCheck.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpperCheck.Location = new System.Drawing.Point(473, 330);
            this.UpperCheck.Name = "UpperCheck";
            this.UpperCheck.Size = new System.Drawing.Size(64, 26);
            this.UpperCheck.TabIndex = 6;
            this.UpperCheck.Text = "A-Z";
            this.UpperCheck.UseVisualStyleBackColor = true;
            // 
            // OutputTxt
            // 
            this.OutputTxt.AcceptsTab = true;
            this.OutputTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.OutputTxt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputTxt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.OutputTxt.Location = new System.Drawing.Point(8, 104);
            this.OutputTxt.Name = "OutputTxt";
            this.OutputTxt.ReadOnly = true;
            this.OutputTxt.Size = new System.Drawing.Size(465, 351);
            this.OutputTxt.TabIndex = 5;
            this.OutputTxt.Text = "Nothing to show";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Length: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantity: ";
            // 
            // LengthTxt
            // 
            this.LengthTxt.Location = new System.Drawing.Point(81, 67);
            this.LengthTxt.Name = "LengthTxt";
            this.LengthTxt.Size = new System.Drawing.Size(156, 31);
            this.LengthTxt.TabIndex = 1;
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.Location = new System.Drawing.Point(97, 30);
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.Size = new System.Drawing.Size(63, 31);
            this.QuantityTxt.TabIndex = 0;
            // 
            // GenBtn
            // 
            this.GenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.GenBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenBtn.Location = new System.Drawing.Point(150, 551);
            this.GenBtn.Name = "GenBtn";
            this.GenBtn.Size = new System.Drawing.Size(230, 31);
            this.GenBtn.TabIndex = 2;
            this.GenBtn.Text = "Generate";
            this.GenBtn.UseVisualStyleBackColor = false;
            this.GenBtn.Click += new System.EventHandler(this.GenBtn_Click);
            // 
            // RandomPassGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(572, 591);
            this.Controls.Add(this.GenBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "RandomPassGenerator";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox LengthTxt;
        private TextBox QuantityTxt;
        private Button GenBtn;
        private RichTextBox OutputTxt;
        private CheckBox SymbolsCheck;
        private CheckBox NumericCheck;
        private CheckBox LowerCheck;
        private CheckBox UpperCheck;
    }
}