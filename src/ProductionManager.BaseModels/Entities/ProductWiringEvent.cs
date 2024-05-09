using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    public  class ProductWiringEvent:BaseEvent
    {
        //public int ProductId { get; set; }
        //public string UserName { get; set; } = string.Empty;
        //public DateTime TimeStamp { get; set; }
        

    }
}
/*
 -- Table `mydb_test`.`productwiringevents`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb_test`.`productwiringevents` (
  `products_serial` INT NOT NULL,
  `timestamp` DATETIME NOT NULL,
  `users_username` VARCHAR(256) NOT NULL,
  PRIMARY KEY(`products_serial`, `timestamp`),
  INDEX `fk_productWiringEvents_users1` (`users_username` ASC) VISIBLE,
  CONSTRAINT `fk_productWiringEvents_products1`
    FOREIGN KEY(`products_serial`)
    REFERENCES `mydb_test`.`products` (`serial`)
    ON DELETE CASCADE,
  CONSTRAINT `fk_productWiringEvents_users1`
    FOREIGN KEY(`users_username`)
    REFERENCES `mydb_test`.`users` (`username`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;*/