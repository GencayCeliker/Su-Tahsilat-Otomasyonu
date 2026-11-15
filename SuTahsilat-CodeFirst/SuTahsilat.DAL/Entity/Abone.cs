using System;
using System.Collections.Generic;
using System.Text;

namespace SuTahsilat.DAL.Entity
{
    public class Abone
    {
        public int AboneID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string TCKimlikNo { get; set; }

        public string Adres { get; set; }

        public string Telefon { get; set; }

        public ICollection<Sayac> Sayaclar { get; set; }=new List<Sayac>();//Bu tablonun sayac tablosuyla ilişkisi var
    }
}
