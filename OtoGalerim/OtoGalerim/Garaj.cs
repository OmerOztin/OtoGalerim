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
    public partial class Garaj : Telerik.WinControls.UI.RadForm
    {
        public Garaj()
        {
            InitializeComponent();
        }

        public class Arabalar
        {
            public int ArabaID { get; set; }
            public string Marka { get; set; }
            public string Model { get; set; }
            public int Fiyat { get; set; }
            public string AlindigiTarih{ get; set; }
            public string Plaka { get; set; }
        }

        private void radGridView1_Click(object sender, EventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Araba_Ekle ekle = new Araba_Ekle();
            ekle.ShowDialog();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            ArabaSat sat = new ArabaSat();
            this.Hide();
            sat.Show();
        }
        ArabaAyrinti ayrinti = new ArabaAyrinti();
        private void radButton2_Click(object sender, EventArgs e)
        {
            ayrinti.label1.Text = radGridView1.CurrentRow.Cells[0].Value.ToString();
            ayrinti.ShowDialog();
            
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
        
        private void Garaj_Load(object sender, EventArgs e)
        {
            List<ArabaSurragate> sonuc = new List<ArabaSurragate>();
            ArabaSurragate aracbilgi = new ArabaSurragate();
            sonuc = ArabaBusiness.bilgiget(aracbilgi.ResimID).ToList();
            radGridView1.DataSource = sonuc;

        }
        List<Resimlerr> resimliste = new List<Resimlerr>();
        int arabaid = 0;
        int secim = 1;
        public class Resimlerr
        {
            public int ResimID { get; set; }
            public int ArabaID { get; set; }
            public string ResimYolu { get; set; }
        }
        private void radGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (secim == 1)
            {
                secim++;
            }
            else if (secim >= 2)
            {
                List<ResimlerSurragate> sonuc2 = new List<ResimlerSurragate>();
                ResimlerSurragate rsm = new ResimlerSurragate();
                arabaid = Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value);
                sonuc2 = ArabaBusiness.resimgetir(arabaid).ToList();

                listBox1.DataSource = sonuc2;   
                listBox1.ValueMember = "ResimYolu";

                //using (DB_OtoGaleriEntities1 resim = new DB_OtoGaleriEntities1())
                //{
                //    var resimal = (from r in resim.TB_Resimler
                //                   join y in resim.TB_Araba on r.ArabaID equals y.ArabaID
                //                   where r.ArabaID == arabaid
                //                   select new
                //                   {
                //                       ResimID = r.ResimID,
                //                       ArabaID = r.ArabaID,
                //                       ResimYolu = r.ResimYolu,
                //                   }
                //                   ).ToList();

                //}
                basla = true;
                sayac = 0;
                    timer1.Start();
                
            }
        }
        bool basla = true;
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (basla == true)
            {
                timer1.Interval = 5;
                basla = false;
            }
            else if (basla == false)
            {
                timer1.Interval = 2500;
            }
            string selected = listBox1.GetItemText(listBox1.SelectedValue);

            listBox1.SelectedIndex = sayac;
            pictureBox1.ImageLocation = selected;
            sayac++;
            if (sayac == listBox1.Items.Count)
            {
                sayac = 0;
            }
        }

        ArabaAyrinti gunc = new ArabaAyrinti();
        private void radButton4_Click(object sender, EventArgs e)
        {
            gunc.label1.Text = radGridView1.CurrentRow.Cells[0].Value.ToString();
            gunc.ShowDialog();
        }

        private void Garaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaEkran goster = new AnaEkran();
            this.Hide();
            goster.Show();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            List<ArabaSurragate> sonuc = new List<ArabaSurragate>();
            ArabaSurragate aracbilgi = new ArabaSurragate();
            sonuc = ArabaBusiness.bilgiget(aracbilgi.ResimID).ToList();
            radGridView1.DataSource = sonuc;
        }
        Satildi satildi = new Satildi();
        private void radButton4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            satildi.Show();
        }
    }
}
