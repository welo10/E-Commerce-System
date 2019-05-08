﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           StreamReader sr = new StreamReader("items.txt");
            string d = sr.ReadLine();
            while(d!=null)
            {
           
                string[] values = d.Split(',');
                data.b.addItem(Int32.Parse(values[2]), values[1], values[0], values[3], Int32.Parse(values[4]), Int32.Parse(values[5]), values[6]);

                d = sr.ReadLine();
            }
            sr.Close();
            sr = new StreamReader("users.txt");
             d = sr.ReadLine();
            while (d != null)
            {
                User u = new User();
                string[] values = d.Split(',');
                u.signUp(values[0], values[1], values[2], values[3]);
                data.users[values[0]] = u;
                d = sr.ReadLine();
            }
            sr.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup s =new signup();
            s.Show();
           //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sign_in s = new sign_in();
            s.Show();
              //this.Hide();
        }
    }
}
