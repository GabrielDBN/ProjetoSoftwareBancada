-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8mb3 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`dados`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`dados` (
  `idDados` INT NOT NULL AUTO_INCREMENT,
  `Peso` FLOAT NOT NULL,
  `PMax` FLOAT NOT NULL,
  `Tempo` FLOAT NOT NULL,
  `FatorCal` FLOAT NOT NULL,
  PRIMARY KEY (`idDados`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`motor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`motor` (
  `CodMotor` VARCHAR(45) NOT NULL,
  `Classe` VARCHAR(45) NOT NULL,
  `Propelente` VARCHAR(45) NOT NULL,
  `Material` VARCHAR(45) NOT NULL,
  `Massa` VARCHAR(45) NOT NULL,
  `MassaPos` VARCHAR(45) NOT NULL,
  `DataFabri` DATETIME NOT NULL,
  PRIMARY KEY (`CodMotor`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`operador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`operador` (
  `idOperador` INT NOT NULL AUTO_INCREMENT,
  `NomeOp` VARCHAR(45) NOT NULL,
  `Cargo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idOperador`))
ENGINE = InnoDB
AUTO_INCREMENT = 13
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`teste`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`teste` (
  `CodTeste` VARCHAR(45) NOT NULL,
  `LocalEnsaio` VARCHAR(45) NOT NULL,
  `Dia` DATETIME NOT NULL,
  `Hora` DATETIME NOT NULL,
  `Celula` VARCHAR(45) NOT NULL,
  `Observacoes` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`CodTeste`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


-- -----------------------------------------------------
-- Table `mydb`.`relatorio`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`relatorio` (
  `idRelatorio` INT NOT NULL AUTO_INCREMENT,
  `idOperador` INT NOT NULL,
  `CodMotor` VARCHAR(45) NOT NULL,
  `CodTeste` VARCHAR(45) NOT NULL,
  `idDados` INT NOT NULL,
  PRIMARY KEY (`idRelatorio`),
  INDEX `idOperador_idx` (`idOperador` ASC),
  INDEX `CodTeste_idx` (`CodTeste` ASC),
  INDEX `CodMotor_idx` (`CodMotor` ASC),
  INDEX `idDados_idx` (`idDados` ASC),
  CONSTRAINT `CodMotor`
    FOREIGN KEY (`CodMotor`)
    REFERENCES `mydb`.`motor` (`CodMotor`),
  CONSTRAINT `CodTeste`
    FOREIGN KEY (`CodTeste`)
    REFERENCES `mydb`.`teste` (`CodTeste`),
  CONSTRAINT `idDados`
    FOREIGN KEY (`idDados`)
    REFERENCES `mydb`.`dados` (`idDados`),
  CONSTRAINT `idOperador`
    FOREIGN KEY (`idOperador`)
    REFERENCES `mydb`.`operador` (`idOperador`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb3;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
