CREATE TABLE [dbo].[CarDPOes] (
    [ID]         INT             IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (MAX)  NULL,
    [Engine]     DECIMAL (18, 2) NOT NULL,
    [SeriesYear] INT             NOT NULL,
    CONSTRAINT [PK_dbo.CarDPOes] PRIMARY KEY CLUSTERED ([ID] ASC)
);

