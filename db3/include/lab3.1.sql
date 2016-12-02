-- phpMyAdmin SQL Dump
-- version 3.5.7
-- http://www.phpmyadmin.net
--
-- Хост: localhost
-- Время создания: Окт 15 2014 г., 15:05
-- Версия сервера: 5.6.15
-- Версия PHP: 5.3.28

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `lab3`
--

-- --------------------------------------------------------

--
-- Структура таблицы `pharmacy`
--

DROP TABLE IF EXISTS `pharmacy`;
CREATE TABLE IF NOT EXISTS `pharmacy` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `ph_name` varchar(255) NOT NULL,
  `address`  varchar(255) NOT NULL,
  `phone` varchar(255) NOT NULL,
  `manager_name` varchar(255) NOT NULL,
  `open_year` int(4) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Дамп данных таблицы `pharmacy`
--

INSERT INTO `pharmacy` (`ph_name`, `address`, `phone`, `manager_name`, `open_year`) VALUES
('Фарма', 'Советская, 102', '28-34-85', 'Иванов', 1985),
('Бережная', 'Первомайская, 16', '38-56-99', 'Сидоров', 1988),
('Авиценна', 'Ленина, 18', '30-27-58', 'Петров', 2001),
('Айболит', 'Баумана, 78', '94-23-45', 'Москвин', 2008),
('Аптека №1', 'Мира, 4', '72-49-18', 'Казаков', 1989),
('Аптека №2', 'Первомайская, 123', '30-56-29', 'Комаров', 1990),
('Аптека №3', 'Дружбы, 56', '05-78-23', 'Ефимов',2012),
('Аптека №4', 'Петрова, 52', '37-56-29', 'Алешин', 2005),
('Аптека №5', 'Первомайская, 89', '49-25-56', 'Федоров', 1975),
('Аптека №6', 'Ленина, 17', '90-99-39', 'Андреев', 2004);

-- --------------------------------------------------------

--
-- Структура таблицы `medicament`
--

DROP TABLE IF EXISTS `medicament`;
CREATE TABLE IF NOT EXISTS `medicament` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `med_name` varchar(255) NOT NULL,
  `med_type` ENUM ('tablet','ampula', 'maz', 'miksture') NOT NULL DEFAULT 'tablet',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Дамп данных таблицы `medicament`
--

INSERT INTO `medicament` (`med_name`, `med_type`) VALUES
('Аспирин', 'tablet'),
('Валидол', 'tablet'),
('Анти-ангин', 'ampula'),
('Панадол', 'miksture'),
('Преднизолон', 'tablet'),
('Клофелин', 'miksture'),
('Виагра', 'tablet'),
('Мазь Вишневского', 'maz'),
('Преднизолон', 'maz'),
('Анти-ангин', 'tablet');

-- --------------------------------------------------------

--
-- Структура таблицы `delivery`
--

DROP TABLE IF EXISTS `delivery`;
CREATE TABLE IF NOT EXISTS `delivery` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `delivery_date` date NOT NULL,
  `pharmacy_id` int(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Дамп данных таблицы `delivery`
--

INSERT INTO `delivery` (`delivery_date`, `pharmacy_id` ) VALUES
('2014-09-05', 1),
('2014-09-06', 2),
('2014-09-07', 5),
('2014-09-08', 4),
('2014-09-12', 3),
('2014-09-13', 9),
('2014-09-14', 7),
('2014-09-23', 6),
('2014-10-12', 8),
('2014-10-13', 10),
('2014-10-16', 1),
('2014-10-16', 2),
('2014-10-17', 3),
('2014-10-18', 4);



--
-- Структура таблицы `med_delivery`
--

DROP TABLE IF EXISTS `med_delivery`;
CREATE TABLE IF NOT EXISTS `med_delivery` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `delivery_id` int(10), 
  `medicament_id` int(10) NOT NULL,
  `delivery_size` int(10) NOT NULL,
  `price` int(10) NOT NULL,
  `exp` date NOT NULL,
  `remaind` int(10) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

--
-- Дамп данных таблицы `med_delivery`
--

INSERT INTO `med_delivery` (`delivery_id`, `medicament_id`, `delivery_size`, `price`, `exp`, `remaind`) VALUES
(1, 1, 40, 100, '2014-10-20', 23),
(1, 2, 50, 150, '2015-12-10', 34),
(1, 3, 70, 300, '2015-05-18', 15),
(2, 6, 100, 600, '2014-10-10', 23),
(2, 3, 17, 300, '2014-06-05', 4),
(3, 2, 45, 160, '2016-10-11', 18),
(3, 7, 67, 1000, '2016-01-25', 23),
(4, 8, 24, 40, '2015-11-20', 1),
(4, 1, 78, 110, '2014-10-20', 22),
(4, 5, 34, 550, '2014-10-20', 20),
(5, 3, 78, 310, '2014-10-23', 25),
(5, 7, 23, 1100, '2014-10-20', 12),
(6, 5, 22, 560, '2015-09-14', 2),
(6, 7, 33, 1100, '2016-11-09', 23),
(6, 8, 33, 45, '2013-10-11', 13),
(7, 2, 67, 160, '2012-09-10', 43),
(7, 4, 78, 410, '2012-06-17', 36),
(8, 5, 22, 570, '2013-03-11', 20),
(9, 9, 44, 570, '2018-04-20', 23),
(9, 7, 56, 1100, '2012-06-12', 33),
(9, 1, 76, 100, '2014-10-05', 27),
(10, 3, 27, 320, '2015-04-17', 7),
(10, 4, 33, 420, '2011-09-13', 12),
(10, 5, 67, 560, '2014-10-20', 23),
(10, 8, 34, 47, '2015-11-04', 12),
(10, 10, 58, 620, '2016-01-21', 55),
(11, 4, 20, 420, '2015-02-24', 7),
(11, 5, 46, 570, '2016-10-23', 33),
(11, 6, 45, 610, '2012-08-14', 43),
(11, 7, 23, 1200, '2011-07-26', 3),
(12, 8, 67, 50, '2012-06-16', 24),
(12, 2, 19, 170, '2011-05-05', 10),
(12, 3, 28, 320, '2016-05-16', 18),
(12, 9, 27, 580, '2014-05-30', 16),
(13, 3, 28, 320, '2015-12-11', 16),
(13, 4, 28, 450, '2014-10-20', 19),
(13, 5, 38, 570, '2014-12-23', 10),
(14, 1, 56, 120, '2011-05-14', 23),
(14, 10, 10, 170, '2014-10-20', 2),
(14, 3, 13, 330, '2015-12-01', 7),
(14, 4, 44, 450, '2016-07-18', 11);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
