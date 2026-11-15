using System;
using System.Collections.Generic;
using System.Text;

namespace SuTahsilat.DAL.Entity
{
    public class Tarife
    {
        public int TarifeID { get; set; }
        public string TarifeAdi { get; set; } = string.Empty;
        public ICollection<Sayac> Sayaclar { get; set; } = new List<Sayac>();//Bu tablonun sayac tablosuyla ilişkisi var
        public ICollection<Ucret> Ucretler { get; set; } = new List<Ucret>();//Bu tablonun ucret tablosuyla ilişkisi var
    }
}
