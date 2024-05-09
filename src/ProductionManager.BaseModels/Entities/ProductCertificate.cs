using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    [BaseModelsForeignKeyAttribute("Product", "ProductCertificates")]
    [BaseModelsHardForeignKeyAttribute("ProductCertificateType", "ProductCertificates", ["CertifcateType"])]
    public class ProductCertificate : BaseEntity
    {
        [BaseModelBasicAttribute(true, false)]
        public int ProductCertificateId { get; init; }
        [BaseModelBasicAttribute(true, true)]
        public int ProductId { get; init; } // SerialNo


        public string CertifcateType { get; init; } = string.Empty;
        [BaseModelBasicAttribute(2500, 0, false, false)]
        public string JsonData { get; init; } = string.Empty;
        public DateTime Timestamp { get; init; }


        public int Capacity { get; init; }
        public Product Product { get; init; }
        public ProductCertificateType ProductCertificateType { get; init; }
    }



    public class ProductCertificateType : BaseEntity
    {
        [BaseModelBasicAttribute(32, 0, true, false)]
        public string CertifcateType { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public ICollection<ProductCertificate> ProductCertificates { get; init; } = new List<ProductCertificate>();

    }
}
