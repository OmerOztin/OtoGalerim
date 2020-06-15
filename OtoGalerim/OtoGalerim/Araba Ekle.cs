using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;
using System.Windows.Input;
using BusinessGaleri;
using SurragateGaleri;
using GaleriEntity;

namespace OtoGalerim
{
    public partial class Araba_Ekle : Telerik.WinControls.UI.RadForm
    {
        public Araba_Ekle()
        {
            InitializeComponent();
        }
        public string CustomFormat { get; set; }
        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPlaka1_TextChanged(object sender, EventArgs e)
        {

        }
        bool tiklama = false;
        private void txtPlaka1_Click(object sender, EventArgs e)
        {
            if (tiklama == false)
            {
                txtPlaka1.Clear();
                txtPlaka2.Clear();
                txtPlaka3.Clear();
                tiklama = true;
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            txtPlaka1.Clear();
            txtPlaka2.Clear();
            txtPlaka3.Clear();
            txtSatisFiyat.Clear();
            txtKm.Clear();
            txtAracTN.Clear();
            txtAlisfiyat.Clear();
            listBox1.Items.Clear();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                ArabaSurragate arabilgi = new ArabaSurragate();
                arabilgi.Marka = radDropDownList1.SelectedItem.Text;
                arabilgi.Model = radDropDownList2.SelectedItem.Text;
                arabilgi.Yil = dtpYil.Value;
                arabilgi.Km = txtKm.Text;
                arabilgi.Yakıt = comboYakit.SelectedItem.ToString();
                arabilgi.Renk = comboRenk.SelectedItem.ToString();
                arabilgi.AracTNo = txtAracTN.Text;
                string plaka = txtPlaka1.Text + " " + txtPlaka2.Text + " " + txtPlaka3.Text;
                arabilgi.Plaka = plaka;
                arabilgi.Fiyat = Convert.ToInt32(txtSatisFiyat.Text);
                arabilgi.AlisFiyat = int.Parse(txtAlisfiyat.Text);
                arabilgi.TedarikciAdi = txtAd.Text;
                arabilgi.TedarikciTel = txtTel.Text;
                arabilgi.AlindigiTarih = dtpAlindigiTarih.Value;

                id = ArabaBusiness.ekle(arabilgi);
                try
                {
                    ResimlerSurragate rsmekle = new ResimlerSurragate();
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        rsmekle.ResimYolu = listBox1.Items[i].ToString();
                        rsmekle.ArabaID = id;
                        ArabaBusiness.resimget(rsmekle);
                    }

                    MessageBox.Show("Resim Eklendi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu lütfen daha sonra tekrar deneyiniz" + Environment.NewLine + "Hata :" + ex.Message);
                }
                MessageBox.Show("Kayıt Başarılı " + "ID = " + id.ToString());
                ekle = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu Lütfen bilgileri kontrol ediniz Hata : " + ex);
            }
        }

        private void txtPlaka2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboRenk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Araba_Ekle_Load(object sender, EventArgs e)
        {
            List<MarkaModelSurragate> sonuc = new List<MarkaModelSurragate>();


            dtpYil.Format = DateTimePickerFormat.Custom;
            dtpYil.CustomFormat = "yyyy";
            try
            {


                using (DB_OtoGaleriEntities doldur = new DB_OtoGaleriEntities())
                {
                    var markagetir = doldur.TB_MarkaModel.Select(g => new { g.MarkaAdı, g.MarkaKodu }).Distinct().ToList().OrderBy(g => g.MarkaAdı);
                    //select new { g.MarkaAdı, g.MarkaKodu }).ToList().GroupBy(q=>q.MarkaAdı);
                    radDropDownList1.DataSource = markagetir;
                    radDropDownList1.ValueMember = "MarkaKodu";
                    radDropDownList1.DisplayMember = "MarkaAdı";
                }
            }
            catch
            {

            }
        }
        int sayac = 0;
        bool ekle = false;
        private void radDropDownList1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            try
            {
                if (sayac == 0)
                {
                    sayac++;
                }
                else if (sayac > 0)
                {
                    radDropDownList2.Enabled = true;

                    int kod = int.Parse(radDropDownList1.SelectedValue.ToString());
                    using (DB_OtoGaleriEntities modelget = new DB_OtoGaleriEntities())
                    {

                        var araba = modelget.TB_MarkaModel.Where(q => q.MarkaKodu == kod).ToList().OrderBy(q => q.ModelAdı);
                        radDropDownList2.DataSource = araba;
                        radDropDownList2.ValueMember = "ModelKodu";
                        radDropDownList2.DisplayMember = "ModelAdı";
                    }
                }
            }
            catch
            {

            }
        }
        int id;
        private void radButton3_Click(object sender, EventArgs e)
        {
            try
            {
                    openFileDialog1.CheckFileExists = true;
                    openFileDialog1.CheckPathExists = true;
                    openFileDialog1.Multiselect = true;
                    openFileDialog1.Filter =
                    "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";

                    openFileDialog1.Title = "Fotoları seçiniz";
                    openFileDialog1.ShowDialog();
                    
                    foreach (String resimler in openFileDialog1.FileNames)
                    {
                        listBox1.Items.Add(resimler);
                        basla = true;
                        sayac = 0;
                        timer1.Start();
                    }           
            }
            catch (Exception)
            {

            }               
        }
        bool basla = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void radGroupBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
