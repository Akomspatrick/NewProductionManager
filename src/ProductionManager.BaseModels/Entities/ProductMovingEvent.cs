using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProductionManager.BaseModels.Entities
{
    public class ProductMovingEvent : BaseEvent
    {
        //public int Productid {  get; set; }
        //public DateTime TimeStamp { get; set; }
        //public string UserName { get; set; }=   string.Empty;

        public string SourceStage { get; set; } = string.Empty;
        public string DestinationStage { get; set; } = string.Empty;

        [BaseModelBasicAttribute(256, 0, false, false)]
        public string MovingNotes { get; set; } = string.Empty;
    }
}
/*
         -- -----------------------------------------------------
-- Table `mydb_test`.`productmovingevents`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb_test`.`productmovingevents` (
  `products_serial` INT NOT NULL,
  `timestamp` DATETIME NOT NULL,
  `users_username` VARCHAR(256) NOT NULL,
  `source_stage` VARCHAR(256) NOT NULL,
  `destination_stage` VARCHAR(256) NOT NULL,
  `movingNotes` TEXT NULL DEFAULT NULL,
  PRIMARY KEY(`products_serial`, `timestamp`),
  INDEX `fk_productMovingEvents_users1` (`users_username` ASC) VISIBLE,
  CONSTRAINT `fk_productMovingEvents_products1`
    FOREIGN KEY(`products_serial`)
    REFERENCES `mydb_test`.`products` (`serial`)
    ON DELETE CASCADE
    ON UPDATE CASCADE,
  CONSTRAINT `fk_productMovingEvents_users1`
    FOREIGN KEY(`users_username`)
    REFERENCES `mydb_test`.`users` (`username`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;
 */