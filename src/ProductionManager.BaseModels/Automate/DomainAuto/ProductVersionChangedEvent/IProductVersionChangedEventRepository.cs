using ProductionManager.Domain.Entities;
namespace ProductionManager.Domain.Interfaces
{
    public  interface IProductVersionChangedEventRepository:IGenericRepository< ProductVersionChangedEvent>
    {
    }
}