using ProductionManager.Domain.Entities;
namespace ProductionManager.Domain.Interfaces
{
    public  interface IProductFinishedEventRepository:IGenericRepository< ProductFinishedEvent>
    {
    }
}