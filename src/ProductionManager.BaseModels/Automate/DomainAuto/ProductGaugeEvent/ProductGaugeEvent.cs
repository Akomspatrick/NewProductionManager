using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductGaugeEvent  : BaseEntity
    {
        private ProductGaugeEvent(){}
        public string GuageModel    { get; init; }  = string.Empty; 
        public string GuageLotNo    { get; init; }  = string.Empty; 
        public Int32 ProductId    { get; init; } 
        public Product Product    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public DateTime TimeStamp    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static ProductGaugeEvent Create(string  guageModel, string  guageLotNo, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductGaugeEvent Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            GuageModel = guageModel ,
            GuageLotNo = guageLotNo ,
            ProductId = productId ,
            UserName = userName ,
            TimeStamp = timeStamp ,
            GuidId = guidId ,
        };
    }
    }
}