
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BusniKolodvor];
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

-- Creating table 'Buses'
CREATE TABLE [dbo].[Buses] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Linija] nvarchar(max)  NOT NULL,
    [Registracija] nvarchar(max)  NOT NULL,
    [Kapacitet] nvarchar(max)  NOT NULL,
    [Skolski] nvarchar(max)  NOT NULL,
    [Kompanija] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Buses'
ALTER TABLE [dbo].[Buses]
ADD CONSTRAINT [PK_Buses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------