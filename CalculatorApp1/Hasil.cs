using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp1
{
    public partial class Form1 : Form
    {
        private IList<Hasil_Perhitungan> listofHasilPertitungan = new List<Hasil_Perhitungan>();


        public Form1()
        {
            InitializeComponent();
        }
        private void FrmEntry_OnCreate(Hasil_Perhitungan hasil_Perhitungan)
        {
            listofHasilPertitungan.Clear();
            listofHasilPertitungan.Add(hasil_Perhitungan);
            lstHasil.Items.Add(hasil_Perhitungan.Hasil);

        }

        private void btnHitung_Click(object sender, EventArgs e)
        {

            Perhitungan perhitungan = new Perhitungan();
            perhitungan.OnCreate += FrmEntry_OnCreate;
            perhitungan.ShowDialog();
        }
    }
}
