-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Oct 09, 2017 at 09:53 AM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.5.37

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vts_biblioteka`
--

-- --------------------------------------------------------

--
-- Table structure for table `autori`
--

CREATE TABLE `autori` (
  `ID` int(11) NOT NULL,
  `Sifra` varchar(10) DEFAULT NULL,
  `ImePrezime` varchar(50) DEFAULT NULL,
  `Zemlja` varchar(20) NOT NULL,
  `Godina` varchar(10) NOT NULL,
  `Napomena` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `autori`
--

INSERT INTO `autori` (`ID`, `Sifra`, `ImePrezime`, `Zemlja`, `Godina`, `Napomena`) VALUES
(1, '1', 'Ostali', '', '', ''),
(2, '3', 'Simona Hill', '', '', ''),
(3, '4', 'Hlebec Boris', '', '', ''),
(4, '5', 'Grozdanić, K. Dušan', '', '', ''),
(5, '6', 'Mihailović Dobrivoje', 'Srbija', '1950', ''),
(6, '7', 'Ristić Slobodan', 'Srbija', '1958', ''),
(7, '8', 'Šuvaković Miško', 'Srbija', '1954', ''),
(8, '9', 'Arnason, H.H.', '', '', ''),
(9, '10', 'Arsenijević Stanimir', '', '', ''),
(10, '11', 'Schell Jeff', '', '', ''),
(11, '12', 'Makar Jobe', '', '', ''),
(12, '13', 'Patterson Danny', '', '', ''),
(13, '14', 'Žarković Radmila', 'Srbija', '', ''),
(14, '15', 'Pavlović Slađana', 'Srbija', '', 'Diplomski rad'),
(15, '16', 'Tušar Božena', '', '', ''),
(16, '17', 'Ljubisavljević Dejan', '', '', ''),
(17, '18', 'Burrough B.P.,  McDonnell R.A.', '', '', ''),
(18, '19', 'Nikolić Vesna', 'Crna Gora', '1965', ''),
(19, '20', 'Radaković Miloš', '', '', ''),
(20, '21', 'Todorović Marko', '', '', ''),
(21, '22', 'Todorović Tamara', '', '', ''),
(22, '23', 'Čvorović Zoran V.', '', '', ''),
(23, '24', 'Gavrilovski Dragica', '', '', ''),
(24, '25', 'Stević Zoran', '', '', ''),
(25, '26', 'Janson Horst Voldemar', '', '', ''),
(26, '27', 'Feher Gyorgi', '', '', ''),
(27, '28', 'Szunyoghy Andras', '', '', ''),
(28, '29', 'Simić Dušan', '', '', ''),
(29, '30', 'Vujaklija Milan', '', '', ''),
(30, '31', 'Miller Judith', '', '', ''),
(31, '32', 'Fiell Charlotte and Peter', '', '', 'Prevod na srpski Jelena Petrović'),
(32, '33', 'Sandon John', '', '', ''),
(33, '34', 'Jevtić Milan', '', '', ''),
(34, '35', 'Dragonjić Velizar', '', '', ''),
(35, '36', 'Stevanović Radmila', '', '', ''),
(36, '37', 'Marković Radisav', '', '', ''),
(37, '38', 'Filipović Jovan', '', '', ''),
(38, '39', 'Luković Anka', 'Srbija', '1946', ''),
(39, '40', 'Stamenković Marica', '', '', ''),
(40, '41', 'Mihailović Đoeđe', 'Srbija', '1981', ''),
(41, '42', 'Petrović Nataša', '', '', ''),
(42, '43', 'Popić Relja', '', '', ''),
(43, '44', 'Simić Miroljub', '', '', ''),
(44, '45', 'Fajfer Brus Bruks', '', '', ''),
(45, '46', 'Koen Žan Luj', '', '', ''),
(46, '47', 'Ger Andžela', '', '', ''),
(47, '48', 'Nikolić Dragan', '', '', ''),
(48, '49', 'Marija Tecilazić-Stevanović', '', '', ''),
(49, '50', 'Belobrković Stanoje', '', '', ''),
(50, '51', 'Dalmacija Božo', '', '', ''),
(51, '52', 'Krstić-Vulićević Ljiljana', '', '', ''),
(52, '54', 'Vulović Radisav', '', '', ''),
(53, '55', 'Abramov N. N.', '', '', ''),
(54, '56', 'Nikolić Olivera', '', '', ''),
(55, '57', 'Ost-Rasov', '', '', ''),
(56, '58', 'Maksimović Rade', '', '', ''),
(57, '59', 'Tolić Milanka', '', '', ''),
(58, '60', 'Nikolić Dragan', '', '', ''),
(59, '61', 'Ignatovski Jovan', '', '', ''),
(60, '62', 'Đokić Radiša', '', '', ''),
(61, '63', 'Pantelić Rade', '', '', ''),
(62, '64', 'Milovanović Draga', '', '', ''),
(63, '65', 'Laškai Judit', '', '', ''),
(64, '66', 'Pavlović Božidar', '', '', ''),
(65, '67', 'Antonić Žarko', '', '', 'Diplomirao 1980.'),
(66, '68', 'Komadina Milena', '', '', 'Diplomirala 1980.'),
(67, '69', 'Mijatović Miroslav', '', '', 'Diplomirao 1980.'),
(68, '70', 'Milićević Branko', '', '', 'Diplomirao 1980.'),
(69, '71', 'Milanović Radiša', '', '', 'Diplomirao 1980.'),
(70, '72', 'Simić Gordana', '', '', 'Diplomirala 1980.'),
(71, '73', 'Vitorović Olga', '', '', 'Diplomirala 1980.'),
(72, '74', 'Prodanović Dragoljub', '', '', 'Diplomirao 1980.'),
(73, '75', 'Mihajlović-Popović Milka', '', '', 'Diplomirala 1981.'),
(74, '76', 'Obrenović Milivoje', '', '', 'Diplomirao 1981.'),
(75, '77', 'Ilić Violeta', '', '', 'Diplomirala 1981.'),
(76, '78', 'Netkovski Zoran', '', '', 'Diplomirao 1981.'),
(77, '79', 'Jevtović Zoran', '', '', 'Diplomirao 1981.'),
(78, '80', 'Zdjelar Brankica', '', '', 'Diplomirala 1981.'),
(79, '81', 'Trajkov Slavčo', '', '', 'Diplomirao 1981.'),
(80, '82', 'Nikolić Milija', '', '', 'Diplomirao 1981.'),
(81, '83', 'Kamberović Miodrag', '', '', 'Diplomirao 1981.'),
(82, '84', 'Vitorović Milan', '', '', 'Diplomirao 1981.'),
(83, '85', 'Arsić Draža', '', '', 'Diplomirao 1981.'),
(84, '86', 'Arsenijević Slobodanka', '', '', 'Diplomirala 1981.'),
(85, '87', 'Milošević Ranko', '', '', 'Diplomirao 1981.'),
(86, '88', 'Stojanovski Trajče', '', '', 'Diplomirao 1981.'),
(87, '89', 'Savić Dragan', '', '', 'Diplomirao 1982.'),
(88, '90', 'Hrnić Besim', '', '', 'Diplomirao 1982.'),
(89, '91', 'Kečan Borislav', '', '', 'Diplomirao 1982.'),
(90, '92', 'Delkić Asmira', '', '', 'Diplomirala 1982.'),
(91, '93', 'Jordanovski Jovan', '', '', 'Diplomirao 1982.'),
(92, '94', 'Stojiljković Sreten', '', '', 'Diplomirao 1982.'),
(93, '95', 'Milićević Milena', '', '', 'Diplomirala 1982.'),
(94, '96', 'Zalloum-Abdel Rahman', '', '', 'Diplomirao 1982.'),
(95, '97', 'Perović Miloš', '', '', 'Diplomirao 1983.'),
(96, '98', 'Atanasovski Slave', '', '', 'Diplomirao 1983.'),
(97, '99', 'Tucović Dragica', '', '', 'Diplomirala 1983.'),
(98, '100', 'Sečei Šandor', '', '', 'Diplomirao 1983.'),
(99, '101', 'Vasiljević Milenko', '', '', 'Diplomirao 1983.'),
(100, '102', 'Avramović Goran', '', '', 'Diplomirao 1983.'),
(101, '103', 'Rudić Ružica', '', '', 'Diplomirala 1982.'),
(102, '104', 'Danilović Milan', '', '', 'Diplomirao 1982.'),
(103, '105', 'Dimitrijević Panta', '', '', 'Diplomirao 1982.'),
(104, '106', 'Zarbool Hasan', '', '', 'Diplomirao 1982.'),
(105, '107', 'Vujanović Dragan', '', '', 'Diplomirao 1982.'),
(106, '108', 'Crnomarković Ilija', '', '', 'Diplomirao 1982.'),
(107, '109', 'Vesić Radmila', '', '', 'Diplomirala 1982.'),
(108, '110', 'Masoud Zaki "Mohamed Jalal"', '', '', 'Diplomirao 1987.'),
(109, '111', 'Perić Velibor', '', '', 'Diplomirao 1982.'),
(110, '112', 'Aleksić Dragiša', '', '', 'Diplomirao 1982.'),
(111, '113', 'Lazarević Milena', '', '', 'Diplomirala 1982.'),
(112, '114', 'Vitorović Dragomir', '', '', ''),
(113, '115', 'Mitolinski Ivica', '', '', 'Diplomirao 1982.'),
(114, '116', 'Nikolić Obrad', '', '', 'Diplomirao 1982.'),
(115, '117', 'Raketić Svetlana', '', '', 'Diplomirala 1982.'),
(116, '118', 'Radosavljević Vesna', '', '', 'Diplomirala 1983.'),
(117, '119', 'Stojković Stanojlo', '', '', 'Diplomirao 1983.'),
(118, '120', 'Šutić Dragiša', '', '', 'Diplomirao 1983.'),
(119, '121', 'Kelović Nadežda', '', '', 'Diplomirala 1983.'),
(120, '122', 'Milivojević Radmila', '', '', 'Diplomirala 1983.'),
(121, '123', 'Brkić Miodrag', '', '', 'Diplomirao 1983.'),
(122, '124', 'Kostadinović Branko', '', '', 'Diplomirao 1983.'),
(123, '125', 'Lukičić Momčilo', '', '', 'Diplomirao 1983.'),
(124, '126', 'Đorđević Vladica', '', '', 'Diplomirao 1983.'),
(125, '127', 'Nokić Muhamed', '', '', 'Diplomirao 1983.'),
(126, '128', 'Despotović Biljana', '', '', 'Diplomirao 1982.'),
(127, '129', 'Sejdić Hankija', '', '', 'Diplomir. 1983.'),
(128, '130', 'Stojanović Ljubinka', '', '', 'Diplomirala 1984.'),
(129, '131', 'Ilić Slavko', '', '', 'Diplomirao 1984.'),
(130, '132', 'Sokolović Borislav', '', '', 'Diplomirao 1983.'),
(131, '133', 'Lučić Rajko', '', '', 'Diplomirao 1984.'),
(132, '134', 'Marković Radulka', '', '', 'Diplomirala 1984.'),
(133, '135', 'Ibrišbegović Muris', '', '', 'Diplomirao 1984.'),
(134, '136', 'Bijelić Nebojša', '', '', 'Diplomirao 1984.'),
(135, '137', 'Pantelić Mira', '', '', 'Diplomirala 1984.'),
(136, '138', 'Matićević Zoran', '', '', 'Diplomirao 1985.'),
(137, '139', 'Simić Radovan', '', '', 'Diplomirao 1985.'),
(138, '140', 'Đorđević Petar', '', '', 'Diplomirao 1985.'),
(139, '141', 'Savić Mihailo', '', '', 'Diplomirao 1985.'),
(140, '142', 'Mikelić V. Miloje', '', '', 'Diplomirao 1985.'),
(141, '143', 'Pantelić Dragan', '', '', 'Diplomirao 1985.'),
(142, '144', 'Antonijević Danica', '', '', 'Diplomirala 1985.'),
(143, '145', 'Samardžić Gorica', '', '', 'Diplomirala 1985.'),
(144, '146', 'Mitić Dragan', '', '', 'Diplomirao 1985.'),
(145, '147', 'Stefanović Života', '', '', 'Diplomirao 1985.'),
(146, '148', 'Vujičić-Vuković Slavica', '', '', 'Diplomirala 1985.'),
(147, '149', 'Najman Petar', '', '', 'Diplomirao 1985.'),
(148, '150', 'Milivojević Milomir', '', '', 'Diplomirao 1985.'),
(149, '151', 'Habraken Joe', '', '', ''),
(150, '152', 'Stavrić Božidar', '', '', ''),
(151, '153', 'Nerandžić Radovanka', '', '', 'Diplomirala 1985.'),
(152, '154', 'Stepić Slobodan', '', '', 'Diplomirao 1985.'),
(153, '155', 'Milisavljević Momčilo', '', '', ''),
(154, '156', 'Vujić Milojko', '', '', ''),
(155, '157', 'Kojičić Miodrag', '', '', 'Diplomirao 1985.'),
(156, '158', 'Njekrasov B.V.', '', '', ''),
(157, '159', 'Poleti Dejan', '', '', ''),
(158, '160', 'Remi Breton', '', '', ''),
(159, '161', 'Cvetković Dragan', '', '', ''),
(160, '162', 'Eter M. Dolores', '', '', ''),
(161, '163', 'Kernigan V. Brajan', '', '', ''),
(162, '164', 'Tondo L. Klovis', '', '', ''),
(163, '165', 'Cvetković Dragoš', '', '', ''),
(164, '166', 'Rut Endi', '', '', ''),
(165, '167', 'Jarvud Alf', '', '', ''),
(166, '168', 'Mogin Pavle', '', '', ''),
(167, '169', 'Ivanović Milovan', '', '', 'Diplomirao 1983.'),
(168, '170', 'Madžarević Zoran', '', '', 'Diplomirao 1985.'),
(169, '171', 'Raković Radoslav', '', '', 'Diplomirao 1985.'),
(170, '172', 'Savić Boris', '', '', 'Diplomirao 1985.'),
(171, '173', 'Dakić Vesna', '', '', 'Diplomirala 1989.'),
(172, '174', 'Damnjanović Gordana', '', '', 'Diplomirala 1990.'),
(173, '175', 'Voko Aleksandar', '', '', 'Diplomirao 1989.'),
(174, '176', 'Delić Stojan', '', '', 'Diplomirao 1989.'),
(175, '177', 'Drljača Saša', '', '', 'Diplomirao 1989.'),
(176, '178', 'Pantić Slađan', '', '', 'Diplomirao 1991.'),
(177, '179', 'Rakonjac Tatjana', '', '', 'Diplomirala 1991.'),
(178, '180', 'Mantel, C.L.', '', '', ''),
(179, '181', 'Mladenović Sreten', '', '', ''),
(182, '182', 'Stavrić Božidar', '', '', ''),
(183, '183', 'Đukin Zorka', '', '', ''),
(184, '184', 'Jovanović M. Prvoslav', 'Srbija', '', ''),
(185, '185', 'Rašić R. Tihomir', '', '', ''),
(186, '186', 'Nikola Počuča', 'Jugoslavija', '1946', ''),
(187, '187', 'Radojičić Miroslav', 'Srbija', '1952', 'Tehnički fakultet, Čačak'),
(188, '188', 'Đurđević Vlada', 'Srbija', '', ''),
(189, '189', 'Petrović Radmilo', '', '', 'Akademik'),
(190, '190', 'Helen Gardner', '', '', ''),
(191, '191', 'Majher Vesna', '', '', ''),
(192, '192', 'Read Herbert', '', '', ''),
(193, '193', 'Estevez Alberto', '', '', ''),
(194, '194', 'Blažić D. Rajko', '', '', ''),
(195, '195', 'Bazen Žermen', '', '', ''),
(196, '196', 'Nardini Bruno', '', '', ''),
(197, '197', 'Breton Andre', '', '', ''),
(198, '198', 'Flint Tom', '', '', ''),
(199, '199', 'Pešikan Mitar', '', '', ''),
(200, '200', 'Strauss L. Walter', '', '', ''),
(201, '201', 'Lefteri Chris', '', '', ''),
(202, '202', 'Brofi Piter', '', '', ''),
(203, '203', 'Berns Dž. Vilijam', '', '', ''),
(204, '204', 'Flečer Kit', '', '', ''),
(205, '205', 'Kolber Fransoa', '', '', ''),
(206, '206', 'Kojn Silija', 'Slovenija', '', ''),
(207, '207', 'Lazarević P. Mihailo', '', '', ''),
(209, '209', 'Fiamengo Ante', '', '', ''),
(210, '210', 'Arsovski Zora', '', '', ''),
(211, '211', 'Đurović Igor', '', '', ''),
(212, '212', 'Radović Vladeta', '', '', ''),
(213, '213', 'Arsovski Slavko', '', '', ''),
(214, '214', 'Lazić Miodrag', '', '', ''),
(215, '215', 'Izvonar Dušan', '', '', 'Profesor'),
(216, '216', 'Aspen Boris', '', '', ''),
(217, '217', 'Simić Milorad', '', '', ''),
(218, '218', 'Veljović Alempije', '', '', 'Profesor, Čačak'),
(219, '219', 'Bogetić Branislava', '', '', 'Profesorka'),
(220, '220', 'Laban Miloš', '', '', 'Profesor ETF Beograd'),
(221, '221', 'Sebastijan Linc Zvonimir', '', '', 'Profesot VTŠSS Aranđelovac'),
(222, '222', 'Marković Ž. Danilo', '', '', 'Profesor beogradskog univerziteta'),
(223, '223', 'Isaković Svetlana', '', '', ''),
(224, '224', 'Janjić Tomislav', '', '', ''),
(225, '225', 'Njegovan V.N.', '', '', ''),
(226, '226', 'Stojanović I. Nikola', '', '', ''),
(227, '227', 'Anđelković Branislav', '', '', 'Fakultet zaštite na radu, Niš'),
(228, '228', 'Vukotić Biljana', '', '1952', ''),
(229, '229', 'Dragićević M. Ljubinko', '', '', ''),
(230, '230', 'Steve Schwartz', '', '', ''),
(231, '231', 'Popović Mihailo', '', '', ''),
(232, '232', 'Unković Slobodan', '', '', 'Profesor'),
(233, '233', 'Savić Ivo', '', '', ''),
(234, '234', 'Stefanović Vidoje', '', '', ''),
(235, '235', 'Spasojević Saša', '', '', ''),
(236, '236', 'Vojnović Boško', '', '', ''),
(237, '237', 'Bilbija Nenad', '', '', ''),
(238, '238', 'Dejan Riznić', 'Srbija', '', ''),
(239, '239', 'Maksimović Mirko', '', '', ''),
(240, '240', 'Turinski Živojin', '', '', ''),
(241, '241', 'Vilijams Čak', '', '', 'Prevod sa engleskog'),
(242, '242', 'Stoiljković Miloje', '', '', ''),
(243, '243', 'Snežana Bibin', '', '', ''),
(244, '244', 'Lazarević Ivana', '', '', ''),
(245, '245', 'Matić Jelena', '', '', ''),
(246, '246', 'Pantelić Dragana', '', '', ''),
(247, '247', 'Simeonović Nenad', '', '', ''),
(248, '248', 'Nedović Sandra', '', '', 'Završni rad VTŠSS'),
(249, '249', 'Đošić Bojana', '', '', 'Završni rad VTŠSS'),
(250, '250', 'Povrenović Dragan', '', '', ''),
(251, '251', 'Najdanović Aleksandar', '', '', 'Student Visoke tehnološke škole za nemetale'),
(252, '252', 'Katanić Marijana', '', '', 'Studentkinja VTŠSS'),
(253, '253', 'Lacmanović Drago', '', '', 'Student Visoke tehnološke škole za nemetale'),
(254, '254', 'Trajković Marija', '', '', 'Studentkinja VTŠSS'),
(255, '255', 'Plećević Ljiljana', '', '', ''),
(256, '256', 'Jovanović Brankica', '', '', ''),
(257, '257', 'Kiš Šandor', '', '', ''),
(258, '258', 'Milošević Staniša', '', '', ''),
(259, '259', 'Stojanović Vladimir', '', '', ''),
(260, '260', 'Mirković Dušica', '', '', 'Studentkinja, završni rad'),
(261, '261', 'Gajić Miodrag', '', '', 'Završni rad, mentor: Ljiljana Plećević'),
(262, '262', 'Petrović Ivana', '', '', 'Studentkinja, završni rad'),
(263, '263', 'Ćertić Danijela', '', '', 'Studentkinja, završni rad'),
(264, '264', 'Đoković Č. Vladan', '', '', 'Student, završni rad'),
(265, '265', 'Perišić Jovana', '', '', 'Studentkinja, završni rad'),
(266, '266', 'Đukić Vesna', '', '', 'Studentkinja, završni rad'),
(267, '267', 'Stepanović Milica', '', '', 'Studentkinja, završni rad'),
(268, '268', 'Plašić Nevena', '', '', 'Studentkinja, završni rad'),
(269, '269', 'Milačić Olivera', '', '', 'Studentkinja, završni rad'),
(270, '270', 'Mitrović Snežana', '', '', 'Studentkinja, završni rad'),
(271, '271', 'Ilić Milica', '', '', 'Studentkinja, završni rad'),
(272, '272', 'Perić Desimir', '', '', 'Student, završni rad'),
(273, '273', 'Đurašević Nenad', '', '', 'Student, završni rad'),
(274, '274', 'Sinđelić Ivana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(275, '275', 'Radoš Milijana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(276, '276', 'Avramović Vladimir', '', '', 'Student VTŠSS, Aranđelovac'),
(277, '277', 'Vukomanović Milica', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(278, '278', 'Đurčić Dijana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(279, '279', 'Vilotijević Ana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(280, '280', 'Vojinović Katarina', '', '', 'Završni rad, studentkinja VTŠSS - Aranđelovac'),
(281, '281', 'Mikulić Miloš', '', '', 'Završni rad, VTŠSS'),
(282, '282', 'Blagojević Dragana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(283, '283', 'Lošić Milan', '', '', 'Student VTŠSS, Aranđelovac'),
(284, '284', 'Todorović Jovana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(285, '285', 'Jelić Dušica', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(286, '286', 'Jovanović Dragana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(287, '287', 'Rašić Stefan', '', '', 'Student VTŠSS, Aranđelovac'),
(288, '288', 'Dunjić Lazar', '', '', 'Student VTŠSS, Aranđelovac'),
(289, '289', 'Stojanović Nikola', '', '', 'Student VTŠSS, Aranđelovac'),
(290, '290', 'Jovinov Jovana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(291, '291', 'Lazarević R. Veljko', '', '', 'Student VTŠSS, Aranđelovac'),
(292, '292', 'Vilimonović Aleksandra', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(293, '293', 'Ćertić Danijela', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(294, '294', 'Danilović Milica', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(295, '295', 'Jolić Stefan', '', '', 'Student VTŠSS, Aranđelovac'),
(296, '296', 'Sretenović Ana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(297, '297', 'Baričević Petrović Marijana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(298, '298', 'Griževski Ana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(299, '299', 'Bjelica Mirko', '', '', 'Student VTŠSS, Aranđelovac'),
(300, '300', 'Preković Milan', '', '', 'Student VTŠSS, Aranđelovac'),
(301, '301', 'Đorđević Danijela', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(302, '302', 'Mičić Predrag', '', '', 'Student VTŠSS, Aranđelovac'),
(303, '303', 'Vesić Sanja', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(304, '304', 'Otašević Bojan', '', '', 'Student VTŠSS, Aranđelovac'),
(305, '305', 'Gruičić Aleksandra', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(306, '306', 'Boričić Milica', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(307, '307', 'Kalimančević Snežana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(308, '308', 'Popović Ana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(309, '309', 'Ognjanović Danijela', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(310, '310', 'Đurić Lena', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(311, '311', 'Marković Aleksandar', '', '', 'Student VTŠSS, Aranđelovac'),
(312, '312', 'Marković Jelica', '', '', 'Studentkinja VTŠSS, Aranđelovac (DIUK)'),
(313, '313', 'Lukić Milana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(314, '314', 'Marković Jelica', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(315, '315', 'Prokić Jelena', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(316, '316', 'Plećević Zoran', '', '', 'Student VTŠSS, Aranđelovac'),
(317, '317', 'Sošić Marina', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(318, '318', 'Đurović Miloš', '', '', 'Student VTŠSS, Aranđelovac'),
(319, '319', 'Vasić Marina', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(320, '320', 'Račović Aleksa', '', '', 'Student VTŠSS, Aranđelovac'),
(321, '321', 'Jovanović Stefan', '', '', 'Student VTŠSS, Aranđelovac'),
(322, '322', 'Rajković Milica', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(323, '323', 'Stevanović Suzana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(324, '324', 'Mirić Dragana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(325, '325', 'Ilić Milena', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(326, '326', 'Jovanović Svetlana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(327, '327', 'Ševo Milana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(328, '328', 'Vojinović R. Olgica', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(329, '329', 'Lukić Milivoje', '', '', 'Student VTŠSS, Aranđelovac'),
(330, '330', 'Danković Duško', '', '', 'Student VTŠSS, Aranđelovac'),
(331, '331', 'Bojović Ljiljana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(332, '332', 'Đorđević Andrijana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(333, '333', 'Šuša Jovan', '', '', 'Student VTŠSS, Aranđelovac'),
(334, '334', 'Savčić Marija', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(335, '335', 'Mirić Milorad', '', '', 'Student VTŠSS, Aranđelovac'),
(336, '336', 'Lazović Marko', '', '', 'Student VTŠSS, Aranđelovac'),
(337, '337', 'Živojinović Milica', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(338, '338', 'Švabić Marijana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(339, '339', 'Milovančević Marko', '', '', 'Student VTŠSS, Aranđelovac'),
(340, '340', 'Živković Vladan', '', '', 'Student VTŠSS, Aranđelovac'),
(341, '341', 'Vuković Ana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(342, '342', 'Dimitrijević B. Nada', '', '', 'Diplomirala 2014'),
(343, '343', 'Obradović D. Marija', '', '', 'Diplomirala 2014'),
(344, '344', 'Prišedko Nikolaj Avtonomović', 'SSSR', '', ''),
(345, '345', 'Stanić Tamara', '', '', 'Završni rad, studentkinja VTŠSS-Aranđelovac'),
(346, '346', 'Petković N. Slađana', '', '', 'Završni rad, diplomirala 2014.'),
(347, '347', 'Bogdanović Kosta', '', '', ''),
(348, '348', 'Delić M. Ana', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(349, '349', 'Biševac Slobodan', '', '', 'Student VTŠSS, Aranđelovac'),
(350, '350', 'Jevtić Č. Miroslav', '', '', 'Student VTŠSS, Aranđelovac'),
(351, '351', 'Đorđević M. Jasmina', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(352, '352', 'Aladić M. Jelena', '', '', 'Studentkinja VTŠSS, Aranđelovac'),
(353, '353', 'Ranković Mirjana', '', '', 'Završni rad'),
(354, '354', 'Gadžić Milan', '', '', 'Student VTŠSS, Aranđelovac'),
(355, '355', 'Marković N. Ivan', '', '', 'Student VTŠSS, Aranđelovac'),
(356, '356', 'Vesović Marija', '', '', 'Studentkinja VTŠSS, Aranđelovac');

-- --------------------------------------------------------

--
-- Table structure for table `autori_praksa`
--

CREATE TABLE `autori_praksa` (
  `ID` int(11) NOT NULL,
  `Sifra` varchar(10) DEFAULT NULL,
  `ImePrezime` varchar(50) DEFAULT NULL,
  `Zemlja` varchar(20) NOT NULL,
  `Godina` varchar(10) NOT NULL,
  `Napomena` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `clanovi`
--

CREATE TABLE `clanovi` (
  `ID` int(11) NOT NULL,
  `ClanskaKarta` varchar(20) DEFAULT NULL,
  `BrojIndeksa` varchar(20) NOT NULL,
  `Ime` varchar(30) DEFAULT NULL,
  `Prezime` varchar(30) DEFAULT NULL,
  `Adresa` varchar(50) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Telefon` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `izdavaci`
