using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductAdditionalInfo  : BaseEntity
    {
        private ProductAdditionalInfo(){}
        public int ProductAdditionalInfoId    { get; init; } 
        public int ProductId    { get; init; } 
        public decimal InputVoltage    { get; init; } 
        public decimal CableLenght    { get; init; } 
        public string CableLenghtUnit    { get; init; }  = string.Empty; 
        public Guid GuidId    { get; init; } 
        
        public static ProductAdditionalInfo Create(int  productAdditionalInfoId, int  productId, decimal  inputVoltage, decimal  cableLenght, string  cableLenghtUnit, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductAdditionalInfo Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            ProductAdditionalInfoId = productAdditionalInfoId ,
            ProductId = productId ,
            InputVoltage = inputVoltage ,
            CableLenght = cableLenght ,
            CableLenghtUnit = cableLenghtUnit ,
            GuidId = guidId ,
        };
    }
    }
}