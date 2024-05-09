using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class NonConformanceLog  : BaseEntity
    {
        private NonConformanceLog(){}
        public int ProductId    { get; init; } 
        public int ModelVersionId    { get; init; } 
        public string ModelName    { get; init; }  = string.Empty; 
        public int BatcNo    { get; init; } 
        public string Stage    { get; init; }  = string.Empty; 
        public DateTime WhenItOccurred    { get; init; } 
        public string DefectName    { get; init; }  = string.Empty; 
        public string LogByUserName    { get; init; }  = string.Empty; 
        public string Status    { get; init; }  = string.Empty; 
        public string Solution    { get; init; }  = string.Empty; 
        public DateTime WhenItWasResolved    { get; init; } 
        public string ResolvedByUserName    { get; init; }  = string.Empty; 
        public string Comment    { get; init; }  = string.Empty; 
        public Product Product    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static NonConformanceLog Create(int  productId, int  modelVersionId, string  modelName, int  batcNo, string  stage, DateTime  whenItOccurred, string  defectName, string  logByUserName, string  status, string  solution, DateTime  whenItWasResolved, string  resolvedByUserName, string  comment, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"NonConformanceLog Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            ProductId = productId ,
            ModelVersionId = modelVersionId ,
            ModelName = modelName ,
            BatcNo = batcNo ,
            Stage = stage ,
            WhenItOccurred = whenItOccurred ,
            DefectName = defectName ,
            LogByUserName = logByUserName ,
            Status = status ,
            Solution = solution ,
            WhenItWasResolved = whenItWasResolved ,
            ResolvedByUserName = resolvedByUserName ,
            Comment = comment ,
            GuidId = guidId ,
        };
    }
    }
}