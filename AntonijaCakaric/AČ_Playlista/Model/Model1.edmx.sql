
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Playliste_AntonijaC];
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

-- Creating table 'Playlista'
CREATE TABLE [dbo].[Playlista] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ime] nvarchar(max)  NOT NULL,
    [Autor] nvarchar(max)  NOT NULL,
    [Duljina] nvarchar(max)  NOT NULL,
    [Distribucija] nvarchar(max)  NOT NULL,
    [Eksplicitno] nvarchar(max)  NOT NULL,
    [Grammy] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Playlista'
ALTER TABLE [dbo].[Playlista]
ADD CONSTRAINT [PK_Playlista]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------