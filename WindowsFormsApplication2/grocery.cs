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
    public partial class grocery : Form
    {
        public grocery()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.b.filter("grocery", textBox1.Text, textBox3.Text, textBox2.Text);
        }

        private void grocery_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.b.display("grocery");
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(178, 176, 176);

            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

 
            int i = e.RowIndex;
            DataGridViewRow Row = dataGridView1.Rows[i];
            int s = Int32.Parse(Row.Cells[4].Value.ToString());
            data.cart.Add(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainmenu m = new mainmenu();
            m.Show();
            this.Hide();
        }
    }
}
