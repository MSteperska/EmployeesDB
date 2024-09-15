using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Testy_nauka
{
    public static class Validator
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        } 

        public static bool IsValidPhone(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d{9}$");
        }

        public static bool IsOnlyText(string text)
        {
            return !string.IsNullOrWhiteSpace(text) && Regex.IsMatch(text, @"^[a-zA-Z]+$");
        }

        public static bool IsOnlyDigits(string value)
        {
            return Regex.IsMatch(value, @"^\d+$");
        }

        public static bool OnlyOneDotPlace(string value)
        {
            int dotCount = value.Split('.').Length - 1;
            if(dotCount == 1)
            {
                int dotIndex = value.IndexOf('.');
                return dotIndex == value.Length - 2 || dotIndex == value.Length - 3;
            }
            return false;
        }

        public static bool IsPosDecimal(string value)
        {
            return decimal.TryParse(value, out decimal result) && result > 0;
        }

        public static bool IsPercent(string value)
        {
            return Regex.IsMatch(value, @"^\d{1,2}%$");
        }
    }
}
