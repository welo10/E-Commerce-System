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
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            additems a = new additems();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mobiles a = new mobiles();
            a.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cartt a = new cartt();
            a.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            if (data.user != "waleed")
            {
                button5.Visible = false;
                button1.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //this.Hide();
            //fashion nf = new fashion();
            //nf.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //this.Hide();
            //grocery ng = new grocery();
            //ng.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //this.Hide();
            //laptop nl = new laptop();
            //nl.ShowDialog();
        }

        //private void panel4_Paint(object sender, PaintEventArgs e)
        //{
        //    this.Hide();
        //    mobiles nm = new mobiles();
        //    nm.ShowDialog();
        //}

        private void panel4_Click(object sender, EventArgs e)
        {
            this.Hide();
            mobiles nm = new mobiles();
            nm.ShowDialog();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            laptop nl = new laptop();
            nl.ShowDialog();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            grocery ng = new grocery();
            ng.ShowDialog();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            fashion nf = new fashion();
            nf.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            itemsfunction i = new itemsfunction();
            i.Show();
        }
    }
}
