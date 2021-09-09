using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            password = ValidPassowrd(password);
            Console.WriteLine(password);
        }

        static string ValidPassowrd(string password)
        {
            int countChar = 0;
            int countDigit = 0;
            int countSymbol = 0;
            for (int i = 0; i < password.Length; i++)
            {
                countChar++;
                if (char.IsDigit(password[i]))
                {
                    countDigit++;
                }
                if (!char.IsLetterOrDigit(password[i]))
                {
                    countSymbol++;
                }
            }
            password = string.Empty;
            if (countChar >= 6 && countChar <= 10 && countDigit >= 2 && countSymbol <= 0)
            {
                password = "Password is valid";
                return password;
            }
            if (countChar < 6 || countChar > 10)
            {
                password += "Password must be between 6 and 10 characters";
            }
            if (countSymbol > 0)
            {
                password += $"{Environment.NewLine}Password must consist only of letters and digits";
            }
            if (countDigit < 2)
            {
                password += $"{Environment.NewLine}Password must have at least 2 digits";
            }

            return password;           
        }
    }
}
