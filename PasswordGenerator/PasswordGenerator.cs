using PasswordGenerator.Core;
using System.Text;

namespace PasswordGenerator
{
    public partial class FormBody : Form
    {
        public FormBody()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            Template.Initialize(IncludeLowerCheck, IncludeUpperCheck, IncludeNumericCheck, IncludeSymbolsCheck);
        }

        static readonly Random servProvider = new();
        bool isDarkModeEnabled = true;
        int PassQuantity, PassLength = 1;

        /// <summary>
        /// Generates a random character from the specified set of available characters.
        /// </summary>
        /// <param name="availableCharacters">The set of characters to choose from.</param>
        /// <returns>A random character from the specified set of available characters.</returns>

        private static char GenerateRandomCharacter(string availableCharacters)
        {
            int index = servProvider.Next(availableCharacters.Length);
            return availableCharacters[index];
        }


        /// <summary>
        /// Toggles the current state of the dark mode switch.
        /// </summary>
        private void ToggleDarkMode()
        {
            // If dark mode is currently disabled, enable it. Otherwise, disable it.
            isDarkModeEnabled = !isDarkModeEnabled;
        }

        /// <summary>
        /// Applies the current form theme based on the state of the dark mode switch.
        /// </summary>
        private void ApplyFormTheme()
        {
            // Update the colors of the form based on the current state of the dark mode switch.
            BlColors.UpdateState(isDarkModeEnabled);

            // Set the component background color based on the current color scheme.
            NavBar.BackColor = BlColors.NavBarBackColor;
            PassGenGroupBox.BackColor = BlColors.FormBackColor;
            OutputTxt.BackColor = BlColors.LabelBackColor;
            GenerateBtn.BackColor = BlColors.GenButtonBackColor;
            Body.BackColor = BlColors.FormBackColor;
            QuantityTxt.BackColor = BlColors.LabelBackColor;
            LengthTxt.BackColor = BlColors.LabelBackColor;

            // Set the text color based on the current color scheme.
            PassGenGroupBox.ForeColor = BlColors.FormForeColor;
            OutputTxt.ForeColor = BlColors.LabelForeColor;
            GenerateBtn.ForeColor = BlColors.FormForeColor;
            Body.ForeColor = BlColors.FormForeColor;
            QuantityTxt.ForeColor = BlColors.LabelForeColor;
            LengthTxt.ForeColor = BlColors.LabelForeColor;
        }

        /// <summary>
        /// Blocks any non-number key presses, while allowing the backspace key to be pressed.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="keyPressEventArgs">The event arguments.</param>
        private void BlockNonNumbersInputs(object sender, KeyPressEventArgs keyPressEventArgs)
        {
            // Block any non-number key presses. Allow backspace key to be pressed.
            if (!char.IsDigit(keyPressEventArgs.KeyChar) && (keyPressEventArgs.KeyChar != '\b'))
                keyPressEventArgs.Handled = true;
        }

        /// <summary>
        /// Toggles the dark mode and applies the appropriate form theme when the dark mode switch is clicked.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void DarkModeSwitch_Click(object sender, EventArgs e)
        {

            // Toggle the dark mode switch.
            ToggleDarkMode();

            // Apply the appropriate form theme.
            ApplyFormTheme();

            // Get the path to the Resources directory.
            DirectoryInfo currentDirectoryPath = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent;
            string resourcesDirectoryPath = Path.Combine(currentDirectoryPath.FullName, "Resources");

            // Get the paths to the dark mode and inverse dark mode pictures.
            string darkModePicturePath = Path.Combine(resourcesDirectoryPath, "DarkModePicture.png");
            string inverseDarkModePicturePath = Path.Combine(resourcesDirectoryPath, "InverseDarkModePicture.png");
            Bitmap darkModePicture = new(darkModePicturePath);
            Bitmap iDMP = new(inverseDarkModePicturePath);

            // Set the dark mode switch image based on the current state of the dark mode switch.
            DarkModeSwitch.Image = isDarkModeEnabled ? iDMP : darkModePicture;
        }

