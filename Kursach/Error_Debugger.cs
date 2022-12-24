using System;
using System.Drawing;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Kursach
{
    internal class Error_Debugger
    {
        public static bool CheckString(string name, out string message)
        {
            string pattern = @"^[А-ЯЁ][а-яё]{2,}$";

            if (string.IsNullOrWhiteSpace(name))
            {
                message = "неверные данные";
                return false;
            }
            message = string.Empty;
            if (Regex.IsMatch(name, pattern))
            {
                return true;
            }
            message = "неверные данные";
            return false;
        }

        public static bool CheckString_Addname(string name, out string message)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                message = "неверные данные";
                return false;
            }
            else
            {
                message = null;
                return true;
            }
        }

        public static bool CheckString_name(string name, out string errorMsg)
        {
            string pattern = @"^[А-ЯЁ][а-яё]{2,}$";
            errorMsg = string.Empty;
            if (Regex.IsMatch(name, pattern))
            {
                
                return true;
            }

            errorMsg = "Данная строка должна содержать русские символы";
            return false;
        }

        public static bool Is_Number_Valide(string number, out string message)
        {
            string regex = @"(T|S){1}[0-9]{3}";
            message = string.Empty;
            if (!Regex.IsMatch(number, regex))
            {
                message = "неверные данные";
                return false;
            }
            return true;
        }

        public static bool CheckYear(string number, out string errorMsg)
        {
            int result;
            if (!int.TryParse(number, out result) || result <= 0)
            {
                errorMsg = "Данная строка не является числом";
                return false;
            }
            errorMsg = string.Empty;
            return true;
        }

        public static bool CheckStringAthor(string name, out string message)
        {
            string pattern = @"^ *[А-Я][а-я]{1,20}\s *[А-Я]\. *[А-Я]\. *$";

            if (string.IsNullOrWhiteSpace(name))
            {
                message = "неверные данные";
                return false;
            }
            message = string.Empty;
            if (Regex.IsMatch(name, pattern))
            {
                return true;
            }
            message = "неверные данные";
            return false;
        }

        public static bool CheckStringAthor_finder(string name, out string message)
        {

            message = string.Empty;
            if (Regex.IsMatch(name, @"^ *[А-Я][а-я]{1,20}\s *[А-Я]\. *[А-Я]\. *$") || Regex.IsMatch(name, @"^ *[А-ЯЁ][а-яё]{2,20} *$"))
            {
                return true;
            }
            message = "неверные данные";
            return false;
        }

        public static bool CheckYear_Add(string year, out string message)
        {

            message = string.Empty;
            if (Regex.IsMatch(year, @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"))
            {
                return true;
            }
            message = "неверный формат";
            return false;
        }
    }
}