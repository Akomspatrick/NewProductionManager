using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class Test  : BaseEntity
    {
        private Test(){}
        public DateTime Timestamp    { get; init; } 
        public Int32 ProductId    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public string RefStandardSerialNo    { get; init; }  = string.Empty; 
        public string RefStandardManufacturer    { get; init; }  = string.Empty; 
        public string RefStandardModelName    { get; init; }  = string.Empty; 
        public decimal ExcitationResistance    { get; init; } 
        public decimal SignalResistance    { get; init; } 
        public Product Product    { get; init; } 
        public ReferenceStandard ReferenceStandard    { get; init; } 
        // public Guid GuidId    { get; init; } 
        
        public static Test Create(DateTime  timestamp, Int32  productId, string  userName, string  refStandardSerialNo, string  refStandardManufacturer, string  refStandardModelName, decimal  excitationResistance, decimal  signalResistance, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"Test Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            Timestamp = timestamp ,
            ProductId = productId ,
            UserName = userName ,
            RefStandardSerialNo = refStandardSerialNo ,
            RefStandardManufacturer = refStandardManufacturer ,
            RefStandardModelName = refStandardModelName ,
            ExcitationResistance = excitationResistance ,
            SignalResistance = signalResistance ,
            GuidId = guidId ,
        };
    }
    }
}