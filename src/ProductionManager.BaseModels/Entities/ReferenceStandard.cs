using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    public class ReferenceStandard : BaseEntity
    {
        [BaseModelBasicAttribute(32, 0, true, false)]
        public string RefStandardManufacturer { get; init; } = string.Empty;
        [BaseModelBasicAttribute(32, 0, true, false)]
        public string RefStandardModelName { get; init; } = string.Empty;
        [BaseModelBasicAttribute(32, 0, true, false)]

        public string RefStandardSerialNo { get; init; } = string.Empty;
        public int Capacity { get; init; }
        public DateTime Timestamp { get; init; }
        public decimal B0 { get; init; }
        public decimal B1 { get; init; }
        public decimal B2 { get; init; }
        public decimal B3 { get; init; }
        public decimal B4 { get; init; }

        public ICollection<ReferenceCellCalibration> ReferenceCellCalibrations { get; init; }
        public ICollection<Test> Tests { get; init; }
    }
}
