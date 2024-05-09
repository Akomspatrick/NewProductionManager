using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    public class BaseEvent : BaseEntity
    {
        [BaseModelBasicAttribute(true, false)]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string UserName { get; set; } = string.Empty;
        [BaseModelBasicAttribute(true, false)]
        public DateTime TimeStamp { get; set; }
    }
}
