/* SUTAHSILAT veritabanı - SQL Server'dan dışa aktarıldı (2026-11-15)
   SSMS ile açıp Execute (F5) ile çalıştırın. */
IF DB_ID(N'SUTAHSILAT') IS NULL CREATE DATABASE [SUTAHSILAT];
GO
USE [SUTAHSILAT];
GO

CREATE TABLE [dbo].[ABONELER] (
    [AboneId] int IDENTITY(1,1) NOT NULL,
    [Ad] nvarchar(50) NULL,
    [Soyad] nvarchar(50) NULL,
    [TCKimlik] nchar(11) NULL,
    [Adres] nvarchar(255) NULL,
    [Telefon] nvarchar(20) NULL,
    CONSTRAINT [PK__ABONELER__171BF10000000001] PRIMARY KEY ([AboneId])
);
GO

CREATE TABLE [dbo].[SAYACLAR] (
    [SayacId] int IDENTITY(1,1) NOT NULL,
    [AboneId] int NULL,
    [Marka] nvarchar(50) NULL,
    [Seri] nvarchar(10) NULL,
    [Numara] nvarchar(10) NULL,
    CONSTRAINT [PK__SAYACLAR__B4524D65EF66486F] PRIMARY KEY ([SayacId])
);
GO

CREATE TABLE [dbo].[TUKETIM] (
    [TuketimId] int IDENTITY(1,1) NOT NULL,
    [SayacId] int NULL,
    [OTarihi] datetime NULL,
    [Endeks] int NULL,
    [TuketimMiktari] int NULL,
    [Tutar] decimal(14,2) NULL,
    CONSTRAINT [PK__TUKETIM__98CE36EEFE0B6DA1] PRIMARY KEY ([TuketimId])
);
GO

CREATE TABLE [dbo].[UCRET] (
    [UcretId] int IDENTITY(1,1) NOT NULL,
    [BFiyat] decimal(5,2) NULL,
    [KDVOrani] decimal(4,2) NULL,
    [CTVOrani] decimal(4,2) NULL,
    [ABOrani] decimal(4,2) NULL,
    CONSTRAINT [PK__UCRET__C6F2E0A95AD818E2] PRIMARY KEY ([UcretId])
);
GO

SET IDENTITY_INSERT [dbo].[ABONELER] ON;
INSERT INTO [dbo].[ABONELER] ([AboneId], [Ad], [Soyad], [TCKimlik], [Adres], [Telefon]) VALUES (1, N'Ali', N'Cabbar', N'10000000002', N'İstanbul', N'05550000001');
INSERT INTO [dbo].[ABONELER] ([AboneId], [Ad], [Soyad], [TCKimlik], [Adres], [Telefon]) VALUES (2, N'Emrah', N'Çapkan', N'10000000003', N'Ankara', N'1234567891');
SET IDENTITY_INSERT [dbo].[ABONELER] OFF;
GO

SET IDENTITY_INSERT [dbo].[SAYACLAR] ON;
INSERT INTO [dbo].[SAYACLAR] ([SayacId], [AboneId], [Marka], [Seri], [Numara]) VALUES (1, 1, N'Teksan', N'AVB00', N'1234567890');
INSERT INTO [dbo].[SAYACLAR] ([SayacId], [AboneId], [Marka], [Seri], [Numara]) VALUES (2, 2, N'Teksan', N'AB02', N'12345678');
SET IDENTITY_INSERT [dbo].[SAYACLAR] OFF;
GO

