using System;
using System.Collections.Generic;
using System.Text;

namespace SuTahsilat.BLL.Common
{
    public static class DatabaseSettings
    {
        public const string ConnectionString = "Server=.\\SQLEXPRESS;" +
                                               "Database=SuTahsilat_BGrubu;" +
                                               "Trusted_Connection=True;" +
                                               "TrustedServerCertificate=True";//Const ant olarak tanımlanır, değiştirilemez.
    }
}
