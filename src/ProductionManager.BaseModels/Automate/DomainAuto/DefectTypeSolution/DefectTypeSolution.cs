using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class DefectTypeSolution  : BaseEntity
    {
        private DefectTypeSolution(){}
        public string DefectName    { get; init; }  = string.Empty; 
        public string Stage    { get; init; }  = string.Empty; 
        public string Solution    { get; init; }  = string.Empty; 
        public DateTime Timestamp    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public DefectType DefectType    { get; init; } 
        // public Guid GuidId    { get; init; } 
        
        public static DefectTypeSolution Create(string  defectName, string  stage, string  solution, DateTime  timestamp, string  userName, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"DefectTypeSolution Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            DefectName = defectName ,
            Stage = stage ,
            Solution = solution ,
            Timestamp = timestamp ,
            UserName = userName ,
            GuidId = guidId ,
        };
    }
    }
}