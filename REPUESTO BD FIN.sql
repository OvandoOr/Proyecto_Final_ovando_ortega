CREATE DATABASE  IF NOT EXISTS `final_clinica` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `final_clinica`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: final_clinica
-- ------------------------------------------------------
-- Server version	5.7.19-log

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
-- Table structure for table `aparato_medico`
--

DROP TABLE IF EXISTS `aparato_medico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aparato_medico` (
  `idAparato_medico` int(11) NOT NULL AUTO_INCREMENT,
  `Modelo` varchar(445) NOT NULL,
  `Marca` varchar(445) NOT NULL,
  `Area_Clinica_idArea_Clinica` int(11) NOT NULL,
  PRIMARY KEY (`idAparato_medico`,`Area_Clinica_idArea_Clinica`),
  KEY `fk_Aparato_medico_Area_Clinica1_idx` (`Area_Clinica_idArea_Clinica`),
  CONSTRAINT `fk_Aparato_medico_Area_Clinica1` FOREIGN KEY (`Area_Clinica_idArea_Clinica`) REFERENCES `area_clinica` (`idArea_Clinica`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aparato_medico`
--

LOCK TABLES `aparato_medico` WRITE;
/*!40000 ALTER TABLE `aparato_medico` DISABLE KEYS */;
/*!40000 ALTER TABLE `aparato_medico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `area_clinica`
--

DROP TABLE IF EXISTS `area_clinica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `area_clinica` (
  `idArea_Clinica` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(445) NOT NULL,
  PRIMARY KEY (`idArea_Clinica`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `area_clinica`
--

LOCK TABLES `area_clinica` WRITE;
/*!40000 ALTER TABLE `area_clinica` DISABLE KEYS */;
INSERT INTO `area_clinica` VALUES (0,'Ninguna'),(1,'Nutricion'),(2,'General'),(3,'Pediatria');
/*!40000 ALTER TABLE `area_clinica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consulta`
--

DROP TABLE IF EXISTS `consulta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `consulta` (
  `idConsulta` int(11) NOT NULL AUTO_INCREMENT,
  `Doctor` int(11) NOT NULL,
  `Paciente` int(11) NOT NULL,
  `Fecha` datetime DEFAULT NULL,
  `Numero de consultorio` int(11) NOT NULL,
  `Estado_consulta` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`idConsulta`,`Numero de consultorio`,`Doctor`,`Paciente`),
  KEY `fk_consultoriosid_idx` (`Numero de consultorio`),
  KEY `fk_doctor_idx` (`Doctor`),
  KEY `fk_pacienteid_idx` (`Paciente`),
  CONSTRAINT `fk_consultoriosid` FOREIGN KEY (`Numero de consultorio`) REFERENCES `consultorios` (`idConsultorios`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_doctoresid` FOREIGN KEY (`Doctor`) REFERENCES `doctores` (`idDoctores`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_pacienteid` FOREIGN KEY (`Paciente`) REFERENCES `paciente` (`idPaciente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consulta`
--

LOCK TABLES `consulta` WRITE;
/*!40000 ALTER TABLE `consulta` DISABLE KEYS */;
INSERT INTO `consulta` VALUES (0,1,1,NULL,0,'Realizada'),(2,1,1,'2017-11-06 17:00:00',0,'Programada'),(3,1,1,'2017-11-05 07:00:00',0,'Programada');
/*!40000 ALTER TABLE `consulta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `consultorios`
--

DROP TABLE IF EXISTS `consultorios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `consultorios` (
  `idConsultorios` int(11) NOT NULL,
  `Descripcion` varchar(45) NOT NULL,
  `id_area_clinica` int(11) NOT NULL,
  PRIMARY KEY (`idConsultorios`,`id_area_clinica`),
  KEY `fk_id_area_clinica_idx` (`id_area_clinica`),
  CONSTRAINT `fk_id_area_clinica` FOREIGN KEY (`id_area_clinica`) REFERENCES `area_clinica` (`idArea_Clinica`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consultorios`
--

LOCK TABLES `consultorios` WRITE;
/*!40000 ALTER TABLE `consultorios` DISABLE KEYS */;
INSERT INTO `consultorios` VALUES (0,'Ninguno',0);
/*!40000 ALTER TABLE `consultorios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctores`
--

DROP TABLE IF EXISTS `doctores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `doctores` (
  `idDoctores` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(145) NOT NULL,
  `A_paterno` varchar(45) NOT NULL,
  `A_materno` varchar(45) DEFAULT NULL,
  `Telefono` int(10) NOT NULL,
  `Correo` varchar(145) NOT NULL,
  `Fecha_Nac` date NOT NULL,
  `Direccion` varchar(245) NOT NULL,
  `CURP` varchar(45) NOT NULL,
  `Cedula` varchar(145) NOT NULL,
  `Escuela_Estudios` varchar(445) NOT NULL,
  `Tipo_Sangre_idTipo_Sangre` int(11) NOT NULL,
  `Estado_Civil_idEstado_Civil` int(11) NOT NULL,
  `Usuario_idUsuario` int(11) NOT NULL,
  `sexo` int(11) NOT NULL,
  `id_especialidad` int(11) NOT NULL,
  PRIMARY KEY (`idDoctores`,`Tipo_Sangre_idTipo_Sangre`,`Estado_Civil_idEstado_Civil`,`Usuario_idUsuario`,`sexo`,`id_especialidad`),
  KEY `fk_Doctores_Tipo_Sangre_idx` (`Tipo_Sangre_idTipo_Sangre`),
  KEY `fk_Doctores_Estado_Civil1_idx` (`Estado_Civil_idEstado_Civil`),
  KEY `fk_Doctores_sexo_idx` (`sexo`),
  KEY `fk_Doctores_especialidad_idx` (`id_especialidad`),
  KEY `fk_Doctores_Usuario1_idx` (`Usuario_idUsuario`),
  CONSTRAINT `fk_Doctores_Estado_Civil1` FOREIGN KEY (`Estado_Civil_idEstado_Civil`) REFERENCES `estado_civil` (`idEstado_Civil`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Doctores_Tipo_Sangre` FOREIGN KEY (`Tipo_Sangre_idTipo_Sangre`) REFERENCES `tipo_sangre` (`idTipo_Sangre`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Doctores_Usuario1` FOREIGN KEY (`Usuario_idUsuario`) REFERENCES `usuario` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Doctores_especialidad` FOREIGN KEY (`id_especialidad`) REFERENCES `especialidad` (`idEspecialidad`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Doctores_sexo` FOREIGN KEY (`sexo`) REFERENCES `sexo` (`idSexo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctores`
--

LOCK TABLES `doctores` WRITE;
/*!40000 ALTER TABLE `doctores` DISABLE KEYS */;
INSERT INTO `doctores` VALUES (1,'aaa','aaa','aaa',2343243,'asad@hotmail.com','1996-11-12','Por alla en la esquina','123123216123222222','123234123','UDG',7,3,2,2,1);
/*!40000 ALTER TABLE `doctores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctores_has_consulta`
--

DROP TABLE IF EXISTS `doctores_has_consulta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `doctores_has_consulta` (
  `Doctores_idDoctores` int(11) NOT NULL,
  `Doctores_Tipo_Sangre_idTipo_Sangre` int(11) NOT NULL,
  `Doctores_Estado_Civil_idEstado_Civil` int(11) NOT NULL,
  `Consulta_idConsulta` int(11) NOT NULL,
  PRIMARY KEY (`Doctores_idDoctores`,`Doctores_Tipo_Sangre_idTipo_Sangre`,`Doctores_Estado_Civil_idEstado_Civil`,`Consulta_idConsulta`),
  KEY `fk_Doctores_has_Consulta_Consulta1_idx` (`Consulta_idConsulta`),
  KEY `fk_Doctores_has_Consulta_Doctores1_idx` (`Doctores_idDoctores`,`Doctores_Tipo_Sangre_idTipo_Sangre`,`Doctores_Estado_Civil_idEstado_Civil`),
  CONSTRAINT `fk_Doctores_has_Consulta_Consulta1` FOREIGN KEY (`Consulta_idConsulta`) REFERENCES `consulta` (`idConsulta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Doctores_has_Consulta_Doctores1` FOREIGN KEY (`Doctores_idDoctores`, `Doctores_Tipo_Sangre_idTipo_Sangre`, `Doctores_Estado_Civil_idEstado_Civil`) REFERENCES `doctores` (`idDoctores`, `Tipo_Sangre_idTipo_Sangre`, `Estado_Civil_idEstado_Civil`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctores_has_consulta`
--

LOCK TABLES `doctores_has_consulta` WRITE;
/*!40000 ALTER TABLE `doctores_has_consulta` DISABLE KEYS */;
/*!40000 ALTER TABLE `doctores_has_consulta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empleado`
--

DROP TABLE IF EXISTS `empleado`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `empleado` (
  `idEmpleado` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `A_paterno` varchar(45) NOT NULL,
  `A_materno` varchar(45) NOT NULL,
  `Telefono` int(10) NOT NULL,
  `Telefono_Emergencia` int(10) NOT NULL,
  `Correo` varchar(115) NOT NULL,
  `Fecha_nac` date NOT NULL,
  `Direccion` varchar(400) NOT NULL,
  `CURP` varchar(45) NOT NULL,
  `Tipo_Sangre_idTipo_Sangre` int(11) NOT NULL,
  `Estado_Civil_idEstado_Civil` int(11) NOT NULL,
  `Trabajador_idTrabajador` int(11) NOT NULL,
  `Area_Clinica_idArea_Clinica` int(11) NOT NULL,
  `sexo` int(11) NOT NULL,
  PRIMARY KEY (`idEmpleado`,`sexo`,`Area_Clinica_idArea_Clinica`,`Estado_Civil_idEstado_Civil`,`Tipo_Sangre_idTipo_Sangre`,`Trabajador_idTrabajador`),
  KEY `fk_Empleado_Estado_Civil1_idx` (`Estado_Civil_idEstado_Civil`),
  KEY `fk_Empleado_Trabajador1_idx` (`Trabajador_idTrabajador`),
  KEY `fk_Empleado_Area_Clinica1_idx` (`Area_Clinica_idArea_Clinica`),
  KEY `fk_sexo_idx` (`sexo`),
  KEY `fk_tipo_sangre_idx` (`Tipo_Sangre_idTipo_Sangre`),
  CONSTRAINT `fk_areaId` FOREIGN KEY (`Area_Clinica_idArea_Clinica`) REFERENCES `area_clinica` (`idArea_Clinica`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_estadoCivil` FOREIGN KEY (`Estado_Civil_idEstado_Civil`) REFERENCES `estado_civil` (`idEstado_Civil`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_sexo` FOREIGN KEY (`sexo`) REFERENCES `sexo` (`idSexo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_tipo_sangre` FOREIGN KEY (`Tipo_Sangre_idTipo_Sangre`) REFERENCES `tipo_sangre` (`idTipo_Sangre`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_trabajadorid` FOREIGN KEY (`Trabajador_idTrabajador`) REFERENCES `trabajador` (`idTrabajador`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empleado`
--

LOCK TABLES `empleado` WRITE;
/*!40000 ALTER TABLE `empleado` DISABLE KEYS */;
INSERT INTO `empleado` VALUES (1,'Maria','Lizarraga','Osuna',28982837,1902383,'maria@hotmail.com','1987-10-08','Por la esquina del mercado','AJHSD83U23NDJS',2,1,5,0,2);
/*!40000 ALTER TABLE `empleado` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `especialidad`
--

DROP TABLE IF EXISTS `especialidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `especialidad` (
  `idEspecialidad` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(445) NOT NULL,
  PRIMARY KEY (`idEspecialidad`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `especialidad`
--

LOCK TABLES `especialidad` WRITE;
/*!40000 ALTER TABLE `especialidad` DISABLE KEYS */;
INSERT INTO `especialidad` VALUES (1,'Medico general'),(2,'Nutrición');
/*!40000 ALTER TABLE `especialidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `especialidad_has_doctores`
--

DROP TABLE IF EXISTS `especialidad_has_doctores`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `especialidad_has_doctores` (
  `Especialidad_idEspecialidad` int(11) NOT NULL,
  `Doctores_idDoctores` int(11) NOT NULL,
  `Doctores_Tipo_Sangre_idTipo_Sangre` int(11) NOT NULL,
  `Doctores_Estado_Civil_idEstado_Civil` int(11) NOT NULL,
  PRIMARY KEY (`Especialidad_idEspecialidad`,`Doctores_idDoctores`,`Doctores_Tipo_Sangre_idTipo_Sangre`,`Doctores_Estado_Civil_idEstado_Civil`),
  KEY `fk_Especialidad_has_Doctores_Doctores1_idx` (`Doctores_idDoctores`,`Doctores_Tipo_Sangre_idTipo_Sangre`,`Doctores_Estado_Civil_idEstado_Civil`),
  KEY `fk_Especialidad_has_Doctores_Especialidad1_idx` (`Especialidad_idEspecialidad`),
  CONSTRAINT `fk_Especialidad_has_Doctores_Doctores1` FOREIGN KEY (`Doctores_idDoctores`, `Doctores_Tipo_Sangre_idTipo_Sangre`, `Doctores_Estado_Civil_idEstado_Civil`) REFERENCES `doctores` (`idDoctores`, `Tipo_Sangre_idTipo_Sangre`, `Estado_Civil_idEstado_Civil`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Especialidad_has_Doctores_Especialidad1` FOREIGN KEY (`Especialidad_idEspecialidad`) REFERENCES `especialidad` (`idEspecialidad`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `especialidad_has_doctores`
--

LOCK TABLES `especialidad_has_doctores` WRITE;
/*!40000 ALTER TABLE `especialidad_has_doctores` DISABLE KEYS */;
/*!40000 ALTER TABLE `especialidad_has_doctores` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estado_civil`
--

DROP TABLE IF EXISTS `estado_civil`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `estado_civil` (
  `idEstado_Civil` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(100) NOT NULL,
  PRIMARY KEY (`idEstado_Civil`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estado_civil`
--

LOCK TABLES `estado_civil` WRITE;
/*!40000 ALTER TABLE `estado_civil` DISABLE KEYS */;
INSERT INTO `estado_civil` VALUES (1,'Soltero'),(2,'Casado'),(3,'Otro');
/*!40000 ALTER TABLE `estado_civil` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `factura` (
  `idFactura` int(11) NOT NULL AUTO_INCREMENT,
  `Ventas` varchar(415) NOT NULL,
  `Perdidas` varchar(415) NOT NULL,
  PRIMARY KEY (`idFactura`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `farmacia`
--

DROP TABLE IF EXISTS `farmacia`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `farmacia` (
  `idFarmacia` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Medicamento o recurso medico` int(11) NOT NULL,
  `Nombre generico` varchar(45) DEFAULT NULL,
  `precio` double DEFAULT NULL,
  `proveerdor_idproveerdor` int(11) NOT NULL,
  `Fecha ingreso` date NOT NULL,
  `Fecha de caducidad` date DEFAULT NULL,
  `Formula` varchar(45) DEFAULT NULL,
  `Stock` int(11) NOT NULL,
  PRIMARY KEY (`idFarmacia`,`Medicamento o recurso medico`,`proveerdor_idproveerdor`),
  KEY `fk_Farmacia_proveerdor1_idx` (`proveerdor_idproveerdor`),
  KEY `fk_idTipodeProducto_idx` (`Medicamento o recurso medico`),
  CONSTRAINT `fk_Farmacia_proveerdor1` FOREIGN KEY (`proveerdor_idproveerdor`) REFERENCES `proveerdor` (`idproveerdor`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_idTipodeProducto` FOREIGN KEY (`Medicamento o recurso medico`) REFERENCES `tipo de producto` (`idTipo de producto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `farmacia`
--

LOCK TABLES `farmacia` WRITE;
/*!40000 ALTER TABLE `farmacia` DISABLE KEYS */;
INSERT INTO `farmacia` VALUES (1,'Paracetamol',1,'Paracetamol',15.5,1,'2017-11-02','2018-11-30','Paracetamol 50mg',7),(2,'Ibuprofen',0,'Simiprufeno',30.99,1,'2017-11-02',NULL,'Ibuprofeno55mg',10);
/*!40000 ALTER TABLE `farmacia` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historial_clinico`
--

DROP TABLE IF EXISTS `historial_clinico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `historial_clinico` (
  `id_consulta_historial` int(11) NOT NULL AUTO_INCREMENT,
  `idPaciente` int(11) NOT NULL,
  `estatura` decimal(10,2) DEFAULT NULL,
  `peso` decimal(10,2) DEFAULT NULL,
  `Doctor` int(11) DEFAULT NULL,
  `observaciones` varchar(45) DEFAULT NULL,
  `Sintomas` varchar(45) NOT NULL,
  `Diagnostico` varchar(45) NOT NULL,
  `Consultorio` int(11) NOT NULL,
  `Fecha` date NOT NULL,
  `Hora` time NOT NULL,
  `Señal` varchar(45) NOT NULL,
  PRIMARY KEY (`id_consulta_historial`),
  KEY `paciente_idx` (`idPaciente`),
  KEY `consultorio_idx` (`Consultorio`),
  KEY `Doctor_idx` (`Doctor`),
  CONSTRAINT `Doctor` FOREIGN KEY (`Doctor`) REFERENCES `doctores` (`idDoctores`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `consultorio` FOREIGN KEY (`Consultorio`) REFERENCES `consultorios` (`idConsultorios`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `paciente` FOREIGN KEY (`idPaciente`) REFERENCES `paciente` (`idPaciente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historial_clinico`
--

LOCK TABLES `historial_clinico` WRITE;
/*!40000 ALTER TABLE `historial_clinico` DISABLE KEYS */;
INSERT INTO `historial_clinico` VALUES (1,1,1.74,75.00,1,'NA','Dolor de cabez','Chorro',2,'2017-11-05','09:00:00',''),(2,2,1.56,60.00,1,'NA','Dolor','Chorro',1,'2017-11-05','10:00:00','');
/*!40000 ALTER TABLE `historial_clinico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventario`
--

DROP TABLE IF EXISTS `inventario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `inventario` (
  `idInventario` int(11) NOT NULL AUTO_INCREMENT,
  `Aparato_medico_idAparato_medico` int(11) NOT NULL,
  `Mobiliario_idMobiliario` int(11) NOT NULL,
  PRIMARY KEY (`idInventario`,`Aparato_medico_idAparato_medico`,`Mobiliario_idMobiliario`),
  KEY `fk_Inventario_Aparato_medico1_idx` (`Aparato_medico_idAparato_medico`),
  KEY `fk_Inventario_Mobiliario1_idx` (`Mobiliario_idMobiliario`),
  CONSTRAINT `fk_Inventario_Aparato_medico1` FOREIGN KEY (`Aparato_medico_idAparato_medico`) REFERENCES `aparato_medico` (`idAparato_medico`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Inventario_Mobiliario1` FOREIGN KEY (`Mobiliario_idMobiliario`) REFERENCES `mobiliario` (`idMobiliario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventario`
--

LOCK TABLES `inventario` WRITE;
/*!40000 ALTER TABLE `inventario` DISABLE KEYS */;
/*!40000 ALTER TABLE `inventario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mobiliario`
--

DROP TABLE IF EXISTS `mobiliario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `mobiliario` (
  `idMobiliario` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) NOT NULL,
  `Tipo de equipo` varchar(30) NOT NULL,
  `uso` varchar(200) NOT NULL,
  `Marca` varchar(30) DEFAULT NULL,
  `Modelo` varchar(45) DEFAULT NULL,
  `Area_Clinica_idArea_Clinica` int(11) NOT NULL,
  PRIMARY KEY (`idMobiliario`,`Area_Clinica_idArea_Clinica`),
  KEY `fk_Mobiliario_Area_Clinica1_idx` (`Area_Clinica_idArea_Clinica`),
  CONSTRAINT `fk_Mobiliario_Area_Clinica1` FOREIGN KEY (`Area_Clinica_idArea_Clinica`) REFERENCES `area_clinica` (`idArea_Clinica`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mobiliario`
--

LOCK TABLES `mobiliario` WRITE;
/*!40000 ALTER TABLE `mobiliario` DISABLE KEYS */;
INSERT INTO `mobiliario` VALUES (1,'Mesa','Mobiliario','Poner cosas',NULL,NULL,1),(2,'Escritorio','Mobiliario','Sostener cosas','INTELLA','RSJ42',1);
/*!40000 ALTER TABLE `mobiliario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente`
--

DROP TABLE IF EXISTS `paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paciente` (
  `idPaciente` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `A_paterno` varchar(145) NOT NULL,
  `A_materno` varchar(145) DEFAULT NULL,
  `Telefono` int(10) NOT NULL,
  `Telefono_Emergencia` int(10) NOT NULL,
  `Correo` varchar(145) NOT NULL,
  `Fecha_Nac` date NOT NULL,
  `Direccion` varchar(145) NOT NULL,
  `CURP` varchar(145) NOT NULL,
  `Tipo_Sangre_idTipo_Sangre` int(11) NOT NULL,
  `Estado_Civil_idEstado_Civil` int(11) NOT NULL,
  `Consulta_idConsulta` int(11) NOT NULL,
  `sexo` int(11) NOT NULL,
  `Antecedentes Heredofamiliares` varchar(400) DEFAULT NULL,
  `Antecedentes personales` varchar(400) DEFAULT NULL,
  PRIMARY KEY (`idPaciente`,`Tipo_Sangre_idTipo_Sangre`,`Estado_Civil_idEstado_Civil`,`Consulta_idConsulta`,`sexo`),
  KEY `fk_Paciente_Tipo_Sangre1_idx` (`Tipo_Sangre_idTipo_Sangre`),
  KEY `fk_Paciente_Estado_Civil1_idx` (`Estado_Civil_idEstado_Civil`),
  KEY `fk_Paciente_Consulta1_idx` (`Consulta_idConsulta`),
  KEY `fk_Paciente_sexo_idx` (`sexo`),
  CONSTRAINT `fk_Paciente_Estado_Civil1` FOREIGN KEY (`Estado_Civil_idEstado_Civil`) REFERENCES `estado_civil` (`idEstado_Civil`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Paciente_Tipo_Sangre1` FOREIGN KEY (`Tipo_Sangre_idTipo_Sangre`) REFERENCES `tipo_sangre` (`idTipo_Sangre`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente`
--

LOCK TABLES `paciente` WRITE;
/*!40000 ALTER TABLE `paciente` DISABLE KEYS */;
INSERT INTO `paciente` VALUES (1,'Jose','Mendoza','Mendoza',98728723,9938383,'jose@hotmail.com','1992-06-17','Villa Grande #125','A23ESDSADASDAWEEEE',4,3,0,1,NULL,NULL);
/*!40000 ALTER TABLE `paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pregunta`
--

DROP TABLE IF EXISTS `pregunta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pregunta` (
  `idPregunta` int(11) NOT NULL AUTO_INCREMENT,
  `Pregunta` varchar(145) NOT NULL,
  PRIMARY KEY (`idPregunta`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pregunta`
--

LOCK TABLES `pregunta` WRITE;
/*!40000 ALTER TABLE `pregunta` DISABLE KEYS */;
INSERT INTO `pregunta` VALUES (0,'¿Cuál es tu comida favorita?'),(1,'¿Cuál es el nombre de tu mejor amigo de la infancia?'),(2,'¿Cuál es el nombre de tu primera mascota?'),(3,'¿Cuál es ciudad favorita?'),(4,'¿Cuál era tu materia favorita de la primaria?'),(5,'¿Quién es tu persona favorita?');
/*!40000 ALTER TABLE `pregunta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveedor` (
  `idProveedor` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `giro` varchar(45) NOT NULL,
  `Razon_Social` varchar(45) NOT NULL,
  `RFC` varchar(45) NOT NULL,
  `Telefono` int(14) NOT NULL,
  `correo` varchar(45) NOT NULL,
  `direccion` varchar(150) NOT NULL,
  PRIMARY KEY (`idProveedor`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveerdor`
--

DROP TABLE IF EXISTS `proveerdor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveerdor` (
  `idproveerdor` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(145) NOT NULL,
  `Empresa` varchar(145) NOT NULL,
  `Telefono` int(10) NOT NULL,
  `Direccion` varchar(145) NOT NULL,
  PRIMARY KEY (`idproveerdor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveerdor`
--

LOCK TABLES `proveerdor` WRITE;
/*!40000 ALTER TABLE `proveerdor` DISABLE KEYS */;
INSERT INTO `proveerdor` VALUES (1,'Simi','Simi A.C.',11982384,'Ciudad de México calle lopez Mateos');
/*!40000 ALTER TABLE `proveerdor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receta`
--

DROP TABLE IF EXISTS `receta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receta` (
  `idreceta` int(11) NOT NULL AUTO_INCREMENT,
  `Numero de receta` int(11) NOT NULL,
  `Medicamento` int(11) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `Toma del medicamento` varchar(120) NOT NULL,
  `Paciente` int(11) NOT NULL,
  `Doctor` int(11) NOT NULL,
  `Fecha` datetime DEFAULT NULL,
  PRIMARY KEY (`idreceta`),
  KEY `Doctor_idx` (`Doctor`),
  KEY `Receta_paciente_idx` (`Paciente`),
  KEY `Receta_medicamento_idx` (`Medicamento`),
  CONSTRAINT `Receta_doctor` FOREIGN KEY (`Doctor`) REFERENCES `doctores` (`idDoctores`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Receta_medicamento` FOREIGN KEY (`Medicamento`) REFERENCES `farmacia` (`idFarmacia`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Receta_paciente` FOREIGN KEY (`Paciente`) REFERENCES `paciente` (`idPaciente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receta`
--

LOCK TABLES `receta` WRITE;
/*!40000 ALTER TABLE `receta` DISABLE KEYS */;
INSERT INTO `receta` VALUES (1,1,1,2,'cada 8 horas',1,1,NULL);
/*!40000 ALTER TABLE `receta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `sexo`
--

DROP TABLE IF EXISTS `sexo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `sexo` (
  `idSexo` int(11) NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  PRIMARY KEY (`idSexo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `sexo`
--

LOCK TABLES `sexo` WRITE;
/*!40000 ALTER TABLE `sexo` DISABLE KEYS */;
INSERT INTO `sexo` VALUES (1,'Masculino'),(2,'Femenino');
/*!40000 ALTER TABLE `sexo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo de producto`
--

DROP TABLE IF EXISTS `tipo de producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo de producto` (
  `idTipo de producto` int(11) NOT NULL,
  `Descripcion` varchar(25) NOT NULL,
  PRIMARY KEY (`idTipo de producto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo de producto`
--

LOCK TABLES `tipo de producto` WRITE;
/*!40000 ALTER TABLE `tipo de producto` DISABLE KEYS */;
INSERT INTO `tipo de producto` VALUES (0,'Medicamento'),(1,'Objeto medico');
/*!40000 ALTER TABLE `tipo de producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipo_sangre`
--

DROP TABLE IF EXISTS `tipo_sangre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipo_sangre` (
  `idTipo_Sangre` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(45) NOT NULL,
  PRIMARY KEY (`idTipo_Sangre`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipo_sangre`
--

LOCK TABLES `tipo_sangre` WRITE;
/*!40000 ALTER TABLE `tipo_sangre` DISABLE KEYS */;
INSERT INTO `tipo_sangre` VALUES (1,'AB+'),(2,'AB-'),(3,'A+'),(4,'A-'),(5,'B+'),(6,'B-'),(7,'O+'),(8,'O-');
/*!40000 ALTER TABLE `tipo_sangre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trabajador`
--

DROP TABLE IF EXISTS `trabajador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trabajador` (
  `idTrabajador` int(11) NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(100) NOT NULL,
  PRIMARY KEY (`idTrabajador`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trabajador`
--

LOCK TABLES `trabajador` WRITE;
/*!40000 ALTER TABLE `trabajador` DISABLE KEYS */;
INSERT INTO `trabajador` VALUES (1,'Administrador'),(2,'Doctor'),(3,'Farmaceutico'),(4,'Secretaria(o)'),(5,'Jefe mantenimiento'),(6,'Mantenimiento'),(7,'Enfermero(a)');
/*!40000 ALTER TABLE `trabajador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(145) NOT NULL,
  `Contraseña` varchar(145) NOT NULL,
  `Pregunta_idPregunta` int(11) NOT NULL,
  `Respuesta_pregunta` varchar(45) NOT NULL,
  `id_trabajador` int(11) NOT NULL,
  PRIMARY KEY (`idUsuario`,`Pregunta_idPregunta`,`id_trabajador`),
  KEY `fk_Usuario_Pregunta1_idx` (`Pregunta_idPregunta`),
  KEY `fk_Usuario_trabajador_idx` (`id_trabajador`),
  CONSTRAINT `fk_Usuario_Pregunta1` FOREIGN KEY (`Pregunta_idPregunta`) REFERENCES `pregunta` (`idPregunta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Usuario_trabajador` FOREIGN KEY (`id_trabajador`) REFERENCES `trabajador` (`idTrabajador`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,'Ovando','1234',0,'NA',1),(2,'Roberto','1234',5,'Nadie',2);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ventas`
--

DROP TABLE IF EXISTS `ventas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ventas` (
  `idVentas` int(11) NOT NULL AUTO_INCREMENT,
  `numero_recibo` int(11) DEFAULT NULL,
  `Tipo_de_pago` varchar(45) NOT NULL,
  `Cantidad` int(11) NOT NULL,
  `Total` int(11) NOT NULL,
  `Cliente_idCliente` int(11) NOT NULL,
  `Empleado_idEmpleado` int(11) NOT NULL,
  `Productos_idProductos` int(11) NOT NULL,
  `Fecha_Compra` datetime NOT NULL,
  PRIMARY KEY (`idVentas`,`Cliente_idCliente`,`Empleado_idEmpleado`,`Productos_idProductos`),
  KEY `fk_Ventas_Cliente_idx` (`Cliente_idCliente`),
  KEY `fk_Ventas_Empleado1_idx` (`Empleado_idEmpleado`),
  KEY `fk_Ventas_Productos1_idx` (`Productos_idProductos`),
  CONSTRAINT `fk_Ventas_Cliente` FOREIGN KEY (`Cliente_idCliente`) REFERENCES `paciente` (`idPaciente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Ventas_Empleado1` FOREIGN KEY (`Empleado_idEmpleado`) REFERENCES `empleado` (`idEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Ventas_Productos1` FOREIGN KEY (`Productos_idProductos`) REFERENCES `farmacia` (`idFarmacia`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ventas`
--

LOCK TABLES `ventas` WRITE;
/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;
/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-11-05 17:21:07
