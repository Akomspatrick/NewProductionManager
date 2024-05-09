using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductGaugeInspectionEvent  : BaseEntity
    {
        private ProductGaugeInspectionEvent(){}
        public Int32 InspectionResult    { get; init; } 
        public string DefectName    { get; init; }  = string.Empty; 
        public Int32 GaugeFailed    { get; init; } 
        public Int32 GaugePassed    { get; init; } 
        public Int32 ProductId    { get; init; } 
        public Product Product    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public DateTime TimeStamp    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static ProductGaugeInspectionEvent Create(Int32  inspectionResult, string  defectName, Int32  gaugeFailed, Int32  gaugePassed, Int32  productId, string  userName, DateTime  timeStamp, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductGaugeInspectionEvent Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            InspectionResult = inspectionResult ,
            DefectName = defectName ,
            GaugeFailed = gaugeFailed ,
            GaugePassed = gaugePassed ,
            ProductId = productId ,
            UserName = userName ,
            TimeStamp = timeStamp ,
            GuidId = guidId ,
        };
    }
    }
}