using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ProductStage  : BaseEntity
    {
        private ProductStage(){}
        public string Stage    { get; init; }  = string.Empty; 
        public string StageDescription    { get; init; }  = string.Empty; 
        public int StageNo    { get; init; } 
        public string StageBarcode    { get; init; }  = string.Empty; 
        public string SaveBarCode    { get; init; }  = string.Empty; 
        public string SaveAndEndBarCode    { get; init; }  = string.Empty; 
        private  List <Product> _Products { get;  set;}  = new List<Product>();
        public  IReadOnlyCollection<Product> Products => _Products;
        private  List <DefectType> _DefectTypes { get;  set;}  = new List<DefectType>();
        public  IReadOnlyCollection<DefectType> DefectTypes => _DefectTypes;
        public Guid GuidId    { get; init; } 
        
        public static ProductStage Create(string  stage, string  stageDescription, int  stageNo, string  stageBarcode, string  saveBarCode, string  saveAndEndBarCode, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ProductStage Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            Stage = stage ,
            StageDescription = stageDescription ,
            StageNo = stageNo ,
            StageBarcode = stageBarcode ,
            SaveBarCode = saveBarCode ,
            SaveAndEndBarCode = saveAndEndBarCode ,
            GuidId = guidId ,
        };
    }
    }
}