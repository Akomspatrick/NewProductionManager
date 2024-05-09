using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductSurfacePreparationEvent  : BaseEntity
    {
        private ProductSurfacePreparationEvent(){}
        public Int32 InspectionResult    { get; init; } 
        public string DefectName    { get; init; }  = string.Empty; 
        public Int32 ProductId    { get; init; } 
        public Product Product    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public DateTime TimeStamp    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static ProductSurfacePreparationEvent Create(Int32  inspectionResult, string  defectName, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductSurfacePreparationEvent Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            InspectionResult = inspectionResult ,
            DefectName = defectName ,
            ProductId = productId ,
            UserName = userName ,
            TimeStamp = timeStamp ,
            GuidId = guidId ,
        };
    }
    }
}