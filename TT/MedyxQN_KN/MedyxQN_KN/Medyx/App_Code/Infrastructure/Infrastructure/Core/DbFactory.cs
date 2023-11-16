namespace Infrastructure.Core
{
    public class DbFactory : Dispoable, IDbFactory
    {
        private HTCDbContext dbContext;

        public HTCDbContext Init()
        {
            return dbContext ?? (dbContext = new HTCDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}