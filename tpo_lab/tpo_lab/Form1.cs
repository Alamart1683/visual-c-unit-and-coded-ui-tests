using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpo_lab
{
    // Класс пользовательского интерфейса
    public partial class Form1 : Form
    {
        char computeChar = '*';

        public Form1()
        {
            InitializeComponent();
        }

        // Метод выбора подсчета звездочек
        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            computeChar = '*';
        }

        // Метод выбора подсчета амерсантов
        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            computeChar = '&';
        }

        // Метод нажатия на кнопку вычисления строки
        private void button1_Click(object sender, EventArgs e)
        {
            InputControl inputControl = new InputControl();
            StringComputer stringComputer = new StringComputer();
            StringExtractor stringExtractor = new StringExtractor();

            if (inputControl.isModTwo(textBox1.Text) && inputControl.isModThree(textBox1.Text) && inputControl.isModFour(textBox2.Text)
                && textBox1.Text != "" && textBox2.Text != "")
            {
                if (inputControl.isLesserThenTwelfNubersInString(stringExtractor.getFirstHalfOfString(textBox1.Text)) &&
                    inputControl.isNotStringContainsLatinChars(stringExtractor.getLastQuaterOfString(textBox2.Text))
                    )
                {
                    int k = stringComputer.getValueOfSymbolInString(stringExtractor.getSecondThirdPartOfString(textBox1.Text), computeChar);
                    label3.Text = "Значение K: " + k;
                }
                else
                {
                    MessageBox.Show("Условие задания не выполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Условие задания не выполнено", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
