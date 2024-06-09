USE FoodDB;

CREATE TABLE food (
    MaMonAn INT PRIMARY KEY,
    TenMonAn NVARCHAR(100),
    DiaChi NVARCHAR(255),
    NguoiDongGop NVARCHAR(100),
    Gia DECIMAL(10, 2),
    IMGurl NVARCHAR(255)
);

INSERT INTO food (MaMonAn, TenMonAn, DiaChi, NguoiDongGop, Gia, IMGurl)
VALUES 
(1, N'Phở Bò', N'24 Lý Quốc Sư, Hà Nội', N'Nguyễn Văn A', 50000, N'https://bizweb.dktcdn.net/100/442/328/products/bun-cha-ha-noi.jpg?v=1644892472637'),
(2, N'Bánh Mì', N'37 Nguyễn Trãi, TP. Hồ Chí Minh', N'Lê Thị B', 20000, N'https://th.bing.com/th/id/OIP.L5mldyQlCQoxJQQFm_briAHaEL?rs=1&pid=ImgDetMain'),
(3, N'Bún Chả', N'140 Bạch Đằng, Hà Nội', N'Trần Văn C', 60000, N'https://bizweb.dktcdn.net/100/442/328/products/bun-cha-ha-noi.jpg?v=1644892472637');

select * from food
SELECT MaMonAn, TenMonAn, DiaChi, NguoiDongGop, Gia, IMGurl FROM food;

DELETE FROM food WHERE MaMonAn = 521

