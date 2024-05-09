
using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    [BaseModelsForeignKey("ProductStage", "DefectTypes")]
    public class DefectType : BaseEntity
    {
        [BaseModelBasicAttribute(32, 0, true, false)]
        public required string DefectName { get; init; }

        [BaseModelBasicAttribute(32, 0, true, true)]
        public required string Stage { get; init; } = string.Empty;


        public string DefectDescription { get; init; } = string.Empty;

        public decimal TriggerPercentage { get; init; } = 5m;
        public int MinTotalProductInBatchB4Trigger { get; init; } = 0;

        public ProductStage ProductStage { get; init; }

        public ICollection<DefectTypeSolution>? DefectTypeSolutions { get; init; }
    }

}

