using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOH.Data.Infrastructure
{
    public class DbFactory : IDisposable, IDbFactory
    {

        EOHEntities dbContext;
        public EOHEntities Init()
        {
            return dbContext ?? (dbContext = new EOHEntities());
        }
        public void Dispose()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }


    }
}
