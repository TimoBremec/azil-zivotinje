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
    public partial class Početna : Form
    {
        public Početna()
        {
            InitializeComponent();
        }
        //Vodi nas na formu za unos zivotinja u azil
        private void button1_Click(object sender, EventArgs e)
        {
            Unos_Zivotinje frm2 = new Unos_Zivotinje();
            frm2.ShowDialog();
        }
        //Zatvara aplikaciju
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Početna_Load(object sender, EventArgs e)
        {

        }
        //Vodi nas na formu za pregled svih zivotinja u azilu
        private void button2_Click(object sender, EventArgs e)
        {
            Pregled frm3 = new Pregled();
            frm3.ShowDialog();
        }
        //Vodi nas na formu za filtriranje zivotinja u azilu po odredjenim kriterijima
        private void button3_Click(object sender, EventArgs e)
        {
            Filtriranje frm4 = new Filtriranje();
            frm4.ShowDialog();
        }
        //Vodi nas na formu za udomljavanje zivotinja iz azila
        private void button4_Click(object sender, EventArgs e)
        {
            Udomljavanje frm5 = new Udomljavanje();
            frm5.ShowDialog();
        }
        //Vodi nas na formu sa statistickim podacima o zivotinjama u azilu
        private void button5_Click(object sender, EventArgs e)
        {
            Statistika frm6 = new Statistika(); 
            frm6.ShowDialog();
        }
    }
}
