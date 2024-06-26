-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: vehicle_healthbook
-- ------------------------------------------------------
-- Server version	8.3.0

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
-- Table structure for table `faults`
--

DROP TABLE IF EXISTS `faults`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `faults` (
  `id_f` int NOT NULL AUTO_INCREMENT,
  `fault_type` enum('wheels','engine','windows','suspension','electrical','body','other') DEFAULT NULL,
  `fault_desc` text,
  `repair_price` text,
  PRIMARY KEY (`id_f`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `faults`
--

LOCK TABLES `faults` WRITE;
/*!40000 ALTER TABLE `faults` DISABLE KEYS */;
/*!40000 ALTER TABLE `faults` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `owners`
--

DROP TABLE IF EXISTS `owners`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `owners` (
  `id_o` int NOT NULL AUTO_INCREMENT,
  `gender` enum('female','male','other') DEFAULT NULL,
  `name_first` text NOT NULL,
  `name_second` text,
  `surname` text NOT NULL,
  `birth_date` date DEFAULT NULL,
  `pesel` char(11) DEFAULT NULL,
  `citizenship` text,
  `id_number` char(9) DEFAULT NULL,
  `postal_code` char(6) DEFAULT NULL,
  `street_house_num` text,
  `phone_num` char(9) DEFAULT NULL,
  `e_mail` text,
  `vehicle_id` int DEFAULT NULL,
  PRIMARY KEY (`id_o`),
  KEY `fk_vehicle` (`vehicle_id`),
  CONSTRAINT `fk_vehicle` FOREIGN KEY (`vehicle_id`) REFERENCES `vehicles` (`id_p`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `owners`
--

LOCK TABLES `owners` WRITE;
/*!40000 ALTER TABLE `owners` DISABLE KEYS */;
/*!40000 ALTER TABLE `owners` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `vehicle_healthbook`
--

DROP TABLE IF EXISTS `vehicle_healthbook`;
/*!50001 DROP VIEW IF EXISTS `vehicle_healthbook`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `vehicle_healthbook` AS SELECT 
 1 AS `name_first`,
 1 AS `surname`,
 1 AS `producer`,
 1 AS `model`,
 1 AS `production_year`,
 1 AS `type`,
 1 AS `license_plate_num`,
 1 AS `mileage`,
 1 AS `mot_date`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `vehicles`
--

DROP TABLE IF EXISTS `vehicles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicles` (
  `id_p` int NOT NULL AUTO_INCREMENT,
  `producer` text NOT NULL,
  `model` text NOT NULL,
  `production_year` char(4) NOT NULL,
  `license_plate_num` char(8) NOT NULL,
  `mileage` text NOT NULL,
  `color` text,
  `insurance_date` date NOT NULL,
  `mot_date` date NOT NULL,
  `faults` enum('tak','nie') DEFAULT NULL,
  `vin` char(17) DEFAULT NULL,
  `type` enum('car','truck','motorcycle','bus','van','suv','other') NOT NULL DEFAULT 'car',
  `owner_id` int DEFAULT NULL,
  `fault_id` int DEFAULT NULL,
  PRIMARY KEY (`id_p`),
  KEY `fk_owner` (`owner_id`),
  KEY `fk_fault` (`fault_id`),
  CONSTRAINT `fk_fault` FOREIGN KEY (`fault_id`) REFERENCES `faults` (`id_f`),
  CONSTRAINT `fk_owner` FOREIGN KEY (`owner_id`) REFERENCES `owners` (`id_o`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicles`
--

LOCK TABLES `vehicles` WRITE;
/*!40000 ALTER TABLE `vehicles` DISABLE KEYS */;
/*!40000 ALTER TABLE `vehicles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `vehicle_healthbook`
--

/*!50001 DROP VIEW IF EXISTS `vehicle_healthbook`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `vehicle_healthbook` AS select `o`.`name_first` AS `name_first`,`o`.`surname` AS `surname`,`v`.`producer` AS `producer`,`v`.`model` AS `model`,`v`.`production_year` AS `production_year`,`v`.`type` AS `type`,`v`.`license_plate_num` AS `license_plate_num`,`v`.`mileage` AS `mileage`,`v`.`mot_date` AS `mot_date` from (`vehicles` `v` join `owners` `o` on((`v`.`owner_id` = `o`.`id_o`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-06-20 15:58:21
