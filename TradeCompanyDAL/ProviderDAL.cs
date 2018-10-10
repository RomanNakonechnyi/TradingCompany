using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeCompanyDAL
{
    public class ProviderDAL : TradingCompanyEntities
    {
        public List<tblProvider> GetProviders()
        {
            using (var db = new ProviderDAL())
            {
                return db.tblProviders
                    .Where(x => x.blocked == false)
                    .ToList();
            }
        }

        public List<tblProvider> SortProviders(List<tblProvider> providers,int type)
        {
            switch (type)
            {
                case 1:
                    return providers.OrderBy(x=>x.name).ToList();
                case 2:
                    return providers.OrderByDescending(x => x.name).ToList();
                case 3:
                    return providers.OrderBy(x => x.rating).ToList();
                case 4:
                    return providers.OrderByDescending(x => x.rating).ToList();

                default:
                    return providers;
            }
            
        }

        public List<tblProvider> GetBlockedProviders()
        {
            using (var db = new ProviderDAL())
            {
                return db.tblProviders
                    .Where(x => x.blocked == true)
                    .ToList();
            }
        }

        public int UnblockById(int id)
        {
            using (var db = new ProviderDAL())
            {
                var result = db.tblProviders.SingleOrDefault(p => p.providerID == id);
                if (result != null)
                {
                    result.blocked = false;
                    db.SaveChanges();
                    return result.providerID;
                }
                return 0;
            }
        }

        public int BlockById(int id)
        {
            using (var db = new ProviderDAL())
            {
                var result = db.tblProviders.SingleOrDefault(p => p.providerID == id);
                if (result != null)
                {
                    result.blocked = true;
                    db.SaveChanges();
                    return result.providerID;
                }
                return 0;
            }
        }

        public tblProvider GetProviderById(int id)
        {
            using (var db = new ProviderDAL())
            {
                return db.tblProviders.FirstOrDefault(p => p.providerID == id);
            }
        }
        
        public tblProvider GetProviderByName(string name)
        {
            using (var db = new ProviderDAL())
            {
                return db.tblProviders
                    .Where(p => p.name == name)
                    .FirstOrDefault();
            }
        }

        public int AddProvider(tblProvider provider)
        {
            if (provider != null)
            {
                using (var db = new ProviderDAL())
                {
                    db.tblProviders.Add(provider);
                    db.SaveChanges();
                    return provider.providerID;
                }
            }return 0;
        }
    }
}
