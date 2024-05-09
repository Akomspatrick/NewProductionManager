using ProductionManager.DomainBase;
namespace ProductionManager.Domain.Entities
{
    public partial class ModelVersion  : BaseEntity
    {
        private ModelVersion(){}
        public Int32 ModelVersionId    { get; init; } 
        public string VersionDescription    { get; init; }  = string.Empty; 
        public string ModelVersionName    { get; init; }  = string.Empty; 
        public string ModelName    { get; init; }  = string.Empty; 
        private  List <Product> _Products { get;  set;}  = new List<Product>();
        public  IReadOnlyCollection<Product> Products => _Products;
        public string ModelVersionGroupName    { get; init; }  = string.Empty; 
        public string DefaultTestingMode    { get; init; }  = string.Empty; 
        public DateTime Timestamp    { get; init; } 
        public string UserName    { get; init; }  = string.Empty; 
        public Int32 Capacity    { get; init; } 
        public decimal NominalOutput    { get; init; } 
        public decimal NominalOutputPercentage    { get; init; } 
        public decimal NonlinearityPercentage    { get; init; } 
        public Int32? MinimumDeadLoad    { get; init; } 
        public decimal vMin    { get; init; } 
        public Int32? nMax    { get; init; } 
        public Int32? SafeLoad    { get; init; } 
        public Int32? UltimateLoad    { get; init; } 
        public string ShellMaterialName    { get; init; }  = string.Empty; 
        public bool Alloy    { get; init; } 
        public Int32? DefaultCableLength    { get; init; } 
        public Int32? NumberOfGauges    { get; init; } 
        public Int32? Resistance    { get; init; } 
        public string CCNumber    { get; init; }  = string.Empty; 
        public string AccuracyClass    { get; init; }  = string.Empty; 
        public string Application    { get; init; }  = string.Empty; 
        public Int32? TemperingHardnessLow    { get; init; } 
        public Int32? TemperingHardnessHigh    { get; init; } 
        public string NTEPCertificationId    { get; init; }  = string.Empty; 
        public DateTime? NTEPCertificationTimestamp    { get; init; } 
        public string OIMLCertificationId    { get; init; }  = string.Empty; 
        public DateTime? OIMLCertificationTimestamp    { get; init; } 
        public bool TestPointDirection    { get; init; } 
        // public Guid GuidId    { get; init; } 
        
        public static ModelVersion Create(Int32  modelVersionId, string  versionDescription, string  modelVersionName, string  modelName, string  modelVersionGroupName, string  defaultTestingMode, DateTime  timestamp, string  userName, Int32  capacity, decimal  nominalOutput, decimal  nominalOutputPercentage, decimal  nonlinearityPercentage, Int32  minimumDeadLoad, decimal  vMin, Int32  nMax, Int32  safeLoad, Int32  ultimateLoad, string  shellMaterialName, bool  alloy, Int32  defaultCableLength, Int32  numberOfGauges, Int32  resistance, string  cCNumber, string  accuracyClass, string  application, Int32  temperingHardnessLow, Int32  temperingHardnessHigh, string  nTEPCertificationId, DateTime  nTEPCertificationTimestamp, string  oIMLCertificationId, DateTime  oIMLCertificationTimestamp, bool  testPointDirection, Guid  guidId)
    {
    if (guidId == Guid.Empty)
    {
        throw new ArgumentException($"ModelVersion Guid value cannot be empty {nameof(guidId)}");
    }
        return  new()
        {
            ModelVersionId = modelVersionId ,
            VersionDescription = versionDescription ,
            ModelVersionName = modelVersionName ,
            ModelName = modelName ,
            ModelVersionGroupName = modelVersionGroupName ,
            DefaultTestingMode = defaultTestingMode ,
            Timestamp = timestamp ,
            UserName = userName ,
            Capacity = capacity ,
            NominalOutput = nominalOutput ,
            NominalOutputPercentage = nominalOutputPercentage ,
            NonlinearityPercentage = nonlinearityPercentage ,
            MinimumDeadLoad = minimumDeadLoad ,
            vMin = vMin ,
            nMax = nMax ,
            SafeLoad = safeLoad ,
            UltimateLoad = ultimateLoad ,
            ShellMaterialName = shellMaterialName ,
            Alloy = alloy ,
            DefaultCableLength = defaultCableLength ,
            NumberOfGauges = numberOfGauges ,
            Resistance = resistance ,
            CCNumber = cCNumber ,
            AccuracyClass = accuracyClass ,
            Application = application ,
            TemperingHardnessLow = temperingHardnessLow ,
            TemperingHardnessHigh = temperingHardnessHigh ,
            NTEPCertificationId = nTEPCertificationId ,
            NTEPCertificationTimestamp = nTEPCertificationTimestamp ,
            OIMLCertificationId = oIMLCertificationId ,
            OIMLCertificationTimestamp = oIMLCertificationTimestamp ,
            TestPointDirection = testPointDirection ,
            GuidId = guidId ,
        };
    }
    }
}