using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class DefectType  : BaseEntity
    {
        private DefectType(){}
        public string DefectName    { get; init; }  = string.Empty; 
        public string Stage    { get; init; }  = string.Empty; 
        public string DefectDescription    { get; init; }  = string.Empty; 
        public decimal TriggerPercentage    { get; init; } 
        public int MinTotalProductInBatchB4Trigger    { get; init; } 
        public ProductStage ProductStage    { get; init; } 
        private  List <DefectTypeSolution> _DefectTypeSolutions { get;  set;}  = new List<DefectTypeSolution>();
        public  IReadOnlyCollection<DefectTypeSolution> DefectTypeSolutions => _DefectTypeSolutions;
        public Guid GuidId    { get; init; } 
        
        public static DefectType Create(string  defectName, string  stage, string  defectDescription, decimal  triggerPercentage, int  minTotalProductInBatchB4Trigger, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"DefectType Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            DefectName = defectName ,
            Stage = stage ,
            DefectDescription = defectDescription ,
            TriggerPercentage = triggerPercentage ,
            MinTotalProductInBatchB4Trigger = minTotalProductInBatchB4Trigger ,
            GuidId = guidId ,
        };
    }
    }
}