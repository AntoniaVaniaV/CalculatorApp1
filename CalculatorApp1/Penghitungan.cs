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
    public partial class Perhitungan: Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler( Hasil_Perhitungan hasil_Perhitungan);
        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;
        
        // deklarasi variabel untuk menyimpan status entry data (input baru atau  update)
        private bool isNewData = true;
        // deklarasi variabel/objek mhs untuk meyimpan data mahasiswa
        private Hasil_Perhitungan hasil_Perhitungan;


        public Perhitungan()
        {
            InitializeComponent();
        }

        public string operasi;
        private void btnProses_Click(object sender, EventArgs e)
        {
            if (isNewData) hasil_Perhitungan = new Hasil_Perhitungan();
            if (operasi =="Penambahan")
            {
            hasil_Perhitungan.Hasil = "Hasil Penambahan " + txtNilaiA.Text + "+" + txtNilaiB.Text + "=" + (int.Parse(txtNilaiA.Text) + int.Parse(txtNilaiB.Text));
         
            }
            else if(operasi =="Pengurangan")
            {
            hasil_Perhitungan.Hasil = "Hasil Pengurangan " + txtNilaiA.Text + "-" + txtNilaiB.Text + "=" + (int.Parse(txtNilaiA.Text) - int.Parse(txtNilaiB.Text));

            }
            else if (operasi == "Perkalian")
            {
           hasil_Perhitungan.Hasil = "Hasil Perkalian " + txtNilaiA.Text + "*" + txtNilaiB.Text + "=" + (int.Parse(txtNilaiA.Text) * int.Parse(txtNilaiB.Text));

            }
            else if (operasi == "Pembagian")
            {
              hasil_Perhitungan.Hasil = "Hasil Pembagian " + txtNilaiA.Text + "/" + txtNilaiB.Text + "=" + (int.Parse(txtNilaiA.Text) / int.Parse(txtNilaiB.Text));

            }
            if (isNewData)
            {
                OnCreate(hasil_Perhitungan);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            operasi = comboBox1.SelectedItem.ToString();
        }
    }
}
