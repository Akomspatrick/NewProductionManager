using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductReceptionEvent  : BaseEntity
    {
        private ProductReceptionEvent(){}
        public string Notes    { get; init; }  = string.Empty; 
        public Int32 ProductId    { get; init; } 
        public Product Product    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public DateTime TimeStamp    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static ProductReceptionEvent Create(string  notes, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductReceptionEvent Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            Notes = notes ,
            ProductId = productId ,
            UserName = userName ,
            TimeStamp = timeStamp ,
            GuidId = guidId ,
        };
    }
    }
}