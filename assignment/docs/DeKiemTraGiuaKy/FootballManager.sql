/****** Object:  Table [dbo].[BangDiemThiDau]    Script Date: 6/19/2018 12:05:17 PM ******/
CREATE TABLE [dbo].[BangDiemThiDau](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenBang] [nvarchar](225) NULL,
	[TenDoi] [nvarchar](225) NULL,
	[TenDoiDoiThu] [nvarchar](225) NULL,
	[TiSo] [nvarchar](225) NULL,
	[SoTranDaThiDau] [int] NULL,
	[HieuSo] [int] NULL,
	[Diem] [int] NULL
) ON [PRIMARY]
GO

INSERT INTO [dbo].[BangDiemThiDau]
           ([TenBang]
           ,[TenDoi]
           ,[TenDoiDoiThu]
           ,[TiSo]
           ,[SoTranDaThiDau]
           ,[HieuSo]
           ,[Diem])
     VALUES
           (N'Bảng G'
           ,N'Bỉ'
           ,N'Panama'
           ,N'3-0'
           ,1
           ,3
           ,3)
GO

INSERT INTO [dbo].[BangDiemThiDau]
           ([TenBang]
           ,[TenDoi]
           ,[TenDoiDoiThu]
           ,[TiSo]
           ,[SoTranDaThiDau]
           ,[HieuSo]
           ,[Diem])
     VALUES
           (N'Bảng G'
           ,N'Panama'
           ,N'Bỉ'
           ,N'0-3'
           ,1
           ,-3
           ,0)
GO

INSERT INTO [dbo].[BangDiemThiDau]
           ([TenBang]
           ,[TenDoi]
           ,[TenDoiDoiThu]
           ,[TiSo]
           ,[SoTranDaThiDau]
           ,[HieuSo]
           ,[Diem])
     VALUES
           (N'Bảng G'
           ,N'Anh'
           ,N'Tunisia'
           ,N'2-1'
           ,1
           ,3
           ,1)
GO

INSERT INTO [dbo].[BangDiemThiDau]
           ([TenBang]
           ,[TenDoi]
           ,[TenDoiDoiThu]
           ,[TiSo]
           ,[SoTranDaThiDau]
           ,[HieuSo]
           ,[Diem])
     VALUES
           (N'Bảng G'
           ,N'Tunisia'
           ,N'Anh'
           ,N'1-2'
           ,1
           ,0
           ,-1)
GO

select * from [BangDiemThiDau]