using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    [BaseModelsForeignKeyAttribute("Product", "NonConformanceLogs")]
    public class NonConformanceLog : BaseEntity
    {
        [BaseModelBasicAttribute(true, true)]
        public int ProductId { get; init; }
        [BaseModelBasicAttribute(true)]
        public int ModelVersionId { get; init; }
        public string ModelName { get; init; } = string.Empty;
        public int BatcNo { get; init; }
        [BaseModelBasicAttribute(true)]
        public string Stage { get; init; } = string.Empty;
        [BaseModelBasicAttribute(true)]
        public DateTime WhenItOccurred { get; init; }
        public string DefectName { get; init; } = string.Empty;

        public string LogByUserName { get; init; } = string.Empty;

        public string Status { get; init; } = "UNRESOLVED-OPEN";// UNRESOLVED-OPEN,  UNRESOLVED-CLOSED, "RESOLVED-CLOSED"

        [BaseModelBasicAttribute(256, 0, false, false)]
        public string Solution { get; init; } = string.Empty;
        public DateTimeOffset WhenItWasResolved { get; init; } = DateTimeOffset.Now;
        public string ResolvedByUserName { get; init; } = string.Empty;

        public string Comment { get; init; } = string.Empty;

        public Product Product { get; init; }

    }
}
