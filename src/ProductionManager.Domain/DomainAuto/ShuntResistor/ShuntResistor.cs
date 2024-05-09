using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ShuntResistor  : BaseEntity
    {
        private ShuntResistor(){}
        public decimal Value    { get; init; } 
        // public Guid GuidId    { get; init; } 
        
        public static ShuntResistor Create(decimal  value, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ShuntResistor Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            Value = value ,
            GuidId = guidId ,
        };
    }
    }
}