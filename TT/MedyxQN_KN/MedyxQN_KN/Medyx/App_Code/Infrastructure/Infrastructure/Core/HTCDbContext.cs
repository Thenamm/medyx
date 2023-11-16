namespace Infrastructure.Core
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class HTCDbContext : DbContext
    {
        public HTCDbContext()
            : base("name=HTCDbContext")
        {
            var objectContext = (this as IObjectContextAdapter).ObjectContext;

            // Sets the command timeout for all the commands
            objectContext.CommandTimeout = 500;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}