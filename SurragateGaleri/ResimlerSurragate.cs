
namespace SurragateGaleri
{
    //ResimID] [int] IDENTITY(1,1) NOT NULL,
    //[ArabaID] [int] NULL,
    //[ResimYolu] [varchar](max) NULL,
    public class ResimlerSurragate
    {
        public int ResimID { get; set; }
        public int ArabaID { get; set; }
        public string ResimYolu { get; set; }
    }
}
