using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductCertificateType  : BaseEntity
    {
        private ProductCertificateType(){}
        public string CertifcateType    { get; init; }  = string.Empty; 
        public string Description    { get; init; }  = string.Empty; 
        private  List <ProductCertificate> _ProductCertificates { get;  set;}  = new List<ProductCertificate>();
        public  IReadOnlyCollection<ProductCertificate> ProductCertificates => _ProductCertificates;
        public Guid GuidId    { get; init; } 
        
        public static ProductCertificateType Create(string  certifcateType, string  description, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductCertificateType Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            CertifcateType = certifcateType ,
            Description = description ,
            GuidId = guidId ,
        };
    }
    }
}