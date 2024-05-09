using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{
    public class ProductAdditionalInfo : BaseEntity
    {
        public int ProductAdditionalInfoId { get; init; }
        [BaseModelBasicAttribute(true)]
        public int ProductId { get; init; }

        public decimal InputVoltage { get; init; }
        public decimal CableLenght { get; init; }

        public string CableLenghtUnit { get; init; }




        //        -- -----------------------------------------------------
        //-- Table `mydb_test`.`productadditionalinfo`
        //-- -----------------------------------------------------
        //CREATE TABLE IF NOT EXISTS `mydb_test`.`productadditionalinfo` (
        //  `product_additional_info_id` INT NOT NULL AUTO_INCREMENT,
        //  `products_serial` INT NOT NULL DEFAULT '0',
        //  `input_voltage` DECIMAL(18,6) NOT NULL DEFAULT '0.000000',
        //  `cable_length` DECIMAL(18,6) NOT NULL DEFAULT '0.000000',
        //  PRIMARY KEY(`product_additional_info_id`),
        //  INDEX `PRODUCTS_SERIAL` (`products_serial` ASC) VISIBLE)
        //ENGINE = InnoDB
        //AUTO_INCREMENT = 11
        //DEFAULT CHARACTER SET = latin1;
    }
}
