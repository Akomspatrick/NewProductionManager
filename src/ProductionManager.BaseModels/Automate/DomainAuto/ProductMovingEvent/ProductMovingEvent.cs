using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductMovingEvent  : BaseEntity
    {
        private ProductMovingEvent(){}
        public string SourceStage    { get; init; }  = string.Empty; 
        public string DestinationStage    { get; init; }  = string.Empty; 
        public string MovingNotes    { get; init; }  = string.Empty; 
        public Int32 ProductId    { get; init; } 
        public Product Product    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public DateTime TimeStamp    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static ProductMovingEvent Create(string  sourceStage, string  destinationStage, string  movingNotes, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductMovingEvent Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            SourceStage = sourceStage ,
            DestinationStage = destinationStage ,
            MovingNotes = movingNotes ,
            ProductId = productId ,
            UserName = userName ,
            TimeStamp = timeStamp ,
            GuidId = guidId ,
        };
    }
    }
}