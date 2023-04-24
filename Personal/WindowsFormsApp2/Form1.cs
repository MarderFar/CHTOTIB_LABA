using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FirstName.Text.Length > 0 && SecondName.Text.Length > 0)
            {
                Person person = new Person();
                person.FirstName = FirstName.Text;
                person.SecondName = SecondName.Text;
                person.SetAge(dateTimePicker1.Value);
                if (person.Age > 18 && person.Age < 70)
                {
                    MessageBox.Show("Имя: " + person.FirstName + "\n" + "Фамилия: " + person.SecondName + "\n" + "Возраст: " + person.Age);
                }
                else
                {
                    MessageBox.Show("Введите возраст от 18 до 65");
                }

            }

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecondName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FirstName_Enter(object sender, EventArgs e)
        {

        }

        private void FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void SecondName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
