-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 22 Okt 2021 pada 08.26
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
-- Database: `paymentdb`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `aspnetroleclaims`
--

CREATE TABLE `aspnetroleclaims` (
  `Id` int(11) NOT NULL,
  `RoleId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `aspnetroles`
--

CREATE TABLE `aspnetroles` (
  `Id` varchar(255) NOT NULL,
  `Name` varchar(256) DEFAULT NULL,
  `NormalizedName` varchar(256) DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `aspnetuserclaims`
--

CREATE TABLE `aspnetuserclaims` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) NOT NULL,
  `ClaimType` longtext DEFAULT NULL,
  `ClaimValue` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `aspnetuserlogins`
--

CREATE TABLE `aspnetuserlogins` (
  `LoginProvider` varchar(128) NOT NULL,
  `ProviderKey` varchar(128) NOT NULL,
  `ProviderDisplayName` longtext DEFAULT NULL,
  `UserId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `aspnetuserroles`
--

CREATE TABLE `aspnetuserroles` (
  `UserId` varchar(255) NOT NULL,
  `RoleId` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `aspnetusers`
--

CREATE TABLE `aspnetusers` (
  `Id` varchar(255) NOT NULL,
  `UserName` varchar(256) DEFAULT NULL,
  `NormalizedUserName` varchar(256) DEFAULT NULL,
  `Email` varchar(256) DEFAULT NULL,
  `NormalizedEmail` varchar(256) DEFAULT NULL,
  `EmailConfirmed` tinyint(1) NOT NULL,
  `PasswordHash` longtext DEFAULT NULL,
  `SecurityStamp` longtext DEFAULT NULL,
  `ConcurrencyStamp` longtext DEFAULT NULL,
  `PhoneNumber` longtext DEFAULT NULL,
  `PhoneNumberConfirmed` tinyint(1) NOT NULL,
  `TwoFactorEnabled` tinyint(1) NOT NULL,
  `LockoutEnd` datetime(6) DEFAULT NULL,
  `LockoutEnabled` tinyint(1) NOT NULL,
  `AccessFailedCount` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `aspnetusers`
--

INSERT INTO `aspnetusers` (`Id`, `UserName`, `NormalizedUserName`, `Email`, `NormalizedEmail`, `EmailConfirmed`, `PasswordHash`, `SecurityStamp`, `ConcurrencyStamp`, `PhoneNumber`, `PhoneNumberConfirmed`, `TwoFactorEnabled`, `LockoutEnd`, `LockoutEnabled`, `AccessFailedCount`) VALUES
('2011d3bf-feb7-441d-9241-ac00abe9e070', 'febrigalung', 'FEBRIGALUNG', 'febrigalung@example.com', 'FEBRIGALUNG@EXAMPLE.COM', 0, 'AQAAAAEAACcQAAAAECpo/rOavyQVUKAQQRKUbgJ8AYNWVBiCzE7j0X7YWNgBvMabo+qVYol5wrF1U0bpqg==', 'E47QZWDKFBUI4BEBVYSKAHX4NNAPVPHC', '3fad5473-8e8e-43f3-b4ad-49f88fb5a526', NULL, 0, 0, NULL, 1, 0),
('9a5fb3ac-32cf-4872-9a41-2c262cce2630', 'monster', 'MONSTER', 'monster@example.com', 'MONSTER@EXAMPLE.COM', 0, 'AQAAAAEAACcQAAAAEFMdyW2aJHo0IHsrzjOxhYvp7Tph4ecKvXxXVxAtubfVg17CQtFBBRqBTbr0uLKZhA==', 'OAW3NLGS37IRE7GZHTPY4FLRXOGFGQUS', '9c64f77b-868e-4862-84b4-ed53f105563a', NULL, 0, 0, NULL, 1, 0),
('b301b5ed-99d1-4a64-a3a3-43523d5776a0', 'jaya', 'JAYA', 'jaya@example.com', 'JAYA@EXAMPLE.COM', 0, 'AQAAAAEAACcQAAAAEHTEjs2T+spJ6VosqYA0Up83GiXC3nCdopEr5moqMc8CIs8Bbml8Kl2275Xafnr/PQ==', '4WNBPGFHX3N7RHUUSXL2IXVEKTKVNWYM', '549e9676-b132-4204-8ab3-7f57f98d064c', NULL, 0, 0, NULL, 1, 0),
('f8a6c144-a3cb-40b7-81a3-4a4af094b4a1', 'wowwow', 'wowo1', 'wowo@gmail.com', 'wowo@GMAIL.COM', 0, 'AQAAAAEAACcQAAAAEKDEW1iL21O6cF1SV4PjH0CEFlzg2/8T2qC0IZuCnhURBpZ4kePDsUzixR/ivO6VlQ==', 'PKJ3CN272Q7CIFLTMHUVRZXSKG232GRS', '48c2d5e3-8d07-4c8e-a269-f9255427c656', NULL, 0, 0, NULL, 1, 0),
('ff40a3de-6af1-4e3e-ac6f-b3c82381eb12', 'febriwij', 'FEBRIWIJ', 'febri@example.com', 'FEBRI@EXAMPLE.COM', 0, 'AQAAAAEAACcQAAAAEOlrlkwLD/7GAtLqhnXEX4/oIYoSFVBlGVNURryktmf3cEhKxMfpqJbtM2qu0b0EJw==', '6S4CDXOGW6H6BHGRX2FZG743BFN4S7DS', '5f2768ae-3df3-45b0-9eac-580d81b973ce', NULL, 0, 0, NULL, 1, 0);

-- --------------------------------------------------------

--
-- Struktur dari tabel `aspnetusertokens`
--

CREATE TABLE `aspnetusertokens` (
  `UserId` varchar(255) NOT NULL,
  `LoginProvider` varchar(128) NOT NULL,
  `Name` varchar(128) NOT NULL,
  `Value` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `paymentdetail`
--

CREATE TABLE `paymentdetail` (
  `paymentDetailId` int(11) NOT NULL,
  `cardOwnerName` longtext DEFAULT NULL,
  `cardNumber` longtext DEFAULT NULL,
  `expirationDate` datetime(6) NOT NULL,
  `securityCode` longtext DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `paymentdetail`
--

INSERT INTO `paymentdetail` (`paymentDetailId`, `cardOwnerName`, `cardNumber`, `expirationDate`, `securityCode`) VALUES
(3, 'terserah 2', '567567', '2022-12-31 00:00:00.000000', '263'),
(4, 'terserah 3', '567567567', '2023-07-31 00:00:00.441000', '548'),
(5, 'terserah 4', '456456', '2022-08-31 00:00:00.149000', '537'),
(7, 'coba', '12345', '2021-10-22 02:48:18.053000', '0891'),
(8, 'terserah coba', '123345', '2021-10-22 03:25:01.677000', '998098'),
(9, 'starla', '09784', '2021-10-22 03:45:59.423000', '1234');

-- --------------------------------------------------------

--
-- Struktur dari tabel `refreshtokens`
--

CREATE TABLE `refreshtokens` (
  `Id` int(11) NOT NULL,
  `UserId` varchar(255) DEFAULT NULL,
  `Token` longtext DEFAULT NULL,
  `JwtId` longtext DEFAULT NULL,
  `IsUsed` tinyint(1) NOT NULL,
  `IsRevorked` tinyint(1) NOT NULL,
  `AddedDate` datetime(6) NOT NULL,
  `ExpiryDate` datetime(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `refreshtokens`
--

INSERT INTO `refreshtokens` (`Id`, `UserId`, `Token`, `JwtId`, `IsUsed`, `IsRevorked`, `AddedDate`, `ExpiryDate`) VALUES
(1, 'f8a6c144-a3cb-40b7-81a3-4a4af094b4a1', 'AHG8CFO6XCZV1GHOZH8ZF4IPIXNC33VEMDEd1681f93-f59e-4c64-a9ec-b608b0f106d1', 'dc0cb0ae-dcfc-40cc-bf23-cfbb13bc4656', 0, 0, '2021-10-20 19:01:53.202735', '2022-04-20 19:01:53.202770'),
(2, 'f8a6c144-a3cb-40b7-81a3-4a4af094b4a1', 'FNE73006OD1LHKORF36H0H58OBVP1D1U8LYf434ccd3-25ba-4329-85f1-c03294583cb6', '30b51b73-91f8-4563-b054-9dd92b2df563', 0, 0, '2021-10-20 19:02:16.821984', '2022-04-20 19:02:16.821984'),
(3, 'ff40a3de-6af1-4e3e-ac6f-b3c82381eb12', 'WNHL02KSA3YH9C0GPKF8707QUBEGR8V1R469762032c-7dc5-435f-89a0-d5f9205b7def', '49e7a48a-9619-45d0-b3ed-18072bda8d28', 0, 0, '2021-10-22 02:45:06.873120', '2022-04-22 02:45:06.873172'),
(4, 'ff40a3de-6af1-4e3e-ac6f-b3c82381eb12', 'AVRSIXVOM30WOGPMXHKU2VUUI432FNUUWX070e011e1-5181-462c-bad1-d659a5f87777', 'd93e5d6f-32f8-4e46-94b5-4d8245467056', 0, 0, '2021-10-22 02:45:54.450153', '2022-04-22 02:45:54.450153'),
(5, 'b301b5ed-99d1-4a64-a3a3-43523d5776a0', 'KEPV614L1HE5NOBTKPZ03T7IYYP8NOPQL8Pc5ffa460-34b9-4ea1-a7c8-6cd6c83ce0c0', 'b78c2bf5-d48a-45c8-8966-6b8ce36112a8', 0, 0, '2021-10-22 03:02:23.423074', '2022-04-22 03:02:23.423077'),
(6, 'b301b5ed-99d1-4a64-a3a3-43523d5776a0', 'Y5HVWZ00IW2O3S1X1B51573ZN2ZCMZ2MK8K783bfb50-f2ab-4c0c-893f-5981d8cb249d', 'ffa2b3a8-1f6a-4892-860d-7d2348765338', 0, 0, '2021-10-22 03:02:50.947467', '2022-04-22 03:02:50.947468'),
(7, '2011d3bf-feb7-441d-9241-ac00abe9e070', 'Z0QV59TEMYJVSJHSJ146NCBTI2O455UIY7Jf1a0ff68-9b61-4d19-bccc-b6088fad8500', '9d16f472-714b-4fbe-8005-83e23dc65626', 0, 0, '2021-10-22 03:23:02.516845', '2022-04-22 03:23:02.516846'),
(8, '2011d3bf-feb7-441d-9241-ac00abe9e070', 'EMZXVRZAKD7DZY2C15MB8LY68SMLFX0TGPT28a79302-8f34-438d-b9f3-dad9c20e82df', '5aa1893e-aca6-4a6e-b7ca-fd753831b7a6', 0, 0, '2021-10-22 03:23:48.976280', '2022-04-22 03:23:48.976281'),
(9, '9a5fb3ac-32cf-4872-9a41-2c262cce2630', 'CSNIPOSUS7GM6RQ6DCBIM0Z7HO3PAEWHXCUac08e6c9-f33b-4af0-bba7-dd3412f7ec73', '47d0663d-475b-4ba1-a379-3ffe528cc45b', 0, 0, '2021-10-22 03:38:10.561788', '2022-04-22 03:38:10.561849'),
(10, '9a5fb3ac-32cf-4872-9a41-2c262cce2630', '8FOYTQUBO0S3D6R2VPS5IDGA4JGJ20MN691fa354a4f-7a95-4e74-a640-d968fe826ae3', '3e05085e-5725-4456-934d-413902782ce4', 0, 0, '2021-10-22 03:40:11.844365', '2022-04-22 03:40:11.844366');

-- --------------------------------------------------------

--
-- Struktur dari tabel `__efmigrationshistory`
--

CREATE TABLE `__efmigrationshistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ProductVersion` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `__efmigrationshistory`
--

INSERT INTO `__efmigrationshistory` (`MigrationId`, `ProductVersion`) VALUES
('20211020185956_Adding authentication', '5.0.11');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetRoleClaims_RoleId` (`RoleId`);

--
-- Indeks untuk tabel `aspnetroles`
--
ALTER TABLE `aspnetroles`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `RoleNameIndex` (`NormalizedName`);

--
-- Indeks untuk tabel `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_AspNetUserClaims_UserId` (`UserId`);

--
-- Indeks untuk tabel `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD PRIMARY KEY (`LoginProvider`,`ProviderKey`),
  ADD KEY `IX_AspNetUserLogins_UserId` (`UserId`);

--
-- Indeks untuk tabel `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD PRIMARY KEY (`UserId`,`RoleId`),
  ADD KEY `IX_AspNetUserRoles_RoleId` (`RoleId`);

--
-- Indeks untuk tabel `aspnetusers`
--
ALTER TABLE `aspnetusers`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `UserNameIndex` (`NormalizedUserName`),
  ADD KEY `EmailIndex` (`NormalizedEmail`);

--
-- Indeks untuk tabel `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD PRIMARY KEY (`UserId`,`LoginProvider`,`Name`);

--
-- Indeks untuk tabel `paymentdetail`
--
ALTER TABLE `paymentdetail`
  ADD PRIMARY KEY (`paymentDetailId`);

--
-- Indeks untuk tabel `refreshtokens`
--
ALTER TABLE `refreshtokens`
  ADD PRIMARY KEY (`Id`),
  ADD KEY `IX_RefreshTokens_UserId` (`UserId`);

--
-- Indeks untuk tabel `__efmigrationshistory`
--
ALTER TABLE `__efmigrationshistory`
  ADD PRIMARY KEY (`MigrationId`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `paymentdetail`
--
ALTER TABLE `paymentdetail`
  MODIFY `paymentDetailId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT untuk tabel `refreshtokens`
--
ALTER TABLE `refreshtokens`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `aspnetroleclaims`
--
ALTER TABLE `aspnetroleclaims`
  ADD CONSTRAINT `FK_AspNetRoleClaims_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE;

--
-- Ketidakleluasaan untuk tabel `aspnetuserclaims`
--
ALTER TABLE `aspnetuserclaims`
  ADD CONSTRAINT `FK_AspNetUserClaims_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Ketidakleluasaan untuk tabel `aspnetuserlogins`
--
ALTER TABLE `aspnetuserlogins`
  ADD CONSTRAINT `FK_AspNetUserLogins_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Ketidakleluasaan untuk tabel `aspnetuserroles`
--
ALTER TABLE `aspnetuserroles`
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetRoles_RoleId` FOREIGN KEY (`RoleId`) REFERENCES `aspnetroles` (`Id`) ON DELETE CASCADE,
  ADD CONSTRAINT `FK_AspNetUserRoles_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Ketidakleluasaan untuk tabel `aspnetusertokens`
--
ALTER TABLE `aspnetusertokens`
  ADD CONSTRAINT `FK_AspNetUserTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`) ON DELETE CASCADE;

--
-- Ketidakleluasaan untuk tabel `refreshtokens`
--
ALTER TABLE `refreshtokens`
  ADD CONSTRAINT `FK_RefreshTokens_AspNetUsers_UserId` FOREIGN KEY (`UserId`) REFERENCES `aspnetusers` (`Id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
