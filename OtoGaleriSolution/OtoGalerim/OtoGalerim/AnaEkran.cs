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
    public partial class AnaEkran : Telerik.WinControls.UI.RadForm
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Garaj garaj = new Garaj();
            this.Hide();
            garaj.Show();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            Satildi sold = new Satildi();
            this.Hide();
            sold.ShowDialog();
        }

        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            Banka bank = new Banka();
            this.Hide();
            bank.Show();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            Hakkinda hakac = new Hakkinda();
            this.Hide();
            hakac.Show();
        }
    }
}
