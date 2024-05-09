using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductCertificate  : BaseEntity
    {
        private ProductCertificate(){}
        public Int32 ProductCertificateId    { get; init; } 
        public Int32 ProductId    { get; init; } 
        public string CertifcateType    { get; init; }  = string.Empty; 
        public string JsonData    { get; init; }  = string.Empty; 
        public DateTime Timestamp    { get; init; } 
        public Int32 Capacity    { get; init; } 
        public Product Product    { get; init; } 
        public ProductCertificateType ProductCertificateType    { get; init; } 
        // public Guid GuidId    { get; init; } 
        
        public static ProductCertificate Create(Int32  productCertificateId, Int32  productId, string  certifcateType, string  jsonData, DateTime  timestamp, Int32  capacity, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductCertificate Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            ProductCertificateId = productCertificateId ,
            ProductId = productId ,
            CertifcateType = certifcateType ,
            JsonData = jsonData ,
            Timestamp = timestamp ,
            Capacity = capacity ,
            GuidId = guidId ,
        };
    }
    }
}