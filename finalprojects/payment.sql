-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 22 Okt 2021 pada 01.19
-- Versi server: 10.4.21-MariaDB
-- Versi PHP: 7.4.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `payment`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `paymentapi`
--

CREATE TABLE `paymentapi` (
  `paymentDetailId` int(11) NOT NULL,
  `cardOwnerName` varchar(100) NOT NULL,
  `cardNumber` varchar(100) NOT NULL,
  `expirationDate` varchar(100) NOT NULL,
  `securityCode` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `paymentapi`
--

INSERT INTO `paymentapi` (`paymentDetailId`, `cardOwnerName`, `cardNumber`, `expirationDate`, `securityCode`) VALUES
(1, 'febri', '001', '20 oktober 2021', '12345'),
(3, 'rudi', '0897', '20 september 2020', '1234'),
(4, 'andi', '3456', '08 februari 2019', '090219');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `paymentapi`
--
ALTER TABLE `paymentapi`
  ADD PRIMARY KEY (`paymentDetailId`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `paymentapi`
--
ALTER TABLE `paymentapi`
  MODIFY `paymentDetailId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
