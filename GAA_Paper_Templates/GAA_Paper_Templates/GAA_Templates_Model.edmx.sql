
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/23/2015 22:30:30
-- Generated from EDMX file: C:\TortoiseGit\GAA_Paper_Templates\GAA_Paper_Templates\GAA_Paper_Templates\GAA_Templates_Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GAA_Templates];
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

-- Creating table 'Matches'
CREATE TABLE [dbo].[Matches] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [MatchDate] nvarchar(max)  NOT NULL,
    [IsObsolete] nvarchar(max)  NOT NULL,
    [MatchTime] nvarchar(max)  NOT NULL,
    [Venue_ID] int  NOT NULL
);
GO

-- Creating table 'Teams'
CREATE TABLE [dbo].[Teams] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Counties'
CREATE TABLE [dbo].[Counties] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CountyTeams_ID] int  NOT NULL
);
GO

-- Creating table 'Players'
CREATE TABLE [dbo].[Players] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [IsObsolete] nvarchar(max)  NOT NULL,
    [CountyTeam_ID] int  NULL,
    [ClubTeam_ID] int  NOT NULL
);
GO

-- Creating table 'Venues'
CREATE TABLE [dbo].[Venues] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Location] nvarchar(max)  NOT NULL,
    [County_ID] int  NOT NULL
);
GO

-- Creating table 'MatchPlayers'
CREATE TABLE [dbo].[MatchPlayers] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Goals] nvarchar(max)  NOT NULL,
    [Penalties] nvarchar(max)  NOT NULL,
    [Points] nvarchar(max)  NOT NULL,
    [Frees] nvarchar(max)  NOT NULL,
    [IsSubbed] nvarchar(max)  NOT NULL,
    [MinuteOn] nvarchar(max)  NOT NULL,
    [MinuteOff] nvarchar(max)  NOT NULL,
    [PlayerNumber] nvarchar(max)  NOT NULL,
    [Match_ID] int  NOT NULL,
    [Teams_ID] int  NOT NULL,
    [Player_ID] int  NOT NULL
);
GO

-- Creating table 'Teams_CountyTeam'
CREATE TABLE [dbo].[Teams_CountyTeam] (
    [ID] int  NOT NULL
);
GO

