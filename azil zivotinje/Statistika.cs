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
    public partial class Statistika : Form
    {
        public Statistika()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// Ovdje se učitavaju sve potrebne informacije o azilu i prikazuju se u listboxu
        private void Statistika_Load(object sender, EventArgs e)
        {
            List<string> lista = Admin.Load();
            int brojac = 0;
            foreach (string linija in lista)
            {
                brojac++;
            }
            listBox1.Items.Add("Ukupan broj zivotinja u azilu je " + brojac);
            List<string> Udomitelj = Admin.UcitajSveUdomitelje();
            int brojac2 = 0;
            foreach (string linija in Udomitelj)
            {
                brojac2++;
            }
            listBox1.Items.Add("Ukupan broj udomljenih je " + brojac2);
            listBox1.Items.Add("Broj trenutno prisutnih zivotinja u nasem azilu je " + (brojac - brojac2));
            listBox1.Items.Add("Prosjecna dob zivotinja u nasem azilu je " + Admin.ProsjecnaDob());
            listBox1.Items.Add("Broj zivotinja po vrstama: ");
            foreach (string linija in Admin.BrojVrsta())
            {
                listBox1.Items.Add(linija);


            }
        }
    }
}
