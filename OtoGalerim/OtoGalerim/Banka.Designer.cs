namespace OtoGalerim
{
    partial class Banka
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banka));
            this.telerikMetroTheme1 = new Telerik.WinControls.Themes.TelerikMetroTheme();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.lblBanka = new Telerik.WinControls.UI.RadLabel();
            this.lblKasa = new Telerik.WinControls.UI.RadLabel();
            this.radRadioButton1 = new Telerik.WinControls.UI.RadRadioButton();
            this.radRadioButton2 = new Telerik.WinControls.UI.RadRadioButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radGroupBox2 = new Telerik.WinControls.UI.RadGroupBox();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.txtMiktar = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radButton2 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBanka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).BeginInit();
            this.radGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.AutoSizeRows = true;
            this.radGridView1.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditOnKeystroke;
            this.radGridView1.Location = new System.Drawing.Point(9, 29);
            // 
            // radGridView1
            // 
            this.radGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "islemCesidi";
            gridViewTextBoxColumn1.HeaderText = "Yapılan İşlem";
            gridViewTextBoxColumn1.Name = "column5";
            gridViewTextBoxColumn1.Width = 175;
            gridViewTextBoxColumn2.FieldName = "İslemAciklama";
            gridViewTextBoxColumn2.HeaderText = "Açıklama";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 271;
            gridViewTextBoxColumn3.FieldName = "BankadakiPara";
            gridViewTextBoxColumn3.HeaderText = "Bankadaki Para";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 116;
            gridViewTextBoxColumn4.FieldName = "KasadakiPara";
            gridViewTextBoxColumn4.HeaderText = "Kasadaki Para";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 108;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.Size = new System.Drawing.Size(688, 428);
            this.radGridView1.TabIndex = 0;
            this.radGridView1.Text = "radGridView1";
            this.radGridView1.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radLabel1.Location = new System.Drawing.Point(186, -3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(164, 32);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "- İşlem Geçmişi -";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radLabel2.Location = new System.Drawing.Point(5, 21);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(168, 32);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Bankadaki Bakiye";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radLabel3.Location = new System.Drawing.Point(5, 84);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(155, 32);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Kasadaki Bakiye";
            // 
            // lblBanka
            // 
            this.lblBanka.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.lblBanka.Location = new System.Drawing.Point(8, 56);
            this.lblBanka.Name = "lblBanka";
            this.lblBanka.Size = new System.Drawing.Size(18, 32);
            this.lblBanka.TabIndex = 3;
            this.lblBanka.Text = "-";
            // 
            // lblKasa
            // 
            this.lblKasa.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.lblKasa.Location = new System.Drawing.Point(8, 122);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(18, 32);
            this.lblKasa.TabIndex = 2;
            this.lblKasa.Text = "-";
            // 
            // radRadioButton1
            // 
            this.radRadioButton1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.radRadioButton1.Location = new System.Drawing.Point(5, 217);
            this.radRadioButton1.Name = "radRadioButton1";
            this.radRadioButton1.Size = new System.Drawing.Size(202, 23);
            this.radRadioButton1.TabIndex = 0;
            this.radRadioButton1.Text = "Kasaya Ekle - Kasadan Öde";
            this.radRadioButton1.ThemeName = "TelerikMetroBlue";
            // 
            // radRadioButton2
            // 
            this.radRadioButton2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.radRadioButton2.Location = new System.Drawing.Point(5, 186);
            this.radRadioButton2.Name = "radRadioButton2";
            this.radRadioButton2.Size = new System.Drawing.Size(213, 23);
            this.radRadioButton2.TabIndex = 0;
            this.radRadioButton2.Text = "Bankaya Ekle-Bankadan Öde";
            this.radRadioButton2.ThemeName = "TelerikMetroBlue";
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.lblKasa);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.lblBanka);
            this.radGroupBox1.HeaderText = "Hesaplar";
            this.radGroupBox1.Location = new System.Drawing.Point(703, 29);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(301, 169);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "Hesaplar";
            this.radGroupBox1.ThemeName = "TelerikMetroBlue";
            // 
            // radGroupBox2
            // 
            this.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox2.Controls.Add(this.radButton1);
            this.radGroupBox2.Controls.Add(this.label1);
            this.radGroupBox2.Controls.Add(this.txtAciklama);
            this.radGroupBox2.Controls.Add(this.txtMiktar);
            this.radGroupBox2.Controls.Add(this.radLabel6);
            this.radGroupBox2.Controls.Add(this.comboBox1);
            this.radGroupBox2.Controls.Add(this.radLabel5);
            this.radGroupBox2.Controls.Add(this.radLabel4);
            this.radGroupBox2.Controls.Add(this.radRadioButton1);
            this.radGroupBox2.Controls.Add(this.radRadioButton2);
            this.radGroupBox2.HeaderText = "İşlem Ekle";
            this.radGroupBox2.Location = new System.Drawing.Point(702, 204);
            this.radGroupBox2.Name = "radGroupBox2";
            this.radGroupBox2.Size = new System.Drawing.Size(302, 253);
            this.radGroupBox2.TabIndex = 0;
            this.radGroupBox2.Text = "İşlem Ekle";
            this.radGroupBox2.ThemeName = "TelerikMetro";
            // 
            // radButton1
            // 
            this.radButton1.BackgroundImage = global::OtoGalerim.Properties.Resources.payment_icon1;
            this.radButton1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.radButton1.Image = global::OtoGalerim.Properties.Resources.payment_icon1;
            this.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.radButton1.Location = new System.Drawing.Point(218, 177);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(76, 71);
            this.radButton1.TabIndex = 0;
            this.radButton1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.radButton1.ThemeName = "TelerikMetroBlue";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "₺";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(117, 59);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(173, 75);
            this.txtAciklama.TabIndex = 1;
            this.txtAciklama.Text = "";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtMiktar.Location = new System.Drawing.Point(117, 140);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(151, 31);
            this.txtMiktar.TabIndex = 5;
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 16.25F);
            this.radLabel6.Location = new System.Drawing.Point(5, 137);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(73, 34);
            this.radLabel6.TabIndex = 4;
            this.radLabel6.Text = "Miktar";
            this.radLabel6.ThemeName = "TelerikMetroTouch";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ödeme",
            "Para Ekleme"});
            this.comboBox1.Location = new System.Drawing.Point(117, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 32);
            this.comboBox1.TabIndex = 0;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radLabel5.Location = new System.Drawing.Point(5, 73);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(92, 32);
            this.radLabel5.TabIndex = 3;
            this.radLabel5.Text = "Açıklama";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 15.25F);
            this.radLabel4.Location = new System.Drawing.Point(5, 21);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(119, 32);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "İşlem Çeşidi";
            // 
            // radButton2
            // 
            this.radButton2.Location = new System.Drawing.Point(630, 12);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(67, 31);
            this.radButton2.TabIndex = 6;
            this.radButton2.Text = "Yenile";
            this.radButton2.ThemeName = "TelerikMetroTouch";
            this.radButton2.Click += new System.EventHandler(this.radButton2_Click);
            // 
            // Banka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 467);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.radGroupBox2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1024, 502);
            this.MinimumSize = new System.Drawing.Size(1024, 502);
            this.Name = "Banka";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.RootElement.MaxSize = new System.Drawing.Size(1024, 502);
            this.Text = "Banka";
            this.ThemeName = "TelerikMetro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Banka_FormClosing);
            this.Load += new System.EventHandler(this.Banka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBanka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblKasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radRadioButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox2)).EndInit();
            this.radGroupBox2.ResumeLayout(false);
            this.radGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.TelerikMetroTheme telerikMetroTheme1;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel lblBanka;
        private Telerik.WinControls.UI.RadLabel lblKasa;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton1;
        private Telerik.WinControls.UI.RadRadioButton radRadioButton2;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox2;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadButton radButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private Telerik.WinControls.UI.RadTextBox txtMiktar;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private System.Windows.Forms.ComboBox comboBox1;
        private Telerik.WinControls.UI.RadButton radButton2;
    }
}
