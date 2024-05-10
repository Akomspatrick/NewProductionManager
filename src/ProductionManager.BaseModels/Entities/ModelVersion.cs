using System.Reflection.Metadata;
using System.Reflection;
using CodeGeneratorAttributesLibrary;

namespace ProductionManager.BaseModels.Entities
{
    public class ModelVersion : BaseEntity
    {
        [BaseModelBasicAttribute(true)]
        public int ModelVersionId { get; init; }

        public string VersionDescription { get; init; } = string.Empty;
        public string ModelVersionName { get; init; } = string.Empty;


        [BaseModelBasicAttribute(32, 0, true, true, false)]
        public string ModelName { get; init; } = string.Empty;

        public string DefaultTestingMode { get; init; } = string.Empty; // Manual, Automatic for each product
        public DateTime Timestamp { get; init; }
        public string UserName { get; init; } = string.Empty;

        [BaseModelBasicAttribute(0, 0, false, false, false, true)]
        public int Capacity { get; init; }
        public int TestCapacity { get; init; }
        public double? NominalOutput { get; init; }
        public decimal? NominalOutputPercentage { get; init; }
        public decimal? NonlinearityPercentage { get; init; }
        public int? MinimumDeadLoad { get; init; }
        [BaseModelBasicAttribute(11, 1, false)]
        public double? vMin { get; init; }
        public int? nMax { get; init; }
        public int? SafeLoad { get; init; }
        public int? UltimateLoad { get; init; }
        [BaseModelBasicAttribute(32, 0, false, false, true)]
        public string? ShellMaterialName { get; init; } = string.Empty;
        // public bool Alloy { get; init; }//  This is on Probation Now
        public int? DefaultCableLength { get; init; }
        //public int? NumberOfGauges { get; init; }
        public int? Resistance { get; init; }
        public string? CCNumber { get; init; }
        public string? AccuracyClass { get; init; } = string.Empty;
        public string? Application { get; init; } = string.Empty;
        public ICollection<Product>? Products { get; init; }
    }
}
