-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.10.2-MariaDB-1:10.10.2+maria~ubu2204 - mariadb.org binary distribution
-- Server OS:                    debian-linux-gnu
-- HeidiSQL Version:             12.3.0.6589
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Dumping database structure for jacms
DROP DATABASE IF EXISTS `jacms`;
CREATE DATABASE IF NOT EXISTS `jacms` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `jacms`;

-- Dumping structure for table jacms.Document
DROP TABLE IF EXISTS `Document`;
CREATE TABLE IF NOT EXISTS `Document` (
  `DocumentId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL DEFAULT '',
  `CreatedDateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `CreatedBy` int(11) DEFAULT 0,
  PRIMARY KEY (`DocumentId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for table jacms.ImageContent
DROP TABLE IF EXISTS `ImageContent`;
CREATE TABLE IF NOT EXISTS `ImageContent` (
  `ImageContentId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL DEFAULT '0',
  `FileExtension` varchar(15) NOT NULL DEFAULT '0',
  `StorageName` uuid NOT NULL,
  `IsDeleted` bit(1) NOT NULL DEFAULT b'0',
  `CreatedDateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `ModifiedDateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `AltText` text NOT NULL,
  PRIMARY KEY (`ImageContentId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for table jacms.Section
DROP TABLE IF EXISTS `Section`;
CREATE TABLE IF NOT EXISTS `Section` (
  `SectionId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL,
  `DocumentId` int(11) NOT NULL,
  `ContentTypeId` int(11) NOT NULL,
  `ContentId` int(11) NOT NULL,
  `IsDeleted` bit(1) NOT NULL DEFAULT b'0',
  `Order` int(11) NOT NULL,
  `CreatedDateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `CreatedBy` int(11) DEFAULT NULL,
  PRIMARY KEY (`SectionId`),
  KEY `FK_Section_Document` (`DocumentId`),
  KEY `FK_Section_Type` (`ContentTypeId`),
  CONSTRAINT `FK_Section_Document` FOREIGN KEY (`DocumentId`) REFERENCES `Document` (`DocumentId`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Section_ContentType` FOREIGN KEY (`ContentTypeId`) REFERENCES `Type` (`ContentTypeId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for table jacms.TextContent
DROP TABLE IF EXISTS `TextContent`;
CREATE TABLE IF NOT EXISTS `TextContent` (
  `TextContentId` int(11) NOT NULL AUTO_INCREMENT,
  `Value` text NOT NULL,
  `TextTypeId` int(11) NOT NULL DEFAULT 0,
  `IsDeleted` bit(1) NOT NULL DEFAULT b'0',
  `CreatedDateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `ModifiedDateTime` datetime NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`TextContentId`),
  KEY `FK_TextContent_TextType` (`TextTypeId`),
  CONSTRAINT `FK_TextContent_TextType` FOREIGN KEY (`TextTypeId`) REFERENCES `TextType` (`TextTypeId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for table jacms.TextType
DROP TABLE IF EXISTS `TextType`;
CREATE TABLE IF NOT EXISTS `TextType` (
  `TextTypeId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(150) NOT NULL DEFAULT '0',
  `Description` varchar(500) NOT NULL DEFAULT '0',
  `Style` text NOT NULL,
  PRIMARY KEY (`TextTypeId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for table jacms.Type
DROP TABLE IF EXISTS `ContentType`;
CREATE TABLE IF NOT EXISTS `ContentType` (
  `ContentTypeId` int(11) NOT NULL AUTO_INCREMENT,
  `Descritpion` varchar(500) NOT NULL DEFAULT '',
  `TableName` varchar(250) NOT NULL DEFAULT '',
  PRIMARY KEY (`ContentTypeId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