        /// <summary>
        /// Change the Length text label based on the stable length check
        /// </summary>
        private void StableLengthCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (!StableLengthCheck.Checked)
            {
                LengthTxt.Location = new System.Drawing.Point(79, 68);
                StableLengthCheck.Location = new System.Drawing.Point(241, 70);
                LengthLabel.Text = "Length:";
            }
            else
            {
                LengthTxt.Location = new System.Drawing.Point(100, 68);
                StableLengthCheck.Location = new System.Drawing.Point(262, 70);
                LengthLabel.Text = "MaxLength:";
            }
        }

        /// <summary>
        /// Generates and displays a specified number of passwords of a specified length specified by user, using a set of characters specified by the user.
        /// </summary>
        private void GenBtn_Click(object sender, EventArgs e)
        {
            // Initialize the template
            Template.Initialize(IncludeLowerCheck, IncludeUpperCheck, IncludeNumericCheck, IncludeSymbolsCheck);

            // Check if the template has any available characters
            if (Template.AvailableCharacters != string.Empty)
            {
                // Check if the quantity or length text boxes are null
                if (QuantityTxt.Text == string.Empty || LengthTxt.Text == string.Empty || QuantityTxt.Text == "0" || LengthTxt.Text == "0")
                {
                    // Clear the output text box and display an error message
                    OutputTxt.Clear();
                    OutputTxt.SelectionColor = Color.Red;
                    OutputTxt.SelectedText = "Invalid input";
                    return;
                }
                else
                {
                    // Parse the quantity and length values from the text boxes.
                    PassQuantity = int.Parse(QuantityTxt.Text);
                    PassLength = int.Parse(LengthTxt.Text);
                }

                // Create an array to hold all the generated passwords.
                string[] AllPasses = new string[PassQuantity];

                // Use a StringBuilder to generate the passwords.
                StringBuilder stringBuilder = new();
                Random randomLength = new();
                int unstableLength;
                for (int i = 0; i < PassQuantity; i++)
                {
                    stringBuilder.Clear();

                    if (StableLengthCheck.Checked)
                    {
                        for (int n = 0; n < PassLength; n++)
                        {
                            // Append a randomly generated character to the string builder.
                            stringBuilder.Append(GenerateRandomCharacter(Template.AvailableCharacters));
                        }
                    }
                    else
                    {
                        unstableLength = randomLength.Next(1, PassLength);
                        for (int n = 0; n < unstableLength; n++)
                        {

                            stringBuilder.Append(GenerateRandomCharacter(Template.AvailableCharacters));
                        }
                    }
                    // Add the generated password to the array.
                    AllPasses[i] = stringBuilder.ToString();
                }

                // Clear the output text box
                OutputTxt.Clear();

                // Display the generated passwords
                OutputTxt.SelectionColor = Color.Red;
                OutputTxt.SelectedText = "Generated passwords: \r\n\r\n";
                int PassCount = 0;
                foreach (string Pass in AllPasses)
                {
                    PassCount++;

                    // Convert the password to base64
                    byte[] strPass = Encoding.UTF8.GetBytes(Pass);
                    string toB64 = System.Convert.ToBase64String(strPass);

                    // Display the password and its base64 representation
                    OutputTxt.SelectionColor = Color.Green;
                    OutputTxt.SelectedText = $" Pass {PassCount}: ";
                    OutputTxt.SelectionColor = Color.OrangeRed;
                    OutputTxt.SelectedText = Pass + "\r\n";
                    OutputTxt.SelectionColor = Color.DarkGreen;
                    OutputTxt.SelectedText = $" Base64Pass {PassCount}: ";
                    OutputTxt.SelectionColor = Color.DarkRed;
                    OutputTxt.SelectedText = toB64 + "\r\n\r\n";
                }
            }
            else
            {
                // Clear the output text box and display an error message
                OutputTxt.Clear();
                OutputTxt.SelectionColor = Color.Red;
                OutputTxt.SelectedText = "Select Char types to use";
            }

        }
    }
}