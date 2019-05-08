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

    public partial class itemsfunction : Form
    {
        public static int s;
        public static string br;
        public itemsfunction()
        {
            InitializeComponent();
        }

        private void Change_price_Click(object sender, EventArgs e)
        {
            data.b.change_price(s, item_id.Text);
        }

        private void change_quantity_Click(object sender, EventArgs e)
        {
            data.b.change_quantity(s, item_id.Text);

        }

        private void removeb_Click(object sender, EventArgs e)
        {
            data.b.remove_brand(br);

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            data.b.remove_item(s);

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Remove.Visible = true;
            removeb.Visible = true;
            Change_price.Visible = true;
            change_quantity.Visible = true;
            item_id.Visible = true;
            int i = e.RowIndex;
            DataGridViewRow Row = dataGridView1.Rows[i];
            s = Int32.Parse(Row.Cells[4].Value.ToString());
            br = Row.Cells[3].Value.ToString();

        }

        private void dataGridView1_CellDoubleClick(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainmenu m = new mainmenu();
            m.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void itemsfunction_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data.b.display("all");
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

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int i = e.RowIndex;
            DataGridViewRow Row = dataGridView1.Rows[i];
            s = Int32.Parse(Row.Cells[4].Value.ToString());
            br = Row.Cells[3].Value.ToString();
        }
    }
}
