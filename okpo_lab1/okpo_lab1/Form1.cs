using System;
using System.Windows.Forms;

namespace tpo4 {
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Метод проверки на пустоту вводимой строки и определения длины текста
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label3.Text = "Длина текста: " + textBox1.Text.Length.ToString();
            if (textBox1.Text.Equals(""))
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        // Метод обработки события нажатия на кнопку запуска обработки текста
        private void button1_Click(object sender, EventArgs e)
        {
            ChainDetector chainDetector = new ChainDetector();
            StringCompressor stringCompressor = new StringCompressor();
            if (chainDetector.symbolChainDetector(textBox1.Text))
            {
                textBox2.Text = stringCompressor.compressString(textBox1.Text);
            }
            else
            {
                MessageBox.Show("В введенном тексте отсутствуют последовательности из повторяющихся символов, обработка не имеет смысла.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Метод обработки события нажатия на кнопку выход
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
