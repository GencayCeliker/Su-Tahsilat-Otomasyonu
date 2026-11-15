using System;
using System.Collections.Generic;
using System.Text;

namespace SuTahsilat.DAL.Entity
{
    public class Ucret
    {
        public int UcretID { get; set; }
        public int TarifeID { get; set; }
        public Tarife? Tarife { get; set; } 
        public DateTime GecerliTarih { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal CTVOrani { get; set; }
        public decimal ABOrani { get; set; }
        public decimal KDVOrani { get; set; }


    }
}
