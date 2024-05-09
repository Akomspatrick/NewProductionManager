namespace ProductionManager.BaseModels.Entities
{
    public class ProductVersionChangedEvent : BaseEvent
    {
        public int PrevModelVersionId { get; init; }
        public string PrevModelName { get; init; } = string.Empty;

        public int CurrentModelVersionId { get; init; }
        public string CurrentPrevModelName { get; init; } = string.Empty;
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