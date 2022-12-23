namespace PasswordGenerator
{
    partial class FormBody
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBody));
            this.NavBar = new System.Windows.Forms.Panel();
            this.DarkModeSwitch = new System.Windows.Forms.PictureBox();
            this.PassGenGroupBox = new System.Windows.Forms.GroupBox();
            this.StableLengthCheck = new System.Windows.Forms.CheckBox();
            this.IncludeSymbolsCheck = new System.Windows.Forms.CheckBox();
            this.IncludeNumericCheck = new System.Windows.Forms.CheckBox();
            this.IncludeLowerCheck = new System.Windows.Forms.CheckBox();
            this.IncludeUpperCheck = new System.Windows.Forms.CheckBox();
            this.OutputTxt = new System.Windows.Forms.RichTextBox();
            this.LengthTxt = new System.Windows.Forms.TextBox();
            this.QuantityTxt = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.Body = new System.Windows.Forms.Panel();
            this.NavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DarkModeSwitch)).BeginInit();
            this.PassGenGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavBar
            // 
            this.NavBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.NavBar.Controls.Add(this.DarkModeSwitch);
            this.NavBar.Location = new System.Drawing.Point(-1, 0);
            this.NavBar.Name = "NavBar";
            this.NavBar.Size = new System.Drawing.Size(572, 78);
            this.NavBar.TabIndex = 0;
            // 
            // DarkModeSwitch
            // 
            this.DarkModeSwitch.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.DarkModeSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DarkModeSwitch.Image = ((System.Drawing.Image)(resources.GetObject("DarkModeSwitch.Image")));
            this.DarkModeSwitch.InitialImage = null;
            this.DarkModeSwitch.Location = new System.Drawing.Point(521, 12);
            this.DarkModeSwitch.Name = "DarkModeSwitch";
            this.DarkModeSwitch.Size = new System.Drawing.Size(40, 36);
            this.DarkModeSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DarkModeSwitch.TabIndex = 0;
            this.DarkModeSwitch.TabStop = false;
            this.DarkModeSwitch.Click += new System.EventHandler(this.DarkModeSwitch_Click);
            // 
            // PassGenGroupBox
            // 
            this.PassGenGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassGenGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.PassGenGroupBox.Controls.Add(this.StableLengthCheck);
            this.PassGenGroupBox.Controls.Add(this.IncludeSymbolsCheck);
            this.PassGenGroupBox.Controls.Add(this.IncludeNumericCheck);
            this.PassGenGroupBox.Controls.Add(this.IncludeLowerCheck);
            this.PassGenGroupBox.Controls.Add(this.IncludeUpperCheck);
            this.PassGenGroupBox.Controls.Add(this.OutputTxt);
            this.PassGenGroupBox.Controls.Add(this.LengthTxt);
            this.PassGenGroupBox.Controls.Add(this.QuantityTxt);
            this.PassGenGroupBox.Controls.Add(this.LengthLabel);
            this.PassGenGroupBox.Controls.Add(this.QuantityLabel);
            this.PassGenGroupBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PassGenGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.PassGenGroupBox.Location = new System.Drawing.Point(12, 84);
            this.PassGenGroupBox.Name = "PassGenGroupBox";
            this.PassGenGroupBox.Size = new System.Drawing.Size(548, 461);
            this.PassGenGroupBox.TabIndex = 1;
            this.PassGenGroupBox.TabStop = false;
            this.PassGenGroupBox.Text = "PassGen";
            // 
            // StableLengthCheck
            // 
            this.StableLengthCheck.AutoSize = true;
            this.StableLengthCheck.Checked = true;
            this.StableLengthCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StableLengthCheck.Location = new System.Drawing.Point(241, 70);
            this.StableLengthCheck.Name = "StableLengthCheck";
            this.StableLengthCheck.Size = new System.Drawing.Size(172, 27);
            this.StableLengthCheck.TabIndex = 10;
            this.StableLengthCheck.Text = "stable length";
            this.StableLengthCheck.UseVisualStyleBackColor = true;
            this.StableLengthCheck.CheckedChanged += new System.EventHandler(this.StableLengthCheck_CheckedChanged);
            // 
            // IncludeSymbolsCheck
            // 
            this.IncludeSymbolsCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IncludeSymbolsCheck.AutoSize = true;
            this.IncludeSymbolsCheck.Checked = true;
            this.IncludeSymbolsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeSymbolsCheck.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IncludeSymbolsCheck.Location = new System.Drawing.Point(468, 421);
            this.IncludeSymbolsCheck.Name = "IncludeSymbolsCheck";
            this.IncludeSymbolsCheck.Size = new System.Drawing.Size(69, 26);
            this.IncludeSymbolsCheck.TabIndex = 9;
            this.IncludeSymbolsCheck.Text = "#@!";
            this.IncludeSymbolsCheck.UseVisualStyleBackColor = true;
            // 
            // IncludeNumericCheck
            // 
            this.IncludeNumericCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IncludeNumericCheck.AutoSize = true;
            this.IncludeNumericCheck.Checked = true;
            this.IncludeNumericCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeNumericCheck.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IncludeNumericCheck.Location = new System.Drawing.Point(468, 388);
            this.IncludeNumericCheck.Name = "IncludeNumericCheck";
            this.IncludeNumericCheck.Size = new System.Drawing.Size(64, 26);
            this.IncludeNumericCheck.TabIndex = 8;
            this.IncludeNumericCheck.Text = "0-9";
            this.IncludeNumericCheck.UseVisualStyleBackColor = true;
            // 
            // IncludeLowerCheck
            // 
            this.IncludeLowerCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IncludeLowerCheck.AutoSize = true;
            this.IncludeLowerCheck.Checked = true;
            this.IncludeLowerCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeLowerCheck.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IncludeLowerCheck.Location = new System.Drawing.Point(466, 324);
            this.IncludeLowerCheck.Name = "IncludeLowerCheck";
            this.IncludeLowerCheck.Size = new System.Drawing.Size(61, 26);
            this.IncludeLowerCheck.TabIndex = 7;
            this.IncludeLowerCheck.Text = "a-z";
            this.IncludeLowerCheck.UseVisualStyleBackColor = true;
            // 
            // IncludeUpperCheck
            // 
            this.IncludeUpperCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.IncludeUpperCheck.AutoSize = true;
            this.IncludeUpperCheck.Checked = true;
            this.IncludeUpperCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeUpperCheck.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IncludeUpperCheck.Location = new System.Drawing.Point(468, 356);
            this.IncludeUpperCheck.Name = "IncludeUpperCheck";
            this.IncludeUpperCheck.Size = new System.Drawing.Size(64, 26);
            this.IncludeUpperCheck.TabIndex = 6;
            this.IncludeUpperCheck.Text = "A-Z";
            this.IncludeUpperCheck.UseVisualStyleBackColor = true;
            // 
            // OutputTxt
            // 
            this.OutputTxt.AcceptsTab = true;
            this.OutputTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.OutputTxt.DetectUrls = false;
            this.OutputTxt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.OutputTxt.Location = new System.Drawing.Point(6, 104);
            this.OutputTxt.Name = "OutputTxt";
            this.OutputTxt.ReadOnly = true;
            this.OutputTxt.Size = new System.Drawing.Size(449, 351);
            this.OutputTxt.TabIndex = 5;
            this.OutputTxt.Text = "Nothing to show";
            // 
            // LengthTxt
            // 
            this.LengthTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.LengthTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.LengthTxt.Location = new System.Drawing.Point(79, 68);
            this.LengthTxt.Name = "LengthTxt";
            this.LengthTxt.Size = new System.Drawing.Size(156, 31);
            this.LengthTxt.TabIndex = 1;
            this.LengthTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNonNumbersInputs);
            // 
            // QuantityTxt
            // 
            this.QuantityTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.QuantityTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.QuantityTxt.Location = new System.Drawing.Point(82, 30);
            this.QuantityTxt.Name = "QuantityTxt";
            this.QuantityTxt.Size = new System.Drawing.Size(63, 31);
            this.QuantityTxt.TabIndex = 0;
            this.QuantityTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BlockNonNumbersInputs);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LengthLabel.Location = new System.Drawing.Point(12, 78);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(61, 14);
            this.LengthLabel.TabIndex = 4;
            this.LengthLabel.Text = "Length: ";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuantityLabel.Location = new System.Drawing.Point(8, 40);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(73, 14);
            this.QuantityLabel.TabIndex = 3;
            this.QuantityLabel.Text = "Quantity: ";
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(43)))));
            this.GenerateBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenerateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.GenerateBtn.Location = new System.Drawing.Point(150, 551);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(230, 31);
            this.GenerateBtn.TabIndex = 2;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = false;
            this.GenerateBtn.Click += new System.EventHandler(this.GenBtn_Click);
            // 
            // Body
            // 
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(0, 0);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(572, 591);
            this.Body.TabIndex = 3;
            // 
            // FormBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(572, 591);
            this.Controls.Add(this.PassGenGroupBox);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.NavBar);
            this.Controls.Add(this.Body);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBody";
            this.Text = "Password Generator";
            this.NavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DarkModeSwitch)).EndInit();
            this.PassGenGroupBox.ResumeLayout(false);
            this.PassGenGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel NavBar;
        private GroupBox PassGenGroupBox;
        private Label LengthLabel;
        private Label QuantityLabel;
        private TextBox LengthTxt;
        private TextBox QuantityTxt;
        private Button GenerateBtn;
        private RichTextBox OutputTxt;
        private CheckBox IncludeSymbolsCheck;
        private CheckBox IncludeNumericCheck;
        private CheckBox IncludeLowerCheck;
        private CheckBox IncludeUpperCheck;
        private PictureBox DarkModeSwitch;
        private Panel Body;
        private CheckBox StableLengthCheck;
    }
}