using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProductionManager.BaseModels.Entities
{
    public class ProductReceptionEvent : BaseEvent
    {
        //public int ProductId { get; set; }
        //public string UserName { get; set; } = string.Empty;
        //public DateTime TimeStamp { get; set; }
        [BaseModelBasicAttribute(256, 0, false, false)]
        public string Notes { get; set; } = string.Empty;
        // public string MaterialCertification { get; set; }= string.Empty;



    }
}
/*
 -- Table `mydb_test`.`productreceptionevents`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb_test`.`productreceptionevents` (
  `products_serial` INT NOT NULL,
  `timestamp` DATETIME NULL DEFAULT NULL,
  `notes` TEXT NULL DEFAULT NULL,
  `materialCertification` VARCHAR(128) NULL DEFAULT NULL,
  `users_username` VARCHAR(256) NOT NULL,
  PRIMARY KEY(`products_serial`),
  INDEX `fk_productReceptionEvents_users1` (`users_username` ASC) VISIBLE,
  CONSTRAINT `fk_productReceptionEvents_products1`
    FOREIGN KEY(`products_serial`)
    REFERENCES `mydb_test`.`products` (`serial`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_productReceptionEvents_users1`
    FOREIGN KEY(`users_username`)
    REFERENCES `mydb_test`.`users` (`username`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;*/