SET IDENTITY_INSERT [dbo].[TUKETIM] ON;
INSERT INTO [dbo].[TUKETIM] ([TuketimId], [SayacId], [OTarihi], [Endeks], [TuketimMiktari], [Tutar]) VALUES (1, 1, '2026-02-12 22:21:41.530', 70, 70, 133000.00);
INSERT INTO [dbo].[TUKETIM] ([TuketimId], [SayacId], [OTarihi], [Endeks], [TuketimMiktari], [Tutar]) VALUES (2, 1, '2026-02-18 13:12:25.497', 25, 0, 0.00);
INSERT INTO [dbo].[TUKETIM] ([TuketimId], [SayacId], [OTarihi], [Endeks], [TuketimMiktari], [Tutar]) VALUES (3, 1, '2026-02-18 13:26:32.337', 75, 0, 0.00);
INSERT INTO [dbo].[TUKETIM] ([TuketimId], [SayacId], [OTarihi], [Endeks], [TuketimMiktari], [Tutar]) VALUES (4, 1, '2026-02-18 13:26:34.680', 50, 0, 0.00);
INSERT INTO [dbo].[TUKETIM] ([TuketimId], [SayacId], [OTarihi], [Endeks], [TuketimMiktari], [Tutar]) VALUES (7, 1, '2026-02-18 13:57:54.920', 100, 0, 0.00);
INSERT INTO [dbo].[TUKETIM] ([TuketimId], [SayacId], [OTarihi], [Endeks], [TuketimMiktari], [Tutar]) VALUES (8, 1, '2026-02-18 13:58:15.570', 220, 0, 0.00);
INSERT INTO [dbo].[TUKETIM] ([TuketimId], [SayacId], [OTarihi], [Endeks], [TuketimMiktari], [Tutar]) VALUES (9, 1, '2026-02-18 14:00:00.687', 330, 0, 0.00);
INSERT INTO [dbo].[TUKETIM] ([TuketimId], [SayacId], [OTarihi], [Endeks], [TuketimMiktari], [Tutar]) VALUES (10, 2, '2026-02-18 14:15:24.793', 90, 90, 171000.00);
INSERT INTO [dbo].[TUKETIM] ([TuketimId], [SayacId], [OTarihi], [Endeks], [TuketimMiktari], [Tutar]) VALUES (11, 2, '2026-02-18 14:15:29.063', 130, 0, 0.00);
INSERT INTO [dbo].[TUKETIM] ([TuketimId], [SayacId], [OTarihi], [Endeks], [TuketimMiktari], [Tutar]) VALUES (12, 2, '2026-02-18 14:17:24.730', 150, 0, 0.00);
INSERT INTO [dbo].[TUKETIM] ([TuketimId], [SayacId], [OTarihi], [Endeks], [TuketimMiktari], [Tutar]) VALUES (13, 2, '2026-02-18 14:17:32.420', 60, 0, 0.00);
INSERT INTO [dbo].[TUKETIM] ([TuketimId], [SayacId], [OTarihi], [Endeks], [TuketimMiktari], [Tutar]) VALUES (14, 2, '2026-02-18 14:17:46.540', 600, 0, 0.00);
INSERT INTO [dbo].[TUKETIM] ([TuketimId], [SayacId], [OTarihi], [Endeks], [TuketimMiktari], [Tutar]) VALUES (15, 2, '2026-02-18 16:14:03.750', 900, 0, 0.00);
SET IDENTITY_INSERT [dbo].[TUKETIM] OFF;
GO

SET IDENTITY_INSERT [dbo].[UCRET] ON;
INSERT INTO [dbo].[UCRET] ([UcretId], [BFiyat], [KDVOrani], [CTVOrani], [ABOrani]) VALUES (1, 25.00, 20.00, 5.00, 50.00);
SET IDENTITY_INSERT [dbo].[UCRET] OFF;
GO

ALTER TABLE [dbo].[SAYACLAR] ADD CONSTRAINT [FK__SAYACLAR__AboneI__4CA06362] FOREIGN KEY ([AboneId]) REFERENCES [dbo].[ABONELER] ([AboneId]);
GO
ALTER TABLE [dbo].[TUKETIM] ADD CONSTRAINT [FK__TUKETIM__SayacId__4F7CD00D] FOREIGN KEY ([SayacId]) REFERENCES [dbo].[SAYACLAR] ([SayacId]);
GO

CREATE PROCEDURE sp_AboneKaydet
@Ad NVARCHAR(50),
@Soyad NVARCHAR(50),
@TCKimlik NCHAR(11),
@Adres NVARCHAR(255),
@Telefon NVARCHAR(20),
@Marka NVARCHAR(50),
@Seri NVARCHAR(10),
@Numara NVARCHAR(10)
AS
BEGIN
	INSERT INTO ABONELER (Ad, Soyad, TCKimlik, Adres, Telefon)
	VALUES (@Ad, @Soyad, @TCKimlik, @Adres, @Telefon)
	DECLARE @AboneId INT = SCOPE_IDENTITY()--O an oluşan kaydın ID sini alıp aboneId değişkenine atar
	INSERT INTO SAYACLAR (AboneId, Marka, Seri, Numara)
	VALUES (@AboneId, @Marka, @Seri, @Numara)
END
GO

CREATE PROCEDURE sp_AboneListe
AS
BEGIN
	SELECT * FROM ABONELER
