using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using SurragateGaleri;
using BusinessGaleri;

namespace OtoGalerim
{
    public partial class MusterliSec : Telerik.WinControls.UI.RadForm
    {
        public MusterliSec()
        {
            InitializeComponent();
        }
        public class Musteri
        {
            public int MusteriID { get; set; }
            public string Musteriİsim { get; set; }
            public string Telefon { get; set; }
            public string Adres { get; set; }
            public string  TC { get; set; }
        }
        private void MusterliSec_Load(object sender, EventArgs e)
        {
            int MusteriID =int.Parse(label1.Text);
            try
            {
                List<MusteriSurragate> sonuc = new List<MusteriSurragate>();
                MusteriSurragate mus = new MusteriSurragate();
                sonuc = ArabaBusiness.musterisec(MusteriID).ToList();
                radGridView1.DataSource = sonuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteriler getirilirken bir hata oluştu !" + Environment.NewLine + "Hata :" + ex.Message + MessageBoxIcon.Error);
            }
        }
        private void radButton1_Click(object sender, EventArgs e)
        {
            ArabaSat sat = new ArabaSat();
            this.Hide();
            sat.Show();

        }
        string isim;
        private void radButton2_Click(object sender, EventArgs e)
        {
            string kelime2 = radGridView1.CurrentRow.Cells[1].Value.ToString();

            string[] parça; // Sınırları belli olmayan dizi tanımladık

            parça = kelime2.Split(' '); // boşluk karakterine göre parçaladık ve kelimeleri diziye atadık.

            for (int i = 0; i < parça.Length; i++)
            {
                listBox1.Items.Add(parça[i].ToString());  // listboxa kelimeleri yazdırdık.
            }
            ArabaSat sat = new ArabaSat();
            sat.label1.Text = radGridView1.CurrentRow.Cells[0].Value.ToString();
            for (int i = 0; i < listBox1.Items.Count-1; i++)
            {
                 isim = listBox1.Items[i].ToString();
            }
            sat.txtMusteriAd.Text = isim;
            sat.txtMusteriSoyad.Text = listBox1.Items[1].ToString();
            sat.txtTel.Text = radGridView1.CurrentRow.Cells[2].Value.ToString();
            sat.txtAdres.Text = radGridView1.CurrentRow.Cells[3].Value.ToString();
            sat.txtTc.Text = radGridView1.CurrentRow.Cells[5].Value.ToString();
            this.Hide();
            sat.Show();
        }
        public List<MusteriSurragate> arababusiness { get; set; }
    }
}
