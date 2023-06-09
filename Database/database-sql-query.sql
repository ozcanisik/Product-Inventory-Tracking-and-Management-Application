USE [master]
GO
/****** Object:  Database [DbStokTakip]    Script Date: 5.06.2023 20:02:20 ******/
CREATE DATABASE [DbStokTakip]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbStokTakip', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DbStokTakip.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbStokTakip_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DbStokTakip_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DbStokTakip] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbStokTakip].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbStokTakip] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbStokTakip] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbStokTakip] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbStokTakip] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbStokTakip] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbStokTakip] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbStokTakip] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbStokTakip] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbStokTakip] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbStokTakip] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbStokTakip] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbStokTakip] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbStokTakip] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbStokTakip] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbStokTakip] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbStokTakip] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbStokTakip] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbStokTakip] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbStokTakip] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbStokTakip] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbStokTakip] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbStokTakip] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbStokTakip] SET RECOVERY FULL 
GO
ALTER DATABASE [DbStokTakip] SET  MULTI_USER 
GO
ALTER DATABASE [DbStokTakip] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbStokTakip] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbStokTakip] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbStokTakip] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbStokTakip] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbStokTakip] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DbStokTakip', N'ON'
GO
ALTER DATABASE [DbStokTakip] SET QUERY_STORE = OFF
GO
USE [DbStokTakip]
GO
/****** Object:  Table [dbo].[TABLE_ADMIN]    Script Date: 5.06.2023 20:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_ADMIN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KULLANICIAD] [varchar](20) NULL,
	[SIFRE] [varchar](20) NULL,
 CONSTRAINT [PK_TABLE_ADMIN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_BANKA]    Script Date: 5.06.2023 20:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_BANKA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BANKA] [varchar](50) NULL,
 CONSTRAINT [PK_TABLE_BANKA] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_DEPARTMAN]    Script Date: 5.06.2023 20:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_DEPARTMAN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DEPARTMAN_AD] [varchar](50) NULL,
	[ACIKLAMA] [varchar](300) NULL,
 CONSTRAINT [PK_TABLE_DEPARTMAN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_FATURABILGI]    Script Date: 5.06.2023 20:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_FATURABILGI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SERI] [char](1) NULL,
	[SIRANO] [varchar](6) NULL,
	[TARIH] [smalldatetime] NULL,
	[SAAT] [char](5) NULL,
	[VERGIDAIRE] [varchar](50) NULL,
	[MUSTERI] [int] NULL,
	[SORUMLU] [int] NULL,
 CONSTRAINT [PK_TABLE_FATURABILGI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_FATURADETAY]    Script Date: 5.06.2023 20:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_FATURADETAY](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[URUN] [varchar](50) NULL,
	[ADET] [int] NULL,
	[FIYAT] [decimal](18, 2) NULL,
	[TUTAR] [decimal](18, 2) NULL,
	[FATURAID] [int] NULL,
 CONSTRAINT [PK_TABLE_FATURADETAY] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_KATEGORI]    Script Date: 5.06.2023 20:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_KATEGORI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KATEGORI_AD] [varchar](50) NULL,
 CONSTRAINT [PK_TABLE_KATEGORI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_MARKA]    Script Date: 5.06.2023 20:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_MARKA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MARKA_AD] [varchar](50) NULL,
 CONSTRAINT [PK_TABLE_MARKA] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_MUSTERI]    Script Date: 5.06.2023 20:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_MUSTERI](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MUSTERI_AD] [varchar](30) NULL,
	[MUSTERI_SOYAD] [varchar](30) NULL,
	[TELEFON] [varchar](20) NULL,
	[MAIL] [varchar](50) NULL,
	[SEHIR] [int] NULL,
	[BANKA] [int] NULL,
	[VERGI_DAIRESI] [varchar](50) NULL,
	[VERGI_NO] [varchar](50) NULL,
	[ADRES] [varchar](250) NULL,
 CONSTRAINT [PK_TABLE_MUSTERI] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_NOTLAR]    Script Date: 5.06.2023 20:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_NOTLAR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BASLIK] [varchar](50) NULL,
	[ICERIK] [varchar](500) NULL,
	[DURUM] [bit] NULL,
	[TARIH] [datetime] NULL,
 CONSTRAINT [PK_TABLE_NOTLAR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_OZELLIKLER]    Script Date: 5.06.2023 20:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_OZELLIKLER](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OZELLIKLER] [varchar](250) NULL,
 CONSTRAINT [PK_TABLE_OZELLIKLER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_SEHIR]    Script Date: 5.06.2023 20:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_SEHIR](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SEHIR] [varchar](20) NULL,
 CONSTRAINT [PK_Table_SEHIR] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_SORUMLU]    Script Date: 5.06.2023 20:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_SORUMLU](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SORUMLU_AD] [varchar](30) NULL,
	[SORUMLU_SOYAD] [varchar](30) NULL,
	[DEPARTMAN] [int] NULL,
	[FOTOGRAF] [varchar](100) NULL,
	[MAIL] [varchar](50) NULL,
	[TELEFON] [varchar](20) NULL,
 CONSTRAINT [PK_TABLE_SORUMLU] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_URUN]    Script Date: 5.06.2023 20:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_URUN](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[URUN_MODEL] [varchar](50) NULL,
	[MARKA] [int] NULL,
	[ALIS_FIYAT] [decimal](18, 2) NULL,
	[SATIS_FIYAT] [decimal](18, 2) NULL,
	[STOK] [int] NULL,
	[KATEGORI] [int] NULL,
	[DURUM] [bit] NULL,
	[OZELLIK] [int] NULL,
 CONSTRAINT [PK_TABLE_URUN] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TABLE_URUNHAREKET]    Script Date: 5.06.2023 20:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TABLE_URUNHAREKET](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[URUN] [int] NULL,
	[MUSTERI] [int] NULL,
	[SORUMLU] [int] NULL,
	[TARIH] [smalldatetime] NULL,
	[ADET] [int] NULL,
	[FIYAT] [decimal](18, 2) NULL,
	[SERINO] [varchar](20) NULL,
 CONSTRAINT [PK_TABLE_URUNHAREKET] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TABLE_ADMIN] ON 

INSERT [dbo].[TABLE_ADMIN] ([ID], [KULLANICIAD], [SIFRE]) VALUES (1, N'ozcan', N'123')
INSERT [dbo].[TABLE_ADMIN] ([ID], [KULLANICIAD], [SIFRE]) VALUES (2, N'merve', N'123')
INSERT [dbo].[TABLE_ADMIN] ([ID], [KULLANICIAD], [SIFRE]) VALUES (3, N'alperen', N'123')
SET IDENTITY_INSERT [dbo].[TABLE_ADMIN] OFF
GO
SET IDENTITY_INSERT [dbo].[TABLE_BANKA] ON 

INSERT [dbo].[TABLE_BANKA] ([ID], [BANKA]) VALUES (1, N'Ziraat Bankası')
INSERT [dbo].[TABLE_BANKA] ([ID], [BANKA]) VALUES (2, N'TEB')
INSERT [dbo].[TABLE_BANKA] ([ID], [BANKA]) VALUES (3, N'İş Bankası')
INSERT [dbo].[TABLE_BANKA] ([ID], [BANKA]) VALUES (4, N'ING')
INSERT [dbo].[TABLE_BANKA] ([ID], [BANKA]) VALUES (5, N'Halkbank')
SET IDENTITY_INSERT [dbo].[TABLE_BANKA] OFF
GO
SET IDENTITY_INSERT [dbo].[TABLE_DEPARTMAN] ON 

INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (1, N'Genel Yönetim', N'Üst seviye yönetim işlemleri bu departman tarafından yürütülür.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (2, N'Muhasebe', N'Hesaplama ve muhasebe işleri bu departman tarafından yürütülür.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (3, N'Müşteri Yönetimi', N'Müşterilerle telefon, internet, e-posta vb. iletişim biçimleriyle iletişime geçen birim.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (4, N'Mağaza Yönetimi', N'Mağazaya gelen müşterilere yardımcı olan mağaza çalışanlarının yönetilmesini amaçlar.  ')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (5, N'Pazarlama ve Promosyon', N'Yeni ürünlerin ve hizmetlerin tanıtımını yapar, satışları teşvik etmek için kampanyalar ve promosyonlar düzenler.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (6, N'Depo ve Lojistik', N'Ürün stoğunu yönetir ve ürünlerin doğru zamanda doğru yerde olmasını sağlar.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (7, N'Teknik Servis', N'Satılan ürünler için garanti kapsamındaki servis hizmetlerini sağlar.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (8, N'İnsan Kaynakları', N'Çalışanların işe alımını, eğitimini ve işten çıkış işlemlerini yönetir.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (9, N'Bilişim Teknolojileri', N'Şirketin bilgi teknolojileri altyapısını yönetir ve teknolojik gereksinimlerini karşılar.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (10, N'Güvenlik Departmanı', N'Mağazanın ve ürünlerin güvenliğini sağlar, hırsızlık gibi olumsuz durumları önler.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (11, N'Eğitim ve Gelişim', N'Çalışanların profesyonel gelişimini destekler, eğitim programları düzenler ve performanslarını değerlendirir.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (12, N'Hukuk', N'Şirketin hukuki işlemlerini yönetir, hukuki riskleri değerlendirir ve hukuki danışmanlık hizmetleri verir.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (13, N'Sosyal Medya', N'Şirketin online varlığını yönetir, sosyal medya stratejilerini belirler ve dijital pazarlama kampanyalarını yürütür.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (14, N'Ar-Ge (Araştırma ve Geliştirme)', N'Yeni teknoloji ve ürün trendlerini takip eder, inovatif çözümler geliştirir ve ürün gamını genişletir.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (15, N'Kalite Kontrol ve Güvence', N'Ürün ve hizmetlerin kalitesini değerlendirir, kalite standartlarını belirler ve sürekli iyileştirme çabalarını yönlendirir.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (16, N'Veri Analizi ve İş Zekası', N'Şirketin genel performansını analiz eder, veri tabanlı içgörüler sağlar ve karar verme süreçlerini destekler.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (17, N'İş Geliştirme', N'Yeni pazar fırsatlarını keşfeder, stratejik planları oluşturur ve iş büyüme stratejilerini uygular.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (18, N'Sosyal Sorumluluk', N'Şirketin sosyal sorumluluk projelerini planlar ve yürütür, sürdürülebilirlik ve toplum hizmeti stratejilerini belirler.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (19, N'Risk Yönetimi', N'Şirketin karşılaşabileceği riskleri analiz eder, risk azaltma stratejileri oluşturur ve uygular.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (20, N'Proje Yönetimi', N'Şirketin çeşitli projelerini planlar, koordine eder ve uygular.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (21, N'Çevre, Sağlık ve Güvenlik (ÇSG)', N'Çalışanların sağlığı ve güvenliği ile çevresel etkilerin yönetimini sağlar.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (22, N'Satış Sonrası Hizmetler', N'Müşterilere satış sonrası destek sağlar, sorunları çözer ve ürün iadelerini ve değişimlerini yönetir.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (23, N'Kurumsal Strateji', N'Şirketin uzun vadeli hedeflerini ve stratejilerini belirler ve uygulamaları koordine eder.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (24, N'Etik ve Uyumluluk', N'Şirketin etik kurallarını ve yasal uyumluluk gerekliliklerini yönetir.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (25, N'Küresel İlişkiler ve İş Ortağı Yönetimi', N'Uluslararası iş ortakları ve tedarikçilerle ilişkileri yönetir, küresel iş stratejilerini geliştirir.')
INSERT [dbo].[TABLE_DEPARTMAN] ([ID], [DEPARTMAN_AD], [ACIKLAMA]) VALUES (26, N'Dijital Dönüşüm', N'Şirketin dijitalleşme süreçlerini yönetir, dijital teknolojileri kullanarak iş modelini ve iş süreçlerini iyileştirir.')
SET IDENTITY_INSERT [dbo].[TABLE_DEPARTMAN] OFF
GO
SET IDENTITY_INSERT [dbo].[TABLE_KATEGORI] ON 

INSERT [dbo].[TABLE_KATEGORI] ([ID], [KATEGORI_AD]) VALUES (1, N'Elektronik')
INSERT [dbo].[TABLE_KATEGORI] ([ID], [KATEGORI_AD]) VALUES (2, N'Bilgisayar')
INSERT [dbo].[TABLE_KATEGORI] ([ID], [KATEGORI_AD]) VALUES (3, N'Beyaz Eşya')
INSERT [dbo].[TABLE_KATEGORI] ([ID], [KATEGORI_AD]) VALUES (4, N'Küçük Ev Aletleri')
INSERT [dbo].[TABLE_KATEGORI] ([ID], [KATEGORI_AD]) VALUES (5, N'Teknoloji Giyim')
INSERT [dbo].[TABLE_KATEGORI] ([ID], [KATEGORI_AD]) VALUES (6, N'Telefon ve Tablet')
INSERT [dbo].[TABLE_KATEGORI] ([ID], [KATEGORI_AD]) VALUES (10, N'Aksesuar')
INSERT [dbo].[TABLE_KATEGORI] ([ID], [KATEGORI_AD]) VALUES (11, N'Outlet')
INSERT [dbo].[TABLE_KATEGORI] ([ID], [KATEGORI_AD]) VALUES (12, N'Kişisel Bakım ve Sağlık')
INSERT [dbo].[TABLE_KATEGORI] ([ID], [KATEGORI_AD]) VALUES (13, N'Spor ve Oyun')
SET IDENTITY_INSERT [dbo].[TABLE_KATEGORI] OFF
GO
SET IDENTITY_INSERT [dbo].[TABLE_MARKA] ON 

INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (1, N'Samsung')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (2, N'LG')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (3, N'Lenovo')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (4, N'Monster')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (5, N'Logitech')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (6, N'Snopy')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (7, N'Beko')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (8, N'MSI')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (9, N'Apple')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (10, N'Xiaomi')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (11, N'Bosch')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (12, N'Amazfit')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (13, N'Arzum')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (14, N'Huawei')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (15, N'ALTUS')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (16, N'Sony')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (17, N'Microsoft')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (18, N'Braun')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (19, N'Rampage')
INSERT [dbo].[TABLE_MARKA] ([ID], [MARKA_AD]) VALUES (20, N'Baseus')
SET IDENTITY_INSERT [dbo].[TABLE_MARKA] OFF
GO
SET IDENTITY_INSERT [dbo].[TABLE_MUSTERI] ON 

INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (1, N'Mehmet', N'Mor', N'(541) 222-3334', N'mehmetmor@gmail.com', 16, 1, N'Vergi Dairesi 2', N'2', N'Görükle Mah. Deneme Sokak No:7 Daire:2 ')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (2, N'Ahmet', N'Şen', N'(555) 887-8334', N'ahmetsen@gmail.com', 34, 2, N'Vergi Dairesi 3', N'5', N'Yıldız Mah. Kova Sokak No:1 Daire:2')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (3, N'Cemal', N'Şakir', N'(541) 872-9334', N'cemalsakir@gmail.com', 6, 3, N'Vergi Dairesi 7', N'9', N'Akpınar Mah. Demet Sokak No:2 Daire:4')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (4, N'Cevdet', N'Melek', N'(542) 779-9661', N'cevdetmelek@gmail.com', 16, 4, N'Vergi Dairesi 10', N'98', N'Akçağlayan Mah. Dere Sokak No:78 Daire:3')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (5, N'Demet', N'Bahar', N'(514) 852-3642', N'demetbahar@gmail.com', 34, 2, N'Vergi Dairesi 4', N'872', N'Sanayi Mah. Su Sokak No: 2')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (7, N'Ece', N'Şeker', N'(547) 987-4123', N'eceseker@gmail.com', 35, 5, N'Vergi Dairesi 7', N'6512', N'Mevlana Mah. Karakedi Sokak No:2 Daire:4')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (8, N'Kemal', N'Ergin', N'(555) 222-8434', N'kemalergin@gmail.com', 16, 3, N'Vergi Dairesi 71', N'12', N'Görükle Mah. Adnan Sokak No:8 Daire:1 ')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (9, N'Melek', N'Ağır', N'(542) 481-2368', N'melekagir@hotmail.com', 1, 3, N'Vergi Dairesi 41', N'85', N'Seyhan Beyaz Sok. No:6')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (10, N'Esra', N'Dolapçı', N'(517) 124-2234', N'esradolapci@gmail.com', 5, 2, N'Vergi Dairesi 2', N'51', N'Cevdettin Mah. Armut Sok. No: 8')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (11, N'Veli', N'Dolap', N'(521) 335-1235', N'velidolap@gmail.com', 7, 1, N'Vergi Dairesi 3', N'854', N'Leyla Mah. Aynalı Sok. No: 8')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (12, N'Alperen', N'Olgun', N'(515) 133-5412', N'alperenolgun@gmail.com', 17, 5, N'Vergi Dairesi 57', N'852', N'Ayna Mah. Kiraz Sok. No: 1')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (13, N'Halil', N'Çaylak', N'(512) 321-5612', N'halilcaylak@hotmail.com', 21, 3, N'Vergi Dairesi 7', N'21', N'Huzur Mah. Kale Sok. No: 3 Daire: 2')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (14, N'Cemal', N'Şakacı', N'(524) 562-1324', N'cemalsakaci@hotmail.com', 25, 3, N'Vergi Dairesi 24', N'22', N'Yeni Mah. Duvar Sok. No: 4 Daire: 2')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (15, N'Hüseyin', N'Sağlam', N'(512) 387-4210', N'huseyinsaglam@hotmail.com', 63, 3, N'Vergi Dairesi 27', N'321', N'Eski Mah. Kel Sok. No: 5 Daire: 2')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (16, N'Arda', N'Turan', N'(581) 232-4721', N'ardaturan@gmail.com', 7, 4, N'Vergi Dairesi 28', N'11', N'Meltem Mah. 211 Sokak No: 14')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (17, N'Hakan', N'Çalhanoğlu', N'(542) 141-3214', N'hakancalhanoglu@gmail.com', 1, 4, N'Vergi Dairesi 32', N'22', N'Kemal Mah. 2134 Sokak No: 15')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (18, N'Emre', N'Mor', N'(515) 842-1354', N'hakancalhanoglu@gmail.com', 16, 5, N'Vergi Dairesi 89', N'33', N'Cenk Mah. 2224 Sokak No: 18')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (19, N'Mehmet', N'Topal', N'(574) 521-5653', N'mehmettopal@yahoo.com', 21, 1, N'Vergi Dairesi 29', N'44', N'Ahmet Mah. 5123 Sok. No: 8 Daire: 5')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (20, N'Halil', N'Altıntop', N'(564) 321-3213', N'halilaltintop@yahoo.com', 5, 1, N'Vergi Dairesi 8', N'88', N'Derviş Mah. 51284 Sok. No: 9 Daire: 5')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (21, N'Şirin', N'Lale', N'(564) 214-5231', N'sirinlale@gmail.com', 24, 3, N'Vergi Dairesi 85', N'8412', N'Müthiş Mah. Gülen Sok. No:8')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (22, N'Zeki', N'Gül', N'(567) 213-2132', N'zekigul@gmail.com', 40, 5, N'Vergi Dairesi 84', N'841', N'Yeni Mah. Gülen Sok. No:8')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (23, N'Emir', N'Uzun', N'(567) 218-9456', N'emiruzun@gmail.com', 45, 2, N'Vergi Dairesi 84', N'8417', N'Eski Mah. Gülen Sok. No:8')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (24, N'Emre', N'Kısa', N'(567) 284-5321', N'emrekisa@gmail.com', 43, 2, N'Vergi Dairesi 54', N'5412', N'Gül Mah. Ağlayan Sok. No: 7')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (25, N'Kardelen', N'Üzgün', N'(542) 313-2181', N'kardelenuzgun@hotmail.com', 37, 4, N'Vergi Dairesi 4', N'87', N'Kardelen Mah. Karabaş Sok. No: 4')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (26, N'Demet', N'Üzgün', N'(542) 313-9656', N'demetuzgun@hotmail.com', 31, 4, N'Vergi Dairesi 5', N'84', N'Demet Mah. Karabaş Sok. No: 4')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (27, N'Can', N'Üzgün', N'(542) 894-2313', N'canuzgun@hotmail.com', 31, 4, N'Vergi Dairesi 4', N'87', N'Demet Mah. Karabaş Sok. No: 4')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (28, N'Özcan', N'Mutlu', N'(544) 531-2312', N'ozcanmutlu@hotmail.com', 48, 4, N'Vergi Dairesi 5', N'89', N'Neslihan Mah. Ayşe Sok. No: 4')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (29, N'Ozan', N'Genç', N'(548) 432-1321', N'ozangenc@hotmail.com', 7, 1, N'Vergi Dairesi 6', N'98', N'Amaç Mah. Ayşe Sok. No: 7')
INSERT [dbo].[TABLE_MUSTERI] ([ID], [MUSTERI_AD], [MUSTERI_SOYAD], [TELEFON], [MAIL], [SEHIR], [BANKA], [VERGI_DAIRESI], [VERGI_NO], [ADRES]) VALUES (30, N'Kemal', N'Dertli', N'(548) 454-1321', N'kemaldertli@hotmail.com', 1, 5, N'Vergi Dairesi 41', N'100', N'Amaçsız Mah. Fatma Sok. No: 7')
SET IDENTITY_INSERT [dbo].[TABLE_MUSTERI] OFF
GO
SET IDENTITY_INSERT [dbo].[TABLE_NOTLAR] ON 

INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (1, N'Toplantı', N'28 Mayıs''da genel yönetim toplantısı planlandı.', 0, CAST(N'2023-05-28T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (2, N'Stok Yenileme', N'15 Mayıs''da Iphone 11 Stokları yenilenecek', 1, CAST(N'2023-05-15T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (4, N'Toplantı Planı', N'30 Mayıs''da muhasebe yönetim toplantısı var', 0, CAST(N'2023-05-30T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (6, N'İade Ürün', N'Müşterinin iadesi alınacak', 1, CAST(N'2023-05-15T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (7, N'İade Ürün İptali', N'Müşterinin iadesi iptal edilecek  ', 1, CAST(N'2023-05-19T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (8, N'Ürün Sevkiyat', N'Dizüstü bilgisayar sevkiyatı yapılacak', 0, CAST(N'2023-05-31T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (9, N'Hasar Tespit', N'Hasar tespit yapılacak', 0, CAST(N'2023-06-01T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (10, N'Ürün Geliştirme', N'Yeni yazılım versiyonunun beta sürümü önümüzdeki hafta tamamlanacak.', 0, CAST(N'2023-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (11, N'Donanım Üretim', N'Yeni donanım bileşenlerinin üretim süreci 3 gün içinde başlayacak.', 0, CAST(N'2023-06-28T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (12, N'Yazılım Güncelleme', N'Haftaya pazartesi günü tüm sunucular için yazılım güncellemesi yapılacak.', 0, CAST(N'2023-06-12T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (13, N'Müşteri Toplantısı', N'Önemli bir müşteriyle yıllık değerlendirme toplantısı gelecek hafta salı günü saat 13:00''te.', 1, CAST(N'2023-06-04T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (14, N'Kod İncelemesi', N'Yeni özelliklerin kod incelemesi cuma gününe kadar tamamlanmalıdır.', 0, CAST(N'2023-06-09T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (15, N'Veri Yedekleme', N'Büyük veri yedeklemesi yarın gece yarısında başlayacak ve sabah 5''e kadar sürmesi bekleniyor.', 0, CAST(N'2023-06-09T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (16, N'Fiyat Güncelleme', N'Tüm akıllı telefonların fiyatları yarın sabah ilk iş olarak güncellenecek.', 1, CAST(N'2023-06-02T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (17, N'Envanter Kontrolü', N'Ay sonu envanter kontrolü ve sayımı bu cuma günü yapılacak.', 1, CAST(N'2023-01-02T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (18, N'Kargo Gönderimi', N'Toplu online siparişler bugün saat 16:00''da kargoya verilecek.
', 1, CAST(N'2023-01-05T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (19, N'Personel Değişikliği', N'Gece vardiyasındaki personel değişiklikleri bugün itibarıyla uygulanacak.', 0, CAST(N'2023-06-20T00:00:00.000' AS DateTime))
INSERT [dbo].[TABLE_NOTLAR] ([ID], [BASLIK], [ICERIK], [DURUM], [TARIH]) VALUES (20, N'Mağaza Düzenlemesi', N'Yeni ürün sergileme düzenlemesi perşembe günü tamamlanacak.', 0, CAST(N'2023-06-12T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[TABLE_NOTLAR] OFF
GO
SET IDENTITY_INSERT [dbo].[TABLE_OZELLIKLER] ON 

INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (1, N'50MP Kamera, Hızlı Şarj, OneUI 5.1 Ram:8GB')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (2, N'8MP Kamera Ram:3GB')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (3, N'Intel Core i5 1135 Ram:16GB SSD:512GB')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (4, N'720P HD Görüntü Kalitesi')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (5, N'Amoled Ekran, Nabız Ölçer, Aktivite Planlayıcı')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (6, N'Buharlı Yeni Nesil Ütü ')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (7, N'Hacim:580L, Mavi Işık Tekonolojisi mevcut')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (8, N'İşlemci: M2, Ram: 8GB, SSD: 256GB')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (9, N'İşlemci: M1, Ram: 8GB, SSD: 256GB')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (10, N'Hacim:580L, Mavi Işık Teknolojisi mevcut')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (11, N'İşlemci: i7 11700H, Ram:16GB, SSD: 1TB')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (12, N'İşlemci: Snapdragon 865, Ram: 8GB, Rom: 128GB')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (13, N'İşlemci: Snapdragon 865, Ram: 8GB, Kamera: 12MP, ROM: 256GB')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (14, N'İşlemci: A13 Bionic, Ram: 4GB, Kamera: 12MP, ROM: 128GB')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (15, N'')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (16, N'1080P HD Görüntü Kalitesi')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (17, N'RAM:8GB')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (18, N'İşlemci M1 Ram:8GB
')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (19, N'40 MM İşletim Sistemi: WearOS')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (20, N'Hafıza: 256GB, Ram:8GB Kamera: 128MP')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (21, N'Hafıza: 128GB, Ram:8GB Kamera: 64MP')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (22, N'Hafıza: 64GB, Wi-Fİ, Kamera: 8MP')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (23, N'Hafıza: 128GB, Wi-Fİ, Kamera: 32MP')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (24, N'Hafıza: 256GB, Wi-Fİ, RAM:8GB')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (25, N'İşlemci: i51155g7 Hafıza: 512GB, Wi-Fİ, RAM:16GB ')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (26, N'İşlemci: Ryzen5 7520 Hafıza: 512GB, Wi-Fİ, RAM: 8 GB ')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (27, N'Hacim: 323L Bölüm: 4')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (28, N'Kapasite: 10KG, Devir: 1200RPM')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (29, N'3D BAŞLIK')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (30, N'Ram: 4GB, İşlemci: A12 Bionic')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (31, N'Maksimum sürat: 30 KM/Saat')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (32, N'Stylus Kalem')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (33, N'Laptop Soğutucu')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (34, N'İşlemci: Snapdragon 865 Ram: 6 GB, Depolama: 128 GB')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (35, N'8K SMART HD WebOS')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (36, N'360 Derece Dönüş Açısı')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (37, N'3800 MHZ OC, Dual Channel Ram, Maksimum 64 GB Ram kapasitesi')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (38, N'Ankastre mikrodalga fırın, 800W, 20L Pişirme Haznesi Kapasitesi')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (39, N'7 Çekmeceli 256 Litre Hacim No Frost Derin Dondurucu')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (40, N'İşlemci: AMD Zen 2, İşlemci Hızı: 3.5 GHz')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (41, N'Bellek Kapasitesi: 1 TB, Depolama: 1 TB')
INSERT [dbo].[TABLE_OZELLIKLER] ([ID], [OZELLIKLER]) VALUES (42, N'Bıçak malzemesi: Paslanmaz Çelik')
SET IDENTITY_INSERT [dbo].[TABLE_OZELLIKLER] OFF
GO
SET IDENTITY_INSERT [dbo].[TABLE_SEHIR] ON 

INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (1, N'Adana')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (2, N'Adıyaman')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (3, N'Afyonkarahisar')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (4, N'Ağrı')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (5, N'Amasya')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (6, N'Ankara')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (7, N'Antalya')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (8, N'Artvin')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (9, N'Aydın')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (10, N'Balıkesir')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (11, N'Bilecik')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (12, N'Bingöl')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (13, N'Bitlis')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (14, N'Bolu')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (15, N'Burdur')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (16, N'Bursa')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (17, N'Çanakkale')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (18, N'Çankırı')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (19, N'Çorum')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (20, N'Denizli')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (21, N'Diyarbakır')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (22, N'Edirne')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (23, N'Elazığ')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (24, N'Erzincan')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (25, N'Erzurum')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (26, N'Eskişehir')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (27, N'Gaziantep')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (28, N'Giresun')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (29, N'Gümüşhane')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (30, N'Hakkari')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (31, N'Hatay')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (32, N'Isparta')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (33, N'Mersin')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (34, N'İstanbul')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (35, N'İzmir')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (36, N'Kars')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (37, N'Kastamonu')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (38, N'Kayseri')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (39, N'Kırklareli')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (40, N'Kırşehir')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (41, N'Kocaeli')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (42, N'Konya')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (43, N'Kütahya')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (44, N'Malatya')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (45, N'Manisa')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (46, N'Kahramanmaraş')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (47, N'Mardin')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (48, N'Muğla')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (49, N'Muş')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (50, N'Nevşehir')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (51, N'Niğde')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (52, N'Ordu')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (53, N'Rize')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (54, N'Sakarya')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (55, N'Samsun')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (56, N'Siirt')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (57, N'Sinop')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (58, N'Sivas')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (59, N'Tekirdağ')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (60, N'Tokat')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (61, N'Trabzon')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (62, N'Tunceli')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (63, N'Şanlıurfa')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (64, N'Uşak')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (65, N'Van')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (66, N'Yozgat')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (67, N'Zonguldak')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (68, N'Aksaray')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (69, N'Bayburt')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (70, N'Karaman')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (71, N'Kırıkkale')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (72, N'Batman')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (73, N'Şırnak')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (74, N'Bartın')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (75, N'Ardahan')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (76, N'Iğdır')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (77, N'Yalova')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (78, N'Karabük')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (79, N'Kilis')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (80, N'Osmaniye')
INSERT [dbo].[TABLE_SEHIR] ([ID], [SEHIR]) VALUES (81, N'Düzce')
SET IDENTITY_INSERT [dbo].[TABLE_SEHIR] OFF
GO
SET IDENTITY_INSERT [dbo].[TABLE_SORUMLU] ON 

INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (1, N'Demet', N'Harika', 1, NULL, N'demetharika@gmail.com', N'(511) 239-7884')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (2, N'Merve ', N'Çırak', 2, NULL, N'merve@gmail.com', N'(512) 854-2134')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (3, N'Cevdet', N'Şen', 1, NULL, N'cevdetsen@gmail.com', N'(517) 892-3121')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (4, N'Kardelen', N'Genç', 3, NULL, N'kardelengenc@hotmail.com', N'(512) 354-2347')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (5, N'Ahmet', N'Er', 4, NULL, N'ahmeter@hotmail.com', N'(543) 216-5841')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (6, N'Mehmet', N'İnce', 4, NULL, N'mehmetince@hotmail.com', N'(546) 532-1315')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (7, N'Cenk', N'Topal', 1, NULL, N'cenktopal@hotmail.com', N'(541) 215-6413')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (8, N'Mehmet', N'Dinç', 3, NULL, N'mehmetdinc@hotmail.com', N'(541) 248-1231')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (9, N'Hasan', N'Yaşlı', 2, NULL, N'hasanyasli@hotmail.com', N'(542) 181-3212')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (10, N'Günay', N'Neşeli', 4, NULL, N'gunayneseli@gmail.com', N'(545) 421-2212')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (11, N'Özcan', N'Işık', 1, NULL, N'ozcanisik@gmail.com', N'(545) 425-4561')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (12, N'Alperen', N'Mengi', 4, NULL, N'alperenmengi@gmail.com', N'(545) 425-4561')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (13, N'Ayşe', N'Fatma', 14, NULL, N'aysefatma@gmail.com', N'(543) 218-9132')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (14, N'Ayşenur', N'Kadın', 15, NULL, N'aysenur@gmail.com', N'(545) 421-9131')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (15, N'Yağmur', N'Uzun', 16, NULL, N'yagmur@gmail.com', N'(545) 432-1321')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (16, N'Özge', N'Uzun', 21, NULL, N'ozge@gmail.com', N'(545) 432-1321')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (17, N'Hilal', N'Kısa', 24, NULL, N'hilal@gmail.com', N'(545) 785-5416')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (18, N'Güneş', N'Parlak', 26, NULL, N'gunesparlak@gmail.com', N'(545) 454-5412')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (19, N'Gençer', N'Parlak', 23, NULL, N'gencer@gmail.com', N'(545) 987-6542')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (20, N'Hüseyin', N'Pas', 17, NULL, N'huseyinpas@gmail.com', N'(548) 975-6413')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (21, N'Ece', N'Mutlu', 12, NULL, N'ecemutlu@gmail.com', N'(548) 544-5132')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (22, N'Çisem', N'Melek', 19, NULL, N'cisem@gmail.com', N'(548) 544-4545')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (23, N'Berkay', N'Şahin', 11, NULL, N'berkay@gmail.com', N'(548) 784-2123')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (24, N'Melih', N'Uzun', 10, NULL, N'melih@gmail.com', N'(548) 789-7561')
INSERT [dbo].[TABLE_SORUMLU] ([ID], [SORUMLU_AD], [SORUMLU_SOYAD], [DEPARTMAN], [FOTOGRAF], [MAIL], [TELEFON]) VALUES (25, N'Murat', N'Işık', 9, NULL, N'muratisik@gmail.com', N'(548) 846-5435')
SET IDENTITY_INSERT [dbo].[TABLE_SORUMLU] OFF
GO
SET IDENTITY_INSERT [dbo].[TABLE_URUN] ON 

INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (1, N'Macbook Air M1', 9, CAST(17000.00 AS Decimal(18, 2)), CAST(18500.00 AS Decimal(18, 2)), 49, 2, 0, 9)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (2, N'İpad 10. Nesil', 9, CAST(6000.00 AS Decimal(18, 2)), CAST(7500.00 AS Decimal(18, 2)), 1996, 6, 0, 2)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (3, N'Monster Abra A5', 4, CAST(28000.00 AS Decimal(18, 2)), CAST(32000.00 AS Decimal(18, 2)), 995, 2, 0, 3)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (4, N'Logitech C310', 5, CAST(500.00 AS Decimal(18, 2)), CAST(700.00 AS Decimal(18, 2)), 3000, 1, 0, 4)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (5, N'Amazfit Neo', 12, CAST(2200.00 AS Decimal(18, 2)), CAST(2400.00 AS Decimal(18, 2)), 780, 5, 0, 5)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (6, N'Arzum AR600', 13, CAST(2500.00 AS Decimal(18, 2)), CAST(2700.00 AS Decimal(18, 2)), 1400, 4, 0, 6)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (7, N'Beko EI
No Frost Buzdolabı', 7, CAST(14000.00 AS Decimal(18, 2)), CAST(17000.00 AS Decimal(18, 2)), 100, 3, 0, 10)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (11, N'Mac Mini M2', 9, CAST(20000.00 AS Decimal(18, 2)), CAST(25000.00 AS Decimal(18, 2)), 20, 2, 1, 8)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (13, N'Monster Tulpar V7', 4, CAST(30000.00 AS Decimal(18, 2)), CAST(35000.00 AS Decimal(18, 2)), 185, 2, 0, 11)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (14, N'Mi 10T', 10, CAST(10000.00 AS Decimal(18, 2)), CAST(11000.00 AS Decimal(18, 2)), 20, 6, 1, 12)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (15, N'Galaxy S20FE', 1, CAST(10000.00 AS Decimal(18, 2)), CAST(11500.00 AS Decimal(18, 2)), 700, 6, 0, 13)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (16, N'Iphone 11', 9, CAST(14000.00 AS Decimal(18, 2)), CAST(15005.00 AS Decimal(18, 2)), 1500, 6, 0, 14)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (17, N'C270', 5, CAST(450.00 AS Decimal(18, 2)), CAST(600.00 AS Decimal(18, 2)), 500, 1, 0, 4)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (19, N'C920', 5, CAST(1450.00 AS Decimal(18, 2)), CAST(1700.00 AS Decimal(18, 2)), 40, 1, 1, 16)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (20, N'Macbook Air M2', 9, CAST(25000.00 AS Decimal(18, 2)), CAST(28000.00 AS Decimal(18, 2)), 140, 2, 0, 8)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (21, N'Galaxy S23', 1, CAST(21000.00 AS Decimal(18, 2)), CAST(24000.00 AS Decimal(18, 2)), 10, 6, 1, 17)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (22, N'İpad Pro', 9, CAST(15000.00 AS Decimal(18, 2)), CAST(20000.00 AS Decimal(18, 2)), 30, 6, 1, 18)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (24, N'Galaxy Watch 4', 1, CAST(2750.00 AS Decimal(18, 2)), CAST(3099.00 AS Decimal(18, 2)), 50, 5, 1, 19)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (25, N'Redmi Note 12 Pro', 10, CAST(10000.00 AS Decimal(18, 2)), CAST(10599.00 AS Decimal(18, 2)), 35, 6, 1, 20)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (26, N'Galaxy A34', 1, CAST(9000.00 AS Decimal(18, 2)), CAST(9749.00 AS Decimal(18, 2)), 40, 6, 1, 21)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (27, N'Galaxy TAB A7 Lite', 1, CAST(2000.00 AS Decimal(18, 2)), CAST(2499.00 AS Decimal(18, 2)), 60, 6, 0, 22)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (28, N'Lenovo Tab P11 ', 3, CAST(9000.00 AS Decimal(18, 2)), CAST(9999.00 AS Decimal(18, 2)), 40, 6, 1, 23)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (29, N'Macbook Pro M2', 9, CAST(32000.00 AS Decimal(18, 2)), CAST(34999.00 AS Decimal(18, 2)), 80, 2, 0, 24)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (30, N'IdeaPad3', 3, CAST(15000.00 AS Decimal(18, 2)), CAST(15999.00 AS Decimal(18, 2)), 50, 2, 1, 25)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (31, N'IdeaPad Slim3', 3, CAST(12000.00 AS Decimal(18, 2)), CAST(12999.00 AS Decimal(18, 2)), 50, 2, 1, 26)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (32, N'RZ32A74A5AP/TR', 1, CAST(24000.00 AS Decimal(18, 2)), CAST(25999.00 AS Decimal(18, 2)), 60, 3, 0, 27)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (33, N'CM 10120 Çamaşır Makinesi', 7, CAST(14000.00 AS Decimal(18, 2)), CAST(15999.00 AS Decimal(18, 2)), 60, 3, 0, 28)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (34, N'Xiaomi Enchen Blackstone', 10, CAST(250.00 AS Decimal(18, 2)), CAST(399.00 AS Decimal(18, 2)), 150, 12, 0, 29)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (35, N'Iphone XS Max', 9, CAST(15000.00 AS Decimal(18, 2)), CAST(16000.00 AS Decimal(18, 2)), 20, 11, 1, 30)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (36, N'Mi Scooter', 10, CAST(3000.00 AS Decimal(18, 2)), CAST(3500.00 AS Decimal(18, 2)), 40, 13, 1, 31)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (37, N'BASEUS Stylus', 20, CAST(300.00 AS Decimal(18, 2)), CAST(380.00 AS Decimal(18, 2)), 150, 10, 0, 32)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (38, N'RAMPAGE Addison', 19, CAST(500.00 AS Decimal(18, 2)), CAST(599.00 AS Decimal(18, 2)), 200, 10, 0, 33)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (39, N'Matepad 11', 14, CAST(7000.00 AS Decimal(18, 2)), CAST(8499.00 AS Decimal(18, 2)), 300, 6, 0, 34)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (40, N'LG 86QNED816RE', 2, CAST(70000.00 AS Decimal(18, 2)), CAST(77000.00 AS Decimal(18, 2)), 25, 1, 1, 35)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (41, N'V5H Direksiyon Seti', 6, CAST(1500.00 AS Decimal(18, 2)), CAST(1629.00 AS Decimal(18, 2)), 500, 10, 0, 36)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (42, N'MSI Z270 PC MATE Anakart', 8, CAST(1000.00 AS Decimal(18, 2)), CAST(1200.00 AS Decimal(18, 2)), 500, 2, 0, 37)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (43, N'BOSCH BEL524MS0', 11, CAST(8000.00 AS Decimal(18, 2)), CAST(8989.00 AS Decimal(18, 2)), 100, 3, 0, 38)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (44, N'ALTUS AL 709', 15, CAST(8000.00 AS Decimal(18, 2)), CAST(9999.00 AS Decimal(18, 2)), 50, 3, 1, 39)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (45, N'Playstation 5', 16, CAST(18000.00 AS Decimal(18, 2)), CAST(19200.00 AS Decimal(18, 2)), 40, 13, 1, 40)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (46, N'XBOX Series X', 17, CAST(18000.00 AS Decimal(18, 2)), CAST(20999.00 AS Decimal(18, 2)), 45, 13, 1, 41)
INSERT [dbo].[TABLE_URUN] ([ID], [URUN_MODEL], [MARKA], [ALIS_FIYAT], [SATIS_FIYAT], [STOK], [KATEGORI], [DURUM], [OZELLIK]) VALUES (47, N'BRAUN MGK7320', 18, CAST(1700.00 AS Decimal(18, 2)), CAST(1899.00 AS Decimal(18, 2)), 100, 12, 0, 42)
SET IDENTITY_INSERT [dbo].[TABLE_URUN] OFF
GO
SET IDENTITY_INSERT [dbo].[TABLE_URUNHAREKET] ON 

INSERT [dbo].[TABLE_URUNHAREKET] ([ID], [URUN], [MUSTERI], [SORUMLU], [TARIH], [ADET], [FIYAT], [SERINO]) VALUES (2, 1, 2, 1, CAST(N'2023-05-01T00:01:00' AS SmallDateTime), 1, CAST(18500.00 AS Decimal(18, 2)), N'123456')
INSERT [dbo].[TABLE_URUNHAREKET] ([ID], [URUN], [MUSTERI], [SORUMLU], [TARIH], [ADET], [FIYAT], [SERINO]) VALUES (5, 1, 5, 2, CAST(N'2023-06-21T00:00:00' AS SmallDateTime), 2, CAST(7500.00 AS Decimal(18, 2)), N'544800')
INSERT [dbo].[TABLE_URUNHAREKET] ([ID], [URUN], [MUSTERI], [SORUMLU], [TARIH], [ADET], [FIYAT], [SERINO]) VALUES (6, 3, 7, 2, CAST(N'2023-06-10T00:00:00' AS SmallDateTime), 5, CAST(32000.00 AS Decimal(18, 2)), N'416872')
SET IDENTITY_INSERT [dbo].[TABLE_URUNHAREKET] OFF
GO
ALTER TABLE [dbo].[TABLE_NOTLAR] ADD  CONSTRAINT [DF_TABLE_NOTLAR_DURUM]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[TABLE_URUN] ADD  CONSTRAINT [DF_TABLE_URUN_DURUM]  DEFAULT ((0)) FOR [DURUM]
GO
ALTER TABLE [dbo].[TABLE_FATURABILGI]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_FATURABILGI_TABLE_MUSTERI] FOREIGN KEY([MUSTERI])
REFERENCES [dbo].[TABLE_MUSTERI] ([ID])
GO
ALTER TABLE [dbo].[TABLE_FATURABILGI] CHECK CONSTRAINT [FK_TABLE_FATURABILGI_TABLE_MUSTERI]
GO
ALTER TABLE [dbo].[TABLE_FATURABILGI]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_FATURABILGI_TABLE_SORUMLU] FOREIGN KEY([SORUMLU])
REFERENCES [dbo].[TABLE_SORUMLU] ([ID])
GO
ALTER TABLE [dbo].[TABLE_FATURABILGI] CHECK CONSTRAINT [FK_TABLE_FATURABILGI_TABLE_SORUMLU]
GO
ALTER TABLE [dbo].[TABLE_FATURADETAY]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_FATURADETAY_TABLE_FATURABILGI] FOREIGN KEY([FATURAID])
REFERENCES [dbo].[TABLE_FATURABILGI] ([ID])
GO
ALTER TABLE [dbo].[TABLE_FATURADETAY] CHECK CONSTRAINT [FK_TABLE_FATURADETAY_TABLE_FATURABILGI]
GO
ALTER TABLE [dbo].[TABLE_MUSTERI]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_MUSTERI_TABLE_BANKA] FOREIGN KEY([BANKA])
REFERENCES [dbo].[TABLE_BANKA] ([ID])
GO
ALTER TABLE [dbo].[TABLE_MUSTERI] CHECK CONSTRAINT [FK_TABLE_MUSTERI_TABLE_BANKA]
GO
ALTER TABLE [dbo].[TABLE_MUSTERI]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_MUSTERI_TABLE_SEHIR] FOREIGN KEY([SEHIR])
REFERENCES [dbo].[TABLE_SEHIR] ([ID])
GO
ALTER TABLE [dbo].[TABLE_MUSTERI] CHECK CONSTRAINT [FK_TABLE_MUSTERI_TABLE_SEHIR]
GO
ALTER TABLE [dbo].[TABLE_SORUMLU]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_SORUMLU_TABLE_DEPARTMAN] FOREIGN KEY([DEPARTMAN])
REFERENCES [dbo].[TABLE_DEPARTMAN] ([ID])
GO
ALTER TABLE [dbo].[TABLE_SORUMLU] CHECK CONSTRAINT [FK_TABLE_SORUMLU_TABLE_DEPARTMAN]
GO
ALTER TABLE [dbo].[TABLE_URUN]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_URUN_TABLE_KATEGORI] FOREIGN KEY([KATEGORI])
REFERENCES [dbo].[TABLE_KATEGORI] ([ID])
GO
ALTER TABLE [dbo].[TABLE_URUN] CHECK CONSTRAINT [FK_TABLE_URUN_TABLE_KATEGORI]
GO
ALTER TABLE [dbo].[TABLE_URUN]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_URUN_TABLE_MARKA] FOREIGN KEY([MARKA])
REFERENCES [dbo].[TABLE_MARKA] ([ID])
GO
ALTER TABLE [dbo].[TABLE_URUN] CHECK CONSTRAINT [FK_TABLE_URUN_TABLE_MARKA]
GO
ALTER TABLE [dbo].[TABLE_URUN]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_URUN_TABLE_OZELLIKLER] FOREIGN KEY([OZELLIK])
REFERENCES [dbo].[TABLE_OZELLIKLER] ([ID])
GO
ALTER TABLE [dbo].[TABLE_URUN] CHECK CONSTRAINT [FK_TABLE_URUN_TABLE_OZELLIKLER]
GO
ALTER TABLE [dbo].[TABLE_URUNHAREKET]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_URUNHAREKET_TABLE_MUSTERI] FOREIGN KEY([MUSTERI])
REFERENCES [dbo].[TABLE_MUSTERI] ([ID])
GO
ALTER TABLE [dbo].[TABLE_URUNHAREKET] CHECK CONSTRAINT [FK_TABLE_URUNHAREKET_TABLE_MUSTERI]
GO
ALTER TABLE [dbo].[TABLE_URUNHAREKET]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_URUNHAREKET_TABLE_SORUMLU] FOREIGN KEY([SORUMLU])
REFERENCES [dbo].[TABLE_SORUMLU] ([ID])
GO
ALTER TABLE [dbo].[TABLE_URUNHAREKET] CHECK CONSTRAINT [FK_TABLE_URUNHAREKET_TABLE_SORUMLU]
GO
ALTER TABLE [dbo].[TABLE_URUNHAREKET]  WITH CHECK ADD  CONSTRAINT [FK_TABLE_URUNHAREKET_TABLE_URUN] FOREIGN KEY([URUN])
REFERENCES [dbo].[TABLE_URUN] ([ID])
GO
ALTER TABLE [dbo].[TABLE_URUNHAREKET] CHECK CONSTRAINT [FK_TABLE_URUNHAREKET_TABLE_URUN]
GO
USE [master]
GO
ALTER DATABASE [DbStokTakip] SET  READ_WRITE 
GO
