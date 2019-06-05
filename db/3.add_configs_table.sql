CREATE TABLE [dbo].[configs] (
    [Id]    INT             IDENTITY (1, 1) NOT NULL,
    [key]   VARCHAR (255)   NOT NULL,
    [value] NVARCHAR (1000) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

SET IDENTITY_INSERT configs ON
INSERT INTO configs([id], [key], [value]) VALUES(1, 'company.name', N'Công ty TNHH Nền Tảng')
INSERT INTO configs([id], [key], [value]) VALUES(2, 'company.address', N'Cần Thơ')
SET IDENTITY_INSERT configs OFF