using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    [BaseModelsForeignKeyAttribute("Product", "ProductInitialUnits")]
    public class ProductInitialUnit : BaseEntity
    {
        [BaseModelBasicAttribute(true, true)]
        public int ProductId { get; set; }
        [BaseModelBasicAttribute(true, false)]
        public DateTime TimeStamp { get; set; }
        public string InputUnits { get; set; } = string.Empty;
        public string OutputUnits { get; set; } = string.Empty;
        public Product Product { get; init; }

    }
}
/*
         CREATE TABLE IF NOT EXISTS `mydb_test`.`productinitialunits` (
  `products_serial` INT NOT NULL,
  `timestamp` DATETIME NOT NULL,
  `input_units` VARCHAR(45) NOT NULL,
  `output_units` VARCHAR(45) NOT NULL,
  PRIMARY KEY(`products_serial`, `timestamp`),
  INDEX `fk_productInitialUnits_products1` (`products_serial` ASC) VISIBLE,
  CONSTRAINT `fk_productInitialUnits_products1`
    FOREIGN KEY(`products_serial`)
    REFERENCES `mydb_test`.`products` (`serial`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;
 */