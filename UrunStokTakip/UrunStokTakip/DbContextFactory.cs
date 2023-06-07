using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunStokTakip
{
    // Burada Dependecy Injection yöntemiyle static bir class oluşturdum. Çünkü her seferinde dbStokTakipEntities nesnesi üretmek istemiyorum.
    public static class DbContextFactory
    {
        private static DbStokTakipEntities5 _dbContext;

        public static DbStokTakipEntities5 GetDbContext()
        {
            if (_dbContext == null)
            {
                _dbContext = new DbStokTakipEntities5();
            }
            return _dbContext;
        }
    }
}
