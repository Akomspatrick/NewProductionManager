using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class LogSummary  : BaseEntity
    {
        private LogSummary(){}
        public Guid LogSummaryId    { get; init; } 
        public string Stage    { get; init; }  = string.Empty; 
        public DateTime StartTime    { get; init; } 
        public DateTime StopTime    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public Int32 NoOfItemsProcessed    { get; init; } 
        private  List <LogDetail> _LogDetails { get;  set;}  = new List<LogDetail>();
        public  IReadOnlyCollection<LogDetail> LogDetails => _LogDetails;
        public Guid GuidId    { get; init; } 
        
        public static LogSummary Create(Guid  logSummaryId, string  stage, DateTime  startTime, DateTime  stopTime, string  userName, Int32  noOfItemsProcessed, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"LogSummary Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            LogSummaryId = logSummaryId ,
            Stage = stage ,
            StartTime = startTime ,
            StopTime = stopTime ,
            UserName = userName ,
            NoOfItemsProcessed = noOfItemsProcessed ,
            GuidId = guidId ,
        };
    }
    }
}