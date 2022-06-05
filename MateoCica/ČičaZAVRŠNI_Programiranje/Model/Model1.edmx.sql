
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ZadatakProgramiranje];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'GrafickeKartice'
CREATE TABLE [dbo].[GrafickeKartice] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Marka] nvarchar(max)  NOT NULL,
    [MjesecDostave] nvarchar(max)  NOT NULL,
    [BrojMjeseci] nvarchar(max)  NOT NULL,
    [Rezervirana] nvarchar(max)  NOT NULL,
    [Odjeljak] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'GrafickeKartice'
ALTER TABLE [dbo].[GrafickeKartice]
ADD CONSTRAINT [PK_GrafickeKartice]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------