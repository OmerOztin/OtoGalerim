using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using GaleriEntity;
using SurragateGaleri;
using BusinessGaleri;

namespace OtoGalerim
{
    public partial class ArabaSat : Telerik.WinControls.UI.RadForm
    {
        public ArabaSat()
        {
            InitializeComponent();
        }
        int musteriID;
        private void radButton1_Click(object sender, EventArgs e)
        {
            try
            {
            arabaid = Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value);
            int alisfiyat = Convert.ToInt32(radGridView1.CurrentRow.Cells[1].Value);
            string marka = radGridView1.CurrentRow.Cells[3].Value.ToString();
            string model = radGridView1.CurrentRow.Cells[4].Value.ToString();
            string plaka = radGridView1.CurrentRow.Cells[6].Value.ToString();
            MessageBox.Show(marka + " " + model + " " + plaka + " " + alisfiyat.ToString() + " " + arabaid.ToString());

            MusteriSurragate musteri = new MusteriSurragate();
            musteri.Musteriİsim = txtMusteriAd.Text + " " + txtMusteriSoyad.Text;
            musteri.Telefon = txtTel.Text;
            musteri.Adres = txtAdres.Text;
            musteri.TC = txtTc.Text;
            musteri.ArabaID = arabaid;
            musteriID = ArabaBusiness.musekle(musteri);

            SatilanSurragate arabasat = new SatilanSurragate();
            arabasat.SatisFiyat = Convert.ToInt32(txtSatFiyatt.Text);
            arabasat.SatisTarihi = radDateTimePicker1.Value;
            arabasat.MusteriID = musteriID;
            arabasat.ArabaID = arabaid;
            arabasat.Marka = marka;
            arabasat.Model = model;
            arabasat.Plaka = plaka;
            arabasat.AlisFiyat = alisfiyat;
            int satID = ArabaBusiness.sat(arabasat);
            int Kâr = Convert.ToInt32(txtSatFiyatt.Text) - alisfiyat;

            ArabaSurragate arsil = new ArabaSurragate();
            arsil.ArabaID = arabaid;
            int silinen = ArabaBusiness.arabagunc(arsil);
            if (radRadioButton1.IsChecked == true)
            {
                BankaSurragate ekle = new BankaSurragate();

                ekle.islemCesidi = Convert.ToInt32(txtKomisyon.Text);
                ekle.İslemAciklama = marka + " Satışından Gelen Komisyon = " + txtKomisyon.Text;
                if (radCheckBox1.Checked == true)
                {
                    ekle.KasadakiPara = Convert.ToInt32(txtKomisyon.Text);
                    ekle.İslemAciklama = marka + " Satışından Gelen Kâr = " + txtKomisyon.Text;
                }
                else if (radCheckBox1.Checked == false)
                {
                    ekle.KasadakiPara = Kâr;
                }
                ArabaBusiness.IslemEkleKasa(ekle);
            }

            if (radRadioButton2.IsChecked == true)
            {
                BankaSurragate ekle = new BankaSurragate();
                ekle.islemCesidi = Convert.ToInt32(txtKomisyon.Text);
                
                if (radCheckBox1.Checked == true)
                {
                    ekle.BankadakiPara = Convert.ToInt32(txtKomisyon.Text);
                    ekle.İslemAciklama = marka + " Satışından Gelen Komisyon = " + txtKomisyon.Text;
                }
                else if (radCheckBox1.Checked == false)
                {
                    ekle.BankadakiPara = Kâr;
                    ekle.İslemAciklama = marka + " Satışından Gelen Kâr = " + txtKomisyon.Text;
                }
                ArabaBusiness.IslemEkleBanka(ekle);
            }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (progressBar1.Value > 100)
            {
                
            }
            else if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Satıldı");
            }
            else
            {
                progressBar1.Value += 5;
            }
        }
        private void ArabaSat_Load(object sender, EventArgs e)
        {
            txtKomisyon.Enabled = false;
            try
            {
                List<ArabaSurragate> sonuc = new List<ArabaSurragate>();
                ArabaSurragate arac = new ArabaSurragate();
                sonuc = ArabaBusiness.satgetir(arac.ArabaID);
                radGridView1.DataSource = sonuc;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilgiler getirilirken bir hata oluştu Kayılı Araç olmayabilir yada bilgiler hatalı olabilir !" + Environment.NewLine + "Hata :" + ex.Message + MessageBoxIcon.Error);
            }
        }
        private void radGridView1_Click(object sender, EventArgs e)
        {

        }
        int secim = 1;
        int arabaid = 0;

        private void radGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (secim == 1)
            {
                secim++;
            }
            else if (secim >= 2)
            {
                List<ResimlerSurragate> sonuclar = new List<ResimlerSurragate>();
                ResimlerSurragate rsmlr = new ResimlerSurragate();
                arabaid = Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value);
                sonuclar = ArabaBusiness.Satresimget(arabaid).ToList();

                listBox1.DataSource = sonuclar;
                listBox1.ValueMember = "ResimYolu";

                //using (DB_OtoGaleriEntities1 resim = new DB_OtoGaleriEntities1())
                //{
                //    var resimal = (from r in resim.TB_Resimler
                //                   join y in resim.TB_Araba on r.ArabaID equals y.ArabaID
                //                   where r.ArabaID == arabaid
                //                   select new
                //                   {
                //                       resimid = r.ResimID,
                //                       ResimID = r.ResimID,
                //                       ArabaID = r.ArabaID,
                //                       ResimYolu = r.ResimYolu,
                //                   }
                //                   ).ToList();
                //    listBox1.DataSource = resimal;
                //    listBox1.ValueMember = "ResimYolu";
                //}
                timer2.Start();
            }
        }
        int sayac = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            string selected = listBox1.GetItemText(listBox1.SelectedValue);
            listBox1.SelectedIndex = sayac;
            pictureBox1.ImageLocation = selected;
            sayac++;
            if (sayac == listBox1.Items.Count)
            {
                sayac = 0;
            }
        }
        private void radButton3_Click(object sender, EventArgs e)
        {
            MusterliSec musterisec = new MusterliSec();
            musterisec.label1.Text = Convert.ToString(radGridView1.CurrentRow.Cells[0].Value);
            this.Hide();
            musterisec.ShowDialog();
        }
        //TC Kontrol
        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            if (txtTc.Text.Length == 11)
            {
                int toplam = 0;
            string  c,d;
            string sayı1 = txtTc.Text;
            string sayı2 = sayı1[sayı1.Length-1].ToString();
          

            foreach (var i in sayı1)
            {
                c= i.ToString(); 
                
                toplam = toplam + int.Parse(c);
            }

            toplam = toplam - int.Parse(sayı2);

            d = toplam.ToString();

            d = d[d.Length-1].ToString();

            if (d == sayı2)
                label5.Text = "✔";
            else
                label5.Text = "X";
            }
        }
        private void radCheckBox1_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (radCheckBox1.Checked == true)
            {
                txtKomisyon.Enabled = true;
            }
            else if (radCheckBox1.Checked == false)
            {
                txtKomisyon.Enabled = false;
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            txtAdres.Clear();
            txtKomisyon.Clear();
            txtMusteriAd.Clear();
            txtMusteriSoyad.Clear();
            txtSatFiyatt.Clear();
            txtTc.Clear();
            txtTel.Clear();
        }

        private void ArabaSat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Garaj grj = new Garaj();
            this.Hide();
            grj.Show();
        }
    }
}
