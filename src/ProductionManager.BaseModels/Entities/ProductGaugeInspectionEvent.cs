using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProductionManager.BaseModels.Entities
{

    public class ProductGaugeInspectionEvent : BaseEvent
    {
        public int InspectionResult { get; set; }
        public string DefectName { get; set; } = string.Empty;
        public int GaugeFailed { get; set; }
        public int GaugePassed { get; set; }
    }
}
/*
         -- -----------------------------------------------------
-- Table `mydb_test`.`productgaugeinspectionevents`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb_test`.`productgaugeinspectionevents` (
  `products_serial` INT NOT NULL,
  `timestamp` DATETIME NOT NULL,
  `inspectionResult` TINYINT(1) NOT NULL,
  `DefectName` TEXT NOT NULL,
  `users_username` VARCHAR(256) NOT NULL,
  `gaugesFailed` INT NOT NULL DEFAULT '0',
  `gaugesPassed` INT NOT NULL DEFAULT '0',
  PRIMARY KEY(`products_serial`, `timestamp`),
  INDEX `fk_productGaugeInspectionEvents_users1` (`users_username` ASC) VISIBLE,
  CONSTRAINT `fk_productGaugeInspectionEvents_users1`
    FOREIGN KEY(`users_username`)
    REFERENCES `mydb_test`.`users` (`username`),
  CONSTRAINT `fk_productGaugingEvents_products1`
    FOREIGN KEY(`products_serial`)
    REFERENCES `mydb_test`.`products` (`serial`)
    ON DELETE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;
 */