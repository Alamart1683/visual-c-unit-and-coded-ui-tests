using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpo_lab
{
    // Модуль вычисления количества указанных символов
    public class StringComputer
    {
        // Метод вычисления количества указанных символов в строке
        public int getValueOfSymbolInString(string input, char symbol)
        {
            int count = 0;
            foreach (var i in input)
            {
                if (i.Equals(symbol))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
