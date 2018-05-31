-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Czas generowania: 22 Maj 2018, 21:03
-- Wersja serwera: 10.1.21-MariaDB
-- Wersja PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Baza danych: ` electronicstore_projekt`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `customer`
--

CREATE TABLE `customer` (
  `ID` int(11) NOT NULL,
  `login` varchar(60) COLLATE utf8_polish_ci NOT NULL,
  `password` varchar(60) COLLATE utf8_polish_ci NOT NULL,
  `creationDate` datetime NOT NULL,
  `lastLoginDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `customer`
--

INSERT INTO `customer` (`ID`, `login`, `password`, `creationDate`, `lastLoginDate`) VALUES
(1, 'zenon_martyniuk', 'zenontoja', '2017-07-18 05:17:40', '2018-05-06 17:17:16'),
(2, 'TADZ!K', 'hrumhrum', '2017-09-13 09:19:38', '2018-05-15 10:19:24'),
(3, 'Greenpike', 'zaq1', '2016-07-15 18:35:24', '2018-04-12 13:44:29'),
(4, 'Premultex', 'password123', '2018-04-28 21:52:53', '2018-05-23 14:39:59'),
(5, 'BrainyMint', 'love<3Mint', '2018-05-21 23:15:08', '2018-05-23 05:12:18'),
(6, 'BeLike', 'barackobama', '2016-11-23 15:13:16', '2018-05-15 12:24:35'),
(7, 'Rectorbac', '4mePlace', '2017-11-09 10:28:41', '2018-05-04 15:23:30'),
(8, 'CaptainGino', 'xxx1123xxx', '2017-01-25 11:42:34', '2018-04-11 15:16:34');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `lap_modele`
--

CREATE TABLE `lap_modele` (
  `ID` int(11) NOT NULL,
  `productID` int(11) NOT NULL,
  `weight` float NOT NULL,
  `ram` int(11) NOT NULL,
  `storage` int(11) NOT NULL,
  `clockRate` float NOT NULL,
  `cores` int(11) NOT NULL,
  `externalGraphic` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `lap_modele`
--

INSERT INTO `lap_modele` (`ID`, `productID`, `weight`, `ram`, `storage`, `clockRate`, `cores`, `externalGraphic`) VALUES
(2, 1, 1.69, 4, 1024, 2.4, 2, 0),
(3, 2, 1.72, 8, 1024, 2.5, 2, 0),
(4, 3, 2.62, 8, 1024, 2.5, 4, 1),
(5, 4, 1.3, 8, 512, 2.6, 2, 0),
(6, 5, 2, 4, 1024, 2, 2, 1),
(7, 6, 4.42, 32, 1024, 2.9, 4, 1),
(8, 7, 4.56, 32, 1024, 2.9, 6, 1),
(9, 8, 4.56, 32, 1024, 2.9, 4, 1),
(10, 9, 1.83, 16, 512, 2.9, 4, 1),
(11, 10, 1.83, 16, 512, 3.1, 4, 1),
(12, 11, 4.85, 16, 1024, 2.9, 4, 1),
(13, 12, 2.43, 16, 1024, 2.2, 6, 1);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `product`
--

CREATE TABLE `product` (
  `ID` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `producer` enum('Lenovo','HP','DELL','Toshiba','MSI','ASUS','SAMSUNG','NOKIA','HTC','Apple','XIAOMI') COLLATE utf8_polish_ci NOT NULL,
  `productModel` varchar(100) COLLATE utf8_polish_ci NOT NULL,
  `productType` enum('laptop','smartfon','','') COLLATE utf8_polish_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `product`
--

INSERT INTO `product` (`ID`, `price`, `producer`, `productModel`, `productType`) VALUES
(1, 2099, 'Lenovo', ' IdeaPad 320S', 'laptop'),
(2, 2999, 'HP', ' HP Pavilion x360', 'laptop'),
(3, 3799, 'HP', ' Omen 15-ce008nw', 'laptop'),
(4, 3299, 'ASUS', 'ZenBook Flip UX360CA', 'laptop'),
(5, 2149, 'ASUS', 'VivoBook Max', 'laptop'),
(6, 18499, 'DELL', 'Alienware 17 R4', 'laptop'),
(7, 17699, 'MSI', 'GT75 Titan', 'laptop'),
(8, 16099, 'MSI', 'GT75VR', 'laptop'),
(9, 13999, 'Apple', 'MacBook Pro 15.4 ', 'laptop'),
(10, 13349, 'Apple', 'MacBook Pro 15.4', 'laptop'),
(11, 11499, 'HP', 'Omen X 17', 'laptop'),
(12, 10199, 'MSI', 'GS73 ', 'laptop'),
(13, 598, 'XIAOMI', 'Redmi 5', 'smartfon'),
(14, 498, 'Lenovo', 'K5', 'smartfon'),
(15, 629, 'NOKIA', '5', 'smartfon'),
(16, 1949, 'NOKIA', '8', 'smartfon'),
(17, 3999, 'Apple', ' iPhone 8', 'smartfon'),
(18, 498, 'Lenovo', 'K6', 'smartfon'),
(19, 3998, 'SAMSUNG', 'Galaxy S9+', 'smartfon'),
(20, 1399, 'Apple', 'iPhone SE', 'smartfon'),
(21, 998, 'SAMSUNG', 'Galaxy J7', 'smartfon'),
(22, 1198, 'SAMSUNG', 'Galaxy A5', 'smartfon'),
(23, 1599, 'Apple', 'iPhone 6', 'smartfon'),
(24, 1399, 'Apple', 'iPhone SE', 'smartfon');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `sale`
--

CREATE TABLE `sale` (
  `ID` int(11) NOT NULL,
  `transactionID` int(11) NOT NULL,
  `productID` int(11) NOT NULL,
  `amount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `sale`
--

INSERT INTO `sale` (`ID`, `transactionID`, `productID`, `amount`) VALUES
(1, 1, 3, 1),
(2, 1, 20, 1),
(3, 1, 14, 1),
(4, 2, 9, 1),
(5, 3, 4, 5),
(6, 4, 3, 1),
(7, 4, 19, 2),
(8, 5, 7, 1),
(9, 5, 6, 1),
(10, 6, 10, 1),
(11, 7, 16, 3),
(12, 8, 24, 10),
(13, 8, 8, 10),
(14, 9, 13, 3);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `tel_modele`
--

CREATE TABLE `tel_modele` (
  `ID` int(11) NOT NULL,
  `productID` int(11) NOT NULL,
  `weight` int(11) NOT NULL,
  `ram` int(11) NOT NULL,
  `storage` int(11) NOT NULL,
  `clockRate` float NOT NULL,
  `cores` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `tel_modele`
--

INSERT INTO `tel_modele` (`ID`, `productID`, `weight`, `ram`, `storage`, `clockRate`, `cores`) VALUES
(1, 13, 157, 2, 16, 1.8, 8),
(2, 14, 142, 2, 16, 1.4, 8),
(3, 15, 130, 2, 16, 1.4, 8),
(4, 16, 151, 4, 64, 2.5, 8),
(5, 17, 148, 6, 256, 2.5, 6),
(6, 18, 140, 2, 16, 1.4, 8),
(7, 19, 189, 6, 64, 2.9, 8),
(8, 20, 113, 2, 32, 1.8, 2),
(9, 21, 181, 3, 16, 1.6, 8),
(10, 22, 159, 3, 32, 1.9, 8),
(11, 23, 129, 2, 32, 1.4, 2),
(12, 24, 113, 2, 32, 1.8, 2);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `transaction`
--

CREATE TABLE `transaction` (
  `ID` int(11) NOT NULL,
  `dateStamp` datetime NOT NULL,
  `customerID` int(11) NOT NULL,
  `finalized` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_polish_ci;

--
-- Zrzut danych tabeli `transaction`
--

INSERT INTO `transaction` (`ID`, `dateStamp`, `customerID`, `finalized`) VALUES
(1, '2018-05-09 12:19:24', 2, 0),
(2, '2018-05-13 01:04:52', 6, 1),
(3, '2018-05-12 00:19:24', 7, 1),
(4, '2018-02-05 16:25:00', 8, 1),
(5, '2018-03-07 13:17:39', 1, 1),
(6, '2018-05-11 09:08:34', 3, 0),
(7, '2018-05-22 09:00:08', 4, 1),
(8, '2018-05-10 14:19:34', 4, 1),
(9, '2018-03-06 11:17:32', 6, 1);

--
-- Indeksy dla zrzutów tabel
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `lap_modele`
--
ALTER TABLE `lap_modele`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `productID` (`productID`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `sale`
--
ALTER TABLE `sale`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `productID` (`productID`),
  ADD KEY `transactionID` (`transactionID`);

--
-- Indexes for table `tel_modele`
--
ALTER TABLE `tel_modele`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `productID` (`productID`);

--
-- Indexes for table `transaction`
--
ALTER TABLE `transaction`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `customerID` (`customerID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT dla tabeli `customer`
--
ALTER TABLE `customer`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
--
-- AUTO_INCREMENT dla tabeli `lap_modele`
--
ALTER TABLE `lap_modele`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT dla tabeli `product`
--
ALTER TABLE `product`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
--
-- AUTO_INCREMENT dla tabeli `sale`
--
ALTER TABLE `sale`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT dla tabeli `tel_modele`
--
ALTER TABLE `tel_modele`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT dla tabeli `transaction`
--
ALTER TABLE `transaction`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- Ograniczenia dla zrzutów tabel
--

--
-- Ograniczenia dla tabeli `lap_modele`
--
ALTER TABLE `lap_modele`
  ADD CONSTRAINT `lap_modele_ibfk_1` FOREIGN KEY (`productID`) REFERENCES `product` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `sale`
--
ALTER TABLE `sale`
  ADD CONSTRAINT `sale_ibfk_1` FOREIGN KEY (`transactionID`) REFERENCES `transaction` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `sale_ibfk_2` FOREIGN KEY (`productID`) REFERENCES `product` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `tel_modele`
--
ALTER TABLE `tel_modele`
  ADD CONSTRAINT `tel_modele_ibfk_1` FOREIGN KEY (`productID`) REFERENCES `product` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ograniczenia dla tabeli `transaction`
--
ALTER TABLE `transaction`
  ADD CONSTRAINT `transaction_ibfk_1` FOREIGN KEY (`customerID`) REFERENCES `customer` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
