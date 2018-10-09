using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCompanyDAL
{
    public class ProviderDAL : DbContext
    {
        public ProviderDAL():base("TradingCompanyEntities")
        {
        }

        public DbSet<tblProvider> Providers { get; set; }

        public List<tblProvider> GetProviders()
        {
            using (var db = new ProviderDAL())
            {
                return db.Providers.ToList();
            }
        }
    }
}
