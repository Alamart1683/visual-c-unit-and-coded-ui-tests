using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpo4
{
    // Модуль сжатия строки
    public class StringCompressor
    {
        // Метод сжатия строки
        public String compressString(String inputString)
        {
            String compressedString = "";
            int count = 0;
            char currentChar = inputString[0];
            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (inputString[i].Equals(inputString[i + 1]) && inputString[i + 1].Equals(currentChar))
                {
                    count++;
                }
                else
                {
                    if (count == 0)
                    {
                        compressedString += currentChar;
                    }
                    else
                    {
                        compressedString += "(" + (count + 1).ToString() + ")" + currentChar;
                    }
                    if (i + 1 < inputString.Length)
                    {
                        currentChar = inputString[i + 1];
                        count = 0;
                    }
                }
            }
            if (count == 0)
            {
                compressedString += currentChar;
            }
            else
            {
                compressedString += "(" + (count + 1).ToString() + ")" + currentChar;
            }
            return compressedString;
        }
    }
}
