namespace OtoGalerim
{
    partial class Garaj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Garaj));
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radButton5 = new Telerik.WinControls.UI.RadButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            this.radButton3 = new Telerik.WinControls.UI.RadButton();
            this.telerikMetroBlueTheme1 = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.visualStudio2012LightTheme1 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.visualStudio2012LightTheme2 = new Telerik.WinControls.Themes.VisualStudio2012LightTheme();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton4 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.radGridView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radGridView1.Controls.Add(this.radButton5);
            this.radGridView1.EnableKineticScrolling = true;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            this.radGridView1.Location = new System.Drawing.Point(9, 6);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ArabaID";
            gridViewTextBoxColumn1.HeaderText = "ArabaID";
            gridViewTextBoxColumn1.Name = "column0";
            gridViewTextBoxColumn1.Width = 49;
            gridViewTextBoxColumn2.FieldName = "Marka";
            gridViewTextBoxColumn2.HeaderText = "Marka";
            gridViewTextBoxColumn2.Name = "column1";
            gridViewTextBoxColumn2.Width = 136;
            gridViewTextBoxColumn3.FieldName = "Model";
            gridViewTextBoxColumn3.HeaderText = "Model";
            gridViewTextBoxColumn3.Name = "column2";
            gridViewTextBoxColumn3.Width = 234;
            gridViewTextBoxColumn3.WrapText = true;
            gridViewTextBoxColumn4.FieldName = "Fiyat";
            gridViewTextBoxColumn4.FormatString = "{0:###,###.## ₺}";
            gridViewTextBoxColumn4.HeaderText = "Fiyat";
            gridViewTextBoxColumn4.Name = "column3";
            gridViewTextBoxColumn4.Width = 81;
            gridViewTextBoxColumn5.FieldName = "AlindigiTarih";
            gridViewTextBoxColumn5.FormatString = "{0:dd/MM/yyyy}";
            gridViewTextBoxColumn5.HeaderText = "Alış Tarihi";
            gridViewTextBoxColumn5.Name = "column4";
            gridViewTextBoxColumn5.Width = 77;
            gridViewTextBoxColumn6.FieldName = "Plaka";
            gridViewTextBoxColumn6.HeaderText = "Plaka";
            gridViewTextBoxColumn6.Name = "column5";
            gridViewTextBoxColumn6.Width = 79;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(670, 522);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "Arabalar";
            this.radGridView1.ThemeName = "VisualStudio2012Light";
            this.radGridView1.SelectionChanged += new System.EventHandler(this.radGridView1_SelectionChanged);
            this.radGridView1.Click += new System.EventHandler(this.radGridView1_Click);
            // 
            // radButton5
            // 
            this.radButton5.BackColor = System.Drawing.Color.Transparent;
            this.radButton5.Image = global::OtoGalerim.Properties.Resources.Refresh_2_icon;
            this.radButton5.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton5.Location = new System.Drawing.Point(619, 473);
            this.radButton5.Name = "radButton5";
            this.radButton5.Size = new System.Drawing.Size(51, 49);
            this.radButton5.TabIndex = 1;
            this.radButton5.ThemeName = "VisualStudio2012Light";
            this.radButton5.Click += new System.EventHandler(this.radButton5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(685, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.radButton1.Image = global::OtoGalerim.Properties.Resources.add_icon;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radButton1.Location = new System.Drawing.Point(5, 27);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(165, 110);
            this.radButton1.TabIndex = 1;
            this.radButton1.Text = "Araba Ekle";
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButton1.ThemeName = "TelerikMetroBlue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // radButton2
            // 
            this.radButton2.Font = new System.Drawing.Font("Segoe UI", 15.5F);
            this.radButton2.Image = global::OtoGalerim.Properties.Resources.Search_Engine_Optimization_icon__1_;
            this.radButton2.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radButton2.Location = new System.Drawing.Point(5, 142);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(165, 157);
            this.radButton2.TabIndex = 2;
            this.radButton2.Text = "Ayrıntılı Göster  Güncelle";
            this.radButton2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButton2.TextWrap = true;
            this.radButton2.ThemeName = "TelerikMetroBlue";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // radButton3
            // 
            this.radButton3.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.radButton3.Image = global::OtoGalerim.Properties.Resources.payment_icon;
            this.radButton3.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton3.Location = new System.Drawing.Point(182, 27);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(147, 110);
            this.radButton3.TabIndex = 0;
            this.radButton3.Text = "Araba Sat";
            this.radButton3.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButton3.ThemeName = "TelerikMetroBlue";
            this.radButton3.Click += new System.EventHandler(this.radButton3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(897, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 4;
            this.listBox1.Visible = false;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radButton4);
            this.radGroupBox1.Controls.Add(this.radButton1);
            this.radGroupBox1.Controls.Add(this.radButton2);
            this.radGroupBox1.Controls.Add(this.radButton3);
            this.radGroupBox1.Font = new System.Drawing.Font("Segoe UI", 18.25F);
            this.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office;
            this.radGroupBox1.HeaderAlignment = Telerik.WinControls.UI.HeaderAlignment.Center;
            this.radGroupBox1.HeaderText = "İşlemler";
            this.radGroupBox1.HeaderTextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radGroupBox1.Location = new System.Drawing.Point(680, 229);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(334, 306);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "İşlemler";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // radButton4
            // 
            this.radButton4.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.radButton4.Image = global::OtoGalerim.Properties.Resources.rent_a_car_icon;
            this.radButton4.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.radButton4.Location = new System.Drawing.Point(182, 143);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(147, 156);
            this.radButton4.TabIndex = 5;
            this.radButton4.Text = "Sattıklarım";
            this.radButton4.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.radButton4.ThemeName = "TelerikMetroBlue";
            this.radButton4.Click += new System.EventHandler(this.radButton4_Click_1);
            // 
            // Garaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 540);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.radGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1023, 575);
            this.MinimumSize = new System.Drawing.Size(1023, 575);
            this.Name = "Garaj";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(1023, 575);
            this.Text = "Garaj";
            this.ThemeName = "TelerikMetroBlue";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Garaj_FormClosed);
            this.Load += new System.EventHandler(this.Garaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.radGridView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadButton radButton2;
        private Telerik.WinControls.UI.RadButton radButton3;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme telerikMetroBlueTheme1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.Themes.VisualStudio2012LightTheme visualStudio2012LightTheme2;
        private Telerik.WinControls.UI.RadButton radButton5;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton radButton4;
    }
}
