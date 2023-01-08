// C# program to validate the
// Azerbaijan Phone Numbers using Regular
// Expression
using System.Text.RegularExpressions;

namespace ConsoleApp5
{
    internal class Program
    {

        // C# program to validate the
        // International Phone Numbers using Regular
        // Expression

        public class GFG
        {

            // Function to validate the
            // International Phone Numbers
            public static bool
              isValidPhoneNumber(string phonenumber)
            {
                // Regex to check valid phonenumber
                string regex
                  = "^[1-9]\\d{1}\\s\\d{3}\\s\\d{2}\\s\\d{2}$";

                // Compile the ReGex
                Regex p = new Regex(regex);

                // If the phonenumber
                // is empty return false
                if (phonenumber == null)
                {
                    return false;
                }

                // Pattern class contains matcher()
                // method to find matching between
                // given phone number using regex
                Match m = p.Match(phonenumber);

                // Return if the phonenumber
                // matched the ReGex
                return m.Success;
            }

            static void Main(string[] args)
            {
                // Test Case 1:
                string str1 = "50 555 55 55";
                Console.WriteLine(isValidPhoneNumber(str1));

                // Test Case 2:
                string str2 = "77 355 26 12";
                Console.WriteLine(isValidPhoneNumber(str2));

                // Test Case 3:
                string str3 = "+123 123 456";
                Console.WriteLine(isValidPhoneNumber(str3));

                // Test Case 4:
                string str4 = "654294563";
                Console.WriteLine(isValidPhoneNumber(str4));
            }
        }
    }
}
