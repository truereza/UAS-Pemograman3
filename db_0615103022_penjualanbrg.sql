-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 05 Jan 2017 pada 16.27
-- Versi Server: 10.1.19-MariaDB
-- PHP Version: 5.5.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_0615103022_penjualanbrg`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_0615103022_barang`
--

CREATE TABLE `tbl_0615103022_barang` (
  `Kode_Barang` varchar(10) NOT NULL,
  `Nama_Barang` varchar(75) NOT NULL,
  `Satuan` varchar(15) NOT NULL,
  `Stock` varchar(10) NOT NULL,
  `Harga_satuan` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_0615103022_barang`
--

INSERT INTO `tbl_0615103022_barang` (`Kode_Barang`, `Nama_Barang`, `Satuan`, `Stock`, `Harga_satuan`) VALUES
('BRG0001', 'Tahu Bulat', 'PCS', '100', '2500'),
('BRG0002', 'Tempe', 'PCS', '100', '2500'),
('BRG0003', 'Obat', 'Box', '45', '150000'),
('BRG0004', 'Coklat', 'Biji/Buah', '1000', '6500'),
('BRG0005', 'Kue', 'Biji/Buah', '100', '20000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_0615103022_customer`
--

CREATE TABLE `tbl_0615103022_customer` (
  `ID_Customer` varchar(10) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Alamat` varchar(100) NOT NULL,
  `Telepon` varchar(15) NOT NULL,
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_0615103022_customer`
--

INSERT INTO `tbl_0615103022_customer` (`ID_Customer`, `Nama`, `Alamat`, `Telepon`, `Email`) VALUES
('Cust0001', 'Reza', 'Jl. Parakan Saat III No. 103\r\n', '087822551475', 'reza.slamming@gmail.com'),
('Cust0002', 'Haya', 'Jl. Cigondewah no 999\r\n', '08987651234', 'haya@gmail.com'),
('Cust0003', 'Uwa Tere', 'Subang\r\n', '08765431234', 'uwa@yahoo.com'),
('Cust0004', 'Wa Gemling', 'Jampang\r\n', '08123471222', 'gemling@gmail.com'),
('Cust0005', 'Hari', 'Jl. Purwakarta no 9\r\n', '0224213657', 'harieuy@gmail.com');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_0615103022_detailtransaksi`
--

CREATE TABLE `tbl_0615103022_detailtransaksi` (
  `No_Nota` varchar(10) NOT NULL,
  `Kode_Barang` varchar(10) NOT NULL,
  `Nama_Barang` varchar(100) NOT NULL,
  `Jumlah` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_0615103022_detailtransaksi`
--

INSERT INTO `tbl_0615103022_detailtransaksi` (`No_Nota`, `Kode_Barang`, `Nama_Barang`, `Jumlah`) VALUES
('TRX-0001', 'BRG0002', 'Tempe', '3'),
('TRX-0002', 'BRG0004', 'Coklat', '9'),
('TRX-0003', 'BRG0005', 'Kue', '5');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_0615103022_headtransaksi`
--

CREATE TABLE `tbl_0615103022_headtransaksi` (
  `No_Nota` varchar(10) NOT NULL,
  `Tanggal` varchar(15) NOT NULL,
  `ID_Customer` varchar(10) NOT NULL,
  `Total_Harga` varchar(15) NOT NULL,
  `ID_Karyawan` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_0615103022_headtransaksi`
--

INSERT INTO `tbl_0615103022_headtransaksi` (`No_Nota`, `Tanggal`, `ID_Customer`, `Total_Harga`, `ID_Karyawan`) VALUES
('TRX-0001', 'Rabu, 04 Januar', 'Cust0002', '7500', 'KRW00001'),
('TRX-0002', 'Kamis, 05 Janua', 'Cust0005', '58500', 'KRW00002'),
('TRX-0003', 'Kamis, 05 Janua', 'Cust0003', '100000', 'KRW00004');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_0615103022_karyawan`
--

CREATE TABLE `tbl_0615103022_karyawan` (
  `ID_Karyawan` varchar(100) NOT NULL,
  `Nama` varchar(50) NOT NULL,
  `TanggalLahir` varchar(15) NOT NULL,
  `Telepon` varchar(15) NOT NULL,
  `Email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_0615103022_karyawan`
--

INSERT INTO `tbl_0615103022_karyawan` (`ID_Karyawan`, `Nama`, `TanggalLahir`, `Telepon`, `Email`) VALUES
('KRW00001', 'Udin', 'Rabu, 25 Juli 1', '087866665555', 'udinteaeuy@gmail.com'),
('KRW00002', 'Keke', 'Kamis, 17 Novem', '0224203355', 'keketea@gmail.com'),
('KRW00003', 'Reza', 'Senin, 17 Janua', '083822551475', 'reza.slamming@gmail.com'),
('KRW00004', 'Jajang', 'Rabu, 05 Juni 1', '08785432122', 'jajangdeathgore@gmail.com');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_0615103022_login`
--

CREATE TABLE `tbl_0615103022_login` (
  `ID_Karyawan` varchar(10) NOT NULL,
  `Username` varchar(20) NOT NULL,
  `Password` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tbl_0615103022_login`
--

INSERT INTO `tbl_0615103022_login` (`ID_Karyawan`, `Username`, `Password`) VALUES
('KRW00001', 'reza', 'reza');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_0615103022_barang`
--
ALTER TABLE `tbl_0615103022_barang`
  ADD PRIMARY KEY (`Kode_Barang`);

--
-- Indexes for table `tbl_0615103022_customer`
--
ALTER TABLE `tbl_0615103022_customer`
  ADD PRIMARY KEY (`ID_Customer`);

--
-- Indexes for table `tbl_0615103022_detailtransaksi`
--
ALTER TABLE `tbl_0615103022_detailtransaksi`
  ADD PRIMARY KEY (`No_Nota`);

--
-- Indexes for table `tbl_0615103022_headtransaksi`
--
ALTER TABLE `tbl_0615103022_headtransaksi`
  ADD PRIMARY KEY (`No_Nota`);

--
-- Indexes for table `tbl_0615103022_karyawan`
--
ALTER TABLE `tbl_0615103022_karyawan`
  ADD PRIMARY KEY (`ID_Karyawan`);

--
-- Indexes for table `tbl_0615103022_login`
--
ALTER TABLE `tbl_0615103022_login`
  ADD PRIMARY KEY (`ID_Karyawan`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
