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
        //deklaracija varijable z koja ce nam sluziti za spremanje indeksa zivotinje koju zelimo udomiti,
        //a zatim je ukloniti iz listboxa i datoteke azilzivotinje.txt
        int z = 0;
        //Ovdje se učitavaju sve potrebne informacije o zivotinjama u azilu i prikazuju se u listboxu
        private void Udomljavanje_Load(object sender, EventArgs e)
        {
            List<string> lista = Admin.Load();
            foreach (string linija in lista)
            {
                lstbox1.Items.Add(linija.Replace('|', ' '));
            }
        }
        //Double clickom udomimo zivotinju, uklanjamo je iz listboxa i spremamo podatke o udomitelju u datoteku udomitelji.txt,
        //a zivotinja se uklanja iz datoteke azilzivotinje.txt
        private void lstbox1_DoubleClick(object sender, EventArgs e)
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
