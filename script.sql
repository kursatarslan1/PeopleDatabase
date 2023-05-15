USE [People]
GO
/****** Object:  Table [dbo].[people]    Script Date: 15.05.2023 23:31:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[people](
	[Id] [decimal](18, 0) NULL,
	[Name] [nvarchar](50) NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Birthday] [datetime] NULL,
	[Address] [nvarchar](50) NULL,
	[Photo] [image] NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Weight] [int] NULL,
	[Height] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
