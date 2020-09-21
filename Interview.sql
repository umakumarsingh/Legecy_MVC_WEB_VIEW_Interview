Create Database [InterviewerTracker]
GO

USE [InterviewerTracker]
GO

/****** Object:  Table [dbo].[Interviews]    Script Date: 21-09-2020 01:06:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Interviews](
	[InterviewId] [int] IDENTITY(1,1) NOT NULL,
	[InterviewName] [nvarchar](50) NOT NULL,
	[Interviewer] [nvarchar](max) NOT NULL,
	[InterviewUser] [nvarchar](max) NOT NULL,
	[UserSkills] [nvarchar](max) NOT NULL,
	[InterviewDate] [datetime2](7) NOT NULL,
	[InterviewTime] [datetime2](7) NOT NULL,
	[InterViewsStatus] [int] NOT NULL,
	[TInterViews] [int] NOT NULL,
	[Remark] [nvarchar](max) NULL,
 CONSTRAINT [PK_Interviews] PRIMARY KEY CLUSTERED 
(
	[InterviewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ApplicationUsers]    Script Date: 21-09-2020 01:06:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ApplicationUsers](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[ReportingTo] [nvarchar](max) NOT NULL,
	[UserTypes] [int] NOT NULL,
	[Stat] [int] NOT NULL,
	[MobileNumber] [bigint] NOT NULL,
 CONSTRAINT [PK_ApplicationUsers] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO