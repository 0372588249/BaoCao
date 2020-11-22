




SELECT so_tien, ngay_bat_dau, ngay_ket_thuc FROM NganSach
WHERE ma_vi = 1
AND ma_loai_gd = 31

SELECT ten_vi, img, don_vi FROM VI
WHERE ma_vi = 1

SELECT ten_loai_gd, img FROM LoaiGiaoDich
USE QUANLYTAISAN
GO

SELECT * FROM LoaiGiaoDich
SELECT * FROM GiaoDichTaiChinh
SELECT * FROM NhomGiaoDich

select GETDATE()

SELECT SUM(GiaoDichTaiChinh.so_tien) AS 'so_tien', LoaiGiaoDich.ten_loai_gd FROM GiaoDichTaiChinh, LoaiGiaoDich,NhomGiaoDich,VI
WHERE GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
AND LoaiGiaoDich.ma_nhom_gd = NhomGiaoDich.ma_nhom_gd
AND GiaoDichTaiChinh.ma_vi = VI.ma_vi
AND VI.taikhoan = 'ADMIN'
AND NhomGiaoDich.ten_nhom_gd = N'Khoản chi'
AND GiaoDichTaiChinh.thoi_gian >= '11-23-2020'
AND GiaoDichTaiChinh.thoi_gian <= '11-29-2020'
AND VI.ma_vi = '1'
GROUP BY LoaiGiaoDich.ten_loai_gd

SELECT SUM(GiaoDichTaiChinh.so_tien) AS 'so_tien', LoaiGiaoDich.ten_loai_gd FROM GiaoDichTaiChinh, LoaiGiaoDich,NhomGiaoDich,VI
WHERE GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
AND LoaiGiaoDich.ma_nhom_gd = NhomGiaoDich.ma_nhom_gd
AND GiaoDichTaiChinh.ma_vi = VI.ma_vi
AND VI.taikhoan = 'ADMIN'
AND NhomGiaoDich.ten_nhom_gd = N'Khoản thu'
AND GiaoDichTaiChinh.thoi_gian >= GETDATE()
AND GiaoDichTaiChinh.thoi_gian <= GETDATE()
GROUP BY LoaiGiaoDich.ten_loai_gd



SELECT SUM(GiaoDichTaiChinh.so_tien) AS 'so_tien', LoaiGiaoDich.ten_loai_gd FROM GiaoDichTaiChinh, LoaiGiaoDich,NhomGiaoDich,VI
WHERE GiaoDichTaiChinh.ma_loai_gd = LoaiGiaoDich.ma_loai_gd
AND LoaiGiaoDich.ma_nhom_gd = NhomGiaoDich.ma_nhom_gd
AND GiaoDichTaiChinh.ma_vi = VI.ma_vi
AND VI.taikhoan = 'ADMIN'
AND NhomGiaoDich.ten_nhom_gd = N'Khoản chi'
AND GiaoDichTaiChinh.thoi_gian >= '11-23-2020'
AND GiaoDichTaiChinh.thoi_gian <= '11-29-2020'
AND VI.ma_vi = '1'
GROUP BY LoaiGiaoDich.ten_loai_gd