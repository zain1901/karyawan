-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 12 Des 2019 pada 05.10
-- Versi server: 10.3.16-MariaDB
-- Versi PHP: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_karyawan`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `absensi`
--

CREATE TABLE `absensi` (
  `id_absensi` varchar(20) NOT NULL,
  `nik` varchar(20) NOT NULL,
  `jam_masuk` varchar(15) NOT NULL,
  `jam_kerja` varchar(15) NOT NULL,
  `tgl_kerja` date NOT NULL,
  `jam_pulang` varchar(15) NOT NULL,
  `telat_masuk` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `absensi`
--

INSERT INTO `absensi` (`id_absensi`, `nik`, `jam_masuk`, `jam_kerja`, `tgl_kerja`, `jam_pulang`, `telat_masuk`) VALUES
('180191212-110552', '1808', '1/1/0001 11:05:', '1/1/0001 7:00:0', '2019-12-12', '11:05:52', '04:05:52'),
('180191212-110701', '1808', '1/1/0001 11:07:', '1/1/0001 7:00:0', '2019-12-12', '11:07:01', '04:07:01');

-- --------------------------------------------------------

--
-- Struktur dari tabel `gaji`
--

CREATE TABLE `gaji` (
  `id_gaji` int(11) NOT NULL,
  `no_slip` varchar(15) NOT NULL,
  `nik` varchar(20) NOT NULL,
  `tgl_gaji` date NOT NULL,
  `id_jabatan` int(2) NOT NULL,
  `nama_jabatan` varchar(45) NOT NULL,
  `gaji_pokok` decimal(8,0) NOT NULL,
  `tunjangan` decimal(8,0) NOT NULL,
  `uang_lembur` decimal(8,0) NOT NULL,
  `pot_bpjs_kes` decimal(8,0) NOT NULL,
  `pot_bpjs_ket` decimal(8,0) NOT NULL,
  `pot_lain2` decimal(8,0) NOT NULL,
  `no_rek` varchar(20) NOT NULL,
  `nama_rekening` varchar(45) NOT NULL,
  `nama_bank` varchar(20) NOT NULL,
  `total_gaji` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `gaji`
--

INSERT INTO `gaji` (`id_gaji`, `no_slip`, `nik`, `tgl_gaji`, `id_jabatan`, `nama_jabatan`, `gaji_pokok`, `tunjangan`, `uang_lembur`, `pot_bpjs_kes`, `pot_bpjs_ket`, `pot_lain2`, `no_rek`, `nama_rekening`, `nama_bank`, `total_gaji`) VALUES
(2, '9', '082154710218', '2019-11-21', 4, 'direktur', '6000000', '1000000', '100000', '250000', '200000', '100000', '0211111', 'zainuri', 'bri', '7500000'),
(3, 'TR191204-100122', '', '2019-12-04', 1, 'direktur', '5000000', '0', '0', '0', '0', '0', '', '', '', '0'),
(4, 'TR191204-100156', '1808', '2019-12-04', 1, 'direktur', '5000000', '3000000', '200000', '250000', '250000', '100000', '081231', 'zai', 'bri', '5500000'),
(5, 'TR191204-100807', '3514', '2019-12-04', 2, 'manager', '4000000', '400000', '300000', '200000', '150000', '100000', '082154', 'zainur', 'BRI', '6000000'),
(6, 'TR191204-101736', '1091881', '2019-12-04', 1, 'direktur', '5000000', '400000', '300000', '200000', '150000', '100000', '35634', 'zainuri', 'BRI', '70000000'),
(7, 'TR191204-102242', '525163', '2019-12-04', 1, 'direktur', '5000000', '42325143', '541234', '62354', '99999999', '245131', '78956423', 'bri', 'r2qeww', '0'),
(8, 'TR191204-102358', '428471952', '2019-12-04', 1, 'direktur', '5000000', '5652335', '2512', '512532', '3263251', '23152', '975753', 'svz', 'bzsfsdcz', '35264362'),
(9, 'TR191204-102608', '342655421', '2019-12-04', 1, 'direktur', '5000000', '463463', '352346', '346243', '35241', '632532', '4523423', 'dbs', 'xbgdfs', '46387347'),
(10, 'TR191204-102608', '342655421', '2019-12-04', 1, 'direktur', '5000000', '463463', '352346', '346243', '35241', '632532', '4523423', 'dbs', 'xbgdfs', '46387347'),
(11, 'TR191204-102739', '547297642', '2019-12-04', 2, 'manager', '4000000', '36256', '7546428', '754267', '263441', '1564366', '437161', 'bri', 'bni', '9000000'),
(12, 'TR191204-102918', '536963795', '2019-12-04', 1, 'direktur', '5000000', '3463634', '4236265', '56332', '23412', '35121', '3232532', 'ZAIN', 'BRI', '10000000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `jabatan`
--

CREATE TABLE `jabatan` (
  `id_jabatan` int(2) NOT NULL,
  `nama_jabatan` varchar(45) NOT NULL,
  `gaji_pokok` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `jabatan`
--

INSERT INTO `jabatan` (`id_jabatan`, `nama_jabatan`, `gaji_pokok`) VALUES
(1, 'direktur', '5000000'),
(2, 'manager', '4000000');

-- --------------------------------------------------------

--
-- Struktur dari tabel `karyawan`
--

CREATE TABLE `karyawan` (
  `nik` varchar(15) NOT NULL,
  `nama` varchar(30) NOT NULL,
  `tempat_lahir` varchar(20) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `agama` varchar(15) NOT NULL,
  `status` varchar(10) NOT NULL,
  `kewarganegaraan` varchar(3) NOT NULL,
  `no_hp` varchar(13) NOT NULL,
  `email` varchar(25) NOT NULL,
  `alamat` varchar(35) NOT NULL,
  `pendidikan_terakhir` varchar(4) NOT NULL,
  `pt_terakhir` varchar(50) NOT NULL,
  `jabatan` varchar(15) NOT NULL,
  `tgl_masuk` date NOT NULL,
  `bagian` varchar(20) NOT NULL,
  `gaji` varchar(10) NOT NULL,
  `status_karyawan` varchar(10) NOT NULL,
  `status_kerja` varchar(10) NOT NULL,
  `nama_gambar` varchar(200) NOT NULL,
  `lokasi_gambar` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `karyawan`
--

INSERT INTO `karyawan` (`nik`, `nama`, `tempat_lahir`, `tgl_lahir`, `agama`, `status`, `kewarganegaraan`, `no_hp`, `email`, `alamat`, `pendidikan_terakhir`, `pt_terakhir`, `jabatan`, `tgl_masuk`, `bagian`, `gaji`, `status_karyawan`, `status_kerja`, `nama_gambar`, `lokasi_gambar`) VALUES
('1808', 'ahmad', 'padak', '2000-01-19', 'Islam', 'Belum Nika', 'WNI', '0821', 'azain@gmail.com', 'natai kerbau', 'S1', 'ui', 'direktur', '2019-12-12', 'pengusaha', '5000000', 'Tetap', 'Aktif', 'background-6.jpg', 'G:\\Ahmad Zainuri_0821 5471 0218_Kuliah\\Semester 3\\Visual Programing 2\\aplikasi_karyawan_new - Copy\\icon\\background-6.jpg');

-- --------------------------------------------------------

--
-- Struktur dari tabel `lembur`
--

CREATE TABLE `lembur` (
  `id_lembur` int(10) NOT NULL,
  `nik` varchar(20) NOT NULL,
  `nama_karyawan` varchar(45) NOT NULL,
  `id_jabatan` int(2) NOT NULL,
  `tgl_lembur` date NOT NULL,
  `jum_jam_lembur` int(2) NOT NULL,
  `uang_lembur` decimal(8,0) NOT NULL,
  `total_uang_lembur` decimal(8,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `lembur`
--

INSERT INTO `lembur` (`id_lembur`, `nik`, `nama_karyawan`, `id_jabatan`, `tgl_lembur`, `jum_jam_lembur`, `uang_lembur`, `total_uang_lembur`) VALUES
(1, '08', 'zai', 1, '2019-11-01', 3, '300000', '900000');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `absensi`
--
ALTER TABLE `absensi`
  ADD PRIMARY KEY (`id_absensi`);

--
-- Indeks untuk tabel `gaji`
--
ALTER TABLE `gaji`
  ADD PRIMARY KEY (`id_gaji`);

--
-- Indeks untuk tabel `jabatan`
--
ALTER TABLE `jabatan`
  ADD PRIMARY KEY (`id_jabatan`);

--
-- Indeks untuk tabel `karyawan`
--
ALTER TABLE `karyawan`
  ADD PRIMARY KEY (`nik`);

--
-- Indeks untuk tabel `lembur`
--
ALTER TABLE `lembur`
  ADD PRIMARY KEY (`id_lembur`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `gaji`
--
ALTER TABLE `gaji`
  MODIFY `id_gaji` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT untuk tabel `jabatan`
--
ALTER TABLE `jabatan`
  MODIFY `id_jabatan` int(2) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT untuk tabel `lembur`
--
ALTER TABLE `lembur`
  MODIFY `id_lembur` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
