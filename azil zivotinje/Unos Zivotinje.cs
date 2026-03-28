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
    public partial class Unos_Zivotinje : Form
    {
        public Unos_Zivotinje()
        {
            InitializeComponent();
        }
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
        private void button2_Click(object sender, EventArgs e)
        {
            string picture = openFileDialog1.FileName;
            string sp = "";
            string k = "";
            if (cbKast.Checked == true)
            {
                k = "kastriran";
            }
            else
            {
                k = "Nije kastriran";
            }
            string cijep = "";
            if (cbCijep.Checked == true)
            {
                cijep = "cijepljen";
            }
            else
            {
                cijep = "Nije cijepljen";
            }
            if (rbM.Checked == true)
            {
                sp = "Muško";
            }
            else if (rbZ.Checked == true)
            {
                sp = "Žensko";
            }
            string zapis = txtIme.Text + "|" + txtVrsta.Text + "|" + txtPasmina.Text + "|" + sp + "|" + nudDob.Text + "|" + dtpDolazak.Text + "|" + cijep + "|" + k + "|" + txtNapomena.Text + "|" + picture;
            Admin.Unos(zapis);
            txtIme.Clear();
            txtVrsta.Clear();
            txtPasmina.Clear();
            rbM.Checked = false;
            rbZ.Checked = false;
            nudDob.Value = 0;
            dtpDolazak.Value = DateTime.Now;
            cbCijep.Checked = false;
            cbKast.Checked = false;
            txtNapomena.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string picture = openFileDialog1.FileName;
            pictureBox1.Load(picture);
        }
    }
}
