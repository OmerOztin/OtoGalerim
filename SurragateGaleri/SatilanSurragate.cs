using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurragateGaleri
{
    public class SatilanSurragate
    {
        public int SatisID { get; set; }
        public int SatisFiyat { get; set; }
        public DateTime SatisTarihi { get; set; }
        public int MusteriID { get; set; }
            public int ArabaID { get; set; }
            public int AlisFiyat { get; set; }
            public int Kâr { get; set; }
            public string Marka { get; set; }
            public string Model { get; set; }
            public string Plaka { get; set; }
            public int ResimID { get; set; }
            public int İslemID { get; set; }
            public string Musteriİsim { get; set; }
            public string Telefon { get; set; }
    }
}
