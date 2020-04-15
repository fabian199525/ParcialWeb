CREATE DATABASE [EstampillaCovid];
USE  [EstampillaCovid]

CREATE TABLE [dbo].[Estampilla](
	[contratoNum] [nvarchar](10) NOT NULL PRIMARY KEY,
	[contratoObj] [nvarchar](50) NULL,
	[contratoValu] [int] NULL,
	[apoyaEmergenciaCovid] [bool] NULL,
	[valorEstampilla] [numeric](18, 0) NULL,
) 
GO

COMMIT