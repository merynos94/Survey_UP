USE [master]
GO
/****** Object:  Database [n3mikos]    Script Date: 08.03.2021 19:25:49 ******/
CREATE DATABASE [n3mikos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'n3mikos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\n3mikos.mdf' , SIZE = 6144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'n3mikos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\n3mikos_log.ldf' , SIZE = 18240KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [n3mikos] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [n3mikos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [n3mikos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [n3mikos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [n3mikos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [n3mikos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [n3mikos] SET ARITHABORT OFF 
GO
ALTER DATABASE [n3mikos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [n3mikos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [n3mikos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [n3mikos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [n3mikos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [n3mikos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [n3mikos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [n3mikos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [n3mikos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [n3mikos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [n3mikos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [n3mikos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [n3mikos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [n3mikos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [n3mikos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [n3mikos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [n3mikos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [n3mikos] SET RECOVERY FULL 
GO
ALTER DATABASE [n3mikos] SET  MULTI_USER 
GO
ALTER DATABASE [n3mikos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [n3mikos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [n3mikos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [n3mikos] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [n3mikos]
GO
/****** Object:  UserDefinedTableType [dbo].[IntTableType]    Script Date: 08.03.2021 19:25:49 ******/
CREATE TYPE [dbo].[IntTableType] AS TABLE(
	[value] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[VarcharTableType]    Script Date: 08.03.2021 19:25:49 ******/
CREATE TYPE [dbo].[VarcharTableType] AS TABLE(
	[value] [varchar](40) NULL
)
GO
/****** Object:  UserDefinedFunction [dbo].[fnStripTags]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Function [dbo].[fnStripTags]
    (@Dirty varchar(4000))
    Returns varchar(4000)
As

Begin
    Declare @Start int,
        @End int,
        @Length int

    While CharIndex('<', @Dirty) > 0 And CharIndex('>', @Dirty, CharIndex('<', @Dirty)) > 0
     Begin
        Select @Start = CharIndex('<', @Dirty),
         @End = CharIndex('>', @Dirty, CharIndex('<', @Dirty))
        Select @Length = (@End - @Start) + 1
        If @Length > 0
         Begin
            Select @Dirty = Stuff(@Dirty, @Start, @Length, '')
         End
     End

    return @Dirty
End




GO
/****** Object:  UserDefinedFunction [dbo].[vts_fnGetFolderRootCount]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[vts_fnGetFolderRootCount]
(
)
RETURNS INT 
AS
BEGIN
	DECLARE @ret int;

	SELECT @ret = count(*) from vts_tbFolders where ParentFolderId is null

	RETURN @ret
END




GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[Email] [nvarchar](256) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[ConfirmPassword] [nvarchar](max) NULL,
	[Name] [nvarchar](250) NOT NULL,
	[FirstName] [nvarchar](250) NOT NULL,
	[MiddleName] [nvarchar](250) NULL,
	[AlbumNumber] [nvarchar](max) NULL,
	[Department] [nvarchar](max) NULL,
	[UniversityDirection] [nvarchar](max) NULL,
	[Degree] [nvarchar](max) NULL,
	[LearningForm] [nvarchar](max) NULL,
	[PermanentAddress] [nvarchar](max) NULL,
	[PermanentCity] [nvarchar](max) NULL,
	[PermanentPostalCode] [nvarchar](max) NULL,
	[CorrespondAddress] [nvarchar](max) NULL,
	[CorrespondCity] [nvarchar](max) NULL,
	[CorrespondPostalCode] [nvarchar](max) NULL,
	[NameMother] [nvarchar](max) NULL,
	[NameFather] [nvarchar](max) NULL,
	[BirthDate] [datetime2](7) NOT NULL,
	[Pesel] [nvarchar](max) NULL,
	[BirthPlace] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vts_tbAnswer]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vts_tbAnswer](
	[AnswerId] [int] IDENTITY(1,1) NOT NULL,
	[QuestionId] [int] NOT NULL,
	[AnswerTypeId] [smallint] NULL,
	[AnswerText] [nvarchar](4000) NULL,
	[DisplayOrder] [int] NULL,
	[DefaultText] [nvarchar](4000) NULL,
 CONSTRAINT [PK_vts_tbAnswer] PRIMARY KEY NONCLUSTERED 
(
	[AnswerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vts_tbAnswerType]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vts_tbAnswerType](
	[AnswerTypeID] [smallint] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_vts_tbAnswerType] PRIMARY KEY CLUSTERED 
(
	[AnswerTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vts_tbQuestion]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vts_tbQuestion](
	[QuestionId] [int] IDENTITY(1,1) NOT NULL,
	[SurveyId] [int] NULL,
	[ColumnsNumber] [int] NULL,
	[QuestionText] [nvarchar](4000) NULL,
	[DisplayOrder] [int] NULL,
	[PageNumber] [int] NULL,
	[HelpText] [nvarchar](4000) NULL,
	[Alias] [nvarchar](255) NULL,
	[QuestionGroupID] [int] NULL,
	[ShowHelpText] [bit] NOT NULL,
	[SelectionModeQuestionSelectionModeId] [tinyint] NULL,
 CONSTRAINT [PK_vts_tbQuestion] PRIMARY KEY NONCLUSTERED 
(
	[QuestionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vts_tbQuestionSelectionMode]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vts_tbQuestionSelectionMode](
	[QuestionSelectionModeID] [tinyint] NOT NULL,
	[Description] [nvarchar](50) NULL,
	[TypeNameSpace] [varchar](200) NOT NULL,
	[TypeAssembly] [varchar](200) NOT NULL,
	[TypeMode] [int] NULL,
 CONSTRAINT [PK_vts_tbQuestionSelectionMode] PRIMARY KEY CLUSTERED 
(
	[QuestionSelectionModeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vts_tbSurvey]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vts_tbSurvey](
	[SurveyID] [int] IDENTITY(1,1) NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[OpenDate] [datetime] NULL,
	[CloseDate] [datetime] NULL,
	[Title] [nvarchar](255) NOT NULL,
	[ThankYouMessage] [nvarchar](4000) NULL,
	[SurveyDisplayTimes] [int] NOT NULL,
	[Archive] [bit] NOT NULL,
	[Activated] [bit] NOT NULL,
	[Scored] [bit] NULL,
	[SurveyGuid] [uniqueidentifier] NULL,
 CONSTRAINT [PK_vts_tbSurvey] PRIMARY KEY NONCLUSTERED 
(
	[SurveyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vts_tbUserAnswerType]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vts_tbUserAnswerType](
	[UserId] [int] NOT NULL,
	[AnswerTypeId] [smallint] NOT NULL,
 CONSTRAINT [PK_vts_tbUserAnswerType] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[AnswerTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vts_tbUserSurvey]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vts_tbUserSurvey](
	[UserId] [nvarchar](450) NOT NULL,
	[SurveyId] [int] NOT NULL,
 CONSTRAINT [PK_vts_tbUserSurvey] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[SurveyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vts_tbVoter]    Script Date: 08.03.2021 19:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vts_tbVoter](
	[VoterID] [int] IDENTITY(1,1) NOT NULL,
	[UID] [nvarchar](40) NULL,
	[SurveyID] [int] NULL,
	[ContextUserName] [nvarchar](255) NULL,
	[VoteDate] [datetime] NULL,
	[StartDate] [datetime] NULL,
	[IPSource] [nvarchar](50) NULL,
	[Validated] [bit] NULL,
 CONSTRAINT [PK_vts_tbVoter] PRIMARY KEY CLUSTERED 
(
	[VoterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vts_tbVoterAnswers]    Script Date: 08.03.2021 19:25:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vts_tbVoterAnswers](
	[VoterID] [int] NOT NULL,
	[AnswerID] [int] NOT NULL,
	[SectionNumber] [int] NOT NULL,
	[AnswerText] [ntext] NULL,
 CONSTRAINT [PK_vts_tbVoterAnswers] PRIMARY KEY CLUSTERED 
(
	[VoterID] ASC,
	[AnswerID] ASC,
	[SectionNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 08.03.2021 19:25:50 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 08.03.2021 19:25:50 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 08.03.2021 19:25:50 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 08.03.2021 19:25:50 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 08.03.2021 19:25:50 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 08.03.2021 19:25:50 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 08.03.2021 19:25:50 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Answer]    Script Date: 08.03.2021 19:25:50 ******/
CREATE NONCLUSTERED INDEX [IX_Answer] ON [dbo].[vts_tbAnswer]
(
	[DisplayOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
GO
/****** Object:  Index [IX_QuestionID]    Script Date: 08.03.2021 19:25:50 ******/
CREATE NONCLUSTERED INDEX [IX_QuestionID] ON [dbo].[vts_tbAnswer]
(
	[QuestionId] ASC,
	[DisplayOrder] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
GO
/****** Object:  Index [IX_QuestionGroupID]    Script Date: 08.03.2021 19:25:50 ******/
CREATE NONCLUSTERED INDEX [IX_QuestionGroupID] ON [dbo].[vts_tbQuestion]
(
	[QuestionGroupID] ASC
)
INCLUDE([QuestionId]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
GO
/****** Object:  Index [IX_SurveyId]    Script Date: 08.03.2021 19:25:50 ******/
CREATE NONCLUSTERED INDEX [IX_SurveyId] ON [dbo].[vts_tbQuestion]
(
	[SurveyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
GO
/****** Object:  Index [IX_vts_tbQuestion_SelectionModeQuestionSelectionModeId]    Script Date: 08.03.2021 19:25:50 ******/
CREATE NONCLUSTERED INDEX [IX_vts_tbQuestion_SelectionModeQuestionSelectionModeId] ON [dbo].[vts_tbQuestion]
(
	[SelectionModeQuestionSelectionModeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IDX_Voter]    Script Date: 08.03.2021 19:25:50 ******/
CREATE NONCLUSTERED INDEX [IDX_Voter] ON [dbo].[vts_tbVoter]
(
	[Validated] ASC,
	[SurveyID] ASC
)
INCLUDE([VoterID]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
GO
/****** Object:  Index [IX_SurveyID]    Script Date: 08.03.2021 19:25:50 ******/
CREATE NONCLUSTERED INDEX [IX_SurveyID] ON [dbo].[vts_tbVoter]
(
	[SurveyID] ASC
)
INCLUDE([VoterID],[Validated]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Answer]    Script Date: 08.03.2021 19:25:50 ******/
CREATE NONCLUSTERED INDEX [IX_Answer] ON [dbo].[vts_tbVoterAnswers]
(
	[AnswerID] ASC
)
INCLUDE([VoterID]) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 80) ON [PRIMARY]
GO
ALTER TABLE [dbo].[vts_tbAnswer] ADD  CONSTRAINT [DF_vts_tbAnswer_iAnswerTypeId]  DEFAULT ((1)) FOR [AnswerTypeId]
GO
ALTER TABLE [dbo].[vts_tbAnswer] ADD  CONSTRAINT [DF_vts_tbAnswer_DisplayOrder]  DEFAULT ((1)) FOR [DisplayOrder]
GO
ALTER TABLE [dbo].[vts_tbQuestion] ADD  CONSTRAINT [DF_vts_tbQuestion_ColumnsNumber]  DEFAULT ((0)) FOR [ColumnsNumber]
GO
ALTER TABLE [dbo].[vts_tbQuestion] ADD  CONSTRAINT [DF_vts_tbQuestion_PageNumber]  DEFAULT ((1)) FOR [PageNumber]
GO
ALTER TABLE [dbo].[vts_tbQuestion] ADD  CONSTRAINT [DF_vts_tbQuestion_ShowHelpText]  DEFAULT ((0)) FOR [ShowHelpText]
GO
ALTER TABLE [dbo].[vts_tbSurvey] ADD  CONSTRAINT [DF_vts_tbSurvey_dCreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[vts_tbSurvey] ADD  DEFAULT (N'') FOR [Title]
GO
ALTER TABLE [dbo].[vts_tbSurvey] ADD  CONSTRAINT [DF_vts_tbSurvey_iPollBoxDisplayTimes]  DEFAULT ((0)) FOR [SurveyDisplayTimes]
GO
ALTER TABLE [dbo].[vts_tbSurvey] ADD  CONSTRAINT [DF_vts_tbSurvey_bArchive]  DEFAULT ((0)) FOR [Archive]
GO
ALTER TABLE [dbo].[vts_tbSurvey] ADD  CONSTRAINT [DF_vts_tbSurvey_bActivated]  DEFAULT ((0)) FOR [Activated]
GO
ALTER TABLE [dbo].[vts_tbSurvey] ADD  CONSTRAINT [DF_vts_tbSurvey_Scored]  DEFAULT ((0)) FOR [Scored]
GO
ALTER TABLE [dbo].[vts_tbSurvey] ADD  CONSTRAINT [DF_vts_tbSurvey_SurveyGuid]  DEFAULT (newid()) FOR [SurveyGuid]
GO
ALTER TABLE [dbo].[vts_tbVoter] ADD  CONSTRAINT [DF_vts_tbVoter_VoteDate]  DEFAULT (getdate()) FOR [VoteDate]
GO
ALTER TABLE [dbo].[vts_tbVoter] ADD  CONSTRAINT [DF_vts_tbVoter_Validated]  DEFAULT ((0)) FOR [Validated]
GO
ALTER TABLE [dbo].[vts_tbVoterAnswers] ADD  CONSTRAINT [DF_vts_tbVoterAnswers_SectionID]  DEFAULT ((0)) FOR [SectionNumber]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[vts_tbAnswer]  WITH CHECK ADD  CONSTRAINT [FK_vts_tbAnswer_vts_tbAnswerType] FOREIGN KEY([AnswerTypeId])
REFERENCES [dbo].[vts_tbAnswerType] ([AnswerTypeID])
GO
ALTER TABLE [dbo].[vts_tbAnswer] CHECK CONSTRAINT [FK_vts_tbAnswer_vts_tbAnswerType]
GO
ALTER TABLE [dbo].[vts_tbAnswer]  WITH CHECK ADD  CONSTRAINT [FK_vts_tbAnswer_vts_tbQuestion] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[vts_tbQuestion] ([QuestionId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[vts_tbAnswer] CHECK CONSTRAINT [FK_vts_tbAnswer_vts_tbQuestion]
GO
ALTER TABLE [dbo].[vts_tbQuestion]  WITH CHECK ADD  CONSTRAINT [FK_vts_tbQuestion_vts_tbQuestionSelectionMode_SelectionModeQuestionSelectionModeId] FOREIGN KEY([SelectionModeQuestionSelectionModeId])
REFERENCES [dbo].[vts_tbQuestionSelectionMode] ([QuestionSelectionModeID])
GO
ALTER TABLE [dbo].[vts_tbQuestion] CHECK CONSTRAINT [FK_vts_tbQuestion_vts_tbQuestionSelectionMode_SelectionModeQuestionSelectionModeId]
GO
ALTER TABLE [dbo].[vts_tbQuestion]  WITH CHECK ADD  CONSTRAINT [FK_vts_tbQuestion_vts_tbSurvey] FOREIGN KEY([SurveyId])
REFERENCES [dbo].[vts_tbSurvey] ([SurveyID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[vts_tbQuestion] CHECK CONSTRAINT [FK_vts_tbQuestion_vts_tbSurvey]
GO
ALTER TABLE [dbo].[vts_tbUserAnswerType]  WITH CHECK ADD  CONSTRAINT [FK_vts_tbUserAnswerType_vts_tbAnswerType] FOREIGN KEY([AnswerTypeId])
REFERENCES [dbo].[vts_tbAnswerType] ([AnswerTypeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[vts_tbUserAnswerType] CHECK CONSTRAINT [FK_vts_tbUserAnswerType_vts_tbAnswerType]
GO
ALTER TABLE [dbo].[vts_tbUserSurvey]  WITH CHECK ADD  CONSTRAINT [FK_vts_tbUserSurvey_vts_tbSurvey] FOREIGN KEY([SurveyId])
REFERENCES [dbo].[vts_tbSurvey] ([SurveyID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[vts_tbUserSurvey] CHECK CONSTRAINT [FK_vts_tbUserSurvey_vts_tbSurvey]
GO
ALTER TABLE [dbo].[vts_tbVoterAnswers]  WITH CHECK ADD  CONSTRAINT [FK_VoterAnswers_vts_tbAnswer] FOREIGN KEY([AnswerID])
REFERENCES [dbo].[vts_tbAnswer] ([AnswerId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[vts_tbVoterAnswers] CHECK CONSTRAINT [FK_VoterAnswers_vts_tbAnswer]
GO
ALTER TABLE [dbo].[vts_tbVoterAnswers]  WITH CHECK ADD  CONSTRAINT [FK_vts_tbVoterAnswers_vts_tbVoter] FOREIGN KEY([VoterID])
REFERENCES [dbo].[vts_tbVoter] ([VoterID])
GO
ALTER TABLE [dbo].[vts_tbVoterAnswers] CHECK CONSTRAINT [FK_vts_tbVoterAnswers_vts_tbVoter]
GO
USE [master]
GO
ALTER DATABASE [n3mikos] SET  READ_WRITE 
GO
