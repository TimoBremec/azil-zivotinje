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
    public partial class Udomljavanje : Form
    {
        public Udomljavanje()
        {
            InitializeComponent();
        }
        int z = 0;
        private void Udomljavanje_Load(object sender, EventArgs e)
        {
            List<string> lista = Admin.Ucitaj();
            foreach (string linija in lista)
            {
                lstbox1.Items.Add(linija.Replace('|', ' '));
            }
        }
        private void NaseZivotinje_DoubleClick(object sender, EventArgs e)
        {
            z = lstbox1.SelectedIndex;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            lstbox1.Items.RemoveAt(z);
            string zapis = textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text;
            Admin.UnosUdomitelja(zapis);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
