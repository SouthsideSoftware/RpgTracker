using System.Threading.Tasks;

namespace RpgTracker.Storage
{
    public interface IDatabaseConnection
    {
        IUnitOfWork OpenUnitOfWorkAsync();
        void DeleteDatabase();
    }
}