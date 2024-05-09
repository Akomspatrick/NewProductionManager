using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductGaugeInspectionEvent  : BaseEntity
    {
        private ProductGaugeInspectionEvent(){}
        public int InspectionResult    { get; init; } 
        public string DefectName    { get; init; }  = string.Empty; 
        public int GaugeFailed    { get; init; } 
        public int GaugePassed    { get; init; } 
        public int ProductId    { get; init; } 
        public Product Product    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public DateTime TimeStamp    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static ProductGaugeInspectionEvent Create(int  inspectionResult, string  defectName, int  gaugeFailed, int  gaugePassed, int  productId, string  userName, DateTime  timeStamp, Guid  guidId)
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