END
GO

CREATE PROCEDURE sp_TuketimKaydet
@AboneId INT,
@Endeks INT
AS BEGIN
	DECLARE @SayacId INT=(SELECT SayacId FROM SAYACLAR WHERE AboneId = @AboneId)
	INSERT INTO TUKETIM (SayacId,OTarihi,ENDEKS)
	VALUES (@SayacId,GETDATE(),@Endeks)
END
GO

CREATE PROCEDURE [dbo].[sp_TuketimListele]
@AboneId INT
AS
BEGIN
	SELECT SAYACLAR.SayacId, AboneId, Marka, Seri, Numara,
	TuketimId, OTarihi, ENDEKS, TuketimMiktari ,Tutar
	FROM  SAYACLAR JOIN TUKETIM ON SAYACLAR.SayacId = TUKETIM.SayacId
	WHERE SAYACLAR.AboneId = @AboneId					   
END
GO

CREATE PROCEDURE spTuketimDuzenle
@AboneId INT
AS
BEGIN
	DECLARE @OncekiEndeks INT,@Tarih DATETIME,@TuketimId INT,@SayacId INT,@Endeks INT,@TuketimMiktari INT
	SET @SayacId=(SELECT SayacId FROM SAYACLAR WHERE AboneId=@AboneId)
	DECLARE crsTuketim CURSOR FOR
	SELECT TuketimId,Endeks,OTarihi FROM TUKETIM WHERE  SayacId=@SayacId ORDER BY OTarihi 
	OPEN crsTuketim
	FETCH NEXT FROM crsTuketim INTO @TuketimId,@Endeks,@Tarih
	WHILE @@FETCH_STATUS=0-- -1 se kayıt var -0 sa kayıt yok
	BEGIN
	IF NOT EXISTS (SELECT TOP(1) OTarihi FROM TUKETIM 
	WHERE OTarihi<@Tarih AND SayacId=@SayacId ORDER BY OTarihi DESC)--BENDEN DAHA KÜÇÜĞÜ VAR MI
	SET @OncekiEndeks=0
	ELSE
	SET @OncekiEndeks=(SELECT TOP(1) ENDEKS FROM TUKETIM 
	WHERE OTarihi<@Tarih AND SayacId=@SayacId ORDER BY OTarihi DESC)
	SET @TuketimMiktari=@Endeks-@OncekiEndeks
	UPDATE TUKETIM SET TuketimMiktari=@TuketimMiktari WHERE TuketimId=@TuketimId
	FETCH NEXT FROM crsTuketim INTO @TuketimId,@Endeks,@Tarih
	END
	CLOSE crsTuketim
	DEALLOCATE crsTuketim
END
GO

