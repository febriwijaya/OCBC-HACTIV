-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 18 Okt 2021 pada 01.02
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
-- Database: `moviesdb`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `movie`
--

CREATE TABLE `movie` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `genre` varchar(50) NOT NULL,
  `durations` varchar(50) NOT NULL,
  `releasedate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `movie`
--

INSERT INTO `movie` (`id`, `name`, `genre`, `durations`, `releasedate`) VALUES
(1, 'Bad Boys For Life', 'Action/Comedy', '2h 5mins', '2021-10-11 22:02:00'),
(3, 'Bad Boys For Kill People', 'Action/Thriller', '2h 5mins', '2021-10-12 22:02:00');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `movie`
--
ALTER TABLE `movie`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `movie`
--
ALTER TABLE `movie`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
