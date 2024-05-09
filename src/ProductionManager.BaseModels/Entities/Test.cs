using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    [BaseModelsForeignKeyAttribute("ReferenceStandard", "Tests")]
    public class Test : BaseEntity
    {
        [BaseModelBasicAttribute(true, false)]
        public DateTime Timestamp { get; init; }
        [BaseModelBasicAttribute(true, false)]
        public required int ProductId { get; init; }

        public string UserName { get; init; } = string.Empty;

        [BaseModelBasicAttribute(32, 0, true, true)]
        public string RefStandardSerialNo { get; init; } = string.Empty;
        [BaseModelBasicAttribute(32, 0, true, true)]
        public string RefStandardManufacturer { get; init; } = string.Empty;
        [BaseModelBasicAttribute(32, 0, true, true)]

        public string RefStandardModelName { get; init; } = string.Empty;

        public decimal ExcitationResistance { get; init; }
        public decimal SignalResistance { get; init; }
        public Product Product { get; init; }
        public ReferenceStandard ReferenceStandard { get; init; }

    }
}
