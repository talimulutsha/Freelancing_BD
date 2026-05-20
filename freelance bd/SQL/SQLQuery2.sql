USE [fbd]
GO

/****** Object:  Table [dbo].[profilef]    Script Date: 5/21/2026 12:23:23 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[profilef](
	[firstname] [varchar](50) NULL,
	[lastname] [varchar](50) NULL,
	[username] [varchar](50) NOT NULL,
	[phone] [varchar](50) NULL,
	[dob] [date] NULL,
	[gender] [varchar](10) NULL,
	[country] [varchar](10) NULL,
	[address] [varchar](255) NULL,
	[language] [varchar](50) NULL,
	[title] [varchar](100) NULL,
	[skills] [varchar](500) NULL,
	[experience] [varchar](10) NULL,
	[rate] [decimal](10, 2) NULL,
	[portfolio] [varchar](255) NULL,
	[github] [varchar](255) NULL,
	[linkedin] [varchar](255) NULL,
	[university] [varchar](100) NULL,
	[degree] [varchar](50) NULL,
	[department] [varchar](50) NULL,
	[graduationyear] [int] NULL,
	[image] [varchar](255) NULL,
	[gmail] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_profilef] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