--

CREATE TABLE `izdavaci` (
  `ID` int(11) NOT NULL,
  `Sifra` varchar(10) DEFAULT NULL,
  `Naziv` varchar(100) DEFAULT NULL,
  `Mesto` varchar(30) NOT NULL,
  `Adresa` varchar(50) NOT NULL,
  `Telefon` varchar(30) NOT NULL,
  `Web` varchar(30) NOT NULL,
  `Email` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `izdavaci`
--

INSERT INTO `izdavaci` (`ID`, `Sifra`, `Naziv`, `Mesto`, `Adresa`, `Telefon`, `Web`, `Email`) VALUES
(2, '002', 'Mikro knjiga', 'Beograd', '', '', '', ''),
(3, '003', 'Nolit', 'Beograd', '', '', '', ''),
(4, '004', 'Stubovi kulture', 'Beograd', '', '', 'www.stubovi.co.yu', 'office@stubovi.co.yu'),
(5, '005', 'Nova knjiga', 'Podgorica', '13. jula 7', '', '', 'newpublic@'),
(6, '006', 'RAD', 'Beograd', 'Balkanska 2-4', '', '', ''),
(7, '007', 'Hermes House', 'London', 'Blackfriars Road 88-89', '02074012077', 'www.hermeshouse.com', ''),
(8, '008', 'Zavod za udžbenike', 'Beograd', 'Obilićev venac 5', '011/3281-143', 'www.zavod.co.rs', 'kontakt@yavod.co.rs'),
(9, '009', 'Akademska misao', 'Beograd', 'Bulevar Kralja Aleksandra 160', '011/3218-354', 'www.akademska-misao.rs', 'knjizara@akademska-misao.rs'),
(10, '010', 'FON', 'Beograd', 'Jove Ilića 154', '011/3950800', 'www.fon.rs', 'prfon@fon.bg.ac.rs'),
(11, '011', 'Orion art', 'Beograd', '', '381-63-288-913', '', 'orionart@sbb.rs'),
(12, '012', 'Partenon', 'Beograd', 'Braće Jerkovića 74n', '011/3099030', 'www.partenon.rs', 'partenon@infosky.net'),
(13, '013', 'Kompjuter biblioteka', 'Beograd', 'Vojvode Stepe 34', '011/3096966', 'www.kombib.co.rs', 'kom.bib@sezampro.rs'),
(14, '014', 'Viša politehnička škola', 'Beograd', 'Brankova 17', '011/2633127', 'www.politehnika.edu.rs', 'mnesic@politehnika.edu.rs'),
(15, '015', 'Visoka tehnološka škola strukovnih studija', ' Aranđelovac', 'Josifa Pančića 11', '034/6712-264', 'www.vtsar.edu.rs', 'vtsar@eunet.rs'),
(16, '016', 'Croatiaknjiga', 'Zagreb', 'Ilića 42', '(01)4847559', 'www.croatiaknjiga.hr', 'croatiaknjiga@zg.hinet.hr'),
(17, '017', 'Građevinski fakultet Univerziteta u Beogradu', 'Beograd', 'Bulevar kralja Aleksandra 73', '011/3218526', 'www.grf.bg.ac.rs', 'deon@grf.bg.ac.rs'),
(18, '018', 'Zadužbina Andrejević', 'Beograd', 'Držićeva 11', '011/2401045', 'www.zaduzbinaandrejevic.org.rs', 'redakcija@andrejevic.org'),
(19, '019', 'AGM knjiga d.o.o.', 'Beograd-Zemun', '', '011/2618554', 'www.agmknjiga.co.rs', 'agmknjiga@gmail.com'),
(20, '020', 'Srpska akademija inovacionih nauka', ' Beograd', 'Kralja Milana 60', '011/3981599', 'www.sain-akademija.org.rs', 'akademija.sain@gmail.com'),
(21, '021', 'Savez mašinskih i elektrotehnièkih inženjera i tehničara Srbije', 'Beograd', 'Kneza Miloša 7a/II', '011/3230041', 'www.smeits.rs', ''),
(22, '022', 'Stanek d.o.o.', 'Varaždin', 'Marofska 45', '00385-42-207-215', 'www.stanek.hr', 'info@stanek.hr'),
(23, '023', 'Veble commecre', 'Zagreb', '', '', '', ''),
(24, '024', 'Centar za naučna istraživanja SANU i Univerziteta', 'Kragujevac', '', '034/330043', '', ''),
(25, '025', 'Prosveta', 'Beograd', '', '', '', ''),
(26, '026', 'Dorling Kindersley Limited', 'London', '80 Strand', '', '', ''),
(27, '027', 'Taschen', 'Slovenija', '', '', 'www.taschen.com', ''),
(28, '028', 'Miller''s Publications', 'Tenterden, Kent', 'High Street', '+44(0)1580766411', '', ''),
(29, '029', 'Jugozaštita', 'Beograd', 'Pana Ðukića 1', '011/788131', '', ''),
(30, '030', 'Privredni pregled', 'Beograd', 'Maršala', '', '', ''),
(31, '031', 'Pravni fakultet Univerziteta u Kragujevcu', 'Kragujevac', '', '034/306540', 'www.institut.jura.kg.ac.rs', 'faculty@jura.kg.ac.rs'),
(32, '032', 'Mono i Manjana', 'Beograd', 'Gospodar Vučića 245', '011/3087505', 'www.monoimanjana.rs', 'office@monoimanjana.rs'),
(33, '033', 'Viša tehnološka škola za nemetale i građevinske materijale', 'Aranđelovac', 'Josifa Pančića 11', '034/6701821', 'www.vtsar.edu.rs', ''),
(34, '034', 'Tehnološko metalurški fakultet u Beogradu', 'Beograd', 'Karnegijeva 4', '011/3370460', 'www.tmf.bg.ac.rs', 'TMF@ELAB.tmf.bg.ac.rs'),
(35, '035', 'Viša tehnološko-tehnička škola', 'Kruševac', 'Kosančićeva 36', '', '', ''),
(36, '036', 'Prirodno matematički fakultet', 'Novi Sad', 'Trg Dositeja Obradovića 3', '', '', ''),
(37, '037', 'Epoha', 'Požega', '', '', '', ''),
(38, '038', 'Građevinska knjiga', '', '', '', '', ''),
(39, '039', 'Savremena administracija', 'Beograd', 'Kneza Mihaila 6/V', '011/624096', 'www.savremena-ad.com', 'office@savremena-ad.com'),
(40, '040', 'Naučna knjiga', 'Beograd', '', '', '', ''),
(41, '041', 'Udruženje za tehnologiju vode i sanitarno inženjerstvo', 'Beograd', '29. novembra 57', '', '', ''),
(42, '042', 'Institut za primenu nauke u poljoprivredi', 'Beograd', '', '', '', ''),
(43, '043', 'Prirodno-matematički fakultet', 'Beograd', '', '', '', ''),
(44, '044', 'Fakultet tehničkih nauka', 'Čačak', '', '', '', ''),
(45, '045', 'Tehnički fakultet, Novi Sad', ' Novi Sad', '', '', '', ''),
(46, '046', 'Zapis', 'Aranđelovac', '', '', '', ''),
(47, '047', 'CET', 'Beograd', 'Skadarska 45', '011/3243043', 'www.cet.co.rs', ''),
(48, '048', 'Računarski fakultet', 'Beograd', 'Knez Mihaila 6/vi', '011/2627613', 'www.raf.edu.yu', ''),
(49, '049', 'Tehnička knjiga Zagreb', '', '', '', '', ''),
(50, '050', 'Tehničko metalurški fakultet u Beogradu', 'Beograd', 'Karnegijeva 4', '', '', ''),
(51, '051', 'Zapis', 'Aranđelovac', '', '', '', ''),
(52, '052', 'Rašić R. Tihomir', 'Beograd', 'Mutapova 30-a', '', '', ''),
(53, '053', 'Nikola Počuča', '', '', '', '', ''),
(54, '054', 'Tehnički fakultet, Čačak', 'Čačak', 'Svetog Save 65', '', '', ''),
(55, '055', 'Šumarska škola Kraljevo', 'Kraljevo', '', '', '', ''),
(56, '056', 'Metaphyzica', 'Beograd', '', '', '', ''),
(57, '057', 'Matica srpska', 'Novi Sad', '', '', '', ''),
(58, '058', 'Studentski izdavaèki centar', '', '', '', '', ''),
(59, '059', 'Spektar', 'Zagreb', '', '', '', ''),
(60, '060', 'Smotra Mermer i zvuci', 'Aranđelovac', '', '', '', ''),
(61, '061', 'Akademija Srpske pravoslavne crkve za umetnost i konzervaciju', 'Beograd', '', '', '', ''),
(62, '062', 'Vuk Karadžić', 'Beograd', '', '', '', ''),
(63, '063', 'Mladinska knjiga', 'Ljubljana', '', '', '', ''),
(64, '064', 'Bagdala', 'Kruševac', '', '', '', ''),
(65, '065', 'Vukova zadužbina', 'Beograd', '', '', '', ''),
(66, '066', 'Dover Publications Inc.', 'New York', '', '', '', ''),
(67, '067', 'Roto Vision', 'Mies', '', '', '', ''),
(68, '068', 'Klio', '', '', '', '', ''),
(69, '069', 'Fakultet civilne odbrane Univerziteta u Beogradu', 'Beograd', '', '', '', ''),
(70, '070', 'Narodne novine', '', '', '', '', ''),
(71, '071', 'Mašinski fakultet Kragujevac', 'Kragujevac', '', '', '', ''),
(72, '072', 'Narodni muzej u Kragujevcu', 'Kragujevac', '', '', '', ''),
(73, '073', 'Institut za politièke studije', 'Beograd', '', '', '', ''),
(74, '074', 'Šumarski fakultet u Beogradu', 'Beograd', '', '', '', ''),
(75, '075', 'Ministarstvo odbrane Republike Srbije', 'Beograd', '', '', '', ''),
(76, '076', 'Udruženje za tehnologiju vode i sanit. inženjerstvo', 'Beograd', '', '', '', ''),
(77, '077', 'Fakultet zaštite na radu, Niš', ' Niš', '', '', '', ''),
(78, '078', 'Muzej primenjene umetnosti', 'Beograd', 'Vuka Karadžića 18', '', '', ''),
(79, '079', 'Udruženje za tehnologiju vode i sanitarno inženjerstvo', '', '', '', '', ''),
(80, '080', 'Republièki zavod za zaštitu spomenika kulture', '', '', '', '', ''),
(81, '081', 'BIGZ', 'Beograd', '', '', '', ''),
(82, '082', 'Ekonomski fakultet', 'Beograd', 'Kamenička 6', '011/3021240', '', ''),
(83, '083', 'Stone Studio Association', 'Beograd', '', '', '', ''),
(84, '084', 'PMF - Niš', 'Niš', 'Višegradska 33', '', '', ''),
(85, '085', 'Institut za ekonomiku poljoprivrede', 'Beograd', '', '', '', ''),
(86, '086', 'Edukons institut', 'Beograd', '', '', '', ''),
(87, '087', 'Ekounis institut', 'Beograd', '', '', '', ''),
(88, '088', 'Tehnički fakultet u Boru', 'Bor', '', '', '', ''),
(89, '089', 'Contractor d.o.o.', 'Ripanj', 'Brđanska 458', '011/8325568', '', ''),
(90, '090', 'Digital Dizajn', 'S. Palanka', '', '', '', ''),
(91, '091', 'Univerzitet umetnosti u Beogradu', 'Beograd', 'Vuka Karadžića 12', '', '', ''),
(92, '092', 'Data status', 'Beograd', '', '', '', ''),
(93, '093', 'Regionalni centar za životnu sredinu za centralnu i istočnu Evropu', '', '', '', '', ''),
(94, '094', 'Saobraćajni fakultet', 'Beograd', '', '', '', ''),
(95, '095', 'Narodna biblioteka Aranđelovac', 'Aranđelovac', '', '', '', ''),
(96, '096', 'VVB Technische Keramik', 'Weimar', 'Hegelstrasse 3', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `izdavaci_praksa`
--

CREATE TABLE `izdavaci_praksa` (
  `ID` int(11) NOT NULL,
  `Sifra` varchar(10) DEFAULT NULL,
  `Naziv` varchar(100) DEFAULT NULL,
  `Mesto` varchar(30) NOT NULL,
  `Adresa` varchar(50) NOT NULL,
  `Telefon` varchar(30) NOT NULL,
  `Web` varchar(30) NOT NULL,
  `Email` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `jezik`
--

CREATE TABLE `jezik` (
  `ID` int(11) NOT NULL,
  `Sifra` varchar(20) DEFAULT NULL,
  `Naziv` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `jezik`
--

INSERT INTO `jezik` (`ID`, `Sifra`, `Naziv`) VALUES
(1, '001', 'Ostali'),
(2, '002', 'Srpski'),
(3, '003', 'Engleski'),
(4, '004', 'Ruski'),
(5, '005', 'Francuski'),
(6, '006', 'Španski'),
(7, '007', 'Mađarski'),
(8, '008', 'Nemački'),
(9, '009', 'Hrvatski');

-- --------------------------------------------------------

--
-- Table structure for table `kategorije`
--

CREATE TABLE `kategorije` (
  `ID` int(11) NOT NULL,
  `Sifra` varchar(20) DEFAULT NULL,
  `Naziv` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `kategorije`
--

INSERT INTO `kategorije` (`ID`, `Sifra`, `Naziv`) VALUES
(1, '001', 'Nauka i znanje uopšte. Organizacija intelektualnog rada'),
(2, '001.8', 'Metodologija. Opšte učenje o metodi. Tehnićki i naučni postupci izučavanja, istraživanja, naučnih rasprava. Analiza i sinteza'),
(3, '003', 'Sistem pisanja i pisma. Znakovi i simboli'),
(4, '004', 'Kompjuterske nauke i tehnologije'),
(5, '005', 'Poslovanje'),
(6, '005.6', 'Osobine poslovanja. Celokupne osobine poslovanja (TQM) '),
(7, '006', 'Standardi. Standardizacija. Mere'),
(8, '007', 'Aktivnost i organizovanje. Informacije. Teorija komunikacije (kibernetika)'),
(9, '01', 'Istorija'),
(10, '02', 'Bibliotekarstvo'),
(11, '03', 'Časopisi'),
(12, '030', 'Opšta referentna dela. Enciklopedije, rečnici itd.'),
(13, '04', 'Kompjuterska literatura'),
(14, '05', 'Beletristika'),
(16, '06', 'Periodika'),
(17, '061', 'Organizacije. Udruženja. Korporacije. Društva'),
(18, '08', 'Psihologija'),
(19, '1', 'Filozovija. Psihologija'),
(20, '111', 'Estetika'),
(21, '17', 'Nauka o moralu. Etika'),
(22, '2', 'Religija. Teologija'),
(23, '3', 'Drustvene nauke. Zakoni. Uprav'),
(24, '316', 'Sociologija'),
(25, '33', 'Privreda. Ekonomske nauke'),
(26, '331', 'Rad. Zaposlenost. Ekonomija rada. Organizacija rada'),
(27, '332', 'Regionalna privreda. Zemljišna svojina'),
(28, '338', 'Ekonomska politika'),
(29, '339', 'Trgovina'),
(30, '34', 'Pravo. Jurisprudencija'),
(31, '37', 'Obrazovanje'),
(32, '4', 'Rezerva'),
(33, '5', 'Matematika i prirodne nauke'),
(34, '502', 'Ekologija. Čuvanje prirodnih resursa'),
(35, '504', 'Pretnje prirodnom okruženju'),
(36, '51', 'Matematika'),
(37, '512', 'Algebra'),
(38, '52', 'Astronomija. Geodezija'),
(39, '54', 'Hemija'),
(40, '543', 'Analitička hemija'),
(41, '547', 'Organska hemija'),
(42, '55', 'Geografija'),
(43, '552', 'Petrologija. Petrografija'),
(44, '553', 'Ekonomska geologija. Mineralna ležišta'),
(45, '56', 'Pedagoška literatura'),
(46, '574', 'Ekologija'),
(47, '6', 'Primenjene nauke. Medicna'),
(48, '614', 'Javno zdravlje i higijena. Prevencija od udesa'),
(49, '62', 'Inženjering. Tehnologija uopšte'),
(50, '620', 'Ispitivanje materijala. Trgovinski materijali. Elektrane. Energetska privreda'),
(51, '621', 'Opšte mašinstvo. Nuklearna tehnika. Elektrotehnika'),
(52, '621.3', 'Elektrotehnika'),
(53, '621.8', 'Mašinski elementi'),
(54, '626', 'Hidraulika uopšte'),
(55, '628', 'Sanitarna tehnika. Voda. Sanitarni uređaji. Tehnika rasvete'),
(56, '63', 'Poljoprivreda'),
(57, '639', 'Lov. Ribolov. Gajenje riba'),
(58, '65', 'Rukovođenje i organizacija rada u industriji'),
(59, '658', 'Organizacija trgovine i industrije. Preduzeće. Kupovina. Prodaja'),
(60, '66', 'Hemijska tehnologija. Hemijske i srodne industrije'),
(61, '662', 'Eksplozivi, goriva'),
(62, '666', 'Staklena industrija. Keramika. Cement i beton'),
(63, '681.3', 'Računarstvo'),
(64, '691', 'Građevinski materijali'),
(65, '7', 'Umetnost. Rekreacija. Razonoda'),
(66, '7.003', 'Mozaik'),
(67, '7.01', 'Estetika umetnosti'),
(68, '712', 'Planiranje pejzaža (prirodnog i oblikovanog). Parkovi. Vrtovi'),
(69, '72', 'Arhitektura'),
(70, '738', 'Keramika. Grnčarstvo'),
(72, '741', 'Crtanje'),
(73, '743', 'Anatomsko crtanje'),
(74, '745', 'Umetnički ručni radovi'),
(75, '748', 'Vitraž. Umetnička obrada stakla i kristala'),
(76, '75', 'Slikarstvo'),
(77, '8', 'Jezici, Lingvistika, Književnost'),
(78, '81', 'Jezici'),
(79, '821', 'Roman srpske književnosti'),
(80, '886-1', 'Domaća poezija'),
(81, '886-2', 'Domaće pripovetke'),
(82, '886-3', 'Proza'),
(83, '9', 'Geografija. Biografija. Istorija'),
(84, '904', 'Kulturni ostaci istorijskog perioda');

-- --------------------------------------------------------

--
-- Table structure for table `kategorije_praksa`
--

CREATE TABLE `kategorije_praksa` (
  `ID` int(11) NOT NULL,
  `Sifra` varchar(20) DEFAULT NULL,
  `Naziv` varchar(150) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `knjige`
--

CREATE TABLE `knjige` (
  `ID` int(11) NOT NULL,
  `InventarniBroj` varchar(40) NOT NULL,
  `UDKBroj` varchar(30) DEFAULT NULL,
  `ISBNBroj` varchar(30) NOT NULL,
  `Naslov` varchar(200) DEFAULT NULL,
  `GodinaIzdanja` varchar(30) NOT NULL,
  `SifraAutora` varchar(20) DEFAULT NULL,
  `SifraIzdavaca` varchar(20) DEFAULT NULL,
  `SifraKategorije` varchar(20) DEFAULT NULL,
  `SifraJezika` varchar(20) DEFAULT NULL,
  `Stanje` int(20) DEFAULT NULL,
  `Napomena` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `knjige`
--

INSERT INTO `knjige` (`ID`, `InventarniBroj`, `UDKBroj`, `ISBNBroj`, `Naslov`, `GodinaIzdanja`, `SifraAutora`, `SifraIzdavaca`, `SifraKategorije`, `SifraJezika`, `Stanje`, `Napomena`) VALUES
(40, '', '0011', '', 'Mosaics', '', '1', '007', '7.003', '003', 1, ''),
(67, '', '0015', '', 'Standardni srpsko-engleski rečnik', '', '1', '008', '81', '002', 1, ''),
(68, '', '0016', '', 'Numeričke metode', '', '1', '009', '51', '002', 1, ''),
(72, '', '0019', '', 'Liderske kompetencije', '', '1', '010', '005', '002', 1, ''),
(73, '', '0020', '', 'Pojmovnik teorije umetnosti', '', '1', '011', '7.01', '002', 1, ''),
(74, '', '0021', '', 'Istorija umetnosti u Srbiji XX vek', '', '1', '011', '7', '002', 1, ''),
(75, '', '0022', '', 'Istorija moderne umetnosti', '', '1', '011', '7', '002', 1, ''),
(76, '', '0023', '', 'Organska hemija', '', '1', '012', '547', '002', 1, ''),
(78, '', '0025', '', 'PremierePro2', '', '1', '013', '04', '002', 1, ''),
(82, '', '0029', '', 'Flash ActionScript 8', '', '1', '013', '04', '002', 1, ''),
(84, '', '0031', '', 'Matematika', '', '1', '014', '51', '002', 1, ''),
(89, '', '0036', '', 'Diplomski rad: Određivanje herbicida i pesticida u biološkom materijalu', '', '1', '015', '001.8', '002', 1, ''),
(90, '', '0037', '', 'Ispuštanje i pročišćavanje otpadne vode', '', '1', '016', '628', '009', 1, ''),
(94, '', '0041', '', 'Principi geografskih informacionih sistema', '', '018', '017', '007', '002', 1, ''),
(100, '', '0047', '', 'Obrazovanje i zaštita životne sredine', '', '1', '018', '37', '002', 1, ''),
(101, '', '0048', '', 'BIodizel, biogas, biomasa', '', '1', '019', '662', '002', 1, ''),
(102, '', '0049', '', 'Biodizel: humano gorivo', '', '1', '020', '662', '002', 1, ''),
(104, '', '0051', '', 'Obnovljivi izvori energije i njihova ekonomska ocena', '', '1', '019', '502', '002', 1, ''),
(105, '', '0052', '', 'Upravljanje rizicima u životnoj sredini', '', '1', '018', '005', '002', 1, ''),
(106, '', '0053', '', 'Zaštita od korozije', '', '1', '015', '620', '002', 1, ''),
(108, '', '0055', '', 'Tehnika i tehnologija u funkciji zaštite životne sredine', '', '1', '021', '502', '002', 1, ''),
(110, '', '0057', '', 'Jansonova istorija umetnosti', '', '1', '022', '7', '009', 1, ''),
(111, '', '0058', '', 'Anatomija škola crtanja', '', '1', '023', '743', '009', 1, ''),
(112, '', '0059', '', 'Englesko-srpski enciklopedijski rečnik', '', '1', '024', '81', '002', 1, ''),
(113, '', '0060', '', 'Leksikon stranih reči i izraza', '', '1', '025', '81', '002', 1, ''),
(114, '', '0061', '', 'Mala enciklopedija PROSVETA 1 A-LJ', '', '1', '025', '030', '002', 1, ''),
(115, '', '0062', '', 'Mala enciklopedija PROSVETA 2 M-Š', '', '1', '025', '030', '002', 1, ''),
(116, '', '0063', '', 'Decorative Arts', '', '1', '026', '745', '003', 1, ''),
(117, '', '0064', '', 'Dizajn danas', '', '1', '027', '7', '002', 1, ''),
(118, '', '0065', '', '20-th-Century Glass', '', '1', '026', '748', '003', 1, ''),
(119, '', '0066', '', 'Miller''s Ceramics Buyer''s Guide', '', '1', '028', '738', '003', 1, ''),
(120, '', '0067', '', 'Praktikum za zaštitu na radu, zaštitu od požara i zaštitu životne sredine', '', '1', '029', '331', '002', 1, ''),
(121, '', '0068', '', 'Zbirka propisa o zaštiti na radu', '', '1', '029', '331', '002', 1, ''),
(122, '', '0069', '', 'Zbirka propisa o zaštiti životne sredine', '', '1', '029', '502', '002', 1, ''),
(126, '', '0073', '', 'Osnove kvaliteta', '', '1', '010', '005.6', '001', 1, ''),
(127, '', '0074', '', 'Osnove kvaliteta', '', '1', '010', '005.6', '002', 1, ''),
(129, '', '0076', '', 'Mehanika fluida', '', '039', '015', '66', '002', 1, ''),
(130, '', '0077', '', 'Tehnologija bezalkoholnih napitaka', '', '1', '015', '66', '002', 1, ''),
(131, '', '0078', '', 'Negativni ekološki uticaji od saobraćaja', '', '1', '015', '502', '002', 1, ''),
(134, '', '0081', '', 'Naučno-tehnički rečnik rusko-srpskohrvatski', '', '1', '030', '62', '002', 1, ''),
(135, '', '0082', '', 'Uvod u pravo', '', '1', '031', '34', '002', 1, ''),
(136, '', '0083', '', 'Frenk Lojd Rajt', '', '1', '027', '72', '002', 1, ''),
(137, '', '0084', '', 'Le Korbizje', '', '1', '027', '72', '002', 1, ''),
(138, '', '0085', '', 'Veština crtanja i slikanja: postupni uvod u crtanje, slikanje akvarela i uljano slikarstvo', '', '1', '032', '741', '002', 1, ''),
(139, '', '0086', '', 'Stručni rad: Uticaj tehnoloških parametara glazurne suspenzije na kvalitet glazure', '', '1', '015', '001.8', '002', 1, ''),
(141, '', '0088', '', 'Kontrola kvaliteta vode za piće', '', '1', '036', '628', '002', 1, ''),
(142, '', '0089', '', 'Tehnologija malternih veziva', '', '1', '033', '66', '002', 1, ''),
(143, '', '0090', '', 'Osnovi tehnologije keramike I i II', '', '1', '033', '666', '002', 1, ''),
(144, '', '0091', '', 'Računarstvo i informatika', '', '1', '037', '37', '002', 1, ''),
(145, '', '0092', '', 'Snabdevanje vodom', '', '1', '038', '626', '002', 1, ''),
(146, '', '0093', '', 'Fina i tehnička keramika', '', '1', '033', '666', '002', 1, ''),
(147, '', '0094', '', 'Matematika: za više tehničke škole', '', '1', '039', '001', '002', 1, ''),
(148, '', '0095', '', 'Praktikum: tehnologija malternih veziva i vatrostalnih materijala', '', '1', '033', '666', '002', 1, ''),
(150, '', '0097', '', 'Tehnologija stakla', '', '1', '033', '666', '002', 1, ''),
(151, '', '0098', '', 'Udžbenik hemijske tehnologije', '', '1', '040', '66', '002', 1, ''),
(153, '', '0100', '', 'Stručni rad: Tunelske peći i proces pečenja u njima', '', '1', '033', '001.8', '002', 1, ''),
(154, '', '0101', '', 'Tehnološki proces proizvodnje kazanskih opeka sa posebnim osvrtom na proces pečenja', '', '1', '033', '001.8', '002', 1, ''),
(155, '', '0102', '', 'Uticaj tehnoloških parametara glazurne suspenzije na kvalitet glazure', '', '1', '033', '001.8', '002', 1, ''),
(156, '', '0103', '', 'Tehnološki proces proizvodnje tanjira sa posebnim osvrtom na glaziranje i greške pri glaziranju', '', '1', '033', '001.8', '002', 1, ''),
(157, '', '0104', '', 'Zavisnost nekih osobina nikalcink-ferita od odnosa Ni/Zn', '', '062', '033', '001.8', '002', 1, ''),
(158, '', '0105', '', 'Pristup rešavanju problema prečišćavanja otpadnih voda hemijske industrije "Zorka" Šabac', '', '1', '033', '001.8', '002', 1, ''),
(159, '', '0106', '', 'Zavisnost osobina Ni-TiC od sastava', '', '064', '033', '001.8', '002', 1, ''),
(160, '', '0107', '', 'Dobijanje poroznih keramičkih tela na bazi kordijerita', '', '1', '033', '001.8', '002', 1, ''),
(161, '', '0108', '', 'Kontrola kvaliteta elektrotehničkog porcelana i organizacija službe kontrole', '', '1', '033', '001.8', '002', 1, ''),
(162, '', '0109', '', 'Dobijanje granulata za presovanje keram. pločica suš. suspenzije u tornjevima za rasprš…', '', '1', '033', '001.8', '002', 1, ''),
(163, '', '0110', '', 'Tehnol. proces proizvodnje porcel. izolatora sa poseb. osvrtom na oblikovanje iz plastiènih masa', '', '1', '033', '001.8', '002', 1, ''),
(164, '', '0111', '', 'Zavisnost osobina ispresaka i sinterovanog uzorka steatita od pritiska presovanja', '', '069', '033', '001.8', '002', 1, ''),
(165, '', '0112', '', 'Proizvodnja bezalk. napitaka u "B. banji" sa posebnim aspektom na sok "BB pomorandža"', '', '1', '033', '001.8', '002', 1, ''),
(166, '', '0113', '', 'Dobijanje steatitnih cevi izostatičkim presovanjem', '', '1', '033', '001.8', '002', 1, ''),
(167, '', '0114', '', 'Uticaj veličine i pravca dejstva pritiska presov. na velič. koefic. gasopropustljivosti šamot. opeka', '', '1', '033', '001.8', '002', 1, ''),
(170, '', '0117', '', 'Uticaj temperature pečenja na karakter veze minerala nosioca strukture magnezit-hromitne opeke', '', '1', '033', '001.8', '002', 1, ''),
(171, '', '0118', '', 'Tehnološki proces proizvodnje vode za piće u Zenici sa osvrtom na hemijsko-sanitarnu kontrolu', '', '1', '033', '001.8', '002', 1, ''),
(172, '', '0119', '', 'Analiza nekih faktora koji utiču na izdržljivost vatrostalnog materijala u žarnoj zoni krečne peći', '', '1', '033', '001.8', '002', 1, ''),
(173, '', '0120', '', 'Ponašanje plastične mase pod dejstvom spoljne mehaničke sile', '', '1', '033', '001.8', '002', 1, ''),
(174, '', '0121', '', 'Analiza metoda za ocenu plastičnosti i iznalaženje korelacionih odnosa', '', '1', '033', '001.8', '002', 1, ''),
(175, '', '0122', '', 'Ispitivanje faznog sastava nekih šamotnih materijala', '', '1', '033', '001.8', '002', 1, ''),
(176, '', '0123', '', 'Dobijanje i ispitivanje osobina NVT-osigurača', '', '1', '033', '001.8', '002', 1, ''),
(177, '', '0124', '', 'Ispitivanje međudejstva Al2O3 sa rastopom sastava eutektikuma gelenit - anortin - CA6', '', '1', '033', '001.8', '002', 1, ''),
(178, '', '0125', '', 'Izrada aparature za gasopropustljivost i kalibrisanje', '', '1', '035', '001.8', '002', 1, ''),
(179, '', '0126', '', 'Osnovne mogućnosti korišć. visokotemper. elektrootp. peći (tipa kape) za ocenu kval. vatrost. mater', '', '1', '033', '001.8', '002', 1, ''),
(180, '', '0127', '', 'Razmatranje moguć. poveć. koef. dilatacije uvođ. kvarc. peska kao dod. stand. keram. masi za zid.pl.', '', '1', '033', '001.8', '002', 1, ''),
(181, '', '0128', '', 'Uticaj finoće mliva na osobine livačke mase i gotovih proizvoda', '', '1', '033', '001.8', '002', 1, ''),
(182, '', '0129', '', 'Dobijanje kugli od aluminijumoksida izostatičkim presovanjem', '', '1', '033', '001.8', '002', 1, ''),
(183, '', '0130', '', 'Proizvodnja vode za piće na području grada Valjevo', '', '1', '033', '001.8', '002', 1, ''),
(184, '', '0131', '', 'Tehnološki proces proizvodnje elektroker. proiz. iz pres-prahova (suvo i vlaž. pres.) i dimenz. kon.', '', '1', '033', '001.8', '002', 1, ''),
(185, '', '0132', '', 'Priprema uzoraka i analiza za ispitivanje otpornosti na šljake', '', '1', '033', '001.8', '002', 1, ''),
(186, '', '0133', '', 'Određivanje otpornosti vatrost. materijala protiv uticaja šljake', '', '1', '033', '001.8', '002', 1, ''),
(187, '', '0134', '', 'Hemijska analiza alumosilikatnih vatrostalnih materijala', '', '1', '033', '001.8', '002', 1, ''),
(188, '', '0135', '', 'Hemijska kontrola sirovina u rudnicima i industriji "Šamota"', '', '1', '033', '001.8', '002', 1, ''),
(189, '', '0136', '', 'Sušenje PS izolatora u kanalnim sušarama', '', '1', '033', '001', '002', 1, ''),
(190, '', '0137', '', 'Neki problemi određivanja faznog sastava sistema na bazi SiO2-Al2O3 hemijskom analizom', '', '1', '033', '001', '002', 1, ''),
(191, '', '0138', '', 'Organizacija hemijske kontrole sirovina i gotovih proizvoda u fabrici Šamota, Aranđelovac', '', '1', '033', '001.8', '002', 1, ''),
(192, '', '0139', '', 'Hemijska kontrola sirovina koje se koriste za proizvodnju elektroporcelana', '', '1', '033', '001.8', '002', 1, ''),
(193, '', '0140', '', 'Osobine vode Titovog Užica sa posebnim osvrtom na hemijski sastav i kontrolu', '', '1', '033', '001.8', '002', 1, ''),
(194, '', '0141', '', 'Osobine tehnologije važnijih keramičkih magnetnih materijala', '', '100', '033', '001.8', '002', 1, ''),
(195, '', '0142', '', 'Fizičko hemijska kontrola vode za piće u vodovodu - Aranđelovac', '', '101', '033', '001', '002', 1, ''),
(196, '', '0143', '', 'Tehnološki postupak za dobijanje vode za piće u gradu Titovom Užicu', '', '102', '033', '001.8', '002', 1, ''),
(197, '', '0144', '', 'Izrada vatrost. opeka asortimana X-2 pneumatskim post. i mogućnost kontr. deform. ponašanja opeka', '', '103', '033', '001.8', '002', 1, ''),
(198, '', '0145', '', 'Obogaćivanje i proces sušenja lignita pod pritiskom u autoklavama', '', '104', '033', '001.8', '002', 1, ''),
(199, '', '0146', '', 'Termostabilnost vatrost. proizvoda i uticaj dodataka Al2O3 standardnim periklasnom opekama', '', '105', '033', '001.8', '002', 1, ''),
(200, '', '0147', '', 'Uticaj dodatka kvarc. peska osnovnoj livačkoj masi na brzinu nabiranja mase', '', '106', '033', '001.8', '002', 1, ''),
(201, '', '0148', '', 'Uticaj sadržaja opošćivača na reološke i tehnološke karakteristike stand. liv. mase za elektroporcel', '', '107', '033', '001.8', '002', 1, ''),
(202, '', '0149', '', 'Određivanje optimalnih karakteristika šlikera porcelanskih masa za atomiziranje', '', '1', '033', '001.8', '002', 1, ''),
(203, '', '0150', '', 'Organizacija transporta mineralnih sirovina od mesta iskopa do linije prerade', '', '108', '033', '001.8', '002', 1, ''),
(204, '', '0151', '', 'Uticaj koncentracije elektrolita na parametre filtrac. anal. i tečljivost pogonske liv. m. za san. k', '', '109', '033', '001.8', '002', 1, ''),
(205, '', '0152', '', 'Tehnologija prečišć. sirove vode za piće na filter stanici grada Aranđelovca', '', '110', '033', '001.8', '002', 1, ''),
(206, '', '0153', '', 'Određivanje vezivne sposobnosti glina metodom plastičnosti', '', '111', '033', '001.8', '002', 1, ''),
(207, '', '0154', '', 'Određivanje staklene ambalaže i utvrđivanje hemijske postojanosti i termomehan. karakteristika', '', '112', '033', '001.8', '002', 1, ''),
(208, '', '0155', '', 'Dobijanje termoizolacionih opeka na bazi dijatomeja "Baroševac"', '', '113', '033', '001.8', '002', 1, ''),
(209, '', '0156', '', 'Hemijska tehnologija', '', '114', '043', '66', '002', 1, ''),
(211, '', '0158', '', 'Karakteristike ozida i toplotni bilans rotacionih peći', '', '115', '033', '001.8', '002', 1, ''),
(212, '', '0159', '', 'Termostabilnost elektrokeramičkih masa porcelana, steatita i kordijerita', '', '116', '033', '001.8', '002', 1, ''),
(213, '', '0160', '', 'Tehnološki proces proizvodnje zidnih glaziranih pločica i statistička obrada podataka', '', '117', '033', '001.8', '002', 1, ''),
(214, '', '0161', '', 'Sintetsko dobijanje spinelnih pigmenata', '', '118', '033', '001.8', '002', 1, ''),
(215, '', '0162', '', 'Priprema mineralnih sirovina', '', '119', '033', '001', '002', 1, ''),
(216, '', '0163', '', 'Ispitivanje karakteristika pečenog crepa IGM "Ćele Kula" - Niš', '', '120', '033', '001.8', '002', 1, ''),
(217, '', '0164', '', 'Zbornik radova fakulteta tehničkih nauka', '', '1', '001', '001', '002', 1, ''),
(218, '', '0165', '', 'Uticaj orijentacije pora na koef. gasoprop. i utvrđ. jačine veze između ovog koef. i prividne gustin', '', '121', '033', '001.8', '002', 1, ''),
(219, '', '0166', '', 'Uticaj dodataka glinice na čvrstoću elektroporcelana', '', '122', '033', '001.8', '002', 1, ''),
(220, '', '0167', '', 'Proizvodnja dvosl. krist. stakla i ocena postoj. spoja upoređenjem koef. term. širenja od.ek. i r.', '', '123', '033', '001.8', '002', 1, ''),
(221, '', '0168', '', 'Pregled tehnologije dobijanja keramičkih magnetnih materijala', '', '124', '033', '001.8', '002', 1, ''),
(222, '', '0169', '', 'Uporedna karakterizacija rudne i vakuumirane gline koja se koristi u proizvodnji građ. keramike', '', '125', '033', '001.8', '002', 1, ''),
(223, '', '0170', '', 'Mogućnost primene nekih jednačina presovanja za predviđ. fizičko-meh. karakter. šamotnih opeka', '', '126', '033', '001.8', '002', 1, ''),
(224, '', '0171', '', 'Tehnološki proces sušenja u industriji materijala "Sloga" OOUR "Mladost" Novi Pazar', '', '127', '033', '001.8', '002', 1, ''),
(225, '', '0172', '', 'Mogućnost primene CuO u proizvodnji glazure', '', '128', '033', '001.8', '002', 1, ''),
(226, '', '0173', '', 'Proces sušenja grube keramike u industriji građevinskog materijala "Sloga" OOUR "Standard" Novi Paza', '', '129', '033', '001.8', '002', 1, ''),
(227, '', '0174', '', 'Reol.-tehnol. karakt. livač. mase za proizv. elektroiz. i prov. mogućn. zamene metode gips.jez. f. a', '', '130', '033', '001.8', '002', 1, ''),
(228, '', '0175', '', 'Mehaničke, fizičke i termofizičke osobine mulkorita', '', '131', '033', '001.8', '002', 1, ''),
(229, '', '0176', '', 'Organizacija službe održavanja radne organizacije Fabrika porcelana "Porcelan-Zaječar" u Zaječaru', '', '132', '033', '001.8', '002', 1, ''),
(230, '', '0177', '', 'Koefic. neravnom. sušenja kod komor. sušara tipa "Keller" u fabrici fasad. opeke "Standard"-Ar.', '', '133', '033', '001.8', '002', 1, ''),
(231, '', '0178', '', 'Moguć. uštede ener. i skrać. vrem. potrebnog za proizv. asortimana keram. uliv. sita i nos. grejaća', '', '134', '033', '001.8', '002', 1, ''),
(232, '', '0179', '', 'Neki elementi obrade i primene kamena', '', '135', '033', '001.8', '002', 1, ''),
(233, '', '0180', '', 'Rentgenska i mikrostrukturna analiza kordijerita i mulkorita', '', '136', '033', '001.8', '002', 1, ''),
(234, '', '0181', '', 'Uticaj sadrž. i granul. kvarc. peska na parametre filtr. analize liv. mase i susp. za izr. plas. mas', '', '137', '033', '001.8', '002', 1, ''),
(235, '', '0182', '', 'Osnovi metalizacije Al2O3 keramike', '', '138', '033', '001.8', '002', 1, ''),
(236, '', '0183', '', 'Određivanje kvaliteta vakuumiranih oblica merenjem mehaničke jačine u suvom stanju', '', '139', '033', '001.8', '002', 1, ''),
(237, '', '0184', '', 'Industr. kontrola sušenja bloka sa horiz. šupljinama asortimana 190x250x200mm u tunelskim sušarama', '', '140', '033', '001.8', '002', 1, ''),
(238, '', '0185', '', 'Omekšavanje vode za potrebe industrijskog kompleksa H. I. "Zorka" - Šabac', '', '141', '033', '001.8', '002', 1, ''),
(239, '', '0186', '', 'Proizvodnja demineral. vode za potrebe fabrike "Beli limovi" sa opisom prečišćavanja otpadnih voda', '', '142', '033', '001.8', '002', 1, ''),
(240, '', '0187', '', 'Značaj sadržaja kiseonika u otpadnim vodama', '', '143', '033', '620', '002', 1, ''),
(241, '', '0188', '', 'Uticaj viskoziteta glaz. suspenz. i dužine vremena zadržavanja izolatora u glaz. susp.', '', '144', '033', '001.8', '002', 1, ''),
(242, '', '0189', '', 'Snabdevanje vodom grada Čačka, sa osvrtom na tehnologiju prerade i kontrolu vode', '', '145', '033', '001.8', '002', 1, ''),
(243, '', '0190', '', 'Proizvodnja kiselootpornih vučenih pločica', '', '146', '033', '001.8', '002', 1, ''),
(244, '', '0191', '', 'Efekti puštanja u rad ventilatora za rapidno hlađenje na visokotemperat. tunelskoj peći Kerabedarf', '', '147', '033', '001.8', '002', 1, ''),
(245, '', '0192', '', 'Mogućnost izrade keramičkih pločica otpornih na habanje', '', '148', '033', '001.8', '002', 1, ''),
(246, '', '0193', '', 'Uticaj temperature pečenja i prirode gline na fizičko-mehaničke karakteristike keramičkog crepa', '', '149', '033', '001.8', '002', 1, ''),
(247, '', '0194', '', 'Oblikovanje keramičkih proizvoda i uticaj vlažnosti na kvalitet proizvoda', '', '150', '033', '001.8', '002', 1, ''),
(248, '', '0195', '', 'Osnove umrežavanja', '', '151', '002', '04', '001', 1, ''),
(250, '', '0197', '', 'Ekonomika preduzeća, menadžment i marketing u funkciji profita', '', '1', '033', '658', '002', 1, ''),
(251, '', '0198', '', 'Opšta hemija, prvi deo', '', '1', '033', '54', '002', 1, ''),
(252, '', '0199', '', 'Organizacija sistema održavanja u fabrici "Elektroporcelana" u Aranđelovcu', '', '153', '033', '001.8', '002', 1, ''),
(253, '', '0200', '', 'Rashladne vode na proizvodnji PVC-a', '', '154', '033', '001.8', '002', 1, ''),
(254, '', '0201', '', 'Marketing', '', '155', '039', '339', '002', 1, ''),
(255, '', '0202', '', 'Snabdevanje vodom za piće grada Šapca, sa osvrtom na tehnologiju prerade i kontrolu vode', '', '156', '033', '001.8', '002', 1, ''),
(256, '', '0203', '', 'Neorganska hemija', '', '158', '025', '54', '002', 1, ''),
(257, '', '0204', '', 'Opšta hemija', '', '159', '034', '54', '002', 1, ''),
(258, '', '0205', '', 'Ekološki menadžment', '', '1', '010', '005', '002', 1, ''),
(261, '', '0208', '', 'Učenje programa Autodesk 3ds Max 2008', '', '160', '047', '004', '002', 1, ''),
(262, '', '0209', '', 'Računarska grafika', '', '161', '047', '004', '002', 1, ''),
(265, '', '0212', '', 'Uvod u Matlab 7', '', '162', '047', '04', '002', 1, ''),
(268, '', '0215', '', 'Programski jezik C', '', '163', '047', '004', '002', 1, ''),
(271, '', '0218', '', 'Programski jezik C: rešenja zadataka', '', '164', '047', '004', '002', 1, ''),
(272, '', '0219', '', 'Kombinatorika i grafovi', '', '165', '048', '51', '002', 1, ''),
(275, '', '0222', '', 'Sertifikat security +', '', '166', '047', '004', '002', 1, ''),
(276, '', '0223', '', 'Uvod u AutoCAD 2010: 2D i 3D projektovanje', '', '167', '047', '04', '002', 1, ''),
(279, '', '0226', '', 'Strukture podataka i organizacija datoteka', '', '168', '048', '004', '002', 1, ''),
(280, '', '0227', '', 'ADOBE In Design CS3: učionica u knjizi', '', '1', '047', '004', '002', 1, ''),
(282, '', '0229', '', 'Tehnologija proizvodnje vode za piće na novoj filter stanici na području grada Aranđelovca', '', '169', '033', '001.8', '002', 1, ''),
(283, '', '0230', '', 'Procesi i uređaji za dobijanje tehnološke vode pri proizvodnji PVC-a', '', '170', '035', '001.8', '002', 1, ''),
(284, '', '0231', '', 'Priprema vatrostalnih sirovina', '', '171', '033', '001.8', '002', 1, ''),
(285, '', '0232', '', 'Mikrobiološki tretman otpadnih voda kod proizvodnje PVC-a', '', '172', '033', '001.8', '002', 1, ''),
(286, '', '0233', '', 'Tehnologija proizvodnje vode za piće grada  Kragujevca', '', '173', '033', '001.8', '002', 1, ''),
(287, '', '0234', '', 'Tehnološki postupak dobijanja vode za piće na teritoriji grada Mladenovca', '', '174', '033', '001.8', '002', 1, ''),
(288, '', '0235', '', 'Primena koagulanata u prečišć. otpad. voda - uklanjanje 137 Cs i 60 Co iz radioakt. otpad. voda', '', '175', '033', '001.8', '002', 1, ''),
(289, '', '0236', '', 'Ocena postojanosti tehnološkog procesa proizvodnje toplotno-izolacionih proiz. asortimana porit - 10', '', '176', '033', '001.8', '002', 1, ''),
(290, '', '0237', '', 'Obrada otpadnih voda Sokobanje', '', '177', '033', '001.8', '002', 1, ''),
(291, '', '0238', '', 'Teh. proizv. pitkih voda i proc. preč. otp. voda u d.p. "Srbocoop" -ex-imp - Bg, r. j. eksp. kl. Bel', '', '178', '033', '001.8', '002', 1, ''),
(292, '', '0239', '', 'Tehnološki postupak proizvodnje mineralne vode "Rada" Bjelo Polje', '', '179', '033', '001.8', '002', 1, ''),
(293, '', '0240', '', 'Molerova moderna neorganska hemija', '', '1', '040', '54', '002', 1, ''),
(294, '', '0241', '', 'Elektrohemijsko inženjerstvo', '', '180', '049', '62', '001', 1, ''),
(296, '', '0243', '', 'Informatičke tehnologije', '', '1', '015', '681.3', '002', 1, ''),
(297, '', '0244', '', 'Korozija materijala', '', '181', '034', '620', '002', 1, ''),
(299, '', '0246', '', 'Hemija u mašinstvu', '', '183', '040', '54', '002', 1, ''),
(302, '', '0249', '', 'Ekološki projekti', '', '184', '015', '574', '002', 1, ''),
(303, '', '0250', '', 'Kvalitet vode za rekreaciju', '', '1', '036', '628', '002', 1, ''),
(304, '', '0251', '', 'Voda za piće', '', '185', '052', '552', '002', 1, ''),
(305, '', '0252', '', 'Priručnik iz životne sredine', '', '184', '015', '574', '002', 1, ''),
(308, '', '0253', '', 'Festival kvaliteta', '', '1', '001', '001', '002', 1, ''),
(311, '', '0256', '', 'Priručnik o biomasi i njenom korišćenju u energetske svrhe', '', '186', '053', '574', '002', 1, ''),
(312, '', '0257', '', 'Priručnik o biomasi i njenom korišćenju u energetske svrhe', '', '186', '053', '574', '001', 1, ''),
(316, '', '0261', '', 'Industrijski menadžment', '', '187', '054', '001', '002', 1, ''),
(317, '', '0262', '', 'Zveri Balkana', '', '188', '055', '639', '001', 1, ''),
(318, '', '0263', '', 'Dizajn i savremena umetnost', '', '189', '056', '7', '002', 1, ''),
(319, '', '0264', '', 'Umetnost kroz vekove', '', '190', '057', '7', '002', 1, ''),
(320, '', '0265', '', 'Dizajn 20.veka', '', '1', '027', '7', '002', 1, ''),
(321, '', '0266', '', 'Kazivanja i iskazi srpskih vajara', '', '191', '001', '7', '002', 1, ''),
(322, '', '0267', '', 'Dizajn i kultura', '', '1', '058', '7', '002', 1, ''),
(323, '', '0268', '', 'Moderna skulptura', '', '192', '001', '7', '002', 1, ''),
(324, '', '0269', '', 'Gaudi', '', '193', '001', '7', '002', 1, ''),
(325, '', '0270', '', 'The Graphic Work M. C. Escher', '', '1', '027', '7', '003', 1, ''),
(326, '', '0271', '', 'Revolucionarno kiparstvo', '', '1', '059', '7', '009', 1, ''),
(327, '', '0272', '', 'Beli venčac', '', '1', '060', '7', '001', 1, ''),
(328, '', '0273', '', 'Metodologija rada u vajarskim materijalima', '', '194', '061', '7', '002', 1, ''),
(329, '', '0274', '', 'Istorija svetske skulpture', '', '195', '062', '7', '002', 1, ''),
(330, '', '0275', '', 'Leonardo da Vinči, život i delo', '', '196', '062', '7', '002', 1, ''),
(331, '', '0276', '', 'Srednji vek i renesansa', '', '1', '063', '7', '002', 1, ''),
(332, '', '0277', '', '3. manifest nadrealizma 1924., 1930., 1942.', '', '197', '064', '8', '002', 1, ''),
(333, '', '0278', '', 'Anatomy For the Artist', '', '1', '001', '743', '002', 1, ''),
(334, '', '0279', '', 'Naša azbuka i njene norme', '', '199', '065', '003', '001', 1, ''),
(335, '', '0280', '', 'The human figure by Albrecht Durer', '', '200', '066', '743', '003', 1, ''),
(336, '', '0281', '', 'Ceramics materials for inspirational design', '', '201', '067', '738', '003', 1, ''),
(337, '', '0282', '', 'Biblioteka u dvadeset prvom veku', '', '202', '068', '02', '002', 1, ''),
(338, '', '0283', '', 'Menadžment i umetnost', '', '203', '068', '005', '002', 1, ''),
(339, '', '0284', '', 'Upravljanje marketingom i informaciona tehnologija', '', '204', '068', '658', '002', 1, ''),
(340, '', '0285', '', 'Marketing u kulturi i umetnosti', '', '205', '068', '339', '001', 1, ''),
(341, '', '0286', '', 'Prirodna bogatstva zemlje', '', '206', '063', '502', '002', 1, ''),
(342, '', '0287', '', 'Buka - psihofiziološke posledice', '', '1', '010', '614', '002', 1, ''),
(344, '', '0289', '', 'Optimalno upravljanje sistemima sa kašnjenjem u procesnoj industriji', '', '207', '050', '66', '002', 1, ''),
(345, '', '0290', '', 'Informatika', '', '1', '069', '007', '002', 1, ''),
(347, '', '0292', '', 'Osnove opšte sociologije', '', '209', '070', '316', '002', 1, ''),
(348, '', '0293', '', 'Informacioni sistemi', '', '210', '071', '007', '002', 1, ''),
(349, '', '0294', '', 'Srednjevekovni nakit', '', '211', '072', '904', '002', 1, ''),
(350, '', '0295', '', 'Metodologija naučnih istraživanja', '', '1', '010', '001', '002', 1, ''),
(351, '', '0296', '', 'Mediji i e-obrazovanje', '', '212', '073', '005', '002', 1, ''),
(353, '', '0298', '', 'Funkcionalnost zelenih površina', '', '1', '074', '712', '002', 1, ''),
(354, '', '0299', '', 'Vojnotehnički časopis: naučni časopis', '', '1', '075', '050', '002', 1, ''),
(355, '', '0300', '', 'Menadzment procesima', '', '213', '071', '005', '002', 1, ''),
(356, '', '0301', '', 'Fleksibilna automatizacija', '', '1', '071', '621', '002', 1, ''),
(357, '', '0302', '', 'Osnovi metrologije', '', '214', '071', '006', '002', 1, ''),
(358, '', '0303', '', 'Vodič za menadžere kvaliteta', '', '1', '071', '005', '002', 1, ''),
(359, '', '0304', '', 'Mapiranje poslovnih procesa', '', '1', '071', '005', '002', 1, ''),
(360, '', '0305', '', 'Podrška odluèivanju u razvoju CIM sistema DSS/CIM', '', '210', '071', '65', '002', 1, ''),
(361, '', '0306', '', 'Liderstvo: ključ za efektivno upravljanje promenama', '', '1', '071', '005', '002', 1, ''),
(362, '', '0307', '', 'Menadžment proizvodnim i informaciono komunikacionim tehnologijama', '', '1', '071', '001', '002', 1, ''),
(363, '', '0308', '', 'Instrumentalne metode u keramici', '', '215', '033', '620', '001', 1, ''),
(364, '', '0309', '', 'Repetitori više matematike 4', '', '216', '049', '51', '002', 1, ''),
(365, '', '0310', '', 'Uspeh ne dolazi slučajno', '', '217', '019', '17', '002', 1, ''),
(366, '', '0311', '', 'Praktikum iz programiranja', '', '1', '054', '004', '002', 1, ''),
(367, '', '0312', '', 'Razvoj softverske podrške za upravljanje proizvodnjom', '', '187', '054', '658', '002', 1, ''),
(368, '', '0313', '', 'Menadžment ljudska strana', '', '1', '044', '005', '002', 1, ''),
(369, '', '0314', '', 'Praktikum iz menadžmenta razvojno investicionim projektima', '', '187', '054', '005', '001', 1, ''),
(370, '', '0315', '', 'Zbirka zadataka iz matematike', '', '219', '001', '51', '002', 1, ''),
(371, '', '0316', '', 'Moderna algebra', '', '220', '040', '512', '002', 1, ''),
(373, '', '0318', '', 'Kvantitativna hemijska analiza', '', '221', '033', '54', '002', 1, ''),
(374, '', '0319', '', 'Opšta sociologija', '', '222', '039', '316', '002', 1, ''),
(375, '', '0320', '', 'Direktive EU o vodama', '', '1', '076', '502', '002', 1, ''),
(376, '', '0321', '', 'Svet keramike 1974-1994', '', '223', '060', '061', '002', 1, ''),
(377, '', '0322', '', 'Teorijski osnovi analitičke hemije', '', '224', '040', '543', '002', 1, ''),
(378, '', '0323', '', 'Osnovi hemije', '', '225', '040', '54', '002', 1, ''),
(379, '', '0324', '', 'Opšta hemija', '', '226', '040', '54', '002', 1, ''),
(381, '', '0326', '', 'Uvod u zaštitu životne sredine', '', '227', '077', '502', '002', 1, ''),
(382, '', '0327', '', 'Umetnik - Nove teme i ideje, srpska keramika posle 2000.', '', '228', '078', '7', '002', 1, ''),
(383, '', '0328', '', 'Otpadne vode, komunalni čvrsti otpad i opasan otpad', '', '1', '041', '628', '002', 1, ''),
(384, '', '0329', '', 'Umetnik - Nove teme i ideje, srpska keramika posle 2000.', '', '228', '078', '7', '001', 1, ''),
(385, '', '0330', '', '13. trijenale keramike', '', '1', '078', '7', '001', 1, ''),
(386, '', '0331', '', '14. trijenale keramike', '', '1', '078', '7', '002', 1, ''),
(387, '', '0332', '', 'XI trijenale savremene umetničke keramike', '', '1', '078', '7', '002', 1, ''),
(388, '', '0333', '', 'Savremeni materijali u zaštiti spomenika kulture', '', '229', '080', '691', '002', 1, ''),
(389, '', '0334', '', 'CorelDRAW za Windows', '', '230', '047', '004', '002', 1, ''),
(390, '', '0335', '', 'Problemi društvene strukture', '', '231', '081', '316', '002', 1, ''),
(391, '', '0336', '', 'Ekonomika turizma', '', '232', '082', '338', '002', 1, ''),
(392, '', '0337', '', '13. trijenale keramike', '', '1', '078', '7', '002', 1, ''),
(395, '', '0340', '', 'Informatičke tehnologije u zaštiti životne sredine', '', '1', '033', '004', '002', 1, ''),
(397, '', '0342', '', 'Zaštita životne sredine', '', '184', '033', '502', '002', 1, ''),
(400, '', '0345', '', 'Ekologija i zaštita životne sredine', '', '233', '008', '502', '002', 1, ''),
(401, '', '0346', '', '3rd International Conference "Harmony of nature and spirituality in stone"', '', '1', '083', '691', '002', 1, ''),
(403, '', '0348', '', '1th International Conference "Harmony of nature and spirituality in stone"', '', '1', '083', '691', '002', 1, ''),
(404, '', '0349', '', '2nd International Conference "Harmony of nature and spirituality in stone"', '', '1', '083', '691', '002', 1, ''),
(406, '', '0351', '', 'Kadrovska raskršća srpskog agrara', '', '234', '084', '63', '002', 1, ''),
(408, '', '0353', '', 'Integrisani menadžment sistemi u funkciji razvoja preduzeća', '', '235', '085', '005', '002', 1, ''),
(409, '', '0354', '', 'Integrisani menadžment sistemi u funkciji razvoja preduzeća', '', '235', '001', '005', '001', 1, ''),
(410, '', '0355', '', 'Razvojni aspekti turističke delatnosti', '', '236', '085', '338', '001', 1, ''),
(412, '', '0357', '', 'Lavirint menadžmenta', '', '234', '085', '005', '002', 1, ''),
(414, '', '0359', '', 'Priroda hemijske veze i struktura molekula', '', '1', '001', '54', '002', 1, ''),
(416, '', '0361', '', 'U svetlu Mendeljejeva', '', '1', '020', '54', '002', 1, ''),
(417, '', '0362', '', 'Naučnik i pronalazač', '', '1', '087', '66', '002', 1, ''),
(418, '', '0363', '', 'Nobelova nagrada za hemiju u XX veku', '', '1', '020', '54', '002', 1, ''),
(419, '', '0364', '', 'U svetlu Mendeljejeva', '', '021', '020', '54', '002', 1, ''),
(420, '', '0365', '', 'Primenjena petrografija: svojstva i primena kamena', '', '237', '038', '552', '002', 1, ''),
(421, '', '0366', '', 'Menadžerska sredstva i alati u funkciji regionalnog razvoja Srbije', '', '238', '088', '332', '002', 1, ''),
(422, '', '0367', '', 'Eksploatacija, ispitivanje i primena arhitektonskog kamena', '', '239', '089', '553', '001', 1, ''),
(425, '', '0370', '', 'Osnovi upravljanja', '', '236', '090', '005', '002', 1, ''),
(434, '', '0379', '', 'Slikarska tehnologija', '', '240', '091', '75', '002', 1, ''),
(438, '', '0383', '', 'Principi menadžmenta', '', '241', '092', '005', '002', 1, ''),
(440, '', '0385', '', 'Poljoprivreda, turizam i saobraćaj u funkciji privrednog razvoja', '', '236', '085', '63', '002', 1, ''),
(441, '', '0386', '', 'Faktori regionalnog i lokalnog ekonomskog razvoja', '', '236', '085', '332', '002', 1, ''),
(442, '', '0387', '', 'Ekonomska efektivnost upravljanja ljudskim resursima', '', '234', '085', '005', '002', 1, ''),
(443, '', '0388', '', 'Menadžment zadovoljstvom i motivacijom u zdravstvenim ustanovama', '', '242', '085', '005', '002', 1, ''),
(444, '', '0389', '', 'Kontrola kvaliteta mineralne vode primenom instrumentalnih metoda', '', '243', '015', '001.8', '002', 1, ''),
(445, '', '0390', '', 'Integralno upravljanje čvrstim otpadom', '', '244', '015', '001.8', '001', 1, ''),
(446, '', '0391', '', 'Kontrola kvaliteta vode za piće u Institutu za javno zdravlje - Kragujevac', '', '245', '015', '001.8', '002', 1, ''),
(447, '', '0392', '', 'Energetska efikasnost u zgradarstvu', '', '246', '015', '001.8', '002', 1, ''),
(448, '', '0393', '', 'Značaj kontrole vode sa javnih česmi na teritoriji grada Zaječara', '', '247', '015', '001.8', '002', 1, ''),
(449, '', '0394', '', 'Uticaj radioaktivnog otpada na životnu sredinu', '', '248', '015', '001.8', '002', 1, ''),
(450, '', '0395', '', 'Uloga reciklaže u zbrinjavanju komunalno čvrstog otpada na teritoriji grada Kragujevca', '', '249', '015', '001.8', '002', 1, ''),
(451, '', '0396', '', 'Osnove tehnologije prečišćavanja otpadnih voda', '', '250', '050', '628', '002', 1, ''),
(453, '', '0398', '', 'Osnovi tehnologije keramike I i II', '', '1', '033', '666', '002', 1, ''),
(454, '', '0399', '', 'Priručnik za izradu lokalnog ekološkog plana', '', '1', '093', '502', '002', 1, ''),
(455, '', '0400', '', 'Metode odvajanja supstanci', '', '251', '033', '001.8', '001', 1, ''),
(456, '', '0401', '', 'Tehnološki postupak proizvodnje "Guarane mojito"', '', '252', '015', '001.8', '002', 1, ''),
(457, '', '0402', '', 'Membranski procesi - reverzna osmoza u procsima prečišćavanja otpadnih voda', '', '221', '015', '001.8', '002', 1, ''),
(458, '', '0403', '', 'Prečišćavanje otpadnih voda', '', '253', '015', '001.8', '002', 1, ''),
(459, '', '0404', '', 'Tehnološki proces proizvodnje vode za piće BVK - pogon "Makiš"', '', '254', '015', '001.8', '002', 1, ''),
(460, '', '0405', '', 'Kontrola kvaliteta životne sredine', '', '255', '015', '504', '002', 1, ''),
(461, '', '0406', '', 'Eko fizika', '', '256', '015', '574', '002', 1, ''),
(463, '', '0408', '', 'Tehnologija umetničke keramike', '', '257', '091', '666', '002', 1, ''),
(465, '', '0410', '', 'Čovek i saobraćajna buka', '', '258', '094', '614', '002', 1, ''),
(467, '', '0412', '', 'Turizam i održivi razvoj', '', '259', '036', '338', '002', 1, ''),
(470, '', '0414', '', 'Fizička hemija, zbirka zadataka', '', '1', '050', '54', '002', 1, ''),
(472, '', '0416', '', 'Mycrobacterium tuberculosis - Uticaj na zdravlje ljudi', '', '260', '015', '001.8', '002', 1, ''),
(474, '', '0417', '', 'Završni rad: Trbušni tifus', '', '261', '015', '001.8', '002', 1, ''),
(475, '', '0418', '', 'Završni rad: Polne bolesti - uticaj na mlade', '', '262', '015', '001.8', '002', 1, ''),
(476, '', '0419', '', 'Završni rad: Oksidacioni proces prečišćavanja otpadne vode', '', '263', '015', '001.8', '002', 1, ''),
(477, '', '0420', '', 'Završni rad: Identifikacija zagađivača, izvora zagađivanja i zagađujućih materija...', '', '264', '015', '001.8', '002', 1, ''),
(478, '', '0421', '', 'Završni rad: Uticaj motornih ulja na emisiju štetnih gasova', '', '265', '015', '001.8', '002', 1, ''),
(479, '', '0422', '', 'Završni rad', '', '266', '015', '001.8', '002', 1, ''),
(480, '', '0423', '', 'Završni rad: Niskoenergetske kuće', '', '267', '015', '001.8', '002', 1, ''),
(481, '', '0424', '', 'Završni rad: Herbicidi - potencijalni zagađivači životne sredine', '', '268', '015', '001.8', '002', 1, ''),
(482, '', '0425', '', 'Završni rad: Izgradnja egipatskih piramida', '', '269', '015', '001.8', '002', 1, ''),
(483, '', '0426', '', 'Završni rad: Keramičke pločice - tehnologija, osobine, dizajn', '', '270', '015', '001.8', '002', 1, ''),
(484, '', '0427', '', 'Završni rad: Dragica Gavrilovski', '', '271', '015', '001.8', '002', 1, ''),
(485, '', '0428', '', 'Završni rad: Procedne vode deponije Kraljevo', '', '272', '015', '001.8', '002', 1, ''),
(486, '', '0429', '', 'Završni rad: Zagađenost vazduha poreklom od saobraćaja', '', '273', '015', '001.8', '002', 1, ''),
(487, '', '0430', '', 'Završni rad: Elektromagnetno zračenje i životna sredina', '', '274', '015', '001.8', '002', 1, ''),
(488, '', '0431', '', 'Završni rad: Lokalna zajednica i odživi razvoj', '', '275', '015', '001.8', '002', 1, ''),
(489, '', '0432', '', 'Završni rad: Pasivne kuće', '', '276', '015', '001.8', '002', 1, ''),
(490, '', '0433', '', 'Završni rad: Herbicidi - potencijalni zagađivači voda i vodotokova', '', '277', '015', '001.8', '002', 1, ''),
(491, '', '0434', '', 'Završni rad: Toksikološki efekti - Efekti metala - Toksični metali u životnoj sredini', '', '278', '015', '001.8', '002', 1, ''),
(492, '', '0435', '', 'Završni rad: UV zraci i njihov uticaj na čoveka', '', '279', '015', '001.8', '002', 1, ''),
(493, '', '0436', '', 'Toksikologija fenolnih komponenti', '', '280', '015', '001.8', '002', 1, ''),
(494, '', '0437', '', 'Osnove životne sredine (priručnik za spremanje i izradu testova)', '', '184', '015', '502', '002', 1, ''),
(497, '', '0440', '', 'Reciklaža otpadnog materijala u proizvodnji opekarskih proizvoda', '', '281', '015', '001.8', '002', 1, ''),
(498, '', '0441', '', 'Reciklaža stakla', '', '282', '015', '001', '002', 1, ''),
(499, '', '0442', '', 'Ergonomija u službi dizajna', '', '283', '015', '001.8', '002', 1, ''),
(500, '', '0443', '', 'Secesija, Antoni Gaudi', '', '284', '015', '001.8', '002', 1, ''),
(501, '', '0444', '', 'Zbrinjavanje papirnog i kartonskog otpada i njegova reciklaža u gradu Kraljevu', '', '285', '015', '001.8', '002', 1, ''),
(502, '', '0445', '', 'Uticaj železničkog saobraćaja na životnu sredinu', '', '286', '015', '001.8', '002', 1, ''),
(503, '', '0446', '', 'Železnički transport opasnih materija', '', '287', '015', '001.8', '002', 1, ''),
(504, '', '0447', '', 'Bezbednost drumskog saobraćaja sa osvrtom na Smederevsku Palanku', '', '288', '015', '001.8', '002', 1, ''),
(505, '', '0448', '', 'Reciklaža elektronskog otpada', '', '289', '015', '001.8', '002', 1, ''),
(506, '', '0449', '', 'Unikatne dekorativne JJ lampe', '', '290', '015', '001.8', '002', 1, ''),
(508, '', '0450', '', 'Društvena hronika, moda, stil i odevanje', '', '291', '015', '001.8', '002', 1, ''),
(509, '', '0451', '', 'Termoizolacioni materijali', '', '292', '015', '001.8', '002', 1, ''),
(510, '', '0452', '', 'Uticaj viskoziteta i karakteristika mreže na rad pumpnog agregata', '', '293', '015', '001.8', '002', 1, ''),
(511, '', '0453', '', 'Primena Bernulijeve jednačine na transport realnog fluida kod složenog cevovoda', '', '294', '015', '001.8', '002', 1, ''),
(512, '', '0454', '', 'Određivanje fenolnih komponenti u pitkim i otpadnim vodama i vodotokovima', '', '295', '015', '001.8', '002', 1, ''),
(513, '', '0455', '', 'Školjke kao inspiracija', '', '296', '015', '001.8', '002', 1, ''),
(514, '', '0456', '', 'Ornament, njegov razvoj i uticaj na svetsku kulturu', '', '297', '015', '001.8', '002', 1, ''),
(515, '', '0457', '', 'Farmakološko toksikološki efekti hroma i organohromnih jedinjenja', '', '298', '015', '001.8', '002', 1, ''),
(516, '', '0458', '', 'HIV virus', '', '299', '015', '001.8', '002', 1, ''),
(517, '', '0459', '', 'Metode i postupci prečišćavanja otpadnih voda - biološko prečišćavanje', '', '300', '015', '001.8', '002', 1, ''),
(518, '', '0460', '', 'Saobraćajna buka na području opštine Aranđelovac', '', '301', '015', '001.8', '002', 1, ''),
(519, '', '0461', '', 'Toksikologija fosfora i organofosfornih jedinjenja', '', '302', '015', '001.8', '002', 1, ''),
(520, '', '0462', '', 'Toksični efekti metala - toksični efekti metala koji ulaze u sastav lekova', '', '303', '015', '001.8', '002', 1, ''),
(521, '', '0463', '', 'Uticaj modifikovanih silana na osobine fasadnih boja', '', '304', '015', '001.8', '002', 1, ''),
(522, '', '0464', '', 'Membranski procesi u prečišćavanju otpadnih voda', '', '305', '015', '001.8', '002', 1, ''),
(523, '', '0465', '', 'Hidrične epidemije', '', '306', '015', '001.8', '002', 1, ''),
(524, '', '0466', '', 'Instrumentalne metode u analitici pitkih voda', '', '307', '015', '001.8', '002', 1, ''),
(525, '', '0467', '', 'Toksikologija organofosfornih jedinjenja', '', '308', '015', '001.8', '002', 1, ''),
(526, '', '0468', '', 'Oligoelementi - elementi života', '', '309', '015', '001.8', '002', 1, ''),
(527, '', '0469', '', 'Mogućnost primene RFID tehnologije na Visokoj tehnološkoj školi strukovnih studija u Aranđelovcu', '', '310', '015', '001.8', '002', 1, ''),
(528, '', '0470', '', 'Kolorimetrijska merenja u ekologiji', '', '311', '015', '001.8', '002', 1, ''),
(529, '', '0471', '', 'Primena informatičkih tehnolog. u merenju, obradi i prikazu rezultata kvaliteta vode u rekama P. iK.', '', '312', '015', '001.8', '002', 1, ''),
(530, '', '0472', '', 'Dokazivanje, toksičnost, određivanje nervnih otrova', '', '313', '015', '001.8', '002', 1, ''),
(531, '', '0473', '', 'Crnkinje, afrička plemena i verovanja', '', '314', '015', '001.8', '002', 1, ''),
(532, '', '0474', '', 'Reverzna osmoza i membranski, separacioni postupci prečišćavanja pitkih i otpadnih voda', '', '315', '015', '001.8', '002', 1, ''),
(533, '', '0475', '', 'Analiza i standardi kvaliteta - odlike stonih mineralnih voda', '', '316', '015', '001.8', '002', 1, ''),
(534, '', '0476', '', 'Toksični efekti metala', '', '317', '015', '001.8', '002', 1, ''),
(535, '', '0477', '', 'Spektroskopija i spektrografija tragova elemenata (emisione optičke metode)', '', '318', '015', '001.8', '002', 1, ''),
(536, '', '0478', '', 'Elektrohemijski reaktori u procesu prečišćavanja vode', '', '319', '015', '001.8', '002', 1, ''),
(537, '', '0479', '', 'Korišćenje otpada kao sekundarne sirovine - reciklaža plastike', '', '320', '015', '001.8', '002', 1, ''),
(538, '', '0480', '', 'Analiza i strategija borbe protiv buke u gradu Valjevu', '', '321', '015', '001.8', '002', 1, ''),
(539, '', '0481', '', 'Toksikologija nikla i njegovih jedinjenja (istraživanje)', '', '322', '015', '001.8', '002', 1, ''),
(540, '', '0482', '', 'Nuklearni reaktori i životna sredina', '', '323', '015', '001.8', '002', 1, ''),
(541, '', '0483', '', 'Čajnici i upotrebni predmeti koji se koriste u ceremoniji čaja', '', '324', '015', '001.8', '002', 1, ''),
(542, '', '0484', '', 'Zaštita šuma od požara na teritoriji opštine Despotovac', '', '325', '015', '001.8', '002', 1, ''),
(543, '', '0485', '', 'Značaj prečišćavanja industrijskih otpadnih voda za zaštitu vodotokova - prečišć. otp. voda preh.ind', '', '326', '015', '001.8', '002', 1, ''),
(544, '', '0486', '', 'Mogućnost adsorpcije nepoželjnih gasova u prirodnim vodama', '', '327', '015', '001.8', '002', 1, ''),
(545, '', '0487', '', 'Nuklearna-magnetna rezonantna (NMR) spektroskopija', '', '328', '015', '001.8', '002', 1, ''),
(546, '', '0488', '', 'Separaciona gasna hromatografija', '', '329', '015', '001.8', '002', 1, ''),
(547, '', '0489', '', 'Organske toksične supstance u vodama', '', '330', '015', '001.8', '002', 1, ''),
(548, '', '0490', '', 'Kontrola vode za piće fizičko-hemijska i mikrobiološka', '', '331', '015', '001.8', '002', 1, ''),
(550, '', '0492', '', 'Anaerobna digestija otpadnog mulja i monitoring procesa', '', '333', '015', '001.8', '002', 1, ''),
(551, '', '0493', '', 'Čajnik - objekat u funkciji pripovedanja', '', '334', '015', '001.8', '002', 1, ''),
(552, '', '0494', '', 'Elektro-automobil kroz istoriju i njegovu budućnost', '', '335', '015', '001.8', '002', 1, ''),
(553, '', '0495', '', 'Priprema vode za industrijske potrebe', '', '336', '015', '001.8', '002', 1, ''),
(554, '', '0496', '', 'Kolometrijsko merenje pH vrednosti', '', '337', '015', '001.8', '002', 1, ''),
(555, '', '0497', '', 'Kolometrijska merenja u zaštiti životne sredine', '', '338', '015', '001.8', '002', 1, ''),
(556, '', '0498', '', 'Kolorimetrijska merenja u ekologiji i zaštiti životne sredine', '', '339', '015', '001.8', '002', 1, ''),
(557, '', '0499', '', 'Procesi dobijanja šupljeg bloka u ciglarskoj industriji', '', '340', '015', '001.8', '002', 1, ''),
(558, '', '0500', '', 'Uticaj globalnog zagrevanja na poljoprivrednu proizvodnju', '', '341', '015', '001.8', '002', 1, ''),
(559, '', '0501', '', 'Oplemenjivanje životne sredine opštine Aranđelovac', '', '184', '095', '502', '002', 1, ''),
(561, '', '0503', '', 'Monitoring životne sredine i orživi razvoj', '', '342', '015', '001.8', '002', 1, ''),
(562, '', '0504', '', 'Genetski modifikovana hrana - uticaj na zdravlje ljudi i životnu sredinu', '', '343', '015', '001.8', '002', 1, ''),
(563, '', '0505', '', 'Hochspannung (Visoki napon)', '', '1', '096', '621.3', '008', 1, ''),
(564, '', '0506', '', 'Konstrukcija delova mašina', '', '344', '001', '621.8', '004', 1, ''),
(566, '', '0508', '', 'Pesticidi - uticaj na zdravlje ljudi', '', '345', '015', '001.8', '002', 1, ''),
(567, '', '0509', '', 'Važeća domaća i međunarodna regulativa u oblasti upravljanja otpadom', '', '346', '015', '001.8', '002', 1, ''),
(568, '', '0510', '', 'Teorija forme', '', '347', '008', '37', '002', 1, ''),
(570, '', '0512', '', 'Analitička hemija', '', '348', '015', '001.8', '002', 1, ''),
(571, '', '0513', '', 'Z.r: Hemijska analiza vode i rezultati istraživanja', '', '349', '015', '001.8', '002', 1, ''),
(572, '', '0514', '', 'Z.r: Model opštinskog informacionog sistema za upravljaje čvrstim otpadom sa akcentom na ruralni deo', '', '350', '015', '001.8', '002', 1, ''),
(573, '', '0515', '', 'Z.r: Skladištenje i transport opasnih materija u REIK KOLUBARA', '', '351', '015', '001.8', '002', 1, ''),
(574, '', '0516', '', 'Z.r: Određivanje alkalnih metala u pitkim i otpadnim vodama', '', '352', '015', '001.8', '002', 1, ''),
(575, '', '0517', '', 'Z.r: Određivanje fenolnih komponenti u otpadnim vodama', '', '353', '015', '001.8', '002', 1, ''),
(576, '', '0518', '', 'Z.r: Uticaj buke od drumskog i železničkog saobraćaja na stanovnike Mladenovc', '', '354', '015', '001.8', '002', 1, ''),
(577, '', '0519', '', 'Završni rad: Reciklaža električnog otpada', '', '355', '015', '001.8', '002', 1, ''),
(578, '', '0520', '', 'Završni rad: Primena separacionih metoda za primenu vode za piće', '', '356', '015', '001.8', '002', 1, '');

-- --------------------------------------------------------

--
-- Table structure for table `knjige_praksa`
--

CREATE TABLE `knjige_praksa` (
  `ID` int(11) NOT NULL,
  `InventarniBroj` varchar(40) DEFAULT NULL,
  `UDKBroj` varchar(30) NOT NULL,
  `ISBNBroj` varchar(30) NOT NULL,
  `Naslov` varchar(200) DEFAULT NULL,
  `GodinaIzdanja` varchar(30) DEFAULT NULL,
  `SifraAutora` varchar(20) DEFAULT NULL,
  `SifraIzdavaca` varchar(20) DEFAULT NULL,
  `SifraKategorije` varchar(20) DEFAULT NULL,
  `SifraJezika` varchar(20) DEFAULT NULL,
  `Stanje` int(11) DEFAULT NULL,
  `Napomena` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `prijavljivanje`
--

CREATE TABLE `prijavljivanje` (
  `ID` int(11) NOT NULL,
  `KorisnickoIme` varchar(30) DEFAULT NULL,
  `Lozinka` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `prijavljivanje`
--

INSERT INTO `prijavljivanje` (`ID`, `KorisnickoIme`, `Lozinka`) VALUES
(2, 'Dragana', 'vtsbiblioteka'),
(3, 'studenti', '1'),
(4, 'praksa', 'vtspraksa2017');

-- --------------------------------------------------------

--
-- Table structure for table `statistika`
--

CREATE TABLE `statistika` (
  `ID` int(11) NOT NULL,
  `UDKBroj` varchar(20) DEFAULT NULL,
  `BrojIznajmljivanja` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `zaduzivanje_knjiga`
--

CREATE TABLE `zaduzivanje_knjiga` (
  `ID` int(11) NOT NULL,
  `ClanskaKarta` varchar(30) DEFAULT NULL,
  `UDKBroj` varchar(30) DEFAULT NULL,
  `DatumZaduzivanja` varchar(30) DEFAULT NULL,
  `DatumVracanja` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `autori`
--
ALTER TABLE `autori`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Sifra` (`Sifra`);

--
-- Indexes for table `autori_praksa`
--
ALTER TABLE `autori_praksa`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Sifra` (`Sifra`);

--
-- Indexes for table `clanovi`
--
ALTER TABLE `clanovi`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `ClanskaKarta` (`ClanskaKarta`);

--
-- Indexes for table `izdavaci`
--
ALTER TABLE `izdavaci`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Sifra` (`Sifra`);

--
-- Indexes for table `izdavaci_praksa`
--
ALTER TABLE `izdavaci_praksa`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Sifra` (`Sifra`);

--
-- Indexes for table `jezik`
--
ALTER TABLE `jezik`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Sifra` (`Sifra`);

--
-- Indexes for table `kategorije`
--
ALTER TABLE `kategorije`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Šifra` (`Sifra`);

--
-- Indexes for table `kategorije_praksa`
--
ALTER TABLE `kategorije_praksa`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Sifra` (`Sifra`);

--
-- Indexes for table `knjige`
--
ALTER TABLE `knjige`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `UDKBroj` (`UDKBroj`);

--
-- Indexes for table `knjige_praksa`
--
ALTER TABLE `knjige_praksa`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `InventarniBroj` (`InventarniBroj`);

--
-- Indexes for table `prijavljivanje`
--
ALTER TABLE `prijavljivanje`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `KorisnickoIme` (`KorisnickoIme`);

--
-- Indexes for table `statistika`
--
ALTER TABLE `statistika`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `zaduzivanje_knjiga`
--
ALTER TABLE `zaduzivanje_knjiga`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `autori`
--
ALTER TABLE `autori`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=357;
--
-- AUTO_INCREMENT for table `autori_praksa`
--
ALTER TABLE `autori_praksa`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `clanovi`
--
ALTER TABLE `clanovi`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `izdavaci`
--
ALTER TABLE `izdavaci`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=97;
--
-- AUTO_INCREMENT for table `izdavaci_praksa`
--
ALTER TABLE `izdavaci_praksa`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `jezik`
--
ALTER TABLE `jezik`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `kategorije`
--
ALTER TABLE `kategorije`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=85;
--
-- AUTO_INCREMENT for table `kategorije_praksa`
--
ALTER TABLE `kategorije_praksa`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `knjige`
--
ALTER TABLE `knjige`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=579;
--
-- AUTO_INCREMENT for table `knjige_praksa`
--
ALTER TABLE `knjige_praksa`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `prijavljivanje`
--
ALTER TABLE `prijavljivanje`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `statistika`
--
ALTER TABLE `statistika`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `zaduzivanje_knjiga`
--
ALTER TABLE `zaduzivanje_knjiga`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
