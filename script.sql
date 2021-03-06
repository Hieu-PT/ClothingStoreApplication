USE [FashionApp]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 12/07/2020 11:42:31 ******/
DROP TABLE [dbo].[Products]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/07/2020 11:42:31 ******/
DROP TABLE [dbo].[Customer]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/07/2020 11:42:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[username] [nvarchar](20) NOT NULL,
	[password] [nvarchar](20) NULL,
	[isAdmin] [bit] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 12/07/2020 11:42:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [varchar](50) NOT NULL,
	[ProductName] [varchar](50) NULL,
	[ProductPrice] [float] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Customer] ([username], [password], [isAdmin]) VALUES (N'conghieu', N'123', 1)
INSERT [dbo].[Customer] ([username], [password], [isAdmin]) VALUES (N'cus', N'123123', 0)
INSERT [dbo].[Customer] ([username], [password], [isAdmin]) VALUES (N'guest', N'123123', 0)
INSERT [dbo].[Customer] ([username], [password], [isAdmin]) VALUES (N'hieu', N'123', 1)
INSERT [dbo].[Customer] ([username], [password], [isAdmin]) VALUES (N'hoang', N'123', 1)
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice]) VALUES (N'1', N'T-Shirt', 500)
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice]) VALUES (N'2', N'Jean', 1000)
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice]) VALUES (N'3', N'Package', 400)
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice]) VALUES (N'4', N'Sweater', 500)
INSERT [dbo].[Products] ([ProductID], [ProductName], [ProductPrice]) VALUES (N'5', N'Shoes', 1400)