-- Creating table 'Teams_ClubTeam'
CREATE TABLE [dbo].[Teams_ClubTeam] (
    [ID] int  NOT NULL,
    [County_ID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Matches'
ALTER TABLE [dbo].[Matches]
ADD CONSTRAINT [PK_Matches]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Teams'
ALTER TABLE [dbo].[Teams]
ADD CONSTRAINT [PK_Teams]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Counties'
ALTER TABLE [dbo].[Counties]
ADD CONSTRAINT [PK_Counties]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Players'
ALTER TABLE [dbo].[Players]
ADD CONSTRAINT [PK_Players]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Venues'
ALTER TABLE [dbo].[Venues]
ADD CONSTRAINT [PK_Venues]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'MatchPlayers'
ALTER TABLE [dbo].[MatchPlayers]
ADD CONSTRAINT [PK_MatchPlayers]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Teams_CountyTeam'
ALTER TABLE [dbo].[Teams_CountyTeam]
ADD CONSTRAINT [PK_Teams_CountyTeam]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Teams_ClubTeam'
ALTER TABLE [dbo].[Teams_ClubTeam]
ADD CONSTRAINT [PK_Teams_ClubTeam]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CountyTeams_ID] in table 'Counties'
ALTER TABLE [dbo].[Counties]
ADD CONSTRAINT [FK_CountyCountyTeam]
    FOREIGN KEY ([CountyTeams_ID])
    REFERENCES [dbo].[Teams_CountyTeam]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CountyCountyTeam'
CREATE INDEX [IX_FK_CountyCountyTeam]
ON [dbo].[Counties]
    ([CountyTeams_ID]);
GO

-- Creating foreign key on [County_ID] in table 'Teams_ClubTeam'
ALTER TABLE [dbo].[Teams_ClubTeam]
ADD CONSTRAINT [FK_ClubTeamCounty]
    FOREIGN KEY ([County_ID])
    REFERENCES [dbo].[Counties]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubTeamCounty'
CREATE INDEX [IX_FK_ClubTeamCounty]
ON [dbo].[Teams_ClubTeam]
    ([County_ID]);
GO

-- Creating foreign key on [CountyTeam_ID] in table 'Players'
ALTER TABLE [dbo].[Players]
ADD CONSTRAINT [FK_CountyTeamPlayer]
    FOREIGN KEY ([CountyTeam_ID])
    REFERENCES [dbo].[Teams_CountyTeam]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CountyTeamPlayer'
CREATE INDEX [IX_FK_CountyTeamPlayer]
ON [dbo].[Players]
    ([CountyTeam_ID]);
GO

-- Creating foreign key on [ClubTeam_ID] in table 'Players'
ALTER TABLE [dbo].[Players]
ADD CONSTRAINT [FK_ClubTeamPlayer]
    FOREIGN KEY ([ClubTeam_ID])
    REFERENCES [dbo].[Teams_ClubTeam]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubTeamPlayer'
CREATE INDEX [IX_FK_ClubTeamPlayer]
ON [dbo].[Players]
    ([ClubTeam_ID]);
GO

-- Creating foreign key on [County_ID] in table 'Venues'
ALTER TABLE [dbo].[Venues]
ADD CONSTRAINT [FK_CountyVenue]
    FOREIGN KEY ([County_ID])
    REFERENCES [dbo].[Counties]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CountyVenue'
CREATE INDEX [IX_FK_CountyVenue]
ON [dbo].[Venues]
    ([County_ID]);
GO

-- Creating foreign key on [Venue_ID] in table 'Matches'
ALTER TABLE [dbo].[Matches]
ADD CONSTRAINT [FK_VenueMatch]
    FOREIGN KEY ([Venue_ID])
    REFERENCES [dbo].[Venues]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VenueMatch'
CREATE INDEX [IX_FK_VenueMatch]
ON [dbo].[Matches]
    ([Venue_ID]);
GO

-- Creating foreign key on [Match_ID] in table 'MatchPlayers'
ALTER TABLE [dbo].[MatchPlayers]
ADD CONSTRAINT [FK_MatchMatchPlayer]
    FOREIGN KEY ([Match_ID])
    REFERENCES [dbo].[Matches]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MatchMatchPlayer'
CREATE INDEX [IX_FK_MatchMatchPlayer]
ON [dbo].[MatchPlayers]
    ([Match_ID]);
GO

-- Creating foreign key on [Teams_ID] in table 'MatchPlayers'
ALTER TABLE [dbo].[MatchPlayers]
ADD CONSTRAINT [FK_MatchPlayerTeam]
    FOREIGN KEY ([Teams_ID])
    REFERENCES [dbo].[Teams]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MatchPlayerTeam'
CREATE INDEX [IX_FK_MatchPlayerTeam]
ON [dbo].[MatchPlayers]
    ([Teams_ID]);
GO

-- Creating foreign key on [Player_ID] in table 'MatchPlayers'
ALTER TABLE [dbo].[MatchPlayers]
ADD CONSTRAINT [FK_PlayerMatchPlayer]
    FOREIGN KEY ([Player_ID])
    REFERENCES [dbo].[Players]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PlayerMatchPlayer'
CREATE INDEX [IX_FK_PlayerMatchPlayer]
ON [dbo].[MatchPlayers]
    ([Player_ID]);
GO

-- Creating foreign key on [ID] in table 'Teams_CountyTeam'
ALTER TABLE [dbo].[Teams_CountyTeam]
ADD CONSTRAINT [FK_CountyTeam_inherits_Team]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[Teams]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ID] in table 'Teams_ClubTeam'
ALTER TABLE [dbo].[Teams_ClubTeam]
ADD CONSTRAINT [FK_ClubTeam_inherits_Team]
    FOREIGN KEY ([ID])
    REFERENCES [dbo].[Teams]
        ([ID])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------