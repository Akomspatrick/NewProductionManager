using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductPicture  : BaseEntity
    {
        private ProductPicture(){}
        public Int32 ProductId    { get; init; } 
        public DateTime Timestamp    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public string Stage    { get; init; }  = string.Empty; 
        public string FileName    { get; init; }  = string.Empty; 
        public string LocalPathName    { get; init; }  = string.Empty; 
        public string BasePath    { get; init; }  = string.Empty; 
        public string Description    { get; init; }  = string.Empty; 
        public Product Product    { get; init; } 
        public Guid GuidId    { get; init; } 
        
        public static ProductPicture Create(Int32  productId, DateTime  timestamp, string  userName, string  stage, string  fileName, string  localPathName, string  basePath, string  description, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductPicture Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            ProductId = productId ,
            Timestamp = timestamp ,
            UserName = userName ,
            Stage = stage ,
            FileName = fileName ,
            LocalPathName = localPathName ,
            BasePath = basePath ,
            Description = description ,
            GuidId = guidId ,
        };
    }
    }
}