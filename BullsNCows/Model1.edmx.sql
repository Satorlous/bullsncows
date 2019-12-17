
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/17/2019 20:52:41
-- Generated from EDMX file: C:\Users\pilig\Google Диск\УНИВЕР\3 курс 1 семестр\ПИС\bullsncows\BullsNCows\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [bullscows];
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

-- Creating table 'JournalSet'
CREATE TABLE [dbo].[JournalSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Game] nvarchar(max)  NOT NULL,
    [History] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [PlayerId] int  NOT NULL
);
GO

-- Creating table 'RatingSet'
CREATE TABLE [dbo].[RatingSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Player_ID] int  NOT NULL,
    [Score] float  NOT NULL,
    [Date] datetime  NOT NULL,
    [JournalId] int  NOT NULL,
    [PlayerId] int  NOT NULL
);
GO

-- Creating table 'PlayerSet'
CREATE TABLE [dbo].[PlayerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'JournalSet'
ALTER TABLE [dbo].[JournalSet]
ADD CONSTRAINT [PK_JournalSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'RatingSet'
ALTER TABLE [dbo].[RatingSet]
ADD CONSTRAINT [PK_RatingSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PlayerSet'
ALTER TABLE [dbo].[PlayerSet]
ADD CONSTRAINT [PK_PlayerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PlayerId] in table 'JournalSet'
ALTER TABLE [dbo].[JournalSet]
ADD CONSTRAINT [FK_JournalPlayer]
    FOREIGN KEY ([PlayerId])
    REFERENCES [dbo].[PlayerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JournalPlayer'
CREATE INDEX [IX_FK_JournalPlayer]
ON [dbo].[JournalSet]
    ([PlayerId]);
GO

-- Creating foreign key on [PlayerId] in table 'RatingSet'
ALTER TABLE [dbo].[RatingSet]
ADD CONSTRAINT [FK_RatingPlayer]
    FOREIGN KEY ([PlayerId])
    REFERENCES [dbo].[PlayerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RatingPlayer'
CREATE INDEX [IX_FK_RatingPlayer]
ON [dbo].[RatingSet]
    ([PlayerId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------