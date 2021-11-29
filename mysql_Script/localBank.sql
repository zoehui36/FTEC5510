-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema localbanka
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema localbanka
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `localbanka` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `localbanka` ;

-- -----------------------------------------------------
-- Table `localbanka`.`accountinfo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `localbanka`.`accountinfo` (
  `accountID` INT NOT NULL AUTO_INCREMENT,
  `accountNumber` VARCHAR(6) NOT NULL,
  `customerID` VARCHAR(50) NULL DEFAULT NULL,
  `balance` INT NOT NULL,
  PRIMARY KEY (`accountID`),
  UNIQUE INDEX `accountID_UNIQUE` (`accountID` ASC) VISIBLE,
  INDEX `accountNumber_idx` (`accountNumber` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 31
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `localbanka`.`conversionrecord`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `localbanka`.`conversionrecord` (
  `conversionID` INT NOT NULL AUTO_INCREMENT,
  `accountNumber` VARCHAR(6) NOT NULL,
  `convertTime` DATETIME NOT NULL,
  `convertAmount` DOUBLE NOT NULL,
  `convertECNY` TINYINT NOT NULL,
  `remark` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`conversionID`),
  UNIQUE INDEX `conversionID_UNIQUE` (`conversionID` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 35
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
