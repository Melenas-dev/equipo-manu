-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 17-11-2021 a las 22:29:01
-- Versión del servidor: 5.7.31
-- Versión de PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `warescapesrl`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `compras_y_consignaciones`
--

DROP TABLE IF EXISTS `compras_y_consignaciones`;
CREATE TABLE IF NOT EXISTS `compras_y_consignaciones` (
  `n_de_operacion` bigint(20) NOT NULL,
  `fecha_de_operacion` date DEFAULT NULL,
  `monto` decimal(22,2) DEFAULT NULL,
  `id_ed` int(11) NOT NULL,
  PRIMARY KEY (`n_de_operacion`,`id_ed`),
  KEY `id_ed` (`id_ed`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `compras_y_consignaciones`
--

INSERT INTO `compras_y_consignaciones` (`n_de_operacion`, `fecha_de_operacion`, `monto`, `id_ed`) VALUES
(232, '2021-11-15', NULL, 58),
(2321, '2021-11-14', NULL, 58),
(2323, '2021-11-16', NULL, 60),
(3232, '2021-11-15', NULL, 58),
(23213, '2021-11-15', NULL, 58),
(123211, '2021-11-16', NULL, 59),
(2111111, '2021-11-16', NULL, 63),
(2121212, '2021-11-16', NULL, 59),
(23222222, '2021-11-16', NULL, 60),
(232323232, '2021-11-16', NULL, 63);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devoluciones`
--

DROP TABLE IF EXISTS `devoluciones`;
CREATE TABLE IF NOT EXISTS `devoluciones` (
  `id_libro` int(11) NOT NULL,
  `id_ed` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `cantidad` int(11) NOT NULL,
  `id_devoluciones` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id_devoluciones`,`id_ed`,`id_libro`),
  KEY `devoluciones_FK` (`id_ed`),
  KEY `devoluciones_FK_1` (`id_libro`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `editoriales`
--

DROP TABLE IF EXISTS `editoriales`;
CREATE TABLE IF NOT EXISTS `editoriales` (
  `id_ed` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) DEFAULT NULL,
  `rut` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`id_ed`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `editoriales`
--

INSERT INTO `editoriales` (`id_ed`, `nombre`, `rut`) VALUES
(58, 'America Latina', 1),
(59, 'Oceano', 2),
(60, 'Santillana', 3),
(62, 'Escaramusa', 5),
(63, 'Fin de siglo', 6),
(64, 'Gussi', 231),
(65, 'asdasd ', 123123),
(66, '213123 ', 21312),
(67, 'qweqwe qeqe', 16735073679533625);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `generan`
--

DROP TABLE IF EXISTS `generan`;
CREATE TABLE IF NOT EXISTS `generan` (
  `n_de_boleta` bigint(20) NOT NULL,
  `id_libro` int(11) NOT NULL,
  `cantidad_vendida` int(11) DEFAULT NULL,
  `precio` decimal(22,2) DEFAULT NULL,
  PRIMARY KEY (`n_de_boleta`,`id_libro`),
  KEY `generan_ibfk_2` (`id_libro`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `generos`
--

DROP TABLE IF EXISTS `generos`;
CREATE TABLE IF NOT EXISTS `generos` (
  `id_genero` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_genero`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `generos`
--

INSERT INTO `generos` (`id_genero`, `descripcion`) VALUES
(5, 'Historia'),
(6, 'Historia nacional'),
(7, 'Novela'),
(13, 'Accion');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `lcc`
--

DROP TABLE IF EXISTS `lcc`;
CREATE TABLE IF NOT EXISTS `lcc` (
  `n_de_operacion` bigint(20) NOT NULL,
  `id_libro` int(11) NOT NULL,
  `cantidad_consignada` int(11) DEFAULT NULL,
  `cantidad_comprada` int(11) DEFAULT NULL,
  `precio_comprado` decimal(22,2) DEFAULT NULL,
  `precio_consignado` decimal(22,2) DEFAULT NULL,
  PRIMARY KEY (`n_de_operacion`,`id_libro`),
  KEY `lcc_ibfk_1` (`id_libro`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `libros`
--

DROP TABLE IF EXISTS `libros`;
CREATE TABLE IF NOT EXISTS `libros` (
  `id_libro` int(11) NOT NULL AUTO_INCREMENT,
  `isbn` bigint(20) DEFAULT NULL,
  `codigo` bigint(20) DEFAULT NULL,
  `precio` decimal(22,2) DEFAULT NULL,
  `stock` int(11) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  `autor` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`id_libro`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `libros`
--

INSERT INTO `libros` (`id_libro`, `isbn`, `codigo`, `precio`, `stock`, `nombre`, `autor`) VALUES
(7, 23131, 23232323, '32323.00', 2323, '2323', '2323'),
(8, 2213, 2313, '12131.00', 231, 'Mnuael', 'Piter');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `publicidad`
--

DROP TABLE IF EXISTS `publicidad`;
CREATE TABLE IF NOT EXISTS `publicidad` (
  `id_publicidad` int(11) NOT NULL AUTO_INCREMENT,
  `monto` decimal(22,2) DEFAULT NULL,
  `rut` bigint(20) DEFAULT NULL,
  `nombre` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_publicidad`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `publicidad`
--

INSERT INTO `publicidad` (`id_publicidad`, `monto`, `rut`, `nombre`) VALUES
(5, '200.00', 123, '1313');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `se_registran`
--

DROP TABLE IF EXISTS `se_registran`;
CREATE TABLE IF NOT EXISTS `se_registran` (
  `id_publicidad` int(11) NOT NULL,
  `n_de_boleta` bigint(20) NOT NULL,
  PRIMARY KEY (`id_publicidad`,`n_de_boleta`),
  KEY `se_registran_ibfk_2` (`n_de_boleta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `se_registran`
--

INSERT INTO `se_registran` (`id_publicidad`, `n_de_boleta`) VALUES
(5, 232),
(5, 23232),
(5, 123123);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tienen`
--

DROP TABLE IF EXISTS `tienen`;
CREATE TABLE IF NOT EXISTS `tienen` (
  `id_libro` int(11) NOT NULL,
  `id_genero` int(11) NOT NULL,
  PRIMARY KEY (`id_libro`,`id_genero`),
  KEY `id_genero` (`id_genero`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `usuario` varchar(50) DEFAULT NULL,
  `contrasena` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`usuario`, `contrasena`) VALUES
('admin', '9cf627fc399bd5a314e3c483553ef22af498e806'),
('Gerente', 'f10e2821bbbea527ea02200352313bc059445190'),
('Empleado', '8cb2237d0679ca88db6464eac60da96345513964');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

DROP TABLE IF EXISTS `ventas`;
CREATE TABLE IF NOT EXISTS `ventas` (
  `n_de_boleta` bigint(20) NOT NULL,
  `fecha_de_venta` date DEFAULT NULL,
  `monto` decimal(22,2) DEFAULT NULL,
  PRIMARY KEY (`n_de_boleta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`n_de_boleta`, `fecha_de_venta`, `monto`) VALUES
(122, '2021-11-14', '123.00'),
(232, '2021-11-15', '230.00'),
(3333, '2021-11-16', '4666.00'),
(21211, '2021-11-15', '1212.00'),
(23232, '2021-11-15', '232.00'),
(123123, '2021-11-16', '6003.00'),
(12312311, '2021-11-14', '2131.00');

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `compras_y_consignaciones`
--
ALTER TABLE `compras_y_consignaciones`
  ADD CONSTRAINT `compras_y_consignaciones_ibfk_1` FOREIGN KEY (`id_ed`) REFERENCES `editoriales` (`id_ed`);

--
-- Filtros para la tabla `devoluciones`
--
ALTER TABLE `devoluciones`
  ADD CONSTRAINT `devoluciones_FK` FOREIGN KEY (`id_ed`) REFERENCES `editoriales` (`id_ed`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `devoluciones_FK_1` FOREIGN KEY (`id_libro`) REFERENCES `libros` (`id_libro`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `generan`
--
ALTER TABLE `generan`
  ADD CONSTRAINT `generan_ibfk_1` FOREIGN KEY (`n_de_boleta`) REFERENCES `ventas` (`n_de_boleta`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `generan_ibfk_2` FOREIGN KEY (`id_libro`) REFERENCES `libros` (`id_libro`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `lcc`
--
ALTER TABLE `lcc`
  ADD CONSTRAINT `lcc_ibfk_1` FOREIGN KEY (`id_libro`) REFERENCES `libros` (`id_libro`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `lcc_ibfk_2` FOREIGN KEY (`n_de_operacion`) REFERENCES `compras_y_consignaciones` (`n_de_operacion`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `se_registran`
--
ALTER TABLE `se_registran`
  ADD CONSTRAINT `se_registran_ibfk_1` FOREIGN KEY (`id_publicidad`) REFERENCES `publicidad` (`id_publicidad`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `se_registran_ibfk_2` FOREIGN KEY (`n_de_boleta`) REFERENCES `ventas` (`n_de_boleta`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Filtros para la tabla `tienen`
--
ALTER TABLE `tienen`
  ADD CONSTRAINT `tienen_ibfk_1` FOREIGN KEY (`id_libro`) REFERENCES `libros` (`id_libro`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tienen_ibfk_2` FOREIGN KEY (`id_genero`) REFERENCES `generos` (`id_genero`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
