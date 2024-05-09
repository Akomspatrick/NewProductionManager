using System.Reflection.Metadata;
using System.Reflection;
using CodeGeneratorAttributesLibrary;

namespace ProductionManager.BaseModels.Entities
{
    public class ModelVersion : BaseEntity
    {
        [BaseModelBasicAttribute(true)]
        public int ModelVersionId { get; init; }

        [BaseModelBasicAttribute(64, 0, false, false)]
        public string VersionDescription { get; init; } = string.Empty;
        public string ModelVersionName { get; init; } = string.Empty;
        [BaseModelBasicAttribute(32, 0, true)]
        public string ModelName { get; init; } = string.Empty;
        public ICollection<Product>? Products { get; init; }
        public string ModelVersionGroupName { get; private set; } = string.Empty;
        public string DefaultTestingMode { get; init; } = string.Empty; // Manual, Automatic for each product

        public DateTime Timestamp { get; init; }

        public string UserName { get; init; } = string.Empty;
        public int Capacity { get; init; }
        public decimal NominalOutput { get; init; }
        public decimal NominalOutputPercentage { get; init; }
        public decimal NonlinearityPercentage { get; init; }
        public int? MinimumDeadLoad { get; init; }
        [BaseModelBasicAttribute(11, 1, false)]
        public decimal vMin { get; init; }
        public int? nMax { get; init; }
        public int? SafeLoad { get; init; }
        public int? UltimateLoad { get; init; }
        public string ShellMaterialName { get; init; } = string.Empty;
        public bool Alloy { get; init; }
        public int? DefaultCableLength { get; init; }
        public int? NumberOfGauges { get; init; }
        public int? Resistance { get; init; }
        public string CCNumber { get; init; } = string.Empty;
        public string AccuracyClass { get; init; } = string.Empty;
        public string Application { get; init; } = string.Empty;
        public int? TemperingHardnessLow { get; init; }
        public int? TemperingHardnessHigh { get; init; }
        public string NTEPCertificationId { get; init; } = string.Empty;
        public DateTime? NTEPCertificationTimestamp { get; init; }
        public string OIMLCertificationId { get; init; } = string.Empty;
        public DateTime? OIMLCertificationTimestamp { get; init; }
        public bool TestPointDirection { get; init; } = true;// true = increasing, false = decreasing

    }
}
