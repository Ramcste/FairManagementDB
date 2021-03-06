
USE [FairDB]
GO
/****** Object:  Table [dbo].[tbl_Visit]    Script Date: 27-05-2015 03:47:39 AM ******/
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
/****** Object:  Table [dbo].[tbl_Visitor]    Script Date: 27-05-2015 03:47:39 AM ******/
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
/****** Object:  Table [dbo].[tbl_Zone]    Script Date: 27-05-2015 03:47:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_Zone](
	[z_Id] [int] IDENTITY(1,1) NOT NULL,
	[z_TypeName] [varchar](50) NOT NULL,
	[z_NoOfVisitors] [int] NOT NULL,
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
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (18, 10, 1)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (19, 10, 2)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (20, 10, 3)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (21, 10, 4)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (22, 10, 5)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (23, 10, 6)
INSERT [dbo].[tbl_Visit] ([vzr_Id], [visitor_Id], [zone_Id]) VALUES (24, 10, 1006)
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
INSERT [dbo].[tbl_Visitor] ([v_Id], [v_Name], [v_Email], [v_ContactNo]) VALUES (10, N'Ramesh Kumar Goswami', N'ramesh@gmail.com', N'12345678890')
SET IDENTITY_INSERT [dbo].[tbl_Visitor] OFF
SET IDENTITY_INSERT [dbo].[tbl_Zone] ON 

INSERT [dbo].[tbl_Zone] ([z_Id], [z_TypeName], [z_NoOfVisitors]) VALUES (1, N'Enterprise Application Zone', 11)
INSERT [dbo].[tbl_Zone] ([z_Id], [z_TypeName], [z_NoOfVisitors]) VALUES (2, N'Mobile Apps Zone', 11)
INSERT [dbo].[tbl_Zone] ([z_Id], [z_TypeName], [z_NoOfVisitors]) VALUES (3, N'Games & Multimedia Zone', 11)
INSERT [dbo].[tbl_Zone] ([z_Id], [z_TypeName], [z_NoOfVisitors]) VALUES (4, N'Telecom Software Zone', 11)
INSERT [dbo].[tbl_Zone] ([z_Id], [z_TypeName], [z_NoOfVisitors]) VALUES (5, N'Digital Bangladesh Zone', 11)
INSERT [dbo].[tbl_Zone] ([z_Id], [z_TypeName], [z_NoOfVisitors]) VALUES (6, N'Books Zone', 11)
INSERT [dbo].[tbl_Zone] ([z_Id], [z_TypeName], [z_NoOfVisitors]) VALUES (1006, N'Ramesh Zone', 11)
SET IDENTITY_INSERT [dbo].[tbl_Zone] OFF
ALTER TABLE [dbo].[tbl_Zone] ADD  CONSTRAINT [DF_tbl_Zone_z_NoOfVisitors]  DEFAULT ((0)) FOR [z_NoOfVisitors]
GO
ALTER TABLE [dbo].[tbl_Visit]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Visit_tbl_Visitor] FOREIGN KEY([visitor_Id])
REFERENCES [dbo].[tbl_Visitor] ([v_Id])
GO
ALTER TABLE [dbo].[tbl_Visit] CHECK CONSTRAINT [FK_tbl_Visit_tbl_Visitor]
GO
ALTER TABLE [dbo].[tbl_Visit]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Visit_tbl_Zone] FOREIGN KEY([zone_Id])
REFERENCES [dbo].[tbl_Zone] ([z_Id])
GO
ALTER TABLE [dbo].[tbl_Visit] CHECK CONSTRAINT [FK_tbl_Visit_tbl_Zone]
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
