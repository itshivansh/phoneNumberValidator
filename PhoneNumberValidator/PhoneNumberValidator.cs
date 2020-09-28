using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;

namespace PhoneNumberValidator
{
    //Please do not change the signature of class methods
    public class PhoneNumberValidator
    {
        static void Main(string[] args)
        {
            string userInput = GetInput();
            // call the functions to validate phone number and display the status
            int result = ValidatePhoneNumber(userInput);
            DisplayResult(result);
        }
        public static string GetInput()
        {
            // get phonenumber as input   
            string userInput = Console.ReadLine();
            return userInput;
        }
        public static void DisplayResult(int result)
        {
            // display status of phone number valid or invalid
            if (result == -1)
            {
                Console.WriteLine("Empty value");
            }
            if (result == 1)
            {
                Console.WriteLine("Valid");
            }
            if (result == 0)
            {
                Console.WriteLine("Invalid");
            }
        }
        public static int ValidatePhoneNumber(string input)
        {
            // validate phone-number
            // for null or empty value, function should return -1
            // for invalid phone-number, function should return 0
            // for valid phone-number, function should return 1

            String str = input;
            if (string.IsNullOrEmpty(str))
                return -1;
            if (Regex.IsMatch(str, @"^\d{1}[-]?\d{1}[-]?\d{1}[-]?\d{1}[-]?\d{1}[-]?\d{1}[-]?\d{1}[-]?\d{1}[-]?\d{1}[-]?\d{1}$"))
                return 1;
            else
                return 0;
        }
    }
}
