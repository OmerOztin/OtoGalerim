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
    public partial class ArabaAyrinti : Telerik.WinControls.UI.RadForm
    {
        public ArabaAyrinti()
        {
            InitializeComponent();
        }
        private void ArabaAyrinti_Load(object sender, EventArgs e)
        {
            ArabaSurragate araba = new ArabaSurragate();
            int arabaid = int.Parse(label1.Text);

                List<ResimlerSurragate> sonuclar = new List<ResimlerSurragate>();
                ResimlerSurragate rsmlr = new ResimlerSurragate();
                arabaid = Convert.ToInt32(arabaid);
                sonuclar = ArabaBusiness.Satresimget(arabaid).ToList();

                listBox1.DataSource = sonuclar;
                listBox1.ValueMember = "ResimYolu";
                timer1.Start();

                    araba.ArabaID = arabaid;
                    ArabaBusiness.detayli(araba);

                        TB_Araba arcek = new TB_Araba();
                        txtMarka.Text = araba.Marka;
                        txtModel.Text = araba.Model;
                        txtFiyat.Text = araba.Fiyat.ToString();
                        txtKm.Text = araba.Km;
                        txtPlaka.Text = araba.Plaka;
                        txtRenk.Text = araba.Renk;
                        txtTAd.Text = araba.TedarikciAdi;
                        txtTTel.Text = araba.TedarikciTel;
                        txtYakit.Text = araba.Yakıt;
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            ArabaSat sat = new ArabaSat();
            sat.ShowDialog();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
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

        private void radButton1_Click(object sender, EventArgs e)
        {
            ArabaSurragate argunc = new ArabaSurragate();
            argunc.ArabaID = Convert.ToInt32(label1.Text);
            argunc.Marka = txtMarka.Text;
            argunc.Model = txtModel.Text;
            argunc.Plaka = txtPlaka.Text;
            argunc.Renk = txtRenk.Text;
            argunc.Km = txtKm.Text;
            argunc.Fiyat = Convert.ToInt32(txtFiyat.Text);
            argunc.TedarikciAdi = txtTAd.Text;
            argunc.TedarikciTel = txtTTel.Text;
            int ArabaID = ArabaBusiness.DetayGunc(argunc);
        }

        private void radButton3_Click_1(object sender, EventArgs e)
        {
            ArabaSat satagit = new ArabaSat();
            this.Hide();
            satagit.Show();
        }
    }
}
