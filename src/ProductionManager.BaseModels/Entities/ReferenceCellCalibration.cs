using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{

    [BaseModelsForeignKeyAttribute("ReferenceStandard", "ReferenceCellCalibrations")]
    public class ReferenceCellCalibration : BaseEntity
    {
        //[BaseModelsBasicAttribute(true,false)]
        [BaseModelBasicAttribute(0, 0, true, false, false, false, false)]
        public int Weight { get; init; }
        [BaseModelBasicAttribute(0, 32, false, true)]
        public string RefStandardManufacturer { get; init; } = string.Empty;

        [BaseModelBasicAttribute(0, 32, false, true)]
        public string RefStandardModelName { get; init; } = string.Empty;
        [BaseModelBasicAttribute(0, 32, false, true)]
        public string RefStandardSerialNo { get; init; } = string.Empty;

        [BaseModelBasicAttribute(30, 10, false)]
        public decimal LowMeasuredPosition { get; init; }
        [BaseModelBasicAttribute(30, 10, false)]
        public decimal LowCurrent { get; init; }
        [BaseModelBasicAttribute(30, 10, false)]
        public decimal HighMeasuredPosition { get; init; }
        [BaseModelBasicAttribute(30, 10, false)]
        public decimal HighCurrent { get; init; }

        public ReferenceStandard ReferenceStandard { get; init; }
    }
}


