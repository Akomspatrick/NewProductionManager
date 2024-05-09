using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ReferenceCellCalibration  : BaseEntity
    {
        private ReferenceCellCalibration(){}
        public Int32 Weight    { get; init; } 
        public string RefStandardManufacturer    { get; init; }  = string.Empty; 
        public string RefStandardModelName    { get; init; }  = string.Empty; 
        public string RefStandardSerialNo    { get; init; }  = string.Empty; 
        public decimal LowMeasuredPosition    { get; init; } 
        public decimal LowCurrent    { get; init; } 
        public decimal HighMeasuredPosition    { get; init; } 
        public decimal HighCurrent    { get; init; } 
        public ReferenceStandard ReferenceStandard    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static ReferenceCellCalibration Create(Int32  weight, string  refStandardManufacturer, string  refStandardModelName, string  refStandardSerialNo, decimal  lowMeasuredPosition, decimal  lowCurrent, decimal  highMeasuredPosition, decimal  highCurrent, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ReferenceCellCalibration Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            Weight = weight ,
            RefStandardManufacturer = refStandardManufacturer ,
            RefStandardModelName = refStandardModelName ,
            RefStandardSerialNo = refStandardSerialNo ,
            LowMeasuredPosition = lowMeasuredPosition ,
            LowCurrent = lowCurrent ,
            HighMeasuredPosition = highMeasuredPosition ,
            HighCurrent = highCurrent ,
            GuidId = guidId ,
        };
    }
    }
}