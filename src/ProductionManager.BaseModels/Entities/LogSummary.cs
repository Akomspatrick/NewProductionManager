using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    public class LogSummary : BaseEntity
    {
        [BaseModelBasicAttribute(true)]
        public Guid LogSummaryId { get; init; }
        public string Stage { get; init; } = string.Empty;
        public DateTimeOffset StartTime { get; init; }
        public DateTimeOffset StopTime { get; init; }

        public string UserName { get; init; } = string.Empty;

        public int NoOfItemsProcessed { get; init; }
        public
            ICollection<LogDetail>? LogDetails
        { get; init; }


    }
}
