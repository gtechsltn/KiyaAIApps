Create database UCompany1;
GO;
-- use databse

Use UCompany1;


 
GO

/****** Object:  Table [dbo].[Department]    Script Date: 12/8/2023 12:14:30 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Department](
	[DeptNo] [int] NOT NULL,
	[DeptName] [varchar](200) NOT NULL,
	[Location] [varchar](100) NOT NULL,
	[Capacity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DeptNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO




USE [UCompany1]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 12/8/2023 12:15:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[EmpNo] [int] NOT NULL,
	[EmpName] [varchar](200) NOT NULL,
	[Designation] [varchar](200) NOT NULL,
	[DeptNo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmpNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Employee]  WITH CHECK ADD FOREIGN KEY([DeptNo])
REFERENCES [dbo].[Department] ([DeptNo])
GO
