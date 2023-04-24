using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void MoveImage_Click(object sender, EventArgs e)
        {
            Image.Location = new Point(300, 50);
        }
        private void ChangeName_Click(object sender, EventArgs e)
        {
            if (NameFlag.Text == "Флаг России")
            {
                NameFlag.Text = "Флаг Британии";
            }
            else if (NameFlag.Text == "Флаг Британии")
            {
                NameFlag.Text = "Флаг России";
            }
        }
        private void ChangeFlag_Click(object sender, EventArgs e)
        {
            
              if (NameFlag.Text == "Флаг России")
            {
                Image.ImageLocation = @"E:\PR_6\2.jpg";
                NameFlag.Text = "Флаг Британии";
            }
            else if (NameFlag.Text == "Флаг Британии")
            {
                Image.ImageLocation = @"E:\PR_6\1.jpg";
                NameFlag.Text = "Флаг России";
            }

        }
        private void ChangeColor_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DarkGreen;
        }

    }
}
