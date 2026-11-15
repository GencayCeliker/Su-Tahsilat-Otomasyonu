using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SuTahsilat.DAL.Context
{
    public class SuTahsilatDBContextFactory: IDesignTimeDbContextFactory<SuTahsilatDBContext>
    {
        //SuTahsilatDBContextFactory veri tabanına bağlanmak için gerekli olan bağlantı cümlesini oluşturup, SuTahsilatDBContext nesnesi oluşturup döndüren bir sınıftır.
        public SuTahsilatDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SuTahsilatDBContext>();
            var conStr="Server=.\\SQLEXPRESS;" +
                         "Database=SuTahsilat_BGrubu;" +
                         "Trusted_Connection=True;" +
                         "TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(conStr);
            return new SuTahsilatDBContext(optionsBuilder.Options);//bağlantı kurup dbcontext nesnesi oluşturup döndürüyoruz
        }
       
    }
}
