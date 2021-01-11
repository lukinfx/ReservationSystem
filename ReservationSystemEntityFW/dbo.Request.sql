CREATE TABLE [dbo].[Request] (
    [Id]       INT         IDENTITY (1, 1) NOT NULL,
    [Name]     NCHAR (100) NOT NULL,
    [Approved] BIT         NULL,
    [Description] NCHAR(1000) NOT NULL, 
    [Lenght] NUMERIC NOT NULL, 
    [Height] NUMERIC NOT NULL, 
    [Depth] NUMERIC NOT NULL, 
    [Weight] NUMERIC NOT NULL, 
    [SubmitDate] DATETIME NOT NULL, 
    [ApproveDate] DATETIME NOT NULL, 
    [DepartureDate] DATETIME NOT NULL, 
    [Train] NCHAR(20) NOT NULL, 
    CONSTRAINT [PK__Request__3214EC076CC7491B] PRIMARY KEY CLUSTERED ([Id] ASC)
);

