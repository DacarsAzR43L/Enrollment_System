CREATE DATABASE  IF NOT EXISTS `enrollment` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `enrollment`;
-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: enrollment
-- ------------------------------------------------------
-- Server version	8.0.29

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `coursesoffered`
--

DROP TABLE IF EXISTS `coursesoffered`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `coursesoffered` (
  `course_Id` varchar(50) NOT NULL,
  `c_desc` varchar(50) NOT NULL,
  PRIMARY KEY (`course_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `coursesoffered`
--

LOCK TABLES `coursesoffered` WRITE;
/*!40000 ALTER TABLE `coursesoffered` DISABLE KEYS */;
INSERT INTO `coursesoffered` VALUES ('COMP 1001','Twitch'),('COMP 1002','Filipino'),('COMP 1003','MAPEH'),('COMP 1004','SCIENCE'),('COMP 1005','ESP'),('COMP 1006','Modeling'),('COMP 1007','GenMath'),('COMP 1008','Science'),('COMP 2001','Twitter'),('COMP 2002','YouTube');
/*!40000 ALTER TABLE `coursesoffered` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sections`
--

DROP TABLE IF EXISTS `sections`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `sections` (
  `section_Id` varchar(511) NOT NULL,
  `sec_descrip` varchar(50) NOT NULL,
  PRIMARY KEY (`section_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sections`
--

LOCK TABLES `sections` WRITE;
/*!40000 ALTER TABLE `sections` DISABLE KEYS */;
INSERT INTO `sections` VALUES ('PUPSMB-SEC1','BSIT 2-1'),('PUPSMB-SEC2','BSIT 2-2'),('PUPSMB-SEC3','BSIT 3-1'),('PUPSMB-SEC4','BSIT 3-2'),('PUPSMB-SEC5','BSIT 4-1'),('PUPSMB-SEC6','BSIT 4-2'),('PUPSMB-SEC7','BSPSY 3-A 1F'),('PUPSMB-SEC8','BSBA 1-1');
/*!40000 ALTER TABLE `sections` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `studentprofile`
--

DROP TABLE IF EXISTS `studentprofile`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `studentprofile` (
  `student_Id` varchar(511) NOT NULL,
  `f_name` varchar(50) NOT NULL,
  `l_name` varchar(50) NOT NULL,
  `fullname` varchar(50) NOT NULL,
  PRIMARY KEY (`student_Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `studentprofile`
--

LOCK TABLES `studentprofile` WRITE;
/*!40000 ALTER TABLE `studentprofile` DISABLE KEYS */;
INSERT INTO `studentprofile` VALUES ('PUPSMB-2019-1','Burnek','Tigasin','Burnek Tigasin'),('PUPSMB-2019-2','Dayman','Castro','Dayman Castro'),('PUPSMB-2019-3','Justine','Santos','Justine Santos'),('PUPSMB-2019-4','Terry','Scott','Terry Scott'),('PUPSMB-2019-5','Raphael ','Dacara','Raphael  Dacara'),('PUPSMB-2019-6','Michael','Angelo','Michael Angelo');
/*!40000 ALTER TABLE `studentprofile` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tagging`
--

DROP TABLE IF EXISTS `tagging`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tagging` (
  `studentId` varchar(50) NOT NULL,
  `studName` varchar(50) NOT NULL,
  `secDesc` varchar(50) NOT NULL,
  `course` varchar(50) NOT NULL,
  PRIMARY KEY (`studentId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tagging`
--

LOCK TABLES `tagging` WRITE;
/*!40000 ALTER TABLE `tagging` DISABLE KEYS */;
INSERT INTO `tagging` VALUES ('PUPSMB-2019-1','Burnek Tigasin','BSPSY 3-A 1F','COMP 1008'),('PUPSMB-2019-3','Justine Santos','BSIT 2-2','COMP 1003'),('PUPSMB-2019-5','Raphael  Dacara','BSIT 4-2','COMP 1002'),('PUPSMB-2019-6','Michael Angelo','BSBA 1-1','COMP 2002');
/*!40000 ALTER TABLE `tagging` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-07-30 14:26:17
