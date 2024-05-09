using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductFinalUnit  : BaseEntity
    {
        private ProductFinalUnit(){}
        public Int32 ProductId    { get; init; } 
        public DateTime TimeStamp    { get; init; } 
        public string InputUnit    { get; init; }  = string.Empty; 
        public string OuputUnits    { get; init; }  = string.Empty; 
        public string IndicatorType    { get; init; }  = string.Empty; 
        public Int32 IndicatorChannel    { get; init; } 
        public string IndicatorSerialNo    { get; init; }  = string.Empty; 
        public Int32 GradSize    { get; init; } 
        public decimal PinSize    { get; init; } 
        public Int32 Division    { get; init; } 
        public decimal LowWeight    { get; init; } 
        public decimal HighWeight    { get; init; } 
        public Product Product    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static ProductFinalUnit Create(Int32  productId, DateTime  timeStamp, string  inputUnit, string  ouputUnits, string  indicatorType, Int32  indicatorChannel, string  indicatorSerialNo, Int32  gradSize, decimal  pinSize, Int32  division, decimal  lowWeight, decimal  highWeight, Guid  guidId)
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