-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 09, 2017 at 03:28 PM
-- Server version: 10.1.28-MariaDB
-- PHP Version: 7.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `alm`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_application`
--

CREATE TABLE `tbl_application` (
  `applicationid` int(11) NOT NULL,
  `companyid` int(11) NOT NULL,
  `registrationdate` varchar(50) NOT NULL,
  `annexlink` text NOT NULL,
  `loantype` varchar(255) NOT NULL,
  `loanamount` int(11) NOT NULL,
  `productid` int(11) NOT NULL,
  `loanperiod` varchar(255) NOT NULL,
  `lcaccountnumber` int(11) NOT NULL,
  `repaymentaccno` int(11) NOT NULL,
  `approvalstatus` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_application`
--

INSERT INTO `tbl_application` (`applicationid`, `companyid`, `registrationdate`, `annexlink`, `loantype`, `loanamount`, `productid`, `loanperiod`, `lcaccountnumber`, `repaymentaccno`, `approvalstatus`) VALUES
(1, 2, '0000-00-00', 'www.facebook.com', 'Type : A', 400000, 1, '5 year', 122344567, 2147483647, 'true'),
(2, 2, '0000-00-00', 'youtube.com', 'Type : A', 90000, 12, '10 year', 1223345667, 2147483647, 'true'),
(3, 2, '0000-00-00', '', '', 0, 0, 'Select period', 0, 0, 'true'),
(4, 1, '0000-00-00', 'nigga.com', 'Type : A', 67162, 23, '10 year', 1231234, 123123123, 'true'),
(5, 2, '07-Dec-17', 'yobaby.com', 'Type : A', 1233345, 69, '20 year', 1233445677, 123344567, 'true'),
(6, 2, '07-Dec-17', 'dfdsfadsf', 'Type : A', 2123, 2, '20 year', 2147483647, 2147483647, 'true'),
(7, 2, '08-Dec-17', 'sdfdsfds', 'type B', 342344, 69, '1 year', 45455, 454645, 'true'),
(8, 3, '08-Dec-17', 'googledrive/inkiadindustries', 'Type : A', 500000, 1, '10 year', 1234678909, 674583201, 'true'),
(9, 2, '09-Dec-17', 'test.com', 'Type : A', 99999, 3, '5 year', 123456768, 123567990, 'false'),
(10, 2, '09-Dec-17', 'torrentbd.com', 'Type : A', 6767676, 10000002, '10 year', 2147483647, 2147483647, 'false');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_business`
--

CREATE TABLE `tbl_business` (
  `companyid` int(11) NOT NULL,
  `companyname` varchar(255) NOT NULL,
  `pmfirstname` varchar(255) NOT NULL,
  `pmlastname` varchar(255) NOT NULL,
  `tradelicenceid` int(11) NOT NULL,
  `officestreet` varchar(255) NOT NULL,
  `officebuildingno` int(11) NOT NULL,
  `officecity` varchar(255) NOT NULL,
  `officezip` int(11) NOT NULL,
  `businessdetails` varchar(255) NOT NULL,
  `pmemail` varchar(255) NOT NULL,
  `businesstype` varchar(255) NOT NULL,
  `businessuser` varchar(255) NOT NULL,
  `businesspass` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_business`
--

INSERT INTO `tbl_business` (`companyid`, `companyname`, `pmfirstname`, `pmlastname`, `tradelicenceid`, `officestreet`, `officebuildingno`, `officecity`, `officezip`, `businessdetails`, `pmemail`, `businesstype`, `businessuser`, `businesspass`) VALUES
(1, 'asdas', 'asdasd', 'asdas', 123123, 'asda', 123, 'asdasd', 1233, 'asda', 'asdas', 'asdasd', 'nafees', 'nafees'),
(2, 'adil company', 'nafi', 'adil', 123343452, 'dsfds', 1233, 'dhaka', 4443, 'kkksdjfkjkdsfsf', 'kjbkdf@jksdhf', 'sdfsdf', 'bijoy', 'bijoy'),
(3, 'Inkiad Industries', 'Inkiad', 'barfasi', 420420, 'madhubala', 69, 'dhaka', 1217, 'local', 'inkiad@gmail.com', 'importer', 'inkiad', 'inkiad'),
(4, 'Khandaker Enterprise', 'Muhtasim', 'Khandaker', 1410497, 'Mouchak', 1, 'Dhaka', 1213, 'Electronics', 'muhtasim@khandaker.com', 'Importer', 'muhtasim', 'muhtasim');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_employee`
--

CREATE TABLE `tbl_employee` (
  `empid` int(11) NOT NULL,
  `empfirstname` varchar(255) NOT NULL,
  `emplastname` varchar(255) NOT NULL,
  `empdoe` varchar(255) NOT NULL,
  `empusername` varchar(255) NOT NULL,
  `emppassword` varchar(255) NOT NULL,
  `empcity` varchar(255) NOT NULL,
  `empstreet` varchar(255) NOT NULL,
  `emphouse` varchar(255) NOT NULL,
  `emergencydetails` text NOT NULL,
  `designation` varchar(255) NOT NULL,
  `phoneno` int(11) NOT NULL,
  `bloodgrp` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_employee`
