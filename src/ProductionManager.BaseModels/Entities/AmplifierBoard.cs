using CodeGeneratorAttributesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProductionManager.BaseModels.Entities
{

    public class AmplifierBoard : BaseEntity
    {
        [BaseModelBasicAttribute(true)]
        public int AmplifierBoardId { get; init; }
        public string Brand { get; init; } = string.Empty;

        [BaseModelBasicAttribute(32, 0, true, false)]
        public string Name { get; init; } = string.Empty;
        public int HasRed { get; init; } = 0;
        public string RedValue { get; init; } = string.Empty;

        public int HasGreen { get; init; } = 0;
        public string GreenValue { get; init; } = string.Empty;

        public int HasBlack { get; init; } = 0;
        public string BlackValue { get; init; } = string.Empty;

        public int HasWhite { get; init; } = 0;
        public string WhiteValue { get; init; } = string.Empty;

        public int HasShield { get; init; } = 0;
        public string ShieldValue { get; init; } = string.Empty;

    }
}

//-------------------------------------------------------
//--Table `mydb_test`.`amplifierboards`
//-- -----------------------------------------------------
//CREATE TABLE IF NOT EXISTS `mydb_test`.`amplifierboards` (
//  `amplifier_board_id` INT NOT NULL AUTO_INCREMENT,
//  `brand` VARCHAR(100) NULL DEFAULT NULL,
//  `name` VARCHAR(100) NULL DEFAULT NULL,
//  `has_red` INT NULL DEFAULT '0',
//  `red_value` VARCHAR(25) NULL DEFAULT NULL,
//  `has_black` INT NULL DEFAULT '0',
//  `black_value` VARCHAR(25) NULL DEFAULT NULL,
//  `has_green` INT NULL DEFAULT '0',
//  `green_value` VARCHAR(25) NULL DEFAULT NULL,
//  `has_white` INT NULL DEFAULT '0',
//  `white_value` VARCHAR(25) NULL DEFAULT NULL,
//  `has_shield` INT NULL DEFAULT '0',
//  `shield_value` VARCHAR(25) NULL DEFAULT NULL,
//  PRIMARY KEY(`amplifier_board_id`),
//  INDEX `BRAND` (`brand` ASC) VISIBLE,
//  INDEX `NAME` (`name` ASC) VISIBLE)
//ENGINE = InnoDB
//AUTO_INCREMENT = 6
//DEFAULT CHARACTER SET = latin1;
