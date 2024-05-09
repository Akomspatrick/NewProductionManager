using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class MassfussionFunction  : BaseEntity
    {
        private MassfussionFunction(){}
        public string Claim    { get; init; }  = string.Empty; 
        public string Description    { get; init; }  = string.Empty; 
        public string ApplicationName    { get; init; }  = string.Empty; 
        public Guid GuidId    { get; init; } 
        
        public static MassfussionFunction Create(string  claim, string  description, string  applicationName, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"MassfussionFunction Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            Claim = claim ,
            Description = description ,
            ApplicationName = applicationName ,
            GuidId = guidId ,
        };
    }
    }
}