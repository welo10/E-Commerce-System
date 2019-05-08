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
    public partial class cartt : Form
    {
        public cartt()
        {
            InitializeComponent();
        }

        private void cartt_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name");
            dt.Columns.Add("price");
            dt.Columns.Add("color");
            dt.Columns.Add("brand");
   
            int price = 0;
            foreach (var i in data.cart)
            {
                dt.Rows.Add(data.b.item[i].name, data.b.item[i].price, data.b.item[i].color, data.b.item[i].brand);
                price += data.b.item[i].price;
                data.b.item[i].numOforders++;
                data.b.item[i].quantity--;
            }
            dataGridView1.DataSource = dt;
            label1.Text = price+"";
            //MessageBox.Show("Thank You, Confirmed!");
            mainmenu m = new mainmenu();
            m.Show();
            this.Hide();
        }   
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmed");
            mainmenu m = new mainmenu();
            data.cart.Clear();

            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
