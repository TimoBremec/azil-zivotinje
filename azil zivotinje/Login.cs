using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace azil_zivotinje
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="admin" && textBox2.Text == "admin")
            {
                Početna admin = new Početna();
                admin.ShowDialog();
            }
            
            
             else
            {
                MessageBox.Show("Pogrešan username ili password!");
            }
        }
    }
}
