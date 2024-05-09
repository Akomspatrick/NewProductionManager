using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    public class Tester : BaseEntity
    {
        [BaseModelBasicAttribute(32, 0, true, false)]
        public string TesterName { get; init; } = string.Empty;
        public int NistTraceAble { get; init; }
        public ICollection<ProductFinalVerifiationEvent>? ProductFinalVerifiationEvents { get; init; }
        public ICollection<ProductInitialVerificationEvent>? ProductInitialVerificationEvents { get; init; }
    }

    /*
             CREATE TABLE IF NOT EXISTS `mydb_test`.`testers` (
  `tester_name` VARCHAR(128) NOT NULL,
  `nist_traceable` TINYINT(1) NOT NULL,
  PRIMARY KEY(`tester_name`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;
     */
}
