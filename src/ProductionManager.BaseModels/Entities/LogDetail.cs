using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    [BaseModelsForeignKeyAttribute("LogSummary", "LogDetails")]
    public class LogDetail : BaseEntity
    {
        [BaseModelBasicAttribute(true)]
        public required int ProductId { get; init; }
        [BaseModelBasicAttribute(32, 0, true, true)]
        public Guid LogSummaryId { get; init; }
        public LogSummary LogSummary { get; init; }
    }
}
