using SuTahsilat.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuTahsilat.BLL.Services
{
    public class TarifeService: DbServiceBase//DbServiceBase sınıfından kalıtım alarak CreateContext metodunu kullanabileceğiz
    {
        public List<Tarife> GetAllTarifeler()
        {
			try
			{
				using var context = CreateContext();
				return context.Tarifeler.OrderBy(t => t.TarifeAdi).ToList();
            }
			catch (Exception ex)
			{

				throw new Exception("Tarifeler alınırken bir hata oluştu: "+"Detay: " + ex.Message);
            }
			
        }
        public void AddDefaultTarifelerIfNotExist()//tarifeler yoksa geçerli tarifeleri ekleyecek bir metod oluşturduk
        {
            try
            {
                using var context = CreateContext();
                if (!context.Tarifeler.Any())//any herhangi demek yoksa
                {
                    context.Tarifeler.AddRange(
                        new Tarife { TarifeAdi = "Konut" },
                        new Tarife { TarifeAdi = "İşyeri" },
                        new Tarife { TarifeAdi = "Resmi Kurum" }
                    );
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Varsayılan tarifeler eklenirken bir hata oluştu: " + "Detay: " + ex.Message);
            }
        }
    }
}
