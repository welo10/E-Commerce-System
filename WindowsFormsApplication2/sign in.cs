using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication2
{
    public partial class sign_in : Form
    {
        public sign_in()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (data.users[textBox1.Text].password == textBox2.Text)
            {
                StreamWriter sw = new StreamWriter("users.txt");
                foreach (KeyValuePair<string, User> entry in data.users)
                {
                    sw.WriteLine(entry.Value.name + ',' + entry.Value.password + ',' + entry.Value.address + ',' + entry.Value.email);
                }
                sw.Close();
                data.user = textBox1.Text;
                this.Hide();
                mainmenu m = new mainmenu();
                m.Show();
                
            }
            else
                MessageBox.Show("Username or Password is wrong");
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="UserName")
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
    }
}
