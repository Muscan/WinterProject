CREATE TABLE [dbo].[Car] (
    [ID]         INT            IDENTITY (1, 1) NOT NULL,
    [Name]       NCHAR (10)     NOT NULL,
    [Engine]     DECIMAL (2, 1) NOT NULL,
    [SeriesYear] INT            NOT NULL,
    CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED ([ID] ASC)
);

