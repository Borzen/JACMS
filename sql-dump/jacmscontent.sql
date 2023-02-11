-- --------------------------------------------------------
-- Host:                         localhost
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

-- Dumping structure for table jacms.ContentType
DROP TABLE IF EXISTS `ContentType`;
CREATE TABLE IF NOT EXISTS `ContentType` (
  `ContentTypeId` int(11) NOT NULL AUTO_INCREMENT,
  `ContentDescritpion` varchar(500) NOT NULL DEFAULT '',
  `TableName` varchar(250) NOT NULL DEFAULT '',
  PRIMARY KEY (`ContentTypeId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for table jacms.Document
DROP TABLE IF EXISTS `Document`;
CREATE TABLE IF NOT EXISTS `Document` (
  `DocumentId` int(11) NOT NULL AUTO_INCREMENT,
  `DocumentName` varchar(150) NOT NULL DEFAULT '',
  `CreatedDateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `CreatedBy` int(11) DEFAULT NULL,
  `IsDeleted` bit(1) NOT NULL,
  `DeletedBy` int(11) DEFAULT NULL,
  PRIMARY KEY (`DocumentId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for table jacms.ImageContent
DROP TABLE IF EXISTS `ImageContent`;
CREATE TABLE IF NOT EXISTS `ImageContent` (
  `ImageContentId` int(11) NOT NULL AUTO_INCREMENT,
  `ImageName` varchar(150) NOT NULL DEFAULT '0',
  `FileExtension` varchar(15) NOT NULL DEFAULT '0',
  `StorageName` uuid NOT NULL,
  `IsDeleted` bit(1) NOT NULL DEFAULT b'0',
  `CreatedDateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `CreatedBy` int(11) DEFAULT NULL,
  `ModifiedDateTime` datetime DEFAULT NULL,
  `ModifiedBy` int(11) DEFAULT NULL,
  `AltText` text NOT NULL DEFAULT '',
  PRIMARY KEY (`ImageContentId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for table jacms.Section
DROP TABLE IF EXISTS `Section`;
CREATE TABLE IF NOT EXISTS `Section` (
  `SectionId` int(11) NOT NULL AUTO_INCREMENT,
  `SectionName` varchar(150) NOT NULL,
  `DocumentId` int(11) NOT NULL,
  `ContentTypeId` int(11) NOT NULL,
  `ContentId` int(11) NOT NULL,
  `IsDeleted` bit(1) NOT NULL DEFAULT b'0',
  `SectionOrder` int(11) NOT NULL,
  `CreatedDateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `CreatedBy` int(11) DEFAULT NULL,
  `ModifiedDateTime` datetime DEFAULT NULL,
  `ModifiedBy` int(11) DEFAULT NULL,
  PRIMARY KEY (`SectionId`),
  KEY `FK_Section_Document` (`DocumentId`),
  KEY `FK_Section_Type` (`ContentTypeId`),
  CONSTRAINT `FK_Section_ContentType` FOREIGN KEY (`ContentTypeId`) REFERENCES `Type` (`ContentTypeId`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Section_Document` FOREIGN KEY (`DocumentId`) REFERENCES `Document` (`DocumentId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for table jacms.TextContent
DROP TABLE IF EXISTS `TextContent`;
CREATE TABLE IF NOT EXISTS `TextContent` (
  `TextContentId` int(11) NOT NULL AUTO_INCREMENT,
  `TextValue` text NOT NULL DEFAULT '',
  `TextTypeId` int(11) NOT NULL DEFAULT 0,
  `IsDeleted` bit(1) NOT NULL DEFAULT b'0',
  `CreatedDateTime` datetime NOT NULL DEFAULT current_timestamp(),
  `CreatedBy` int(11) DEFAULT NULL,
  `ModifiedDateTime` datetime DEFAULT NULL,
  `ModifiedBy` int(11) DEFAULT NULL,
  PRIMARY KEY (`TextContentId`),
  KEY `FK_TextContent_TextType` (`TextTypeId`),
  CONSTRAINT `FK_TextContent_TextType` FOREIGN KEY (`TextTypeId`) REFERENCES `TextType` (`TextTypeId`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for table jacms.TextType
DROP TABLE IF EXISTS `TextType`;
CREATE TABLE IF NOT EXISTS `TextType` (
  `TextTypeId` int(11) NOT NULL AUTO_INCREMENT,
  `TypeName` varchar(150) NOT NULL DEFAULT '0',
  `TypeDescription` varchar(500) NOT NULL DEFAULT '0',
  `Style` text NOT NULL,
  PRIMARY KEY (`TextTypeId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Data exporting was unselected.

-- Dumping structure for procedure jacms.usp_ContentType_Create
DROP PROCEDURE IF EXISTS `usp_ContentType_Create`;
DELIMITER //
CREATE PROCEDURE `usp_ContentType_Create`(
	IN `ContentDescription` VARCHAR(500),
	IN `TableName` VARCHAR(250)
)
BEGIN
INSERT INTO ContentType VALUES (ContentDescription, TableName);
END//
DELIMITER ;

-- Dumping structure for procedure jacms.usp_Document_Create
DROP PROCEDURE IF EXISTS `usp_Document_Create`;
DELIMITER //
CREATE PROCEDURE `usp_Document_Create`(
	IN `DocumentName` VARCHAR(150),
	IN `CreatedDateTime` DATETIME,
	IN `CreatedBy` INT,
	IN `IsDeleted` BIT,
	IN `DeletedBy` INT
)
BEGIN
INSERT INTO Document VALUES (DocumentName,CreatedDateTime,CreatedBy,IsDeleted,DeletedBy);
END//
DELIMITER ;

-- Dumping structure for procedure jacms.usp_Document_Delete
DROP PROCEDURE IF EXISTS `usp_Document_Delete`;
DELIMITER //
CREATE PROCEDURE `usp_Document_Delete`(
	IN `DocumentId` INT,
	IN `UserId` INT
)
BEGIN
UPDATE Document AS doc
SET 
doc.IsDeleted = 1,
doc.DeletedBy = UserId
WHERE
doc.DocumentId = DocumentId;
END//
DELIMITER ;

-- Dumping structure for procedure jacms.usp_Document_UnDelete
DROP PROCEDURE IF EXISTS `usp_Document_UnDelete`;
DELIMITER //
CREATE PROCEDURE `usp_Document_UnDelete`(
	IN `DocumentId` INT
)
BEGIN
UPDATE Document doc
SET
doc.IsDeleted = 0
WHERE 
doc.DocumentId = DocumentId;
END//
DELIMITER ;

-- Dumping structure for procedure jacms.usp_ImageContent_Create
DROP PROCEDURE IF EXISTS `usp_ImageContent_Create`;
DELIMITER //
CREATE PROCEDURE `usp_ImageContent_Create`(
	IN `ImageName` VARCHAR(150),
	IN `FileExtension` VARCHAR(15),
	IN `StorageName` UUID,
	IN `IsDeleted` BIT,
	IN `CreatedDateTime` DATETIME,
	IN `CreatedBy` INT,
	IN `AltText` TEXT
)
BEGIN
INSERT INTO ImageContent (ImageName,FileExtension,Storagename,IsDeleted,CreatedDateTime,CreatedBy,AltText)
VALUES (ImageName,FileExtension,StorageName,IsDeleted,CreatedDateTime,CreatedBy,AltText);
END//
DELIMITER ;

-- Dumping structure for procedure jacms.usp_Section_Create
DROP PROCEDURE IF EXISTS `usp_Section_Create`;
DELIMITER //
CREATE PROCEDURE `usp_Section_Create`(
	IN `SectionName` VARCHAR(150),
	IN `DocumentId` INT,
	IN `ContentTypeId` INT,
	IN `ContentId` INT,
	IN `IsDeleted` BIT,
	IN `SectionOrder` INT,
	IN `CreatedDateTime` DATETIME,
	IN `CreatedBy` INT
)
BEGIN
INSERT INTO Section VALUES (SectionName,DocumentId,ContentTypeId,ContentId,IsDeleted,SectionOrder,CreatedDateTime,CreatedBy);
END//
DELIMITER ;

-- Dumping structure for procedure jacms.usp_TextContent_Create
DROP PROCEDURE IF EXISTS `usp_TextContent_Create`;
DELIMITER //
CREATE PROCEDURE `usp_TextContent_Create`(
	IN `TextValue` TEXT,
	IN `TextTypeId` INT,
	IN `IsDeleted` BIT,
	IN `CreatedDateTime` DATETIME,
	IN `CreatedBy` INT
)
BEGIN
INSERT INTO TextContent (TextValue, TextTypeId, IsDeleted,CreatedDateTime,CreatedBy)
VALUES (TextValue,TextTypeId,IsDeleted,CreatedDateTime,CreatedBy);
END//
DELIMITER ;

-- Dumping structure for procedure jacms.usp_TextContent_Update
DROP PROCEDURE IF EXISTS `usp_TextContent_Update`;
DELIMITER //
CREATE PROCEDURE `usp_TextContent_Update`(
	IN `TextContentId` INT,
	IN `TextContentValue` TEXT,
	IN `TextTypeId` INT,
	IN `IsDeleted` BIT,
	IN `ModifiedDateTime` DATETIME,
	IN `ModifiedBy` INT
)
BEGIN
UPDATE TextContent tc
SET
tc.TextValue = TextContentValue,
tc.TextTypeId = TextTypeId,
tc.IsDeleted = IsDeleted,
tc.ModifiedDateTime = ModifiedDateTime,
tc.ModifiedBy = ModifiedBy
WHERE
tc.TextContentId = TextContentId;
END//
DELIMITER ;

-- Dumping structure for procedure jacms.usp_TextType_Create
DROP PROCEDURE IF EXISTS `usp_TextType_Create`;
DELIMITER //
CREATE PROCEDURE `usp_TextType_Create`(
	IN `TextTypeName` VARCHAR(150),
	IN `TextTypeDescription` VARCHAR(500),
	IN `Style` TEXT
)
BEGIN
INSERT INTO TextType VALUES (TextTypeName,TextTypeDescription,Style);
END//
DELIMITER ;

-- Dumping structure for procedure jacms.usp_TextType_Update
DROP PROCEDURE IF EXISTS `usp_TextType_Update`;
DELIMITER //
CREATE PROCEDURE `usp_TextType_Update`(
	IN `TextTypeId` INT,
	IN `TypeName` VARCHAR(150),
	IN `TypeDescription` VARCHAR(500),
	IN `Style` TEXT
)
BEGIN
UPDATE TextType tt
SET
tt.TypeName = TypeName,
tt.TypeDescription = TypeDescription,
tt.Style = Style
WHERE
tt.TextTypeId = TextTypeId;
END//
DELIMITER ;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
