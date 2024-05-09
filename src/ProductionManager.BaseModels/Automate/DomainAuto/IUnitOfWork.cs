using LanguageExt;
using ProductionManager.Domain.Errors;
namespace ProductionManager.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<Either<GeneralFailure, int>> CommitAllChanges(CancellationToken cancellationToken);
    }
}