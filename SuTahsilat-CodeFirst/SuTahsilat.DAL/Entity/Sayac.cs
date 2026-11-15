using System;
using System.Collections.Generic;
using System.Text;

namespace SuTahsilat.DAL.Entity
{
    public class Sayac
    {
        public int SayacID { get; set; }

        public int AboneID { get; set; }
      //  public Abone Abone { get; set; } = null!; boş geçilemez
        public Abone? Abone { get; set; } //buda aynısı
        public int TarifeID { get; set; }
        public Tarife? Tarife { get; set; } 
        public string Marka { get; set; }
        public string SeriNo { get; set; }
        public ICollection<Tuketim> Tüketimler { get; set; } = new List<Tuketim>();//Bu tablonun sayac tablosuyla ilişkisi var



    }
}
