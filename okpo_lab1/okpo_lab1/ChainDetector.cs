using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpo4
{
    // Модуль определения, содержит ли строка повторяющиеся символы
    public class ChainDetector
    {
        // Метод определения, содержит ли строка повторяющиеся символы
        public bool symbolChainDetector(String inputString)
        {
            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (inputString[i].Equals(inputString[i + 1]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
