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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textStudentid.Text, textStudentname.Text, comboBox1.Text, comboBox2.Text, textBoxPhone.Text);
            dataGridView2.Rows.Add(textBoxBookid.Text, textBoxBookname.Text, textBoxAuthor.Text, dateTimePicker1.Text, dateTimePicker2.Text);

            textStudentid.Clear();
            textStudentname.Clear();
            comboBox1.Text = String.Empty;
            comboBox2.Text = String.Empty;
            textBoxPhone.Clear();
            textBoxBookid.Clear();
            textBoxBookname.Clear();
            textBoxAuthor.Clear();
            dateTimePicker1.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(0);
            dataGridView2.Rows.RemoveAt(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textStudentid.Clear();
            textStudentname.Clear();
            comboBox1.Text = String.Empty;
            comboBox2.Text = String.Empty;
            textBoxPhone.Clear();
            textBoxBookid.Clear();
            textBoxBookname.Clear();
            textBoxAuthor.Clear();
            dateTimePicker1.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
        }

        private void textStudentid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!Char.IsDigit(key) && key != 8 && key != 46) 
            {
                e.Handled = true;
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!Char.IsDigit(key) && key != 8 && key != 46)
            {
                e.Handled = true;
            }
        }

        private void textBoxBookid_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!Char.IsDigit(key) && key != 8 && key != 46)
            {
                e.Handled = true;
            }
        }
    }
}
