-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 07, 2017 at 08:13 AM
-- Server version: 10.1.25-MariaDB
-- PHP Version: 7.1.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fingerprintvb`
--

-- --------------------------------------------------------

--
-- Table structure for table `candidatedb`
--

CREATE TABLE `candidatedb` (
  `id` int(255) NOT NULL,
  `residenceID` int(255) NOT NULL,
  `houseNumber` varchar(255) NOT NULL,
  `name` varchar(500) NOT NULL,
  `sex` varchar(11) NOT NULL,
  `dateOfBorn` date NOT NULL,
  `dzongkhag` varchar(255) NOT NULL,
  `constituency` varchar(255) NOT NULL,
  `gewog` varchar(255) NOT NULL,
  `village` varchar(255) NOT NULL,
  `photo` mediumblob NOT NULL,
  `voteCount` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `voterdb`
--

CREATE TABLE `voterdb` (
  `id` int(255) NOT NULL,
  `fpIndex` int(1) NOT NULL,
  `residenceID` int(255) NOT NULL,
  `houseNumber` varchar(255) NOT NULL,
  `name` varchar(500) NOT NULL,
  `sex` varchar(11) NOT NULL,
  `dateOfBorn` date NOT NULL,
  `dzongkhag` varchar(255) NOT NULL,
  `constituency` varchar(255) NOT NULL,
  `gewog` varchar(255) NOT NULL,
  `village` varchar(255) NOT NULL,
  `pollingStation` varchar(255) NOT NULL,
  `photo` mediumblob NOT NULL,
  `fingerPrintTemplate` longtext NOT NULL,
  `voteStatus` int(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `candidatedb`
--
ALTER TABLE `candidatedb`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `voterdb`
--
ALTER TABLE `voterdb`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `candidatedb`
--
ALTER TABLE `candidatedb`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `voterdb`
--
ALTER TABLE `voterdb`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
