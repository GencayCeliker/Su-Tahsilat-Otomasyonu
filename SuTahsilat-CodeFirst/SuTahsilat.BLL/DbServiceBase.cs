using Microsoft.EntityFrameworkCore;
using SuTahsilat.BLL.Common;
using SuTahsilat.DAL.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuTahsilat.BLL
{
    public abstract class DbServiceBase
    {
        protected SuTahsilatDBContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<SuTahsilatDBContext>().UseSqlServer(DatabaseSettings.ConnectionString).Options;
            return new SuTahsilatDBContext(options);
        }
    }
}

    
