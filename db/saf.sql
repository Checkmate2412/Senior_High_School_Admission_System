-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 07, 2018 at 03:30 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 7.0.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `research`
--

-- --------------------------------------------------------

--
-- Table structure for table `saf`
--

CREATE TABLE `saf` (
  `AdmissionNumber` int(4) NOT NULL,
  `DateofAdmission` varchar(12) NOT NULL,
  `Grade` varchar(8) NOT NULL,
  `Strand` varchar(75) NOT NULL,
  `FirstName` varchar(60) NOT NULL,
  `MiddleName` varchar(60) NOT NULL,
  `LastName` varchar(60) NOT NULL,
  `Suffix` varchar(10) NOT NULL,
  `Nickname` varchar(20) NOT NULL,
  `Gender` varchar(6) NOT NULL,
  `Religion` varchar(25) NOT NULL,
  `Nationality` varchar(25) NOT NULL,
  `CivilStatus` varchar(25) NOT NULL,
  `DateofBirth` varchar(12) NOT NULL,
  `PlaceofBirth` varchar(75) NOT NULL,
  `BirthOrder` varchar(2) NOT NULL,
  `Age` varchar(2) NOT NULL,
  `EmailAddress` varchar(40) NOT NULL,
  `ContactNumber` varchar(11) NOT NULL,
  `ApartmentHouseNoStreetBarangay` varchar(50) NOT NULL,
  `CityMunicipality` varchar(35) NOT NULL,
  `ProvinceState` varchar(35) NOT NULL,
  `Country` varchar(25) NOT NULL,
  `MothersName` varchar(50) NOT NULL,
  `MothersOccupation` varchar(40) NOT NULL,
  `MothersEmailAddress` varchar(40) NOT NULL,
  `MothersContactNumber` varchar(11) NOT NULL,
  `FathersName` varchar(50) NOT NULL,
  `FathersOccupation` varchar(40) NOT NULL,
  `FathersEmailAddress` varchar(40) NOT NULL,
  `FathersContactNumber` varchar(11) NOT NULL,
  `GuardiansName` varchar(50) NOT NULL,
  `GuardiansOccupation` varchar(40) NOT NULL,
  `GuardiansEmailAddress` varchar(40) NOT NULL,
  `GuardiansContactNumber` varchar(11) NOT NULL,
  `EstimatedTotalAnnualIncome` varchar(35) NOT NULL,
  `BrothersSistersName1` varchar(50) NOT NULL,
  `DateofBirth1` varchar(12) NOT NULL,
  `CourseOccupation1` varchar(40) NOT NULL,
  `SchoolCompany1` varchar(50) NOT NULL,
  `BrothersSistersName2` varchar(50) NOT NULL,
  `DateofBirth2` varchar(12) NOT NULL,
  `CourseOccupation2` varchar(40) NOT NULL,
  `SchoolCompany2` varchar(40) NOT NULL,
  `BrothersSistersName3` varchar(50) NOT NULL,
  `DateofBirth3` varchar(12) NOT NULL,
  `CourseOccupation3` varchar(40) NOT NULL,
  `SchoolCompany3` varchar(40) NOT NULL,
  `BrothersSistersName4` varchar(50) NOT NULL,
  `DateofBirth4` varchar(12) NOT NULL,
  `CourseOccupation4` varchar(40) NOT NULL,
  `SchoolCompany4` varchar(40) NOT NULL,
  `BrothersSistersName5` varchar(50) NOT NULL,
  `DateofBirth5` varchar(12) NOT NULL,
  `CourseOccupation5` varchar(40) NOT NULL,
  `SchoolCompany5` varchar(40) NOT NULL,
  `NameofSchool1` varchar(50) NOT NULL,
  `SchoolAddress1` varchar(75) NOT NULL,
  `YearGraduated1` varchar(4) NOT NULL,
  `HonorsAwards1` varchar(100) NOT NULL,
  `NameofSchool2` varchar(50) NOT NULL,
  `SchoolAddress2` varchar(75) NOT NULL,
  `YearGraduated2` varchar(4) NOT NULL,
  `HonorsAwards2` varchar(100) NOT NULL,
  `NameofSchool3` varchar(50) NOT NULL,
  `SchoolAddress3` varchar(75) NOT NULL,
  `YearGraduated3` varchar(4) NOT NULL,
  `HonorsAwards3` varchar(100) NOT NULL,
  `NameofSchool4` varchar(50) NOT NULL,
  `SchoolAddress4` varchar(75) NOT NULL,
  `YearGraduated4` varchar(4) NOT NULL,
  `HonorsAwards4` varchar(100) NOT NULL,
  `NameofSchool5` varchar(50) NOT NULL,
  `SchoolAddress5` varchar(75) NOT NULL,
  `YearGraduated5` varchar(4) NOT NULL,
  `HonorsAwards5` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `saf`
--

INSERT INTO `saf` (`AdmissionNumber`, `DateofAdmission`, `Grade`, `Strand`, `FirstName`, `MiddleName`, `LastName`, `Suffix`, `Nickname`, `Gender`, `Religion`, `Nationality`, `CivilStatus`, `DateofBirth`, `PlaceofBirth`, `BirthOrder`, `Age`, `EmailAddress`, `ContactNumber`, `ApartmentHouseNoStreetBarangay`, `CityMunicipality`, `ProvinceState`, `Country`, `MothersName`, `MothersOccupation`, `MothersEmailAddress`, `MothersContactNumber`, `FathersName`, `FathersOccupation`, `FathersEmailAddress`, `FathersContactNumber`, `GuardiansName`, `GuardiansOccupation`, `GuardiansEmailAddress`, `GuardiansContactNumber`, `EstimatedTotalAnnualIncome`, `BrothersSistersName1`, `DateofBirth1`, `CourseOccupation1`, `SchoolCompany1`, `BrothersSistersName2`, `DateofBirth2`, `CourseOccupation2`, `SchoolCompany2`, `BrothersSistersName3`, `DateofBirth3`, `CourseOccupation3`, `SchoolCompany3`, `BrothersSistersName4`, `DateofBirth4`, `CourseOccupation4`, `SchoolCompany4`, `BrothersSistersName5`, `DateofBirth5`, `CourseOccupation5`, `SchoolCompany5`, `NameofSchool1`, `SchoolAddress1`, `YearGraduated1`, `HonorsAwards1`, `NameofSchool2`, `SchoolAddress2`, `YearGraduated2`, `HonorsAwards2`, `NameofSchool3`, `SchoolAddress3`, `YearGraduated3`, `HonorsAwards3`, `NameofSchool4`, `SchoolAddress4`, `YearGraduated4`, `HonorsAwards4`, `NameofSchool5`, `SchoolAddress5`, `YearGraduated5`, `HonorsAwards5`) VALUES
(1, '01/04/2018', 'Grade 12', 'General Academic Strand (GAS)', 'FN', 'MN', 'LN', 'Jr.', 'Nick', 'Male', 'Roman Catholic', 'Filipino', 'Single', '11/6/1999', 'Philippines', '2', '18', 'exampleEmail@gmail.com', '09999999999', 'Example', 'Example', 'Example', 'Philippines', 'Mother', 'NA', 'NA', '099999999999', 'Father', 'NA', 'NA', '099999999999', 'sada', 'sadasds', 'asdasdas', '099999999999', '2323232', 'jaskhdjashdjk', '1/2/2018', 'asjkhdasjkdhjk', 'h', 'sadasdjkhjkhjkh', '1/2/2018', 'h', 'kh', 'asdasdjhjkhdndsmnbdas', '1/17/2018', 'jkh', 'kjh', 'sadasdadcnmsbdskfosdifiuoiu', '1/25/2018', 'jk', 'kj', 'dasdm enw,mewne,mnwe', '1/2/2018', 'hkj', 'h', 'kjshdjkhdjkdshjk', 'jh', '8927', 'sdjkfjhfjdh', 'b', 'kb', '7987', '3789hj', 'mnb', 'mnb', '2982', '7khj', 'nm', '', '7897', 'kjh', 'bkjh', 'hjkh', '2789', 'kjh'),
--
-- Indexes for dumped tables
--

--
-- Indexes for table `saf`
--
ALTER TABLE `saf`
  ADD PRIMARY KEY (`AdmissionNumber`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `saf`
--
ALTER TABLE `saf`
  MODIFY `AdmissionNumber` int(4) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
