 
namespace Infrastructure.Core
{
    public interface IDbFactory
    {
        HTCDbContext Init();
    }
}