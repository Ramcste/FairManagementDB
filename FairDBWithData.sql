USE [master]
GO
/****** Object:  Database [FairDB]    Script Date: 26-05-2015 10:53:18 PM ******/
CREATE DATABASE [FairDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FairDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\FairDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FairDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\FairDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FairDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FairDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FairDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FairDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FairDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FairDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FairDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FairDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [FairDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FairDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FairDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FairDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FairDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FairDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FairDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FairDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FairDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FairDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FairDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FairDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FairDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FairDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FairDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FairDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FairDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FairDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FairDB] SET  MULTI_USER 
GO
ALTER DATABASE [FairDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FairDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FairDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FairDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [FairDB]
GO
/****** Object:  Table [dbo].[tbl_Visit]    Script Date: 26-05-2015 10:53:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Visit](
	[vzr_Id] [int] IDENTITY(1,1) NOT NULL,
	[visitor_Id] [int] NOT NULL,
	[zone_Id] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Visit] PRIMARY KEY CLUSTERED 
(
	[vzr_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Visitor]    Script Date: 26-05-2015 10:53:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Visitor](
	[v_Id] [int] IDENTITY(1,1) NOT NULL,
	[v_Name] [varchar](50) NOT NULL,
	[v_Email] [varchar](50) NOT NULL,
	[v_ContactNo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Visitor] PRIMARY KEY CLUSTERED 
(
	[v_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_Zone]    Script Date: 26-05-2015 10:53:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Zone](
	[z_Id] [int] IDENTITY(1,1) NOT NULL,
	[z_TypeName] [varchar](50) NOT NULL,
	[z_NoOfVisitors] [int] NULL,
 CONSTRAINT [PK_tbl_Zone] PRIMARY KEY CLUSTERED 
(
	[z_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_Visit] ON 

INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (1, 8, 2)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (2, 8, 4)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (3, 8, 6)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (4, 9, 1)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (5, 9, 2)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (6, 9, 3)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (7, 9, 4)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (8, 9, 5)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (9, 9, 6)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (10, 9, 1006)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (11, 9, 1)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (12, 9, 2)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (13, 9, 3)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (14, 9, 4)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (15, 9, 5)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (16, 9, 6)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (17, 9, 1006)
SET IDENTITY_INSERT [dbo].[tbl_Visit] OFF
SET IDENTITY_INSERT [dbo].[tbl_Visitor] ON 

INSERT [dbo].[tbl_Visitor] ([v_Id], [v_Name], [v_Email], [v_ContactNo]) VALUES (1, N'Monir Hossain', N'm@gmail.com', N'123')
INSERT [dbo].[tbl_Visitor] ([v_Id], [v_Name], [v_Email], [v_ContactNo]) VALUES (2, N'Monir Hossain', N'm@gmail.com', N'123')
INSERT [dbo].[tbl_Visitor] ([v_Id], [v_Name], [v_Email], [v_ContactNo]) VALUES (3, N'Roni', N'r@gmail.com', N'12345')
INSERT [dbo].[tbl_Visitor] ([v_Id], [v_Name], [v_Email], [v_ContactNo]) VALUES (4, N'Ram', N'r@yahoo.com', N'123')
INSERT [dbo].[tbl_Visitor] ([v_Id], [v_Name], [v_Email], [v_ContactNo]) VALUES (5, N'roni23', N'roni.roni@roni.com', N'123459090')
INSERT [dbo].[tbl_Visitor] ([v_Id], [v_Name], [v_Email], [v_ContactNo]) VALUES (6, N'ramram', N'ram@ram.com', N'0774')
INSERT [dbo].[tbl_Visitor] ([v_Id], [v_Name], [v_Email], [v_ContactNo]) VALUES (7, N'rajesh', N'rajesh@stag', N'2323')
INSERT [dbo].[tbl_Visitor] ([v_Id], [v_Name], [v_Email], [v_ContactNo]) VALUES (8, N'roni3', N'email', N'330')
INSERT [dbo].[tbl_Visitor] ([v_Id], [v_Name], [v_Email], [v_ContactNo]) VALUES (9, N'Monir Hossain2', N'm1@gmail.com', N'12')
SET IDENTITY_INSERT [dbo].[tbl_Visitor] OFF
SET IDENTITY_INSERT [dbo].[tbl_Zone] ON 

INSERT [dbo].[tbl_Zone] ([z_Id], [z_TypeName], [z_NoOfVisitors]) VALUES (1, N'Enterprise Application Zone', NULL)
INSERT [dbo].[tbl_Zone] ([z_Id], [z_TypeName], [z_NoOfVisitors]) VALUES (2, N'Mobile Apps Zone', NULL)
INSERT [dbo].[tbl_Zone] ([z_Id], [z_TypeName], [z_NoOfVisitors]) VALUES (3, N'Games & Multimedia Zone', NULL)
INSERT [dbo].[tbl_Zone] ([z_Id], [z_TypeName], [z_NoOfVisitors]) VALUES (4, N'Telecom Software Zone', NULL)
INSERT [dbo].[tbl_Zone] ([z_Id], [z_TypeName], [z_NoOfVisitors]) VALUES (5, N'Digital Bangladesh Zone', NULL)
INSERT [dbo].[tbl_Zone] ([z_Id], [z_TypeName], [z_NoOfVisitors]) VALUES (6, N'Books Zone', NULL)
INSERT [dbo].[tbl_Zone] ([z_Id], [z_TypeName], [z_NoOfVisitors]) VALUES (1006, N'Ramesh Zone', 0)
SET IDENTITY_INSERT [dbo].[tbl_Zone] OFF
ALTER TABLE [dbo].[tbl_Zone] ADD  CONSTRAINT [DF_tbl_Zone_z_NoOfVisitors]  DEFAULT ((0)) FOR [z_NoOfVisitors]
GO
ALTER TABLE [dbo].[tbl_Visitor]  WITH CHECK ADD  CONSTRAINT [FK_Visitor_Visitor] FOREIGN KEY([v_Id])
REFERENCES [dbo].[tbl_Visitor] ([v_Id])
GO
ALTER TABLE [dbo].[tbl_Visitor] CHECK CONSTRAINT [FK_Visitor_Visitor]
GO
USE [master]
GO
ALTER DATABASE [FairDB] SET  READ_WRITE 
GO
