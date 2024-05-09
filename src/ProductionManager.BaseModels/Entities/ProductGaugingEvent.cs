using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{

    public class ProductGaugeEvent : BaseEvent
    {

        public string GuageModel { get; set; } = string.Empty;
        public string GuageLotNo { get; set; } = string.Empty;


    }
}
/*
         -- -----------------------------------------------------
-- Table `mydb_test`.`productgaugingevents`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb_test`.`productgaugingevents` (
  `products_serial` INT NOT NULL,
  `timestamp` DATETIME NOT NULL,
  `users_username` VARCHAR(256) NOT NULL,
  `guage_model` VARCHAR(100) NULL DEFAULT NULL,
  `guage_lot_no` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY(`products_serial`, `timestamp`),
  INDEX `fk_productGaugingEvents_users1` (`users_username` ASC) VISIBLE,
  CONSTRAINT `fk_productGaugingEvents_products2`
    FOREIGN KEY(`products_serial`)
    REFERENCES `mydb_test`.`products` (`serial`)
    ON DELETE CASCADE,
  CONSTRAINT `fk_productGaugingEvents_users1`
    FOREIGN KEY(`users_username`)
    REFERENCES `mydb_test`.`users` (`username`)
    ON UPDATE CASCADE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;*/