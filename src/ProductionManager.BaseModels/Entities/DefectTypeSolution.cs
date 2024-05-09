
using CodeGeneratorAttributesLibrary;

namespace ProductionManager.BaseModels.Entities
{
    [BaseModelsForeignKey("DefectType", "DefectTypeSolutions")]
    public class DefectTypeSolution : BaseEntity
    {
        [BaseModelBasicAttribute(32, 0, true, true)]
        public required string DefectName { get; init; }

        [BaseModelBasicAttribute(32, 0, true, true)]
        public required string Stage { get; init; } = string.Empty;

        [BaseModelBasicAttribute(264, 2, false)]
        public string Solution { get; init; } = string.Empty;
        [BaseModelBasicAttribute(0, 0, true)]
        public DateTime Timestamp { get; init; } = DateTime.Now;
        public string UserName { get; init; } = string.Empty;

        public DefectType DefectType { get; init; }

    }

}

