-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema thaibankb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema thaibankb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `thaibankb` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `thaibankb` ;

-- -----------------------------------------------------
-- Table `thaibankb`.`accountinfo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `thaibankb`.`accountinfo` (
  `AccountID` INT NOT NULL AUTO_INCREMENT,
  `accountNumber` VARCHAR(6) NOT NULL,
  `customerID` VARCHAR(6) NULL DEFAULT NULL,
  `balance` INT NOT NULL,
  PRIMARY KEY (`AccountID`),
  UNIQUE INDEX `transcationRecordID_UNIQUE` (`AccountID` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 21
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `thaibankb`.`conversionrecord`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `thaibankb`.`conversionrecord` (
  `conversionID` INT NOT NULL AUTO_INCREMENT,
  `accountNumber` VARCHAR(6) NOT NULL,
  `convertTime` DATETIME NOT NULL,
  `convertAmount` DOUBLE NOT NULL,
  `remark` VARCHAR(45) NULL DEFAULT NULL,
  `ConvertECNY` TINYINT NULL DEFAULT NULL,
  PRIMARY KEY (`conversionID`),
  UNIQUE INDEX `TranscationID_UNIQUE` (`conversionID` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 26
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
