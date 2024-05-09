using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductInitialUnit  : BaseEntity
    {
        private ProductInitialUnit(){}
        public Int32 ProductId    { get; init; } 
        public DateTime TimeStamp    { get; init; } 
        public string InputUnits    { get; init; }  = string.Empty; 
        public string OutputUnits    { get; init; }  = string.Empty; 
        public Product Product    { get; init; } 
        // public Guid GuidId    { get; init; } 
        
        public static ProductInitialUnit Create(Int32  productId, DateTime  timeStamp, string  inputUnits, string  outputUnits, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductInitialUnit Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            ProductId = productId ,
            TimeStamp = timeStamp ,
            InputUnits = inputUnits ,
            OutputUnits = outputUnits ,
            GuidId = guidId ,
        };
    }
    }
}