namespace Infrastructure.Core
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}