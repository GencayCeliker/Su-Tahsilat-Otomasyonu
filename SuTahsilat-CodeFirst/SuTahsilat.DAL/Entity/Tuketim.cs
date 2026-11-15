using System;
using System.Collections.Generic;
using System.Text;

namespace SuTahsilat.DAL.Entity
{
    public class Tuketim
    {
        public int TuketimID { get; set; }
        public int SayacID { get; set; }
        public Sayac? Sayac { get; set; } 
        public DateTime TuketimTarihi { get; set; }
        public int Endeks { get; set; }
        public int TuketilenMiktari { get; set; }
        public decimal Tutar { get; set; }
    }
}
