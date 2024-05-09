using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class TrimmingResistor  : BaseEntity
    {
        private TrimmingResistor(){}
        public decimal Value    { get; init; } 
        // public Guid GuidId    { get; init; } 
        
        public static TrimmingResistor Create(decimal  value, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"TrimmingResistor Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            Value = value ,
            GuidId = guidId ,
        };
    }
    }
}