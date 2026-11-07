-- Chay script nay trong SSMS, dang o database QLSinhVien, TRUOC khi chay
-- ung dung Lab 12. Tao 2 bang con thieu: HocPhan va DangKy, kem du lieu mau.
-- Theo de bai, nen sao luu (backup) database truoc khi chay script nay.
USE QLSinhVien;
GO

IF OBJECT_ID('dbo.DangKy', 'U') IS NOT NULL DROP TABLE dbo.DangKy;
IF OBJECT_ID('dbo.HocPhan', 'U') IS NOT NULL DROP TABLE dbo.HocPhan;
GO

CREATE TABLE HocPhan (
    MaHP     VARCHAR(10)   NOT NULL PRIMARY KEY,
    TenHP    NVARCHAR(100) NOT NULL,
    SoTinChi INT           NOT NULL
);
GO

CREATE TABLE DangKy (
    MaSV  VARCHAR(15)   NOT NULL,
    MaHP  VARCHAR(10)   NOT NULL,
    HocKy INT           NOT NULL,
    Diem  DECIMAL(4,2)  NULL,
    CONSTRAINT PK_DangKy PRIMARY KEY (MaSV, MaHP),
    CONSTRAINT FK_DangKy_SinhVien FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
    CONSTRAINT FK_DangKy_HocPhan FOREIGN KEY (MaHP) REFERENCES HocPhan(MaHP)
);
GO

INSERT INTO HocPhan (MaHP, TenHP, SoTinChi) VALUES
    ('HP001', N'Lập trình .NET', 3),
    ('HP002', N'Cơ sở dữ liệu', 3),
    ('HP003', N'Cấu trúc dữ liệu và giải thuật', 4),
    ('HP004', N'Mạng máy tính', 3),
    ('HP005', N'Kỹ thuật phần mềm', 3),
    ('HP006', N'Hệ điều hành', 3);
GO

-- Dang ky mau cho vai sinh vien da co san (chi chay duoc neu MaSV ton tai trong SinhVien)
INSERT INTO DangKy (MaSV, MaHP, HocKy, Diem)
SELECT TOP 5 sv.MaSV, hp.MaHP, 1, NULL
FROM SinhVien sv
CROSS JOIN (SELECT TOP 1 MaHP FROM HocPhan WHERE MaHP = 'HP001') hp
WHERE NOT EXISTS (SELECT 1 FROM DangKy dk WHERE dk.MaSV = sv.MaSV AND dk.MaHP = hp.MaHP);
GO

SELECT COUNT(*) AS TongHocPhan FROM HocPhan;
SELECT COUNT(*) AS TongDangKy FROM DangKy;
GO
