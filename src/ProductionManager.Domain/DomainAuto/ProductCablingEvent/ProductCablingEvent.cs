using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductCablingEvent  : BaseEntity
    {
        private ProductCablingEvent(){}
        public Int32 ProductId    { get; init; } 
        public Product Product    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public DateTime TimeStamp    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static ProductCablingEvent Create(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductCablingEvent Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            ProductId = productId ,
            UserName = userName ,
            TimeStamp = timeStamp ,
            GuidId = guidId ,
        };
    }
    }
}