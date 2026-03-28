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
    public partial class Filtriranje : Form
    {
        public Filtriranje()
        {
            InitializeComponent();
        }

        private void Filtriranje_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Admin.Vrste().Distinct().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            string kriterij = comboBox1.SelectedItem.ToString();
            List<string> vrste = Admin.SearchByVrsta(kriterij);
            foreach (string vrsta in vrste)
            {
                listBox1.Items.Add(vrsta.Replace('|', ' '));

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> lista = Admin.Ucitaj();
            foreach (string linija in lista)
            {
                listBox1.Items.Add(linija.Replace('|', ' '));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
