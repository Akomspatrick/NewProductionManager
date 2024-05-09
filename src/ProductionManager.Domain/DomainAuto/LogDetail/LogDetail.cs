using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class LogDetail  : BaseEntity
    {
        private LogDetail(){}
        public Int32 ProductId    { get; init; } 
        public Guid LogSummaryId    { get; init; } 
        public LogSummary LogSummary    { get; init; } 
        // public Guid GuidId    { get; init; } 
        
        public static LogDetail Create(Int32  productId, Guid  logSummaryId, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"LogDetail Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            ProductId = productId ,
            LogSummaryId = logSummaryId ,
            GuidId = guidId ,
        };
    }
    }
}