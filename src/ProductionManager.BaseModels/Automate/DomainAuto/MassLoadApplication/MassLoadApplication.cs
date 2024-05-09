using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class MassLoadApplication  : BaseEntity
    {
        private MassLoadApplication(){}
        public string Name    { get; init; }  = string.Empty; 
        public string Description    { get; init; }  = string.Empty; 
        public Guid GuidId    { get; init; } 
        
        public static MassLoadApplication Create(string  name, string  description, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"MassLoadApplication Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            Name = name ,
            Description = description ,
            GuidId = guidId ,
        };
    }
    }
}