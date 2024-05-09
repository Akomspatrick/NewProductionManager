using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    public class ShuntResistor : BaseEntity
    {
        [BaseModelBasicAttribute(10, 0, true, false)]
        public decimal Value { get; set; }
    }
}
/*
         -- -----------------------------------------------------
-- Table `mydb_test`.`shuntresistors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb_test`.`shuntresistors` (
  `value` DECIMAL(10,0) NOT NULL,
  PRIMARY KEY(`value`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;*/