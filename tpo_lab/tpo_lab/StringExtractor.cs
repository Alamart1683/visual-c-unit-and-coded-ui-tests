using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpo_lab
{
    // Модуль извлечения частей строк
    public class StringExtractor
    {
        // Метод получения первой половины строки
        public string getFirstHalfOfString(string input)
        {
            int halfLength = input.Length / 2;
            string halfString = input.Substring(0, halfLength);
            return halfString;
        }

        // Метод получения последней четверти строки
        public string getLastQuaterOfString(string input)
        {
            int quaterLength = input.Length / 4;
            string quaterString = input.Substring(3 * quaterLength);
            return quaterString;
        }

        // Метод получения второй трети строки
        public string getSecondThirdPartOfString(string input)
        {
            int thirdPartLength = input.Length / 3;
            string thirdPartString = input.Substring(thirdPartLength, thirdPartLength);
            return thirdPartString;
        }
    }
}
