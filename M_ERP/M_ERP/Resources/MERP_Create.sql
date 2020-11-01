CREATE DATABASE  IF NOT EXISTS `merp` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `merp`;
-- MySQL dump 10.13  Distrib 5.6.13, for Win32 (x86)
--
-- Host: 127.0.0.1    Database: merp
-- ------------------------------------------------------
-- Server version	5.6.17

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `company`
--

DROP TABLE IF EXISTS `company`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `company` (
  `CMP_NAME` int(11) NOT NULL,
  `CMP_ADDRESS` varchar(70) NOT NULL,
  `CMP_PHONENO` varchar(45) DEFAULT NULL,
  `CMP_MOBNO` varchar(45) NOT NULL,
  `CMP_COMMREC` varchar(45) DEFAULT NULL,
  `CMP_TAXREC` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`CMP_NAME`),
  UNIQUE KEY `CMP_NAME_UNIQUE` (`CMP_NAME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `company`
--

LOCK TABLES `company` WRITE;
/*!40000 ALTER TABLE `company` DISABLE KEYS */;
/*!40000 ALTER TABLE `company` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permissions`
--

DROP TABLE IF EXISTS `permissions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `permissions` (
  `PRM_NAME` varchar(45) NOT NULL,
  `PRM_PARENT` varchar(45) NOT NULL DEFAULT 'root',
  PRIMARY KEY (`PRM_NAME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permissions`
--

LOCK TABLES `permissions` WRITE;
/*!40000 ALTER TABLE `permissions` DISABLE KEYS */;
/*!40000 ALTER TABLE `permissions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `products` (
  `PRD_ID` int(11) NOT NULL AUTO_INCREMENT,
  `PRD_NAME` varchar(45) NOT NULL,
  `PRD_TYPE_ID` int(11) NOT NULL,
  `PRD_LIMIT` int(11) NOT NULL,
  `PRD_BUYPRICE` double NOT NULL,
  `PRD_WHLSALEPRICE` double NOT NULL,
  `PRD_SCTRPRICE` double NOT NULL,
  `PRD_DESC` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`PRD_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `USR_ID` int(11) NOT NULL AUTO_INCREMENT,
  `USR_NAME` varchar(45) NOT NULL,
  `USR_PASS` varchar(45) NOT NULL,
  PRIMARY KEY (`USR_ID`),
  UNIQUE KEY `USR_NAME_UNIQUE` (`USR_NAME`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usr_prm`
--

DROP TABLE IF EXISTS `usr_prm`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usr_prm` (
  `PRMUSR_USR_ID` int(11) NOT NULL,
  `PRMUSR_PRM_NAME` varchar(45) NOT NULL,
  PRIMARY KEY (`PRMUSR_USR_ID`,`PRMUSR_PRM_NAME`),
  KEY `PRM_USR_FK_idx` (`PRMUSR_PRM_NAME`),
  CONSTRAINT `USR_PRM_FK` FOREIGN KEY (`PRMUSR_USR_ID`) REFERENCES `users` (`USR_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `PRM_USR_FK` FOREIGN KEY (`PRMUSR_PRM_NAME`) REFERENCES `permissions` (`PRM_NAME`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usr_prm`
--

LOCK TABLES `usr_prm` WRITE;
/*!40000 ALTER TABLE `usr_prm` DISABLE KEYS */;
/*!40000 ALTER TABLE `usr_prm` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-02-04 23:10:14
