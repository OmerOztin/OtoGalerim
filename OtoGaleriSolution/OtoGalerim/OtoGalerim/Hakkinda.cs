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
    public partial class Hakkinda : Telerik.WinControls.UI.RadForm
    {
        public Hakkinda()
        {
            InitializeComponent();
        }

        private void Hakkinda_FormClosing(object sender, FormClosingEventArgs e)
        {
            AnaEkran goster = new AnaEkran();
            this.Hide();
            goster.Show();
        }
    }
}
