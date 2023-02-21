using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace richter2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "Demo" && textBoxPass.Text == "12345")

            {
                this.Hide();
                Form2 main = new Form2();
                main.Show();
            }

            else
            {
                MessageBox.Show("Username and Password Incorrect! Please try again");
                textBoxUser.Clear();
                textBoxPass.Clear();
                textBoxUser.Focus();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
