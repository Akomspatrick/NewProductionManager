using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProductionManager.BaseModels.Entities
{
    public class ProductSurfacePreparationEvent : BaseEvent // formerly ProductChromingEvent
    {
        //public int ProductId { get; set; }
        //public string UserName { get; set; } = string.Empty;
        //public DateTime TimeStamp { get; set; }

        public int InspectionResult { get; set; }
        public string DefectName { get; set; } = string.Empty;

    }
}

/*
 -- Table `mydb_test`.`productchromeinspectionevents`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb_test`.`productchromeinspectionevents` (
  `products_serial` INT NOT NULL,
  `timestamp` DATETIME NOT NULL,
  `inspectionResult` TINYINT(1) NOT NULL,
  `DefectName` TEXT NOT NULL,
  `users_username` VARCHAR(256) NOT NULL,
  PRIMARY KEY(`products_serial`, `timestamp`),
  INDEX `fk_productChromingEvents_users1` (`users_username` ASC) VISIBLE,
  CONSTRAINT `fk_productChromingEvents_products1`
    FOREIGN KEY(`products_serial`)
    REFERENCES `mydb_test`.`products` (`serial`)
    ON DELETE CASCADE,
  CONSTRAINT `fk_productChromingEvents_users1`
    FOREIGN KEY(`users_username`)
    REFERENCES `mydb_test`.`users` (`username`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;
 */