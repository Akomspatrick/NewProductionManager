using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductFinalVerifiationEvent  : BaseEntity
    {
        private ProductFinalVerifiationEvent(){}
        public int Points    { get; init; } 
        public int VerificationResult    { get; init; } 
        public string ReferenceSerial    { get; init; }  = string.Empty; 
        public string TesterName    { get; init; }  = string.Empty; 
        public decimal CalibratedOutput    { get; init; } 
        public decimal PercentNonlinearity    { get; init; } 
        public decimal DutZeroPoint    { get; init; } 
        public decimal RefPoint1    { get; init; } 
        public decimal ForcePoint1    { get; init; } 
        public decimal DutPoint1    { get; init; } 
        public decimal RefPoint2    { get; init; } 
        public decimal ForcePoint2    { get; init; } 
        public decimal DutPoint2    { get; init; } 
        public decimal RefPoint3    { get; init; } 
        public decimal ForcePoint3    { get; init; } 
        public decimal DutPoint3    { get; init; } 
        public decimal RefPoint4    { get; init; } 
        public decimal ForcePoint4    { get; init; } 
        public decimal DutPoint4    { get; init; } 
        public decimal RefPoint5    { get; init; } 
        public decimal ForcePoint5    { get; init; } 
        public decimal DutPoint5    { get; init; } 
        public decimal RefPoint6    { get; init; } 
        public decimal ForcePoint6    { get; init; } 
        public decimal DutPoint6    { get; init; } 
        public decimal RefPoint7    { get; init; } 
        public decimal ForcePoint7    { get; init; } 
        public decimal DutPoint7    { get; init; } 
        public decimal RefPoint8    { get; init; } 
        public decimal ForcePoint8    { get; init; } 
        public decimal DutPoint8    { get; init; } 
        public decimal RefPoint9    { get; init; } 
        public decimal ForcePoint9    { get; init; } 
        public decimal DutPoint9    { get; init; } 
        public decimal RefPoint10    { get; init; } 
        public decimal ForcePoint10    { get; init; } 
        public decimal DutPoint10    { get; init; } 
        public Tester Tester    { get; init; } 
        public int ProductId    { get; init; } 
        public Product Product    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public DateTime TimeStamp    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static ProductFinalVerifiationEvent Create(int  points, int  verificationResult, string  referenceSerial, string  testerName, decimal  calibratedOutput, decimal  percentNonlinearity, decimal  dutZeroPoint, decimal  refPoint1, decimal  forcePoint1, decimal  dutPoint1, decimal  refPoint2, decimal  forcePoint2, decimal  dutPoint2, decimal  refPoint3, decimal  forcePoint3, decimal  dutPoint3, decimal  refPoint4, decimal  forcePoint4, decimal  dutPoint4, decimal  refPoint5, decimal  forcePoint5, decimal  dutPoint5, decimal  refPoint6, decimal  forcePoint6, decimal  dutPoint6, decimal  refPoint7, decimal  forcePoint7, decimal  dutPoint7, decimal  refPoint8, decimal  forcePoint8, decimal  dutPoint8, decimal  refPoint9, decimal  forcePoint9, decimal  dutPoint9, decimal  refPoint10, decimal  forcePoint10, decimal  dutPoint10, int  productId, string  userName, DateTime  timeStamp, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductFinalVerifiationEvent Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            Points = points ,
            VerificationResult = verificationResult ,
            ReferenceSerial = referenceSerial ,
            TesterName = testerName ,
            CalibratedOutput = calibratedOutput ,
            PercentNonlinearity = percentNonlinearity ,
            DutZeroPoint = dutZeroPoint ,
            RefPoint1 = refPoint1 ,
            ForcePoint1 = forcePoint1 ,
            DutPoint1 = dutPoint1 ,
            RefPoint2 = refPoint2 ,
            ForcePoint2 = forcePoint2 ,
            DutPoint2 = dutPoint2 ,
            RefPoint3 = refPoint3 ,
            ForcePoint3 = forcePoint3 ,
            DutPoint3 = dutPoint3 ,
            RefPoint4 = refPoint4 ,
            ForcePoint4 = forcePoint4 ,
            DutPoint4 = dutPoint4 ,
            RefPoint5 = refPoint5 ,
            ForcePoint5 = forcePoint5 ,
            DutPoint5 = dutPoint5 ,
            RefPoint6 = refPoint6 ,
            ForcePoint6 = forcePoint6 ,
            DutPoint6 = dutPoint6 ,
            RefPoint7 = refPoint7 ,
            ForcePoint7 = forcePoint7 ,
            DutPoint7 = dutPoint7 ,
            RefPoint8 = refPoint8 ,
            ForcePoint8 = forcePoint8 ,
            DutPoint8 = dutPoint8 ,
            RefPoint9 = refPoint9 ,
            ForcePoint9 = forcePoint9 ,
            DutPoint9 = dutPoint9 ,
            RefPoint10 = refPoint10 ,
            ForcePoint10 = forcePoint10 ,
            DutPoint10 = dutPoint10 ,
            ProductId = productId ,
            UserName = userName ,
            TimeStamp = timeStamp ,
            GuidId = guidId ,
        };
    }
    }
}