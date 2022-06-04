
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/03/2022 17:57:51
-- Generated from EDMX file: E:\VisualStudio\Zavrsni\MarkoKaratur\MarkoKaratur-TrgovineNTL\Model\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Model1];
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

-- Creating table 'Trgovines'
CREATE TABLE [dbo].[Trgovines] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ImeTrgovine] nvarchar(max)  NOT NULL,
    [Lokacija] nvarchar(max)  NOT NULL,
    [BrojRadnika] nvarchar(max)  NOT NULL,
    [Kategorija] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Trgovines'
ALTER TABLE [dbo].[Trgovines]
ADD CONSTRAINT [PK_Trgovines]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------