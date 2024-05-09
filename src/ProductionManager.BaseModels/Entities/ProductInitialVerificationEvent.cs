using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    [BaseModelsForeignKey("Tester", "ProductInitialVerificationEvents")]
    public class ProductInitialVerificationEvent : BaseEvent
    {

        public int Points { get; init; }

        public int VerificationResult { get; init; }

        public string ReferenceSerial { get; init; } = string.Empty;

        [BaseModelBasicAttribute(32, 0, false, true)]
        public string TesterName { get; init; } = string.Empty;

        [BaseModelBasicAttribute(18, 6, false)]
        public decimal CalibratedOutput { get; init; }
        [BaseModelBasicAttribute(36, 12, false)]
        public decimal PercentNonlinearity { get; init; }
        public decimal DutZeroPoint { get; init; }
        public decimal RefPoint1 { get; init; }
        public decimal ForcePoint1 { get; init; }
        public decimal DutPoint1 { get; init; }
        public decimal RefPoint2 { get; init; }
        public decimal ForcePoint2 { get; init; }
        public decimal DutPoint2 { get; init; }
        public decimal RefPoint3 { get; init; }
        public decimal ForcePoint3 { get; init; }
        public decimal DutPoint3 { get; init; }
        public decimal RefPoint4 { get; init; }
        public decimal ForcePoint4 { get; init; }
        public decimal DutPoint4 { get; init; }
        public decimal RefPoint5 { get; init; }
        public decimal ForcePoint5 { get; init; }
        public decimal DutPoint5 { get; init; }
        public decimal RefPoint6 { get; init; }
        public decimal ForcePoint6 { get; init; }
        public decimal DutPoint6 { get; init; }
        public decimal RefPoint7 { get; init; }
        public decimal ForcePoint7 { get; init; }
        public decimal DutPoint7 { get; init; }
        public decimal RefPoint8 { get; init; }
        public decimal ForcePoint8 { get; init; }
        public decimal DutPoint8 { get; init; }
        public decimal RefPoint9 { get; init; }
        public decimal ForcePoint9 { get; init; }
        public decimal DutPoint9 { get; init; }
        public decimal RefPoint10 { get; init; }
        public decimal ForcePoint10 { get; init; }
        public decimal DutPoint10 { get; init; }


        public Tester Tester { get; init; }


    }
}
/*
 -- -----------------------------------------------------
-- Table `mydb_test`.`productinitialverificationevents`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb_test`.`productinitialverificationevents` (
  `points` INT NOT NULL,
  `products_serial` INT NOT NULL,
  `timestamp` DATETIME NOT NULL,
  `verificationResult` TINYINT(1) NOT NULL,
  `users_username` VARCHAR(256) NOT NULL,
  `reference_serial` VARCHAR(128) NOT NULL,
  `tester` VARCHAR(128) NOT NULL,
  `calibratedOutput` DECIMAL(18,6) NOT NULL,
  `percentNonlinearity` DECIMAL(18,6) NOT NULL,
  `dutZeroPoint` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint1` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint1` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint1` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint2` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint2` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint2` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint3` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint3` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint3` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint4` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint4` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint4` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint5` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint5` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint5` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint6` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint6` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint6` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint7` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint7` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint7` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint8` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint8` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint8` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint9` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint9` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint9` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint10` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint10` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint10` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint11` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint11` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint11` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint12` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint12` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint12` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint13` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint13` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint13` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint14` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint14` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint14` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint15` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint15` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint15` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint16` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint16` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint16` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint17` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint17` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint17` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint18` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint18` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint18` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint19` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint19` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint19` DECIMAL(18,6) NULL DEFAULT NULL,
  `refPoint20` DECIMAL(18,6) NULL DEFAULT NULL,
  `forcePoint20` DECIMAL(18,6) NULL DEFAULT NULL,
  `dutPoint20` DECIMAL(18,6) NULL DEFAULT NULL,
  PRIMARY KEY(`products_serial`, `timestamp`),
  INDEX `fk_productInitialVerificationEvents_products1` (`products_serial` ASC) VISIBLE,
  INDEX `fk_productInitialVerificationEvents_users1` (`users_username` ASC) VISIBLE,
  INDEX `fk_productInitialVerificationEvents_testers` (`tester` ASC) VISIBLE,
  CONSTRAINT `fk_productInitialVerificationEvents_products1`
    FOREIGN KEY(`products_serial`)
    REFERENCES `mydb_test`.`products` (`serial`),
  CONSTRAINT `fk_productInitialVerificationEvents_testers`
    FOREIGN KEY(`tester`)
    REFERENCES `mydb_test`.`testers` (`tester_name`),
  CONSTRAINT `fk_productInitialVerificationEvents_users1`
    FOREIGN KEY(`users_username`)
    REFERENCES `mydb_test`.`users` (`username`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;
 */