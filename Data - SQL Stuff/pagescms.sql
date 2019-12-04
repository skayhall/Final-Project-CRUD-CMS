-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 04, 2019 at 12:08 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pagescms`
--

-- --------------------------------------------------------

--
-- Table structure for table `pagecmsinfo`
--

CREATE TABLE `pagecmsinfo` (
  `pagecmsid` int(20) NOT NULL,
  `pagecmstitle` varchar(255) NOT NULL,
  `pagecmsbody` mediumtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pagecmsinfo`
--

INSERT INTO `pagecmsinfo` (`pagecmsid`, `pagecmstitle`, `pagecmsbody`) VALUES
(1, 'My Miami Trip', 'My trip to Miami was so much fun. I loved it so much! I got to go to the beach, visit family, eat great food and met a really cute guy!'),
(2, 'My Jamaica Trip', 'I love going to Jamaica - I go every year. I love the beaches especially in Negril and Ocho Rios. I also love the amazing food - especially the Jerk Chicken and Ackee and Saltfish. I always visit my family when I go and make sure to bring something nice for my niece and nephew. They are growing up so fast!');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pagecmsinfo`
--
ALTER TABLE `pagecmsinfo`
  ADD PRIMARY KEY (`pagecmsid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pagecmsinfo`
--
ALTER TABLE `pagecmsinfo`
  MODIFY `pagecmsid` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
