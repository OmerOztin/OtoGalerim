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
using GaleriEntity;

namespace OtoGalerim
{
    public partial class Satildi : Telerik.WinControls.UI.RadForm
    {
        public Satildi()
        {
            InitializeComponent();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            if (txtMarka.Enabled == false)
            {
                txtMarka.Enabled = true;
                txtModel.Enabled = true;
                txtMusteri.Enabled = true;
                txtMusteri.Focus();
            }
            else
            { 
                txtMarka.Enabled = false;
                txtModel.Enabled = false;
                txtMusteri.Enabled = false;
                radButton3.Focus();
            }
        }
        private void Satildi_Load(object sender, EventArgs e)
        {
            List<SatilanSurragate> satilan = new List<SatilanSurragate>();
            SatilanSurragate st = new SatilanSurragate();
            satilan = ArabaBusiness.satilanget(st.ArabaID).ToList();
            radGridView1.DataSource = satilan;
            int ay = comboBox1.SelectedIndex + 1; 
            var g = ArabaBusiness.seciliAy(ay);

        }

        private void radGridView1_SelectionChanged(object sender, EventArgs e)
        {
                List<ResimlerSurragate> sonuc2 = new List<ResimlerSurragate>();
                ResimlerSurragate rsm = new ResimlerSurragate();
                arabaid = Convert.ToInt32(radGridView1.CurrentRow.Cells[0].Value);
                sonuc2 = ArabaBusiness.resimgetir(arabaid).ToList();
                
                listBox1.DataSource = sonuc2;
                listBox1.ValueMember = "ResimYolu";

                basla = true;
                sayac = 0;
                timer1.Start();
        }
        bool basla = true;
        int sayac = 0;
        int arabaid = 0;
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
        ArabaAyrinti ayrinti = new ArabaAyrinti();
        private void radButton1_Click(object sender, EventArgs e)
        {
            ayrinti.label1.Text = radGridView1.CurrentRow.Cells[0].Value.ToString();
            ayrinti.ShowDialog();
        }

        private void Satildi_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] aylar ={ "Ocak" , "Şubat" , "Mart " , "Nisan" , "Mayıs" , "Haziran" , "Temmuz" , "Ağustos" , "Eylül" , "Ekim" , "Kasım" , "Aralık" };
            int ay = comboBox1.SelectedIndex+1;
            var g = ArabaBusiness.seciliAy(ay);
            radGridView1.DataSource = g;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime tarihilk = dateTimePicker1.Value;
            DateTime tarihson = dateTimePicker2.Value;

            var g = ArabaBusiness.TarihAraligi(tarihilk, tarihson);
            radGridView1.DataSource = g;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime tarihilk = dateTimePicker1.Value;
            DateTime tarihson = dateTimePicker2.Value;

            var g = ArabaBusiness.TarihAraligi(tarihilk, tarihson);
            radGridView1.DataSource = g;
        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {
            string AraMarka = txtMarka.Text;
            var g = ArabaBusiness.AraMarka(AraMarka);
            radGridView1.DataSource = g;
        }
        private void txtMusteri_TextChanged(object sender, EventArgs e)
        {
            string Araİsim = txtMusteri.Text;
            var g = ArabaBusiness.MusteriAra(Araİsim);
            radGridView1.DataSource = g;
        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {
            string AraModel = txtModel.Text;
            var g = ArabaBusiness.ModelAra(AraModel);
            radGridView1.DataSource = g;
        } 
    }
}