--

INSERT INTO `tbl_employee` (`empid`, `empfirstname`, `emplastname`, `empdoe`, `empusername`, `emppassword`, `empcity`, `empstreet`, `emphouse`, `emergencydetails`, `designation`, `phoneno`, `bloodgrp`) VALUES
(1, 'John', 'Smith', '10/10/1990', 'admin', 'password', 'Dhaka', 'Bashundhara, Block B', '160', 'Wife : Mary Jane \r\nContact : 01688932214', 'Admin', 1677749188, 'O+'),
(2, 'nigga', 'adil', '2017-12-09', 'nigga', 'nigga', 'dhaka', 'rampura', '24', 'lactose intolerent', 'secretary', 1873038081, 'A+'),
(3, 'kazi', 'asfar', '2017-12-09', 'kazi', 'kazi', 'dhaka', 'khejur para', '69', 'loser', 'kamla', 187654321, 'o+'),
(4, 'asdas', 'asdas', 'Friday, December 8, 2017', 'abyaz', 'loser', 'asd', 'asd', '123', 'asda', 'asdasd', 1233454, 'asda'),
(5, 'lula', 'bandor', 'Tuesday, December 19, 2017', 'posa', 'posa', 'asdas', 'asda', '23', 'pagol', 'kam kore', 123123123, 'z');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_getsapproved`
--

CREATE TABLE `tbl_getsapproved` (
  `companyid` int(11) NOT NULL,
  `applicationid` int(11) NOT NULL,
  `employeeID` int(11) NOT NULL,
  `empname` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_loan`
--

