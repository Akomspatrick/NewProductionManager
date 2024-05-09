using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    public class ProductStage : BaseEntity
    {
        [BaseModelBasicAttribute(32, 0, true, false)]
        public string Stage { get; init; } = string.Empty;
        public string StageDescription { get; init; } = string.Empty;

        public int StageNo { get; init; }
        [BaseModelBasicAttribute(64, 0, false, false)]
        public string StageBarcode { get; init; } = string.Empty;
        public string SaveBarCode { get; init; } = string.Empty;
        public string SaveAndEndBarCode { get; init; } = string.Empty;
        public ICollection<Product>? Products { get; init; }
        public ICollection<DefectType>? DefectTypes { get; init; }
    }
}
