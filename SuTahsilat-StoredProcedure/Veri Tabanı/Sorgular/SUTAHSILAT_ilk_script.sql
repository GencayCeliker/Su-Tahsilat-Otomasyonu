CREATE DATABASE SUTAHSILAT
GO
USE SUTAHSILAT
GO
CREATE TABLE ABONELER (
	AboneId INT IDENTITY PRIMARY KEY,
	Ad NVARCHAR(50),
	Soyad NVARCHAR(50),
	TCKimlik NCHAR(11),
	Adres NVARCHAR(255),
	Telefon NVARCHAR(20)
)
GO
CREATE TABLE SAYACLAR (
	SayacId INT IDENTITY PRIMARY KEY,
	AboneId INT FOREIGN KEY REFERENCES ABONELER(AboneId),
	Marka NVARCHAR(50),
	Seri NVARCHAR(10),
	Numara NVARCHAR(10)
)
GO
CREATE TABLE TUKETIM (
	TuketimId INT IDENTITY PRIMARY KEY,
	SayacId INT FOREIGN KEY REFERENCES SAYACLAR(SayacId),
	OTarihi DATETIME,
	ENDEKS INT,
	TuketimMiktari INT
)
GO
CREATE PROCEDURE sp_AboneListe
AS
BEGIN
	SELECT * FROM ABONELER
END
GO
CREATE PROCEDURE sp_TuketimListele
@AboneId INT
AS
BEGIN
	SELECT SAYACLAR.SayacId, AboneId, Marka, Seri, Numara,
	TuketimId, OTarihi, ENDEKS, TuketimMiktari 
	FROM  SAYACLAR JOIN TUKETIM ON SAYACLAR.SayacId = TUKETIM.SayacId
	WHERE SAYACLAR.AboneId = @AboneId					   
END
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
CREATE PROCEDURE sp_TuketimKaydet
@AboneId INT,
@Endeks INT
AS BEGIN
	DECLARE @SayacId INT=(SELECT SayacId FROM SAYACLAR WHERE AboneId = @AboneId)
	INSERT INTO TUKETIM (SayacId,OTarihi,ENDEKS)
	VALUES (@SayacId,GETDATE(),@Endeks)
END
GO
ALTER TRIGGER trg_TuketimHesapla
ON TUKETIM--trigger hangi tablo değişince çalışacak
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
UPDATE TUKETIM SET TuketimMiktari=@Tuketim WHERE TuketimId=@TuketimId
END
GO
DECLARE @Gecici TABLE (TuketimId INT, SayacId INT, OTarihi DATETIME, ENDEKS INT, TuketimMiktari INT)
INSERT INTO TUKETIM (SayacId, OTarihi, ENDEKS)--Önemli
OUTPUT inserted.* INTO @Gecici
VALUES (1, GETDATE(), 220)
SELECT * FROM @Gecici
GO
CREATE TRIGGER Deneme
ON TUKETIM
AFTER INSERT
AS BEGIN
DECLARE @TuketimId INT=(SELECT TuketimId FROM inserted)
DECLARE @SayacId INT=(SELECT SayacId FROM inserted)
DECLARE @Endeks INT=(SELECT ENDEKS FROM inserted)
SELECT 'TuketimId:'+CAST(@TuketimId AS NVARCHAR(25))
SELECT 'SayacId:'+CAST(@SayacId AS NVARCHAR(25))
SELECT 'Endeks:' +CAST(@Endeks AS NVARCHAR(25))
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
ALTER TABLE TUKETIM ADD Tutar DECIMAL(14,2)
GO
CREATE TABLE UCRET
(
UcretId INT IDENTITY PRIMARY KEY,
BFiyat DECIMAL(5,2),
KDVOrani DECIMAL(4,2),
CTVOrani DECIMAL(4,2),
ABOrani DECIMAL(4,2)
)
GO 
INSERT INTO UCRET VALUES (25,20,5,50)
GO
USE SUTAHSILAT
GO
CREATE PROCEDURE spTumTuketimDuzenle
AS BEGIN
	
	DECLARE @SayacId INT
	DECLARE cSayac CURSOR FOR SELECT DISTINCT(SayacId) FROM TUKETIM ORDER BY SayacId
	OPEN cSayac
	FETCH NEXT FROM cSayac INTO @SayacId

	WHILE @@FETCH_STATUS = 0
		BEGIN
			DECLARE @TuketimId INT,
					@OncekiEndeks INT, @Endeks INT,
					@Tarih DATETIME, @OncekiTarih DATETIME,
					@Tuketim INT, @Tutar DECIMAL(14,2)

			DECLARE cTuketim CURSOR FOR SELECT TuketimID, Endeks, OTarihi FROM TUKETIM
			WHERE SayacId = @SayacId ORDER BY OTarihi ASC
			OPEN cTuketim
			FETCH NEXT FROM cTuketim INTO @TuketimId, @Endeks, @Tarih
			
			WHILE @@FETCH_STATUS = 0
			BEGIN
				IF NOT EXISTS (SELECT TOP(1) OTarihi FROM TUKETIM
						WHERE OTarihi < @Tarih AND SayacId = @SayacId ORDER BY OTarihi DESC)
					SET @OncekiEndeks = 0
				ELSE
					BEGIN
					
						SET @OncekiTarih = (SELECT TOP(1) OTarihi FROM TUKETIM
								WHERE OTarihi < @Tarih AND SayacId = @SayacId ORDER BY OTarihi DESC)
					
						SET @OncekiEndeks = (SELECT TOP(1) Endeks FROM TUKETIM
								WHERE SayacId = @SayacId AND OTarihi = @OncekiTarih)
					
					END
					
					DECLARE @BFiyat DECIMAL(5,2) = (SELECT TOP(1) BFiyat FROM UCRET)
					DECLARE @KDVOrani DECIMAL(4,2) = (SELECT TOP(1) KDVOrani FROM UCRET)
					DECLARE @CTVOrani DECIMAL(4,2) = (SELECT TOP(1) CTVOrani FROM UCRET)
					DECLARE @ABOrani DECIMAL(4,2) = (SELECT TOP(1) ABOrani FROM UCRET)

					SET @Tuketim = @Endeks - @OncekiEndeks

					SET @Tutar = @Tuketim * @BFiyat +
								 @Tuketim * @BFiyat * (@KDVOrani/100 )+
								 @Tuketim * @BFiyat * (@CTVOrani/100) +
								 @Tuketim * @BFiyat * (@ABOrani/100) 
					
					UPDATE TUKETIM SET Tuketim = @Tuketim ,Tutar = @Tutar
					WHERE TuketimId = @TuketimId
				
				FETCH NEXT FROM cTuketim INTO @TuketimId, @Endeks, @Tarih
			END
			CLOSE cTuketim
			DEALLOCATE cTuketim
			FETCH NEXT FROM cSayac INTO @SayacId
		END
		CLOSE cSayac
		DEALLOCATE cSayac
END