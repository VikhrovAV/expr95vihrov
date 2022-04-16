using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expr95vihrov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >=10 && textBox1.Text.Length <=40)
            {

            }
            else
            {
                MessageBox.Show("Введите верные данные для поля 'Сценарист'. Минимальное количество символов - 10, максимальное - 40");
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text.Length >= 10 && textBox2.Text.Length <= 40)
            {

            }
            else
            {
                MessageBox.Show("Введите верные данные для поля 'Художник'. Минимальное количество символов - 10, максимальное - 40");
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text.Length >= 2 && textBox3.Text.Length <= 15)
            {

            }
            else
            {
                MessageBox.Show("Введите верные данные для поля 'Издательство'. Минимальное количество символов - 2, максимальное - 15");
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox4.Text);
            if (number <=0)
            {
                MessageBox.Show("Введите положительное число");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
    }
}
