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
    public partial class additems : Form
    {
        public additems()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            //{




            data.b.addItem(Int32.Parse(textBox3.Text), textBox2.Text, textBox1.Text, textBox4.Text,0, Int32.Parse(textBox5.Text),textBox7.Text);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("items.txt");
           
                foreach (KeyValuePair<int, Items> entry2 in data.b.item)
                {
                    sw.WriteLine( entry2.Value.name + ',' + entry2.Value.color + ',' + entry2.Value.price + ',' + entry2.Value.category + ',' + entry2.Value.numOforders + ',' + entry2.Value.quantity+','+entry2.Value.brand);
                }
            
            sw.Close();
            mainmenu m = new mainmenu();
            m.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
