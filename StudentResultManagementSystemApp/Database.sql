USE [StudentResultManagentDB]
GO
/****** Object:  Table [dbo].[StudentsTable]    Script Date: 10/20/2014 03:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StudentsTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RegNo] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
 CONSTRAINT [PK_StudentsTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[StudentsTable] ON
INSERT [dbo].[StudentsTable] ([Id], [RegNo], [Name], [Email]) VALUES (1, N'001', N'Ronok', N'ronok@gmail.com')
INSERT [dbo].[StudentsTable] ([Id], [RegNo], [Name], [Email]) VALUES (2, N'002', N'Shibly', N'shibly@gmail.com')
INSERT [dbo].[StudentsTable] ([Id], [RegNo], [Name], [Email]) VALUES (3, N'003', N'Shuvo', N'shuvo@gmail.com')
INSERT [dbo].[StudentsTable] ([Id], [RegNo], [Name], [Email]) VALUES (4, N'004', N'Mamun', N'Mamun@gmail.com')
SET IDENTITY_INSERT [dbo].[StudentsTable] OFF
/****** Object:  Table [dbo].[CoursesTable]    Script Date: 10/20/2014 03:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CoursesTable](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CourseTitle] [varchar](50) NOT NULL,
	[CourseName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CoursesTable] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CoursesTable] ON
INSERT [dbo].[CoursesTable] ([Id], [CourseTitle], [CourseName]) VALUES (1, N'CSE01', N'Computer Fundamentals')
INSERT [dbo].[CoursesTable] ([Id], [CourseTitle], [CourseName]) VALUES (2, N'CSE02', N'DBMS')
INSERT [dbo].[CoursesTable] ([Id], [CourseTitle], [CourseName]) VALUES (3, N'CSE03', N'Artificial Inteligence')
SET IDENTITY_INSERT [dbo].[CoursesTable] OFF
