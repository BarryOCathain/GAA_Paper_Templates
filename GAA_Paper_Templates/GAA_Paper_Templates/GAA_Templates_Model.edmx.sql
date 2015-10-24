
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/24/2015 14:41:57
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

IF OBJECT_ID(N'[dbo].[FK_CountyCountyTeam]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Counties] DROP CONSTRAINT [FK_CountyCountyTeam];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubTeamCounty]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Teams_ClubTeam] DROP CONSTRAINT [FK_ClubTeamCounty];
GO
IF OBJECT_ID(N'[dbo].[FK_CountyTeamPlayer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Players] DROP CONSTRAINT [FK_CountyTeamPlayer];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubTeamPlayer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Players] DROP CONSTRAINT [FK_ClubTeamPlayer];
GO
IF OBJECT_ID(N'[dbo].[FK_CountyVenue]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Venues] DROP CONSTRAINT [FK_CountyVenue];
GO
IF OBJECT_ID(N'[dbo].[FK_VenueMatch]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Matches] DROP CONSTRAINT [FK_VenueMatch];
GO
IF OBJECT_ID(N'[dbo].[FK_MatchMatchPlayer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MatchPlayers] DROP CONSTRAINT [FK_MatchMatchPlayer];
GO
IF OBJECT_ID(N'[dbo].[FK_PlayerMatchPlayer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MatchPlayers] DROP CONSTRAINT [FK_PlayerMatchPlayer];
GO
IF OBJECT_ID(N'[dbo].[FK_MatchCompetitionMatchType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Matches] DROP CONSTRAINT [FK_MatchCompetitionMatchType];
GO
IF OBJECT_ID(N'[dbo].[FK_CompetitionMatchTypeCompetition_CompetitionMatchType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompetitionMatchTypeCompetition] DROP CONSTRAINT [FK_CompetitionMatchTypeCompetition_CompetitionMatchType];
GO
IF OBJECT_ID(N'[dbo].[FK_CompetitionMatchTypeCompetition_Competition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompetitionMatchTypeCompetition] DROP CONSTRAINT [FK_CompetitionMatchTypeCompetition_Competition];
GO
IF OBJECT_ID(N'[dbo].[FK_MatchCompetition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Matches] DROP CONSTRAINT [FK_MatchCompetition];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamMatch]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Matches] DROP CONSTRAINT [FK_TeamMatch];
GO
IF OBJECT_ID(N'[dbo].[FK_TeamMatch1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Matches] DROP CONSTRAINT [FK_TeamMatch1];
GO
IF OBJECT_ID(N'[dbo].[FK_CountyCompetition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Competitions] DROP CONSTRAINT [FK_CountyCompetition];
GO
IF OBJECT_ID(N'[dbo].[FK_CountyTeam_inherits_Team]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Teams_CountyTeam] DROP CONSTRAINT [FK_CountyTeam_inherits_Team];
GO
IF OBJECT_ID(N'[dbo].[FK_ClubTeam_inherits_Team]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Teams_ClubTeam] DROP CONSTRAINT [FK_ClubTeam_inherits_Team];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Matches]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Matches];
GO
IF OBJECT_ID(N'[dbo].[Teams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teams];
GO
IF OBJECT_ID(N'[dbo].[Counties]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Counties];
GO
IF OBJECT_ID(N'[dbo].[Players]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Players];
GO
IF OBJECT_ID(N'[dbo].[Venues]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Venues];
GO
IF OBJECT_ID(N'[dbo].[MatchPlayers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MatchPlayers];
GO
IF OBJECT_ID(N'[dbo].[Competitions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Competitions];
GO
IF OBJECT_ID(N'[dbo].[CompetitionMatchTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompetitionMatchTypes];
GO
IF OBJECT_ID(N'[dbo].[Teams_CountyTeam]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teams_CountyTeam];
GO
IF OBJECT_ID(N'[dbo].[Teams_ClubTeam]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Teams_ClubTeam];
GO
IF OBJECT_ID(N'[dbo].[CompetitionMatchTypeCompetition]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompetitionMatchTypeCompetition];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Matches'
CREATE TABLE [dbo].[Matches] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [MatchDate] datetime  NOT NULL,
    [IsObsolete] bit  NOT NULL,
    [MatchTime] time  NOT NULL,
    [Venue_ID] int  NOT NULL,
    [CompetitionMatchType_ID] int  NULL,
    [Competition_ID] int  NOT NULL,
    [HomeTeam_ID] int  NOT NULL,
    [AwayTeam_ID] int  NOT NULL
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
    [Province] nvarchar(max)  NOT NULL,
    [CountyTeam_ID] int  NOT NULL
);
GO

-- Creating table 'Players'
CREATE TABLE [dbo].[Players] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [IsObsolete] bit  NOT NULL,
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
    [Goals] int  NOT NULL,
    [Penalties] int  NOT NULL,
    [Points] int  NOT NULL,
    [Frees] int  NOT NULL,
    [IsSubbed] bit  NOT NULL,
    [MinuteOn] int  NOT NULL,
    [MinuteOff] int  NOT NULL,
    [PlayerNumber] int  NOT NULL,
    [SubbedFor] int  NOT NULL,
    [YellowCards] int  NOT NULL,
    [BlackCards] int  NOT NULL,
    [RedCards] int  NOT NULL,
    [IsSentOff] bit  NOT NULL,
    [Match_ID] int  NOT NULL,
    [Player_ID] int  NOT NULL
);
GO

-- Creating table 'Competitions'
CREATE TABLE [dbo].[Competitions] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [StartDate] datetime  NOT NULL,
    [EndDate] datetime  NOT NULL,
    [County_ID] int  NOT NULL
);
GO

-- Creating table 'CompetitionMatchTypes'
CREATE TABLE [dbo].[CompetitionMatchTypes] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
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

-- Creating table 'CompetitionMatchTypeCompetition'
CREATE TABLE [dbo].[CompetitionMatchTypeCompetition] (
    [CompetitionMatchType_ID] int  NOT NULL,
    [Competitions_ID] int  NOT NULL
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

-- Creating primary key on [ID] in table 'Competitions'
ALTER TABLE [dbo].[Competitions]
ADD CONSTRAINT [PK_Competitions]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'CompetitionMatchTypes'
ALTER TABLE [dbo].[CompetitionMatchTypes]
ADD CONSTRAINT [PK_CompetitionMatchTypes]
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

-- Creating primary key on [CompetitionMatchType_ID], [Competitions_ID] in table 'CompetitionMatchTypeCompetition'
ALTER TABLE [dbo].[CompetitionMatchTypeCompetition]
ADD CONSTRAINT [PK_CompetitionMatchTypeCompetition]
    PRIMARY KEY CLUSTERED ([CompetitionMatchType_ID], [Competitions_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CountyTeam_ID] in table 'Counties'
ALTER TABLE [dbo].[Counties]
ADD CONSTRAINT [FK_CountyCountyTeam]
    FOREIGN KEY ([CountyTeam_ID])
    REFERENCES [dbo].[Teams_CountyTeam]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CountyCountyTeam'
CREATE INDEX [IX_FK_CountyCountyTeam]
ON [dbo].[Counties]
    ([CountyTeam_ID]);
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

-- Creating foreign key on [CompetitionMatchType_ID] in table 'Matches'
ALTER TABLE [dbo].[Matches]
ADD CONSTRAINT [FK_MatchCompetitionMatchType]
    FOREIGN KEY ([CompetitionMatchType_ID])
    REFERENCES [dbo].[CompetitionMatchTypes]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MatchCompetitionMatchType'
CREATE INDEX [IX_FK_MatchCompetitionMatchType]
ON [dbo].[Matches]
    ([CompetitionMatchType_ID]);
GO

-- Creating foreign key on [CompetitionMatchType_ID] in table 'CompetitionMatchTypeCompetition'
ALTER TABLE [dbo].[CompetitionMatchTypeCompetition]
ADD CONSTRAINT [FK_CompetitionMatchTypeCompetition_CompetitionMatchType]
    FOREIGN KEY ([CompetitionMatchType_ID])
    REFERENCES [dbo].[CompetitionMatchTypes]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Competitions_ID] in table 'CompetitionMatchTypeCompetition'
ALTER TABLE [dbo].[CompetitionMatchTypeCompetition]
ADD CONSTRAINT [FK_CompetitionMatchTypeCompetition_Competition]
    FOREIGN KEY ([Competitions_ID])
    REFERENCES [dbo].[Competitions]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompetitionMatchTypeCompetition_Competition'
CREATE INDEX [IX_FK_CompetitionMatchTypeCompetition_Competition]
ON [dbo].[CompetitionMatchTypeCompetition]
    ([Competitions_ID]);
GO

-- Creating foreign key on [Competition_ID] in table 'Matches'
ALTER TABLE [dbo].[Matches]
ADD CONSTRAINT [FK_MatchCompetition]
    FOREIGN KEY ([Competition_ID])
    REFERENCES [dbo].[Competitions]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MatchCompetition'
CREATE INDEX [IX_FK_MatchCompetition]
ON [dbo].[Matches]
    ([Competition_ID]);
GO

-- Creating foreign key on [HomeTeam_ID] in table 'Matches'
ALTER TABLE [dbo].[Matches]
ADD CONSTRAINT [FK_TeamMatch]
    FOREIGN KEY ([HomeTeam_ID])
    REFERENCES [dbo].[Teams]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamMatch'
CREATE INDEX [IX_FK_TeamMatch]
ON [dbo].[Matches]
    ([HomeTeam_ID]);
GO

-- Creating foreign key on [AwayTeam_ID] in table 'Matches'
ALTER TABLE [dbo].[Matches]
ADD CONSTRAINT [FK_TeamMatch1]
    FOREIGN KEY ([AwayTeam_ID])
    REFERENCES [dbo].[Teams]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamMatch1'
CREATE INDEX [IX_FK_TeamMatch1]
ON [dbo].[Matches]
    ([AwayTeam_ID]);
GO

-- Creating foreign key on [County_ID] in table 'Competitions'
ALTER TABLE [dbo].[Competitions]
ADD CONSTRAINT [FK_CountyCompetition]
    FOREIGN KEY ([County_ID])
    REFERENCES [dbo].[Counties]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CountyCompetition'
CREATE INDEX [IX_FK_CountyCompetition]
ON [dbo].[Competitions]
    ([County_ID]);
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