using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductShippingEvent  : BaseEntity
    {
        private ProductShippingEvent(){}
        public Int32 ProductId    { get; init; } 
        public Product Product    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public DateTime TimeStamp    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static ProductShippingEvent Create(Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductShippingEvent Guid value cannot be empty {nameof(guidId)}");
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