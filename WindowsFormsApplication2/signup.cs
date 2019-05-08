using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { var u = new User();
                u.signUp(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            //   u.name = textBox1.Text;
            data.users[textBox1.Text] = u;
           // MessageBox.Show(data.users[textBox1.Text].name);
            Form1 f = new Form1();
            f.Show();
            this.Hide();

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "UserName")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.PasswordChar = '*';
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "email")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "address")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }
    }
}
