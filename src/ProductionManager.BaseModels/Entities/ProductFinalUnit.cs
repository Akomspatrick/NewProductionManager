using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ProductionManager.BaseModels.Entities
{
    [BaseModelsForeignKeyAttribute("Product", "ProductFinalUnits")]
    public class ProductFinalUnit : BaseEntity
    {
        [BaseModelBasicAttribute(true, true)]
        public int ProductId { get; set; }

        [BaseModelBasicAttribute(true, false)]
        public DateTime TimeStamp { get; set; }
        public string InputUnit { get; set; } = string.Empty;
        public string OuputUnits { get; set; } = string.Empty;
        public string IndicatorType { get; set; } = string.Empty;
        public int IndicatorChannel { get; set; }
        public string IndicatorSerialNo { get; set; } = string.Empty;
        public int GradSize { get; set; }
        public decimal PinSize { get; set; }
        public int Division { get; set; }
        [BaseModelBasicAttribute(10, 0, false)]
        public decimal LowWeight { get; set; }
        [BaseModelBasicAttribute(10, 0, false)]
        public decimal HighWeight { get; set; }

        public Product Product { get; init; }

    }
}
/*
         -- -----------------------------------------------------
-- Table `mydb_test`.`productfinalunits`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb_test`.`productfinalunits` (
  `products_serial` INT NOT NULL,
  `timestamp` DATETIME NOT NULL,
  `input_units` VARCHAR(45) NOT NULL,
  `output_units` VARCHAR(45) NOT NULL,
  `indicator_type` VARCHAR(45) NULL DEFAULT NULL,
  `indicator_channel` INT NULL DEFAULT NULL,
  `indicator_serial` VARCHAR(45) NULL DEFAULT NULL,
  `grad_size` INT NULL DEFAULT '0',
  `pin_size` DECIMAL(10,0) NULL DEFAULT '0',
  `division` INT NULL DEFAULT NULL,
  `low_weight` DECIMAL(10,0) NULL DEFAULT NULL,
  `high_weight` DECIMAL(10,0) NULL DEFAULT NULL,
  `param3` INT NULL DEFAULT NULL,
  `param4` INT NULL DEFAULT NULL,
  `param6` INT NULL DEFAULT NULL,
  `param11` INT NULL DEFAULT NULL,
  `param34` INT NULL DEFAULT NULL,
  `paramA_name` INT NULL DEFAULT NULL,
  `paramA` INT NULL DEFAULT NULL,
  `paramB_name` INT NULL DEFAULT NULL,
  `paramB` INT NULL DEFAULT NULL,
  `paramC_name` INT NULL DEFAULT NULL,
  `paramC` INT NULL DEFAULT NULL,
  `paramD_name` INT NULL DEFAULT NULL,
  `paramD` INT NULL DEFAULT NULL,
  `cable_type` VARCHAR(45) NULL DEFAULT NULL,
  `cable_length` INT NULL DEFAULT NULL,
  `cable_pin_number` INT NULL DEFAULT NULL,
  `male_connector` TINYINT(1) NULL DEFAULT NULL,
  `sleep_switch` TINYINT(1) NULL DEFAULT NULL,
  `notes` TEXT NULL DEFAULT NULL,
  `comments` TEXT NULL DEFAULT NULL,
  `loadcell1` INT NULL DEFAULT NULL,
  `loadcell2` INT NULL DEFAULT NULL,
  `loadcell3` INT NULL DEFAULT NULL,
  `loadcell4` INT NULL DEFAULT NULL,
  `loadcell5` INT NULL DEFAULT NULL,
  `loadcell6` INT NULL DEFAULT NULL,
  `loadcell7` INT NULL DEFAULT NULL,
  `loadcell8` INT NULL DEFAULT NULL,
  `paramF8` INT NULL DEFAULT NULL,
  `paramF9` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY(`products_serial`, `timestamp`),
  INDEX `fk_productFinalUnits_products1` (`products_serial` ASC) VISIBLE,
  CONSTRAINT `fk_productFinalUnits_products1`
    FOREIGN KEY(`products_serial`)
    REFERENCES `mydb_test`.`products` (`serial`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;
 */