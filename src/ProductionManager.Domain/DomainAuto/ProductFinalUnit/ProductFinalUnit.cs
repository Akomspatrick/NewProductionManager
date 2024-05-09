using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductFinalUnit  : BaseEntity
    {
        private ProductFinalUnit(){}
        public int ProductId    { get; init; } 
        public DateTime TimeStamp    { get; init; } 
        public string InputUnit    { get; init; }  = string.Empty; 
        public string OuputUnits    { get; init; }  = string.Empty; 
        public string IndicatorType    { get; init; }  = string.Empty; 
        public int IndicatorChannel    { get; init; } 
        public string IndicatorSerialNo    { get; init; }  = string.Empty; 
        public int GradSize    { get; init; } 
        public decimal PinSize    { get; init; } 
        public int Division    { get; init; } 
        public decimal LowWeight    { get; init; } 
        public decimal HighWeight    { get; init; } 
        public Product Product    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static ProductFinalUnit Create(int  productId, DateTime  timeStamp, string  inputUnit, string  ouputUnits, string  indicatorType, int  indicatorChannel, string  indicatorSerialNo, int  gradSize, decimal  pinSize, int  division, decimal  lowWeight, decimal  highWeight, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductFinalUnit Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            ProductId = productId ,
            TimeStamp = timeStamp ,
            InputUnit = inputUnit ,
            OuputUnits = ouputUnits ,
            IndicatorType = indicatorType ,
            IndicatorChannel = indicatorChannel ,
            IndicatorSerialNo = indicatorSerialNo ,
            GradSize = gradSize ,
            PinSize = pinSize ,
            Division = division ,
            LowWeight = lowWeight ,
            HighWeight = highWeight ,
            GuidId = guidId ,
        };
    }
    }
}