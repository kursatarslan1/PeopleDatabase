USE [People]
GO

/****** Object:  Table [dbo].[people]    Script Date: 16/05/2023 09:07:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[people](
	[Id] [decimal](11, 0) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Birthday] [datetime] NULL,
	[Address] [nvarchar](150) NULL,
	[Photo] [image] NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[Weight] [int] NULL,
	[Height] [int] NULL,
 CONSTRAINT [PK_people] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

