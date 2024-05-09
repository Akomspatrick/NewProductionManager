using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    public class TrimmingResistor : BaseEntity
    {
        [BaseModelBasicAttribute(10, 0, true, false)]
        public decimal Value { get; set; }
    }
}
/*-- -----------------------------------------------------
-- Table `mydb_test`.`trimmingresistors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb_test`.`trimmingresistors` (
  `value` DECIMAL(10,2) NOT NULL,
  PRIMARY KEY(`value`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;*/