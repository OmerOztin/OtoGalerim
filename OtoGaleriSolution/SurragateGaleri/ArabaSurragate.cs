

using System;
namespace SurragateGaleri
{
    //[ArabaID] [int] IDENTITY(1,1) NOT NULL,
    //[Marka] [varchar](50) NULL,
    //[Model] [varchar](50) NULL,
    //[Yil] [datetime] NULL,
    //[Km] [varchar](50) NULL,
    //[Yakıt] [varchar](50) NULL,
    //[Renk] [varchar](50) NULL,
    //[AracTNo] [varchar](50) NULL,
    //[Plaka] [varchar](50) NULL,
    //[AlisFiyat] [int] NULL,
    //[Fiyat] [int] NULL,
    //[TedarikciAdi] [varchar](50) NULL,
    //[TedarikciTel] [varchar](50) NULL,
    //[AlindigiTarih] [datetime] NULL,
    //[ResimID] [int] NULL,
    public class ArabaSurragate
    {  
        public int ArabaID { get; set;}
        public string Marka { get; set;}
        public string Model { get; set; }
        public DateTime Yil { get; set; }
        public string Km { get; set; }
        public string Yakıt { get; set; }
        public string Renk { get; set; }
        public string AracTNo { get; set; }
        public string Plaka { get; set; }
        public int AlisFiyat { get; set; }
        public int Fiyat { get; set; }
        public string TedarikciAdi { get; set; }
        public string TedarikciTel { get; set; }
        public DateTime AlindigiTarih { get; set; }
        public int ResimID { get; set; }
        public int Satildimi { get; set; }
    }
}