CREATE TABLE `tbl_loan` (
  `loanid` int(11) NOT NULL,
  `applicationid` int(11) NOT NULL,
  `companyid` int(11) NOT NULL,
  `loanamount` int(11) NOT NULL,
  `loantype` varchar(255) NOT NULL,
  `loanissuedate` varchar(30) NOT NULL,
  `paymentdeadline` varchar(30) NOT NULL,
  `loanrepaid` double NOT NULL,
  `loanremarks` varchar(255) NOT NULL,
  `productid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_loan`
--

INSERT INTO `tbl_loan` (`loanid`, `applicationid`, `companyid`, `loanamount`, `loantype`, `loanissuedate`, `paymentdeadline`, `loanrepaid`, `loanremarks`, `productid`) VALUES
(13, 4, 1, 67162, 'Type : A', '0000-00-00', '0000-00-00', 34535, 'bvcfgcf fgf', 23),
(14, 7, 2, 342344, 'type B', '11-Jan-18', '5 year', 3432, 'bla........', 69),
(15, 8, 3, 500000, 'Type : A', '15-Dec-17', '10 year', 0, 'pola bhalo ase', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_manage`
--

CREATE TABLE `tbl_manage` (
  `emplid` int(11) NOT NULL,
  `empname` varchar(255) NOT NULL,
  `loanid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_message`
--

CREATE TABLE `tbl_message` (
  `empmessage` text NOT NULL,
  `empid` int(11) NOT NULL,
  `empname` varchar(255) NOT NULL,
  `proponentname` varchar(255) NOT NULL,
  `proponentid` int(11) NOT NULL,
  `messageid` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_message`
--

INSERT INTO `tbl_message` (`empmessage`, `empid`, `empname`, `proponentname`, `proponentid`, `messageid`) VALUES
('hi Biju Kmn asos?!? ', 0, 'niggaadil', 'adil company', 2, 2),
('second message.. dekhi kmn ashe', 0, 'nigga', 'nafees adil', 2, 3),
('this is a message for nafees', 0, 'niggaadil', 'asdas', 1, 4),
('this is a second message for bijoy', 0, 'niggaadil', 'adil company', 2, 5),
('kire magi kmn asos', 0, 'niggaadil', 'adil company', 2, 6),
('ami kisu pari na waah waaah!', -1, 'NULL', '', 0, 8),
('lol\nlol\nlol\nlol\nlol\nlol\nlol\nlol\nlol\nlol\nlol\nlol\nlol\n', -1, 'NULL', 'adil company', 2, 9),
('dfg', 0, 'niggaadil', 'asdas', 1, 10),
('wT fuck', 0, 'niggaadil', 'adil company', 2, 11),
('nigga nigga\nnigga nigga\nnigga nigganigga nigganigga nigganigga nigga', -1, 'NULL', 'adil company', 2, 12),
('Bro i have applied for a long time but i didnt get any answer... did i make any mistake? pelase reply', -1, 'NULL', 'Inkiad Industries', 3, 13),
('bhai ato tara kisher? wait la!', 0, 'niggaadil', 'Inkiad Industries', 3, 14);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_phone`
--

CREATE TABLE `tbl_phone` (
  `phoneid` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `phone` int(11) NOT NULL,
  `fax` int(11) NOT NULL,
  `mob` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_product`
--

CREATE TABLE `tbl_product` (
  `productid` int(11) NOT NULL,
  `companyid` int(11) NOT NULL,
  `productname` varchar(255) NOT NULL,
  `productbrand` varchar(255) NOT NULL,
  `productmodel` varchar(255) NOT NULL,
  `productdetails` varchar(255) NOT NULL,
  `manufacturer` varchar(255) NOT NULL,
  `manucountry` varchar(255) NOT NULL,
  `manucity` varchar(255) NOT NULL,
  `manuzip` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_product`
--

INSERT INTO `tbl_product` (`productid`, `companyid`, `productname`, `productbrand`, `productmodel`, `productdetails`, `manufacturer`, `manucountry`, `manucity`, `manuzip`) VALUES
(10000001, 2, '', 'htc', 'm1', 'it is a good phone', 'htc', 'brazil', 'dhaka', 1234),
(10000002, 2, 'xbox 360 controller', 'xbox', 'System.Windows.Forms.TextBox, Text: 360', 'game controller', 'microsoft', 'USA', 'california', 7869);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_application`
--
ALTER TABLE `tbl_application`
  ADD PRIMARY KEY (`applicationid`);

--
-- Indexes for table `tbl_business`
--
ALTER TABLE `tbl_business`
  ADD PRIMARY KEY (`companyid`);

--
-- Indexes for table `tbl_employee`
--
ALTER TABLE `tbl_employee`
  ADD PRIMARY KEY (`empid`);

--
-- Indexes for table `tbl_loan`
--
ALTER TABLE `tbl_loan`
  ADD PRIMARY KEY (`loanid`);

--
-- Indexes for table `tbl_message`
--
ALTER TABLE `tbl_message`
  ADD PRIMARY KEY (`messageid`);

--
-- Indexes for table `tbl_phone`
--
ALTER TABLE `tbl_phone`
  ADD PRIMARY KEY (`phoneid`);

--
-- Indexes for table `tbl_product`
--
ALTER TABLE `tbl_product`
  ADD PRIMARY KEY (`productid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_application`
--
ALTER TABLE `tbl_application`
  MODIFY `applicationid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `tbl_business`
--
ALTER TABLE `tbl_business`
  MODIFY `companyid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_employee`
--
ALTER TABLE `tbl_employee`
  MODIFY `empid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_loan`
--
ALTER TABLE `tbl_loan`
  MODIFY `loanid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `tbl_message`
--
ALTER TABLE `tbl_message`
  MODIFY `messageid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `tbl_phone`
--
ALTER TABLE `tbl_phone`
  MODIFY `phoneid` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_product`
--
ALTER TABLE `tbl_product`
  MODIFY `productid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10000003;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
