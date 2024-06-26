using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductVersionChangedEvent  : BaseEntity
    {
        private ProductVersionChangedEvent(){}
        public Int32 PrevModelVersionId    { get; init; } 
        public string PrevModelName    { get; init; }  = string.Empty; 
        public Int32 CurrentModelVersionId    { get; init; } 
        public string CurrentPrevModelName    { get; init; }  = string.Empty; 
        public Int32 ProductId    { get; init; } 
        public Product Product    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public DateTime TimeStamp    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static ProductVersionChangedEvent Create(Int32  prevModelVersionId, string  prevModelName, Int32  currentModelVersionId, string  currentPrevModelName, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductVersionChangedEvent Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            PrevModelVersionId = prevModelVersionId ,
            PrevModelName = prevModelName ,
            CurrentModelVersionId = currentModelVersionId ,
            CurrentPrevModelName = currentPrevModelName ,
            ProductId = productId ,
            UserName = userName ,
            TimeStamp = timeStamp ,
            GuidId = guidId ,
        };
    }
    }
}