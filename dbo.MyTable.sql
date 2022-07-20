CREATE TABLE [dbo].[MyTable] (
    [id]         INT           IDENTITY (1, 1) NOT NULL,
    [low_24]     VARCHAR (255) NOT NULL,
    [high_24]    VARCHAR (255) NOT NULL,
    [avg_24h]    VARCHAR (255) NOT NULL,
    [volume_24h] VARCHAR (255) NOT NULL,
    [timestamp]  VARCHAR (20)  DEFAULT (getdate()) NULL,
    [dateTime] DATETIME NULL DEFAULT (getdate()), 
    PRIMARY KEY CLUSTERED ([id] ASC)
);

