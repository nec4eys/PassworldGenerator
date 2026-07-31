using System.Text;
using System.Windows.Forms;

namespace PassworldGenerator
{
    internal class Logic
    {
        private const string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string lowercase = "abcdefghijklmnopqrstuvwxyz";
        private const string numbersAl = "0123456789";
        private const string symbolsAl = "!\"#$%^&*()_+=;:',./?\\|`~[]{}";

        public static string GeneratePassworld(int passworldLength, bool upperCase, bool lowerCase, bool numbers, bool symbols)
        {
            Random random = new Random();

            StringBuilder al = new StringBuilder();

            if (upperCase)
            {
                al.Append(uppercase);
            }

            if (lowerCase)
            {
                al.Append(lowercase);
            }

            if (numbers)
            {
                al.Append(numbersAl);
            }

            if (symbols)
            {
                al.Append(symbolsAl);
            }

            if(!upperCase && !lowerCase && !numbers && !symbols)
            {
                al.Append(" ");
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < passworldLength; i++)
            {
                sb.Append(al[random.Next(0, al.Length)]);
            }

            return sb.ToString();
        }

        public static void CopyPassworldToClipboard(string passworld)
        {
            if (passworld == "" || passworld == " ") return;

            Clipboard.SetText(passworld);
        }
    }
}
