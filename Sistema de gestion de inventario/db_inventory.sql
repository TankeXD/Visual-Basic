-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 29-11-2023 a las 01:39:55
-- Versión del servidor: 8.0.31
-- Versión de PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `db_inventory`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblautonumber`
--

DROP TABLE IF EXISTS `tblautonumber`;
CREATE TABLE IF NOT EXISTS `tblautonumber` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `STRT` varchar(30) NOT NULL,
  `END` varchar(30) NOT NULL,
  `INCREMENT` int NOT NULL,
  `DESCRIPTION` varchar(30) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tblautonumber`
--

INSERT INTO `tblautonumber` (`ID`, `STRT`, `END`, `INCREMENT`, `DESCRIPTION`) VALUES
(1, '00001', '15', 1, 'Customer'),
(5, '102201', '26', 1, 'StockOut'),
(6, '53132', '28', 1, 'StockReturn'),
(7, '0000', '5', 1, 'itemid'),
(28, 'Mad-000', '8', 1, 'Maderas'),
(29, 'Bro-000', '1', 1, 'Brochas'),
(30, 'Mad-000', '1', 1, 'Madera'),
(31, 'Pin-000', '1', 1, 'Pinturas'),
(32, 'Are-000', '1', 1, 'Arena'),
(33, 'Blo-000', '1', 1, 'Bloques'),
(34, 'Cal-000', '1', 1, 'Cal'),
(35, 'Yes-000', '1', 1, 'Yeso');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblitems`
--

DROP TABLE IF EXISTS `tblitems`;
CREATE TABLE IF NOT EXISTS `tblitems` (
  `ITEMID` varchar(30) NOT NULL,
  `Marca` varchar(50) DEFAULT NULL,
  `Descripcion` varchar(90) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `Categoria` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `Precio` double NOT NULL,
  `Cantidad` int NOT NULL,
  `Unidad` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  PRIMARY KEY (`ITEMID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tblitems`
--

INSERT INTO `tblitems` (`ITEMID`, `Marca`, `Descripcion`, `Categoria`, `Precio`, `Cantidad`, `Unidad`) VALUES
('Mad-0007', 'Cerecita', 'Vigas de Madera', 'Maderas', 2, 21, 'Metros');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblperson`
--

DROP TABLE IF EXISTS `tblperson`;
CREATE TABLE IF NOT EXISTS `tblperson` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ClienteID` varchar(90) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `Nombre` varchar(90) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `Apellido` varchar(90) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `Direccion` varchar(90) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `Telefono` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `Celular` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci DEFAULT NULL,
  `Tipo` varchar(90) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `CUSID` (`ClienteID`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tblperson`
--

INSERT INTO `tblperson` (`ID`, `ClienteID`, `Nombre`, `Apellido`, `Direccion`, `Telefono`, `Celular`, `Tipo`) VALUES
(14, '0000114', 'Daniel', 'Gonzalez', 'psje pedro aguirrez guerra', '223254454', '7834342', 'Cliente');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblsettings`
--

DROP TABLE IF EXISTS `tblsettings`;
CREATE TABLE IF NOT EXISTS `tblsettings` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `DESCRIPTION` text NOT NULL,
  `PARA` varchar(30) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tblsettings`
--

INSERT INTO `tblsettings` (`ID`, `DESCRIPTION`, `PARA`) VALUES
(24, 'Brochas', 'Categoria'),
(25, 'Madera', 'Categoria'),
(26, 'Kilogramos', 'Unidad'),
(28, 'Bloque', 'Unidad'),
(29, 'Metros', 'Unidad'),
(30, 'Docena', 'Unidad'),
(31, 'Cajas', 'Unidad'),
(32, 'Pinturas', 'Categoria'),
(33, 'Arena', 'Categoria'),
(34, 'Bloques', 'Categoria'),
(35, 'Cal', 'Categoria'),
(36, 'Yeso', 'Categoria');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblstock_in_out`
--

DROP TABLE IF EXISTS `tblstock_in_out`;
CREATE TABLE IF NOT EXISTS `tblstock_in_out` (
  `STOCKOUTID` int NOT NULL AUTO_INCREMENT,
  `TRANSACTIONNUMBER` varchar(30) NOT NULL,
  `ITEMID` varchar(30) NOT NULL,
  `TRANSACTIONDATE` date NOT NULL,
  `Cantidad` int NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `ClienteID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  `REMARKS` varchar(30) NOT NULL,
  PRIMARY KEY (`STOCKOUTID`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tblstock_in_out`
--

INSERT INTO `tblstock_in_out` (`STOCKOUTID`, `TRANSACTIONNUMBER`, `ITEMID`, `TRANSACTIONDATE`, `Cantidad`, `TOTALPRICE`, `ClienteID`, `REMARKS`) VALUES
(74, '', 'Mad-0006', '2023-11-28', 222, 2244, '', 'StockIn'),
(75, '', 'Mad-0007', '2023-11-28', 22, 2, '', 'StockIn'),
(76, '10220125', 'Mad-0007', '2023-11-28', 1, 2, '0000114', 'StockOut');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tblstock_return`
--

DROP TABLE IF EXISTS `tblstock_return`;
CREATE TABLE IF NOT EXISTS `tblstock_return` (
  `STOCKRETURNID` int NOT NULL AUTO_INCREMENT,
  `STOCKRETURNNUMBER` varchar(30) NOT NULL,
  `ITEMID` varchar(30) NOT NULL,
  `RETURNDATE` date NOT NULL,
  `QTY` int NOT NULL,
  `TOTALPRICE` double NOT NULL,
  `OWNER_CUS_ID` int NOT NULL,
  PRIMARY KEY (`STOCKRETURNID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tblstock_return`
--

INSERT INTO `tblstock_return` (`STOCKRETURNID`, `STOCKRETURNNUMBER`, `ITEMID`, `RETURNDATE`, `QTY`, `TOTALPRICE`, `OWNER_CUS_ID`) VALUES
(11, '5313227', 'A000010', '2023-11-20', 0, 0, 11);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tbltransaction`
--

DROP TABLE IF EXISTS `tbltransaction`;
CREATE TABLE IF NOT EXISTS `tbltransaction` (
  `STOCKINID` int NOT NULL AUTO_INCREMENT,
  `TRANSACTIONNUMBER` varchar(30) DEFAULT NULL,
  `TRANSACTIONDATE` date NOT NULL,
  `TYPE` varchar(30) NOT NULL,
  `ClienteID` varchar(30) CHARACTER SET latin1 COLLATE latin1_swedish_ci NOT NULL,
  PRIMARY KEY (`STOCKINID`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `tbltransaction`
--

INSERT INTO `tbltransaction` (`STOCKINID`, `TRANSACTIONNUMBER`, `TRANSACTIONDATE`, `TYPE`, `ClienteID`) VALUES
(41, '10220125', '2023-11-28', 'Vendido', '0000114');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `user_id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(90) DEFAULT NULL,
  `user_name` varchar(90) DEFAULT NULL,
  `pass` varchar(90) DEFAULT NULL,
  `type` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=MyISAM AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `user`
--

INSERT INTO `user` (`user_id`, `name`, `user_name`, `pass`, `type`) VALUES
(6, 'aylin', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrador'),
(5, 'daniel', 'admin', 'd033e22ae348aeb5660fc2140aec35850c4da997', 'Administrador');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
