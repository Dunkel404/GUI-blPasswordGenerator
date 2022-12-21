using System.Security.Cryptography;
using System.Buffers.Text;
using System.Text;
using System.Reflection.Metadata.Ecma335;

namespace PasswordGenerator
{
    public partial class RandomPassGenerator : Form
    {
        static RandomNumberGenerator servProvider = RandomNumberGenerator.Create();

        int PassQuantity, PassLength = 0;

        string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string LowerCase = "abcdefghijklmnopqrstuvwxyz";
        string AlphaNumeric = "0123456789";
        string SpecialCharacters = "!@#$%^&*()-_=+<,>.";
        string FinalString = "";

        private static char GenerateChar(string availableChars)
        {
            var byteArr = new byte[1];
            char ch;
            do
            {
                servProvider.GetBytes(byteArr);
                ch = (char)byteArr[0];

            } while (!availableChars.Any(x => x == ch));

            return ch;
        }


        public RandomPassGenerator()
        {

            InitializeComponent();
            VerifyBools();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void VerifyBools()
        {
            bool lowerIsUsed = LowerCheck.Checked;
            bool upperIsUsed = UpperCheck.Checked;
            bool numericIsUsed = NumericCheck.Checked;
            bool symbolIsUsed = SymbolsCheck.Checked;

            
            if (symbolIsUsed)
            {
                FinalString = FinalString.Replace(SpecialCharacters, string.Empty);
                FinalString += SpecialCharacters;
            }
            else
                FinalString = FinalString.Replace(SpecialCharacters, string.Empty);
            if (numericIsUsed)
            {
                FinalString = FinalString.Replace(AlphaNumeric, string.Empty);
                FinalString += AlphaNumeric;
            }
            else
                FinalString = FinalString.Replace(AlphaNumeric, string.Empty);
            if (upperIsUsed)
            {
                FinalString = FinalString.Replace(UpperCase, string.Empty);
                FinalString += UpperCase;
            }
            else
                FinalString = FinalString.Replace(UpperCase, string.Empty);
            if (lowerIsUsed)
            {
                FinalString = FinalString.Replace(LowerCase, string.Empty);
                FinalString += LowerCase;
            }
            else
                FinalString = FinalString.Replace(LowerCase, string.Empty);
            if (!symbolIsUsed && !numericIsUsed && !upperIsUsed && !lowerIsUsed)
            {
                FinalString = null;
            }
        }

        private void Checkers_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void GenBtn_Click(object sender, EventArgs e)
        {
            VerifyBools();

            if (FinalString != null)
            {
                if (QuantityTxt.Text == null || LengthTxt.Text == null)
                {
                    OutputTxt.Clear();
                    OutputTxt.SelectionColor = Color.Red;
                    OutputTxt.SelectedText = "Invalid input";
                }
                else
                {
                    PassQuantity = int.Parse(QuantityTxt.Text);
                    PassLength = int.Parse(LengthTxt.Text);
                }

                
                string[] AllPasses = new string[PassQuantity];


                for (int i = 0; i < PassQuantity; i++)
                {
                    StringBuilder strBuilder = new StringBuilder();
                    for (int n = 0; n < PassLength; n++)
                    {
                        strBuilder = strBuilder.Append(GenerateChar(FinalString));
                    }

                    AllPasses[i] = strBuilder.ToString();
                }

                OutputTxt.Clear();
                OutputTxt.SelectionColor = Color.Red;
                OutputTxt.SelectedText = "Generated passwords: \r\n\r\n";
                int PassCount = 0;
                foreach (string Pass in AllPasses)
                {
                    PassCount++;
                    byte[] strPass = Encoding.UTF8.GetBytes(Pass);
                    string toB64 = System.Convert.ToBase64String(strPass);

                    OutputTxt.SelectionColor = Color.Green;
                    OutputTxt.SelectedText = $" Pass {PassCount}: ";
                    OutputTxt.SelectionColor = Color.OrangeRed;
                    OutputTxt.SelectedText = Pass + "\r\n";
                    OutputTxt.SelectionColor = Color.DarkOliveGreen;
                    OutputTxt.SelectedText = $" Base64Pass {PassCount}: ";
                    OutputTxt.SelectionColor = Color.OrangeRed;
                    OutputTxt.SelectedText = toB64 + "\r\n\r\n";
                }
            } else
            {
                    OutputTxt.Clear();
                    OutputTxt.SelectionColor = Color.Red;
                    OutputTxt.SelectedText = "Select Char types to use";
            }
            
        }
    }
}