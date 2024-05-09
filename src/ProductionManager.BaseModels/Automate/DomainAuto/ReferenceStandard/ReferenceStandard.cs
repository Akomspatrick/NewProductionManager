using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ReferenceStandard  : BaseEntity
    {
        private ReferenceStandard(){}
        public string RefStandardManufacturer    { get; init; }  = string.Empty; 
        public string RefStandardModelName    { get; init; }  = string.Empty; 
        public string RefStandardSerialNo    { get; init; }  = string.Empty; 
        public Int32 Capacity    { get; init; } 
        public DateTime Timestamp    { get; init; } 
        public decimal B0    { get; init; } 
        public decimal B1    { get; init; } 
        public decimal B2    { get; init; } 
        public decimal B3    { get; init; } 
        public decimal B4    { get; init; } 
        private  List <ReferenceCellCalibration> _ReferenceCellCalibrations { get;  set;}  = new List<ReferenceCellCalibration>();
        public  IReadOnlyCollection<ReferenceCellCalibration> ReferenceCellCalibrations => _ReferenceCellCalibrations;
        private  List <Test> _Tests { get;  set;}  = new List<Test>();
        public  IReadOnlyCollection<Test> Tests => _Tests;
        public Guid GuidId    { get; init; } 
        
        public static ReferenceStandard Create(string  refStandardManufacturer, string  refStandardModelName, string  refStandardSerialNo, Int32  capacity, DateTime  timestamp, decimal  b0, decimal  b1, decimal  b2, decimal  b3, decimal  b4, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ReferenceStandard Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            RefStandardManufacturer = refStandardManufacturer ,
            RefStandardModelName = refStandardModelName ,
            RefStandardSerialNo = refStandardSerialNo ,
            Capacity = capacity ,
            Timestamp = timestamp ,
            B0 = b0 ,
            B1 = b1 ,
            B2 = b2 ,
            B3 = b3 ,
            B4 = b4 ,
            GuidId = guidId ,
        };
    }
    }
}