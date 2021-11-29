-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema pboc
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema pboc
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `pboc` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `pboc` ;

-- -----------------------------------------------------
-- Table `pboc`.`registration`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pboc`.`registration` (
  `regID` INT NOT NULL AUTO_INCREMENT,
  `ECNYNumber` VARCHAR(8) NOT NULL,
  `accountNumber` VARCHAR(6) NULL DEFAULT NULL,
  `remark` VARCHAR(50) NULL DEFAULT NULL,
  PRIMARY KEY (`regID`),
  UNIQUE INDEX `id_UNIQUE` (`regID` ASC) VISIBLE,
  UNIQUE INDEX `ECNYNumber_UNIQUE` (`ECNYNumber` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 34681
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `pboc`.`transcation`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pboc`.`transcation` (
  `transcationID` INT NOT NULL AUTO_INCREMENT,
  `transTime` DATETIME NOT NULL,
  `transAmount` VARCHAR(6) NOT NULL,
  `payeeAccNum` VARCHAR(6) NOT NULL,
  `receiverAccNum` VARCHAR(6) NOT NULL,
  `remark` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`transcationID`))
ENGINE = InnoDB
AUTO_INCREMENT = 75
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
