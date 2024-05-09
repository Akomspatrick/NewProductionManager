using CodeGeneratorAttributesLibrary;

namespace ProductionManager.BaseModels.Entities
{
    [BaseModelsForeignKeyAttribute("ReferenceStandard", "ProductPictures")]
    public class ProductPicture : BaseEntity
    {

        [BaseModelBasicAttribute(true, false)]
        public required int ProductId { get; init; }

        [BaseModelBasicAttribute(true, false)]
        public DateTime Timestamp
        {
            get; init;
        }
        public string UserName { get; init; } = string.Empty;

        public string Stage { get; init; } = string.Empty;

        [BaseModelBasicAttribute(64, 0, false)]

        public string FileName { get; init; } = string.Empty; //ProductSerialNo_Stage_/ASAtDateTime.png

        [BaseModelBasicAttribute(128, 0, false)]

        public string LocalPathName { get; init; } = string.Empty;  //ModelType/Model/Version

        [BaseModelBasicAttribute(128, 0, false, false)]

        public string BasePath { get; init; } = string.Empty;  //ModelType/Model/Version

        public string Description { get; init; } = string.Empty;

        public Product Product { get; init; }
    }
}
