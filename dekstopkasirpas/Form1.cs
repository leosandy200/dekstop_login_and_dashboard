using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dekstopkasirpas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Username atau Password anda tidak boleh kosong");
            }
            if (Username.Text != "admin" || Password.Text != "1234")
            {
                MessageBox.Show("Username atau Password anda salah");
            }
            else
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
