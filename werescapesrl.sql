-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: warescapesrl
-- ------------------------------------------------------
-- Server version	5.7.31

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
-- Table structure for table `editoriales`
--

DROP TABLE IF EXISTS `editoriales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `editoriales` (
  `rut` int(30) NOT NULL,
  `nombre` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`rut`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `editoriales`
--

LOCK TABLES `editoriales` WRITE;
/*!40000 ALTER TABLE `editoriales` DISABLE KEYS */;
/*!40000 ALTER TABLE `editoriales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `generan`
--

DROP TABLE IF EXISTS `generan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `generan` (
  `n_de_boleta` int(20) DEFAULT NULL,
  `isbn` int(20) DEFAULT NULL,
  `precio` int(5) DEFAULT NULL,
  `cantidad_comprada` int(5) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `generan`
--

LOCK TABLES `generan` WRITE;
/*!40000 ALTER TABLE `generan` DISABLE KEYS */;
/*!40000 ALTER TABLE `generan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `generos`
--

DROP TABLE IF EXISTS `generos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `generos` (
  `id_genero` int(5) NOT NULL,
  `descripcion` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_genero`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `generos`
--

LOCK TABLES `generos` WRITE;
/*!40000 ALTER TABLE `generos` DISABLE KEYS */;
/*!40000 ALTER TABLE `generos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `libros`
--

DROP TABLE IF EXISTS `libros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `libros` (
  `isbn` int(20) NOT NULL,
  `codigo` int(20) DEFAULT NULL,
  `precio` int(5) DEFAULT NULL,
  `stock` int(10) DEFAULT NULL,
  `nombre` varchar(40) DEFAULT NULL,
  `devoluciones` int(5) DEFAULT NULL,
  PRIMARY KEY (`isbn`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `libros`
--

LOCK TABLES `libros` WRITE;
/*!40000 ALTER TABLE `libros` DISABLE KEYS */;
/*!40000 ALTER TABLE `libros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `poseen`
--

DROP TABLE IF EXISTS `poseen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `poseen` (
  `rut` int(30) DEFAULT NULL,
  `n_de_operacion` int(10) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `poseen`
--

LOCK TABLES `poseen` WRITE;
/*!40000 ALTER TABLE `poseen` DISABLE KEYS */;
/*!40000 ALTER TABLE `poseen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publicidades`
--

DROP TABLE IF EXISTS `publicidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `publicidades` (
  `rut` int(30) NOT NULL,
  `id` int(8) DEFAULT NULL,
  `alcance_de_personas` int(6) DEFAULT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`rut`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publicidades`
--

LOCK TABLES `publicidades` WRITE;
/*!40000 ALTER TABLE `publicidades` DISABLE KEYS */;
/*!40000 ALTER TABLE `publicidades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `usuarios` varchar(20) DEFAULT NULL,
  `contrasena` varchar(100) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES ('admin','9cf627fc399bd5a314e3c483553ef22af498e806'),('gerente','6cc73ded5ce275177c0b19bae885a25457ec9b21'),('empleado','f9f011a553550aef31a8ee2690e1d1b5f261c9ff');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vende_o_consigna`
--

DROP TABLE IF EXISTS `vende_o_consigna`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vende_o_consigna` (
  `rut` int(30) DEFAULT NULL,
  `isbn` int(20) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vende_o_consigna`
--

LOCK TABLES `vende_o_consigna` WRITE;
/*!40000 ALTER TABLE `vende_o_consigna` DISABLE KEYS */;
/*!40000 ALTER TABLE `vende_o_consigna` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ventas` (
  `n_de_boletas` int(20) NOT NULL,
  `fecha_de_venta` date DEFAULT NULL,
  `monto` int(20) DEFAULT NULL,
  PRIMARY KEY (`n_de_boletas`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas_y_consignaciones`
--

DROP TABLE IF EXISTS `ventas_y_consignaciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ventas_y_consignaciones` (
  `n_de_operacion` int(10) NOT NULL,
  `cantidad_consignada` int(10) DEFAULT NULL,
  `fecha_de_operacion` date DEFAULT NULL,
  `cantidad_comprada` int(10) DEFAULT NULL,
  PRIMARY KEY (`n_de_operacion`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas_y_consignaciones`
--

LOCK TABLES `ventas_y_consignaciones` WRITE;
/*!40000 ALTER TABLE `ventas_y_consignaciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas_y_consignaciones` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-01 20:11:24
