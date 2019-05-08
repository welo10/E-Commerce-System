using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication2
{
    
   public class Items
    {
        public int price;
        public string color,brand;
        public string name;
        public string category;
        public int numOforders=0;
        public int quantity;
      public  Items(int vprice, int vnumorders, int vquan, string vcat, string vname, string vcolor,string mbrand)
{

    price = vprice;
	numOforders = vnumorders;
	quantity = vquan;
	category = vcat;
	name = vname;
	color = vcolor;
            brand = mbrand;
}

}
   public class Brand
    {
    public  Dictionary<int, Items> item=new Dictionary<int, Items> () ;
    public static int last_id = 1;
        
        public void addItem(int price, string color, string name, string category, int numOfOrdera,int quantity,string brand)
        {
         //   Items i = new Items(price, numOforders, quantity, category, name, color);

            item[last_id++] = new Items(price, numOfOrdera, quantity, category, name, color,brand);

        }
        public bool instock(int id)
        {
            if (item[id].quantity == 0)
                return false;

            return true;
        }
        public DataTable display(string categ)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name");
            dt.Columns.Add("price");
            dt.Columns.Add("color");
            dt.Columns.Add("brand");
            dt.Columns.Add("id");
            foreach (KeyValuePair<int, Items> entry2 in data.b.item)
            {
                if ((entry2.Value.category == categ||categ=="all") && data.b.instock(entry2.Key)  )
                    dt.Rows.Add(entry2.Value.name, entry2.Value.price, entry2.Value.color, entry2.Value.brand, entry2.Key);
            }
            return dt;
        }
        public DataTable filter(string categ, string col, string strmaxprice, string strminpric)
        {
            int maxprice, minprice;
            if (col == "") col = "non";
            if (strmaxprice == "")
                maxprice = 1000000;
            else
                maxprice = Int32.Parse(strmaxprice);
            if (strminpric == "")
                minprice = 0;
            else
                minprice = Int32.Parse(strminpric);

            DataTable dt = new DataTable();
            dt.Columns.Add("name");
            dt.Columns.Add("price");
            dt.Columns.Add("color");
            dt.Columns.Add("brand");
            dt.Columns.Add("id");
            foreach (KeyValuePair<int, Items> entry2 in data.b.item)
            {
                if (entry2.Value.category == categ && entry2.Value.price<=maxprice && entry2.Value.price>=minprice && (col=="non"|| entry2.Value.color==col) )
                    dt.Rows.Add(entry2.Value.name, entry2.Value.price, entry2.Value.color, entry2.Value.brand, entry2.Key);

            }
            return dt;
        }
        public void remove_item(int id)
        { item.Remove(id); }
        public void change_price(int id,string strprice)
        {
            int nprice = Int32.Parse(strprice);
            item[id].price = nprice;
        }
        public void change_quantity(int id,string quant)
        {
            int nquant = Int32.Parse(quant);
            item[id].quantity = nquant;
        }
        public void remove_brand(string br)
        {
            foreach (KeyValuePair<int, Items> entry2 in data.b.item)
            {
                if (entry2.Value.brand == br)
                    item.Remove(entry2.Key);
            }
        }

    }

}
