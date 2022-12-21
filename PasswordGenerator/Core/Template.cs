using System.Text;

namespace PasswordGenerator.Core
{
    public static class Template
    {
        // Constants with the available character sets
        private const string AvailableLowerCaseCharacters = "abcdefghijklmnopqrstuvwxyz";
        private const string AvailableUpperCaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string AvailableNumericCharacters = "0123456789";
        private const string AvailableSpecialCharacters = "!@#$%^&*()-_=+<,>.";

        // Property with the list of available characters
        public static string AvailableCharacters { get; private set; }

        /// <summary>
        /// Updates the list of available characters according to the options selected by the user
        /// </summary>
        /// <param name="includeLowerCharacters">Indicates whether lowercase characters should be included in the list</param>
        /// <param name="includeUpperCharacters">Indicates whether uppercase characters should be included in the list</param>
        /// <param name="includeNumericCharacters">Indicates whether numeric characters should be included in the list</param>
        /// <param name="includeSymbolsCharacters">Indicates whether special characters should be included in the list</param>

        private static void UpdateAvailableCharacters(CheckBox IncludeLowerCharacters,
            CheckBox IncludeUpperCharacters, CheckBox IncludeNumericCharacters, CheckBox IncludeSymbolsCharacters)
        {
            var availableCharaceters = new StringBuilder();

            if (IncludeLowerCharacters.Checked)
                availableCharaceters.Append(AvailableLowerCaseCharacters);

            if (IncludeUpperCharacters.Checked)
                availableCharaceters.Append(AvailableUpperCaseCharacters);

            if (IncludeNumericCharacters.Checked)
                availableCharaceters.Append(AvailableNumericCharacters);

            if (IncludeSymbolsCharacters.Checked)
                availableCharaceters.Append(AvailableSpecialCharacters);

            Template.AvailableCharacters = availableCharaceters.ToString();
        }

        // Initializes the Template class with the character options selected by the user
        public static void Initialize(CheckBox IncludeLowerCharacters,
            CheckBox IncludeUpperCharacters, CheckBox IncludeNumericCharacters, CheckBox IncludeSymbolsCharacters)
        {
            UpdateAvailableCharacters(IncludeLowerCharacters, IncludeUpperCharacters, IncludeNumericCharacters, IncludeSymbolsCharacters);
        }
    }
}
