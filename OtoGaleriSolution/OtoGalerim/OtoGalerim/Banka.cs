using BusinessGaleri;
using SurragateGaleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace OtoGalerim
{
    public partial class Banka : Telerik.WinControls.UI.RadForm
    {
        public Banka()
        {
            InitializeComponent();
        }

        private void Banka_Load(object sender, EventArgs e)
        {
            BankaSurragate banka = new BankaSurragate();
            lblBanka.Text = ArabaBusiness.BankaBakiye(banka).ToString() + " ₺";
            lblKasa.Text = ArabaBusiness.KasaBakiye(banka).ToString() + " ₺";
            List<BankaSurragate> sonuc = new List<BankaSurragate>();
            sonuc = ArabaBusiness.İslemGetir(banka.İslemID);
            radGridView1.DataSource = sonuc;

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (radRadioButton1.IsChecked == true)
            {
                BankaSurragate ekle = new BankaSurragate();
                if (comboBox1.SelectedIndex == 0)
                {
                    ekle.islemCesidi = Convert.ToInt32(txtMiktar.Text) * -1;
                    ekle.İslemAciklama = txtAciklama.Text;
                    ekle.KasadakiPara = Convert.ToInt32(txtMiktar.Text) * -1;
                    ArabaBusiness.IslemEkleKasa(ekle);
                    MessageBox.Show("İşlem Eklendi");
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    ekle.islemCesidi = Convert.ToInt32(txtMiktar.Text);
                    ekle.İslemAciklama = txtAciklama.Text;
                    ekle.KasadakiPara = Convert.ToInt32(txtMiktar.Text);
                    ArabaBusiness.IslemEkleKasa(ekle);
                    MessageBox.Show("İşlem Eklendi");
                }
            }

            if (radRadioButton2.IsChecked == true)
            {
                BankaSurragate ekle = new BankaSurragate();
                if (comboBox1.SelectedIndex == 0)
	            {
                    ekle.islemCesidi = Convert.ToInt32(txtMiktar.Text) * -1;
                    ekle.İslemAciklama = txtAciklama.Text;
                    ekle.BankadakiPara = Convert.ToInt32(txtMiktar.Text)*-1;
                    ArabaBusiness.IslemEkleBanka(ekle);
                    MessageBox.Show("İşlem Eklendi");
	            }
                else if (comboBox1.SelectedIndex == 1)
                {
                    ekle.islemCesidi = Convert.ToInt32(txtMiktar.Text);
                    ekle.İslemAciklama = txtAciklama.Text;
                    ekle.BankadakiPara = Convert.ToInt32(txtMiktar.Text);
                    ArabaBusiness.IslemEkleBanka(ekle);
                    MessageBox.Show("İşlem Eklendi");
                }
            }
        }

        private void Banka_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaEkran goster = new AnaEkran();
            this.Hide();
            goster.Show();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            BankaSurragate banka = new BankaSurragate();
            lblBanka.Text = ArabaBusiness.BankaBakiye(banka).ToString() + " ₺";
            lblKasa.Text = ArabaBusiness.KasaBakiye(banka).ToString() + " ₺";
            List<BankaSurragate> sonuc = new List<BankaSurragate>();
            sonuc = ArabaBusiness.İslemGetir(banka.İslemID);
            radGridView1.DataSource = sonuc;
        }
    }
}
