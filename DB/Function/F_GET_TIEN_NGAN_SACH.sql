USE [QUANLYTAISAN]
GO
/****** Object:  UserDefinedFunction [dbo].[GET_TienNganSach]    Script Date: 11/22/2020 3:09:42 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




ALTER FUNCTION [dbo].[GET_TienNganSach]
(@id_vi INT, @id_loai_gd INT)
RETURNS MONEY
AS
BEGIN
	DECLARE @SUM MONEY
	DECLARE @count INT

	DECLARE @ngay_bat_dau DATE
	DECLARE @ngay_ket_thuc DATE

	

	SELECT @ngay_bat_dau = ngay_bat_dau FROM NganSach
	WHERE @id_vi = ma_vi
	AND @id_loai_gd = ma_loai_gd

	SELECT @ngay_ket_thuc = ngay_ket_thuc FROM NganSach
	WHERE @id_vi = ma_vi
	AND @id_loai_gd = ma_loai_gd

	SELECT @count = COUNT(*) FROM GiaoDichTaiChinh
	WHERE ma_vi = @id_vi
	AND ma_loai_gd = @id_loai_gd
	AND thoi_gian >= @ngay_bat_dau
	AND thoi_gian <= @ngay_ket_thuc

	IF(@count > 0)
	BEGIN
		SELECT @SUM = SUM(so_tien) FROM GiaoDichTaiChinh
		WHERE ma_vi = @id_vi
		AND ma_loai_gd = @id_loai_gd
		AND thoi_gian >= @ngay_bat_dau
		AND thoi_gian <= @ngay_ket_thuc
		
	END
	ELSE
		SET @SUM = 0
RETURN @SUM
END

