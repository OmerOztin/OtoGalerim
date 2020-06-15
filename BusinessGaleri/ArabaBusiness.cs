using GaleriEntity;
using SurragateGaleri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessGaleri
{

    public class ArabaBusiness
    {
        //SATIŞ Tablosuna getirme !!!
        public static List<ArabaSurragate> satgetir(int ArabaID)
        {
            List<ArabaSurragate> satsonuc = new List<ArabaSurragate>();
            using (DB_OtoGaleriEntities Sget = new DB_OtoGaleriEntities())
            {

                satsonuc = (from a in Sget.TB_Araba
                            where a.Satildimi == 0
                            select new ArabaSurragate
                            {
                                ArabaID = (int)a.ArabaID,
                                Marka = a.Marka,
                                Model = a.Model,
                                AlisFiyat = (int)a.AlisFiyat,
                                Fiyat = (int)a.Fiyat,
                                Yil = (DateTime)a.Yil,
                                Plaka = a.Plaka,

                            }).ToList();
                return satsonuc;
            }
        }
        //Satış Tablosuna Resimleri Getirme
        public static List<ResimlerSurragate> Satresimget(int araba)
        {
            List<ResimlerSurragate> resimcek = new List<ResimlerSurragate>();
            using (DB_OtoGaleriEntities dbrsm = new DB_OtoGaleriEntities())
            {
                resimcek = (from r in dbrsm.TB_Resimler
                            join y in dbrsm.TB_Araba on r.ArabaID equals y.ArabaID
                            where r.ArabaID == araba
                            select new ResimlerSurragate
                            {
                                ResimID = (int)r.ResimID,
                                ArabaID = (int)r.ArabaID,
                                ResimYolu = r.ResimYolu,
                            }
                                 ).ToList();
                return resimcek;
            }
        }
        //SATIŞ TABLOSUNDA SATIŞ İŞLEMİ-Satış Tablosuna ekleme
        public static int sat(SatilanSurragate arabasat)
        {
            int satID;
            using (DB_OtoGaleriEntities db = new DB_OtoGaleriEntities())
            {
                TB_Satilan st = new TB_Satilan();
                st.ArabaID = arabasat.ArabaID;
                st.Marka = arabasat.Marka;
                st.Model = arabasat.Model;
                st.MusteriID = arabasat.MusteriID;
                st.Plaka = arabasat.Plaka;
                st.SatisFiyat = arabasat.SatisFiyat;
                st.SatisTarihi = arabasat.SatisTarihi;
                st.AlisFiyat = arabasat.AlisFiyat;

                db.TB_Satilan.Add(st);
                db.SaveChanges();
                satID = st.SatisID;
            }
            return satID;
        }
        //SATILANLARI GETİRME(JOİN İLE)
        public static List<SatilanSurragate> satilanget(int ArabaID)
        {
            List<SatilanSurragate> sat = new List<SatilanSurragate>();
            using (DB_OtoGaleriEntities db = new DB_OtoGaleriEntities())
            {
                sat = (from a in db.TB_Satilan
                       join m in db.TB_Musteri on a.MusteriID equals m.MusteriID
                       select new SatilanSurragate
                       {
                           ArabaID = (int)a.ArabaID,
                           Marka = a.Marka,
                           Model = a.Model,
                           Plaka = a.Plaka,
                           AlisFiyat = (int)a.AlisFiyat,
                           SatisFiyat = (int)a.SatisFiyat,
                           Kâr = (int)a.SatisFiyat - (int)a.AlisFiyat,
                           SatisTarihi = (DateTime)a.SatisTarihi,
                           Musteriİsim = m.Musteriİsim,
                           Telefon = m.Telefon,
                       }).ToList();
            }
            return sat;
        }
        //MÜŞTERİ EKLEME
        public static List<MusteriSurragate> musterisec(int Musteri)
        {
            List<MusteriSurragate> muslist = new List<MusteriSurragate>();
            using (DB_OtoGaleriEntities db = new DB_OtoGaleriEntities())
            {
                muslist = (from a in db.TB_Musteri
                           select new MusteriSurragate
                           {
                               MusteriID = a.MusteriID,
                               Musteriİsim = a.Musteriİsim,
                               Telefon = a.Telefon,
                               Adres = a.Adres,
                               TC = a.TC,
                           }).ToList();
            }
            return muslist;
        }
        public static int musekle(MusteriSurragate musteri)
        {
            int ID;
            using (DB_OtoGaleriEntities db = new DB_OtoGaleriEntities())
            {
                TB_Musteri mu = new TB_Musteri();
                mu.Musteriİsim = musteri.Musteriİsim;
                mu.TC = musteri.TC;
                mu.Telefon = musteri.Telefon;
                mu.Adres = musteri.Adres;
                mu.ArabaID = musteri.ArabaID;

                db.TB_Musteri.Add(mu);
                db.SaveChanges();
                ID = mu.MusteriID;
            }
            return ID;
        }
        //Arabayı Satıldı olarak işaretleme
        public static int arabagunc(ArabaSurragate araba)
        {
            int ArabaID;
            using (DB_OtoGaleriEntities db = new DB_OtoGaleriEntities())
            {
                TB_Araba argunc = new TB_Araba();
                argunc.ArabaID = araba.ArabaID;
                db.TB_Araba.Attach(argunc);
                argunc.Satildimi = 1;
                db.SaveChanges();
            }
            ArabaID = araba.ArabaID;
            return ArabaID;
        }
        //DETAYLI ARAA GÜNCELLEME
        public static int DetayGunc(ArabaSurragate araba)
        {
            int ArabaID = 0;
            using (DB_OtoGaleriEntities db = new DB_OtoGaleriEntities())
            {
                TB_Araba argunc = new TB_Araba();
                argunc.ArabaID = araba.ArabaID;
                db.TB_Araba.Attach(argunc);
                argunc.Marka = araba.Marka;
                argunc.Model = araba.Model;
                argunc.Fiyat = araba.Fiyat;
                argunc.Km = araba.Km;
                argunc.Plaka = araba.Plaka;
                argunc.Renk = araba.Renk;
                argunc.TedarikciAdi = araba.TedarikciAdi;
                argunc.TedarikciTel = araba.TedarikciTel;
                argunc.Yakıt = araba.Yakıt;
                db.SaveChanges();
            }
            return ArabaID;
        }
        //GARAJA Arabaları Çekme Kodları
        public static List<ArabaSurragate> bilgiget(int sonuc)
        {
            List<ArabaSurragate> grjsonuc = new List<ArabaSurragate>();
            using (DB_OtoGaleriEntities getir = new DB_OtoGaleriEntities())
            {
                grjsonuc = (from a in getir.TB_Araba
                            where a.Satildimi == 0
                            select new ArabaSurragate
                            {
                                ArabaID = (int)a.ArabaID,
                                Marka = a.Marka,
                                Model = a.Model,
                                Fiyat = (int)a.Fiyat,
                                AlindigiTarih = (DateTime)a.AlindigiTarih,
                                Plaka = a.Plaka,
                                Satildimi = (int)a.Satildimi,
                            }).ToList();
            }
            return grjsonuc;
        }
        //Araba Ekleme Kodları
        public static int ekle(ArabaSurragate araba)
        {
            int id;
            // Ekle Kodları ---

            using (DB_OtoGaleriEntities db = new DB_OtoGaleriEntities())
            {
                TB_Araba a = new TB_Araba();
                a.Marka = araba.Marka;
                a.Model = araba.Model;
                a.Yil = araba.Yil;
                a.Km = araba.Km;
                a.Yakıt = araba.Yakıt;
                a.Renk = araba.Renk;
                a.AracTNo = araba.AracTNo;
                a.Plaka = araba.Plaka;
                a.AlisFiyat = araba.AlisFiyat;
                a.Fiyat = araba.Fiyat;
                a.TedarikciAdi = araba.TedarikciAdi;
                a.TedarikciTel = araba.TedarikciTel;
                a.AlindigiTarih = araba.AlindigiTarih;
                a.Satildimi = 0;

                db.TB_Araba.Add(a);
                db.SaveChanges();
                id = a.ArabaID;
            }
            return id;
            //for (int i = 0; i < listBox1.Items.Count; i++)
            //{
            //    resim.ResimYolu = listBox1.Items[i].ToString();
            //    resim.ArabaID = id;
            //    resimekle.TB_Resimler.Add(resim);
            //    resimekle.SaveChanges();
            //}
        }
        //Resim Ekleme Kodları
        public static bool resimget(ResimlerSurragate rsmekle)
        {
            //Resim ekleme kodları ---
            bool rsmsonuc;

            using (DB_OtoGaleriEntities rsm = new DB_OtoGaleriEntities())
            {
                TB_Resimler r = new TB_Resimler();
                r.ResimYolu = rsmekle.ResimYolu;
                r.ArabaID = rsmekle.ArabaID;
                rsm.TB_Resimler.Add(r);
                rsm.SaveChanges();
            }
            rsmsonuc = true;
            return rsmsonuc;
        }
        //Marka-Tip Getirme Kodları
        public static List<MarkaModelSurragate> markagetir(int modelid)
        {
            List<MarkaModelSurragate> sonuc = new List<MarkaModelSurragate>();
            using (DB_OtoGaleriEntities doldur = new DB_OtoGaleriEntities())
            {

                //var markaget = doldur.TB_MarkaModel.Select(g => new { g.MarkaAdı, g.MarkaKodu }).Distinct().ToList();
                //sonuc = (from p in doldur.TB_MarkaModel
                //         select new MarkaModelSurragate
                //         {
                //             MarkaAdı = p.MarkaAdı,
                //             MarkaKodu = (int)p.MarkaKodu,
                //         }).ToList();
                //.GroupBy(p => p.MarkaAdı);
                //select new { g.MarkaAdı, g.MarkaKodu }).ToList().GroupBy(q=>q.MarkaAdı);

                //radDropDownList1.DataSource = markagetir;
                //radDropDownList1.ValueMember = "MarkaKodu";
                //radDropDownList1.DisplayMember = "MarkaAdı";
            }
            return sonuc;
        }
        //Ayrıntılı Göster-Güncelleme Kodları
        public static bool detayli(ArabaSurragate araba)
        {
            bool dtysonuc = true;
            int arabaid = araba.ArabaID;
            using (DB_OtoGaleriEntities getir = new DB_OtoGaleriEntities())
            {
                var g = getir.TB_Araba.Where(q => q.ArabaID == arabaid).FirstOrDefault();
                araba.Km = g.Km;
                araba.Renk = g.Renk;
                araba.Marka = g.Marka;
                araba.Model = g.Model;
                araba.Fiyat = (int)g.Fiyat;
                araba.Plaka = g.Plaka;
                araba.Yakıt = g.Yakıt;
                araba.TedarikciAdi = g.TedarikciAdi;
                araba.TedarikciTel = g.TedarikciTel;
                dtysonuc = true;
            }
            return dtysonuc;
        }
        //Resimleri Getirme Kodları
        public static List<ResimlerSurragate> resimgetir(int araba)
        {
            List<ResimlerSurragate> resimdata = new List<ResimlerSurragate>();
            using (DB_OtoGaleriEntities resim = new DB_OtoGaleriEntities())
            {
                resimdata = (from r in resim.TB_Resimler
                             join y in resim.TB_Araba on r.ArabaID equals y.ArabaID
                             where r.ArabaID == araba
                             select new ResimlerSurragate
                             {
                                 ResimID = (int)r.ResimID,
                                 ArabaID = (int)r.ArabaID,
                                 ResimYolu = r.ResimYolu,
                             }
                               ).ToList();
            }
            return resimdata;
        }
        //----SORGULAR----
        public static int encokMarka(SatilanSurragate marka)
        {
            SatilanSurragate g = new SatilanSurragate();
            int b = 0;
            //using (DB_OtoGaleriEntities db = new DB_OtoGaleriEntities())
            //{
            //      var a = from m in db.TB_Satilan
            //          group m by m.Marka into grp
            //          orderby grp.Marka.Count()descending
            //          select new 
            //          {
            //              marka.Marka = a.Marka,
            //          };
            //}
            return b;
        }
        public static List<SatilanSurragate> seciliAy(int ay)
        {
            DateTime dt = DateTime.Today;
            int mevcutay = dt.Month;

            List<SatilanSurragate> st = new List<SatilanSurragate>();
            using (DB_OtoGaleriEntities db = new DB_OtoGaleriEntities())
            {
                st = (from a in db.TB_Satilan
                      join m in db.TB_Musteri on a.MusteriID equals m.MusteriID
                      where a.SatisTarihi.Value.Month == ay
                      orderby a.SatisFiyat
                      select new SatilanSurragate
                      {
                          ArabaID = (int)a.ArabaID,
                          Marka = a.Marka,
                          Model = a.Model,
                          Plaka = a.Plaka,
                          AlisFiyat = (int)a.AlisFiyat,
                          SatisFiyat = (int)a.SatisFiyat,
                          Kâr = (int)a.SatisFiyat - (int)a.AlisFiyat,
                          SatisTarihi = (DateTime)a.SatisTarihi,
                          Musteriİsim = m.Musteriİsim,
                          Telefon = m.Telefon,
                      }).ToList();
            }
            return st;
        }
        public static List<SatilanSurragate> TarihAraligi(DateTime tarihilk, DateTime tarihson)
        {
            DateTime dt = DateTime.Today;
            int mevcutay = dt.Month;

            List<SatilanSurragate> st = new List<SatilanSurragate>();
            using (DB_OtoGaleriEntities db = new DB_OtoGaleriEntities())
            {
                st = (from a in db.TB_Satilan
                      join m in db.TB_Musteri on a.MusteriID equals m.MusteriID
                      where a.SatisTarihi.Value > tarihilk && a.SatisTarihi.Value < tarihson
                      orderby a.SatisFiyat
                      select new SatilanSurragate
                      {
                          ArabaID = (int)a.ArabaID,
                          Marka = a.Marka,
                          Model = a.Model,
                          Plaka = a.Plaka,
                          AlisFiyat = (int)a.AlisFiyat,
                          SatisFiyat = (int)a.SatisFiyat,
                          Kâr = (int)a.SatisFiyat - (int)a.AlisFiyat,
                          SatisTarihi = (DateTime)a.SatisTarihi,
                          Musteriİsim = m.Musteriİsim,
                          Telefon = m.Telefon,
                      }).ToList();
            }
            return st;
        }
        public static List<SatilanSurragate> AraMarka(string AraMarka)
        {
            DateTime dt = DateTime.Today;
            int mevcutay = dt.Month;

            List<SatilanSurragate> st = new List<SatilanSurragate>();
            using (DB_OtoGaleriEntities db = new DB_OtoGaleriEntities())
            {
                st = (from a in db.TB_Satilan
                      join m in db.TB_Musteri on a.MusteriID equals m.MusteriID
                      where a.Marka.Contains(AraMarka) 
                      orderby a.SatisFiyat
                      select new SatilanSurragate
                      {
                          ArabaID = (int)a.ArabaID,
                          Marka = a.Marka,
                          Model = a.Model,
                          Plaka = a.Plaka,
                          AlisFiyat = (int)a.AlisFiyat,
                          SatisFiyat = (int)a.SatisFiyat,
                          Kâr = (int)a.SatisFiyat - (int)a.AlisFiyat,
                          SatisTarihi = (DateTime)a.SatisTarihi,
                          Musteriİsim = m.Musteriİsim,
                          Telefon = m.Telefon,
                      }).ToList();
            }
            return st;
        }
        public static List<SatilanSurragate> MusteriAra(string Araİsim)
        {
            DateTime dt = DateTime.Today;
            int mevcutay = dt.Month;

            List<SatilanSurragate> st = new List<SatilanSurragate>();
            using (DB_OtoGaleriEntities db = new DB_OtoGaleriEntities())
            {
                st = (from a in db.TB_Satilan
                      join m in db.TB_Musteri on a.MusteriID equals m.MusteriID
                      where m.Musteriİsim.Contains(Araİsim)
                      orderby a.SatisFiyat
                      select new SatilanSurragate
                      {
                          ArabaID = (int)a.ArabaID,
                          Marka = a.Marka,
                          Model = a.Model,
                          Plaka = a.Plaka,
                          AlisFiyat = (int)a.AlisFiyat,
                          SatisFiyat = (int)a.SatisFiyat,
                          Kâr = (int)a.SatisFiyat - (int)a.AlisFiyat,
                          SatisTarihi = (DateTime)a.SatisTarihi,
                          Musteriİsim = m.Musteriİsim,
                          Telefon = m.Telefon,
                      }).ToList();
            }
            return st;
        }
        public static List<SatilanSurragate> ModelAra(string AraModel)
        {
            DateTime dt = DateTime.Today;
            int mevcutay = dt.Month;

            List<SatilanSurragate> st = new List<SatilanSurragate>();
            using (DB_OtoGaleriEntities db = new DB_OtoGaleriEntities())
            {
                st = (from a in db.TB_Satilan
                      join m in db.TB_Musteri on a.MusteriID equals m.MusteriID
                      where a.Model.Contains(AraModel)
                      orderby a.SatisFiyat
                      select new SatilanSurragate
                      {
                          ArabaID = (int)a.ArabaID,
                          Marka = a.Marka,
                          Model = a.Model,
                          Plaka = a.Plaka,
                          AlisFiyat = (int)a.AlisFiyat,
                          SatisFiyat = (int)a.SatisFiyat,
                          Kâr = (int)a.SatisFiyat - (int)a.AlisFiyat,
                          SatisTarihi = (DateTime)a.SatisTarihi,
                          Musteriİsim = m.Musteriİsim,
                          Telefon = m.Telefon,
                      }).ToList();
            }
            return st;
        }
        public static int IslemEkleBanka(BankaSurragate bankaSur)
        {
            using (DB_OtoGaleriEntities DB = new DB_OtoGaleriEntities())
            {
                TB_Banka bank = new TB_Banka();
                bank.İslemCesidi = bankaSur.islemCesidi;
                bank.İslemAciklama = bankaSur.İslemAciklama;
                var g = (from a in DB.TB_Banka
                         orderby a.İslemID descending
                         select a.BankadakiPara).FirstOrDefault();
                                             
                if (g == null)
                {
                    bank.BankadakiPara = bankaSur.BankadakiPara + 0;
                }
                else
                {
                    bank.BankadakiPara = bankaSur.BankadakiPara + g;
                }
                var k = (from a in DB.TB_Banka
                         orderby a.İslemID descending
                         select a.KasadakiPara).FirstOrDefault();

                if (k == null)
                {
                    bank.KasadakiPara = bankaSur.BankadakiPara + 0;
                }
                else
                {
                    bank.KasadakiPara = k;
                }
                DB.TB_Banka.Add(bank);
                DB.SaveChanges();
                return bank.İslemID;
            }
        }
        public static int IslemEkleKasa(BankaSurragate bankaSur)
        {
            using (DB_OtoGaleriEntities DB = new DB_OtoGaleriEntities())
            {
                TB_Banka bank = new TB_Banka();
                bank.İslemCesidi = bankaSur.islemCesidi;
                bank.İslemAciklama = bankaSur.İslemAciklama;
                var g = (from a in DB.TB_Banka
                         orderby a.İslemID descending
                         select a.BankadakiPara).FirstOrDefault();

                if (g == null)
                {
                    bank.BankadakiPara = bankaSur.BankadakiPara + 0;
                }
                else
                {
                    bank.BankadakiPara = g;
                }
                var k = (from a in DB.TB_Banka
                         orderby a.İslemID descending
                         select a.KasadakiPara).FirstOrDefault();

                if (k == null)
                {
                    bank.KasadakiPara = bankaSur.KasadakiPara + 0;
                }
                else
                {
                    bank.KasadakiPara = bankaSur.KasadakiPara + k;
                }
                DB.TB_Banka.Add(bank);
                DB.SaveChanges();
                return bank.İslemID;
            }
        }
        public static int BankaBakiye(BankaSurragate bnk)
        {
            using (DB_OtoGaleriEntities DB = new DB_OtoGaleriEntities())
            {
                var g = (from a in DB.TB_Banka
                         orderby a.İslemID descending
                         select a.BankadakiPara).FirstOrDefault();
                return g.Value;
            }
        }
        public static int KasaBakiye(BankaSurragate bnk)
        {
            using (DB_OtoGaleriEntities DB = new DB_OtoGaleriEntities())
            {
                var g = (from a in DB.TB_Banka
                         orderby a.İslemID descending
                         select a.KasadakiPara).FirstOrDefault();
                return g.Value;

            }
        }
        public static List<BankaSurragate> İslemGetir(int sonuc)
        {
            List<BankaSurragate> bk = new List<BankaSurragate>();
            using (DB_OtoGaleriEntities DB = new DB_OtoGaleriEntities())
            {
                bk = (from a in DB.TB_Banka
                      select new BankaSurragate
                      {
                          BankadakiPara = (int)a.BankadakiPara,
                          KasadakiPara = (int)a.KasadakiPara,
                          islemCesidi = (int)a.İslemCesidi,
                          İslemAciklama = a.İslemAciklama,
                      }).ToList();
                return bk;
            }
        }
    }
}
