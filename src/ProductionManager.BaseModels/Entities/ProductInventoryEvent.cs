using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    public class ProductInventoryEvent : BaseEvent
    {
        //public int ProductId { get; set; }
        //public DateTime TimeStamp { get; set; }
        //public string UserName { get; set; }

        // public string SalesOrderId { get; init; } = string.Empty;
    }
}

/*
 -- Table `mydb_test`.`productpackagingevents`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb_test`.`productpackagingevents` (
  `products_serial` INT NOT NULL,
  `timestamp` DATETIME NOT NULL,
  `users_username` VARCHAR(256) NOT NULL,
  PRIMARY KEY(`products_serial`, `timestamp`),
  INDEX `fk_productPackagingEvents_products1` (`products_serial` ASC) VISIBLE,
  INDEX `fk_productPackagingEvents_users1` (`users_username` ASC) VISIBLE,
  CONSTRAINT `fk_productPackagingEvents_products1`
    FOREIGN KEY(`products_serial`)
    REFERENCES `mydb_test`.`products` (`serial`),
  CONSTRAINT `fk_productPackagingEvents_users1`
    FOREIGN KEY(`users_username`)
    REFERENCES `mydb_test`.`users` (`username`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;
 */