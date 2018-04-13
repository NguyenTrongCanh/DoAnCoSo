using System;

namespace Cinema.Data.Infastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
       
        private DoAnCoSoDbContext dbContext;

        public DoAnCoSoDbContext Init()
        {
            return dbContext ?? (dbContext = new DoAnCoSoDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}