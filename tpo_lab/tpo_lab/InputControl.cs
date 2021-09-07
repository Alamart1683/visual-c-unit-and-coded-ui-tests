using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpo_lab
{
    // Модуль проверки ввода
    public class InputControl
    {
        // Метод проверки, делится ли длина строки на 2
        public bool isModTwo(string input)
        {
            if (input.Length % 2 == 0)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        // Метод проверки, делится ли длина строки на 3
        public bool isModThree(string input)
        {
            if (input.Length % 3 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Метод проверки, делится ли длина строки на 4
        public bool isModFour(string input)
        {
            if (input.Length % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Метод определения менее ли 12 цифр в строке
        public bool isLesserThenTwelfNubersInString(string input)
        {
            int count = 0;
            foreach (var i in input)
            {
                if (char.IsDigit(i))
                {
                    count++;
                }
            }
            if (count < 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Метод проверки, содержит ли строка символы от a до z
        public bool isNotStringContainsLatinChars(string input)
        {
            foreach (var i in input)
            {
                if (i >= 'a' && i <= 'z')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