CREATE PROCEDURE spTumTuketimDuzenle
AS BEGIN
   DECLARE @SayacId INT
   DECLARE @TuketimId INT
   DECLARE @Endeks INT
   DECLARE @OTarihi DATETIME
   DECLARE @OncekiEndeks INT
   DECLARE @OncekiTarih DATETIME
   DECLARE @Tuketim INT
   DECLARE @Tutar DECIMAL(14,2)
   DECLARE cSayac CURSOR FOR SELECT DISTINCT( SayacId) FROM TUKETIM ORDER BY SayacId
   OPEN cSAYAC
   FETCH NEXT FROM cSayac INTO @SayacId
   WHILE @@FETCH_STATUS=0--- OKUMUŞŞSA 0 sa kayıt var -1 se kayıt yok
   BEGIN
   /***************************************************/
   --elimdeki @SayacId değerine göre tuketim miktarları ve Tutarları hesaplayalım
   DECLARE cTuketim CURSOR FOR SELECT TuketimId,Endeks,OTarihi 
							   FROM TUKETIM WHERE  SayacId=@SayacId ORDER BY OTarihi
   OPEN cTuketim
   FETCH NEXT FROM cTuketim INTO @TuketimId,@Endeks,@OTarihi
   WHILE @@FETCH_STATUS=0
   BEGIN
   IF NOT EXISTS (SELECT TOP(1) OTarihi FROM TUKETIM
			  WHERE SayacId=@SayacId AND OTarihi<@OTarihi ORDER BY OTarihi DESC)
	  SET @OncekiEndeks=0
   ELSE 
   BEGIN
	  SET @OncekiTarih=(SELECT TOP(1) OTarihi FROM TUKETIM
			  WHERE SayacId=@SayacId AND OTarihi<@OTarihi ORDER BY OTarihi DESC)
      -- Önceki okumanın endeksi (önceden yanlışlıkla okumanın kendi tarihi kullanılıyordu, tüketim hep 0 çıkıyordu)
      SET @OncekiEndeks=(SELECT TOP(1) Endeks FROM TUKETIM
						 WHERE SayacId=@SayacId AND OTarihi=@OncekiTarih)
   END
   DECLARE @BFiyat DECIMAL(5,2)=(SELECT TOP(1) BFiyat FROM UCRET)
   DECLARE @KDVOrani DECIMAL(4,2)=(SELECT TOP(1) KDVOrani FROM UCRET)
   DECLARE @CTVOrani DECIMAL(4,2)=(SELECT TOP(1) CTVOrani FROM UCRET)
   DECLARE @ABOrani DECIMAL(4,2)=(SELECT TOP(1) ABOrani  FROM UCRET)
   SET @Tuketim=@Endeks-@OncekiEndeks
   -- Oranlar yüzde olarak tutulur (KDV 20 = %20): trg_TuketimHesapla ile aynı formül
   SET @Tutar=@Tuketim*@BFiyat+
		      @Tuketim*@BFiyat*(@KDVOrani/100)+
			  @Tuketim*@BFiyat*(@CTVOrani/100)+
			  @Tuketim*@BFiyat*(@ABOrani/100)
   
   UPDATE TUKETIM SET TuketimMiktari=@Tuketim,Tutar=@Tutar WHERE TuketimId=@TuketimId
   
   FETCH NEXT FROM cTuketim INTO @TuketimId,@Endeks,@OTarihi
   END
   CLOSE cTuketim
   DEALLOCATE cTuketim

	  FETCH NEXT FROM cSayac INTO @SayacId
   END
   CLOSE cSayac
   DEALLOCATE cSayac
   END
GO

CREATE TRIGGER [dbo].[trg_TuketimHesapla]
ON [dbo].[TUKETIM]--trigger hangi tablo değişince çalışacak
FOR INSERT--hangi tablonun ardında çalışacak
AS BEGIN
DECLARE @Tuketim INT,@OTuketimID INT,@OEndeks INT
DECLARE @TuketimId INT=(SELECT TuketimId FROM inserted)--inserted tablosu triggerin çalıştığı tabloya yapılan ekleme işlemini tutar
DECLARE @SayacId INT=(SELECT SayacId FROM inserted)	
DECLARE @OTarihi DATETIME=(SELECT OTarihi FROM inserted)
DECLARE @Endeks INT=(SELECT ENDEKS FROM inserted)
IF NOT EXISTS (SELECT TOP(1) OTarihi FROM TUKETIM 
WHERE OTarihi<@OTarihi AND SayacId=@SayacId ORDER BY OTarihi DESC)--BENİM OKUMA TARİHİMDEN DAHA ESKİ BİR OKUMA TARİHİ YOKSA İLK DEFA OKUMA YAPILIYOR DEMEKTİR TÜKETİMDE ENDEKSE EŞİTTİR
SET @Tuketim=@Endeks
ELSE
BEGIN
SET @OTuketimID=(SELECT TOP(1) TuketimId FROM TUKETIM 
WHERE OTarihi<@OTarihi AND SayacId=@SayacId ORDER BY OTarihi DESC)
SET @OEndeks=(SELECT ENDEKS FROM TUKETIM WHERE TuketimId=@OTuketimID)
SET @Tuketim=@Endeks-@OEndeks
END
DECLARE @BFiyat DECIMAL(5,2)=(SELECT BFiyat FROM UCRET),
		@KDVOrani DECIMAL(4,2)=(SELECT KDVOrani FROM UCRET),
		@CTVOrani DECIMAL(4,2)=(SELECT CTVOrani FROM UCRET),
		@ABOrani DECIMAL(4,2)=(SELECT ABOrani FROM UCRET)
DECLARE @Tutar DECIMAL(14,2)=@BFiyat*@Tuketim+
							 @BFiyat*@Tuketim*(@KDVOrani/100)+
							 @BFiyat*@Tuketim*(@CTVOrani/100)+
							 @BFiyat*@Tuketim*(@ABOrani/100)
UPDATE TUKETIM SET TuketimMiktari=@Tuketim ,Tutar=@Tutar
WHERE TuketimId=@TuketimId
END
GO
