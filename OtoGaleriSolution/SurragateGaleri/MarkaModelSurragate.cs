using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurragateGaleri
{
    //[ArabaID] [int] IDENTITY(1,1) NOT NULL,
    //[MarkaKodu] [int] NULL,
    //[ModelKodu] [int] NULL,
    //[MarkaAdı] [varchar](max) NULL,
    //[ModelAdı] [varchar](max) NULL,
    public class MarkaModelSurragate
    {
        public int ArabaID { get; set; }
        public int MarkaKodu { get; set; }
        public int ModelKodu { get; set; }
        public string MarkaAdı { get; set; }
        public string ModelAdı { get; set; }
    }
}
