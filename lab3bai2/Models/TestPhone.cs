using System.Collections.Generic;
using System.Linq;

namespace lab3bai2.Models
{
    public class TestPhone
    {
        private readonly List<Phone> _list;

        public TestPhone()
        {
            _list = new List<Phone>()
            {
                new Phone { Id = 1, Name = "iPhone 16 Pro Max", Brand = "Apple", Price = 34990000, Image = "/images/iphone16promax.png", Description = "Chip A18 Pro, Dynamic Island, Titanium, Camera 48MP, Always-on Display." },
                new Phone { Id = 2, Name = "iPhone 16", Brand = "Apple", Price = 25990000, Image = "/images/Iphone16.png", Description = "Chip A17 Bionic, màn OLED 6.1\", camera kép 48MP, sạc MagSafe." },
                new Phone { Id = 3, Name = "Samsung Galaxy S24 Ultra", Brand = "Samsung", Price = 32990000, Image = "/images/s24ultra.jpg", Description = "Snapdragon 8 Gen 3, Zoom 100x, bút S-Pen, màn 6.8\" QHD+ 120Hz." },
                new Phone { Id = 4, Name = "Samsung Galaxy S24+", Brand = "Samsung", Price = 28990000, Image = "/images/S24+.jpg", Description = "Chip Snapdragon 8 Gen 3, màn 6.7\", pin 4900mAh, sạc nhanh 45W." },
                new Phone { Id = 5, Name = "Xiaomi 14 Ultra", Brand = "Xiaomi", Price = 22990000, Image = "/images/14ultra.png", Description = "Leica Camera 50MP, Snapdragon 8 Gen 3, màn AMOLED WQHD+ 120Hz." },
                new Phone { Id = 6, Name = "Xiaomi 14 Pro", Brand = "Xiaomi", Price = 18990000, Image = "/images/14pro.png", Description = "Snapdragon 8 Gen 3, pin 5000mAh, sạc nhanh 120W, màn 2K LTPO." },
                new Phone { Id = 7, Name = "OPPO Find X7 Ultra", Brand = "OPPO", Price = 25990000, Image = "/images/x7ultra.jpg", Description = "Camera Hasselblad, 50MP Quad Sensor, chip Dimensity 9300, màn LTPO 120Hz." },
                new Phone { Id = 8, Name = "OPPO Reno12 Pro", Brand = "OPPO", Price = 15990000, Image = "/images/reno12pro.png", Description = "Dimensity 9200+, camera chân dung AI, sạc siêu nhanh 100W, thiết kế mỏng nhẹ." },
                new Phone { Id = 9, Name = "Vivo X100 Pro", Brand = "Vivo", Price = 23990000, Image = "/images/x100pro.jpg", Description = "Zeiss Camera, Dimensity 9300, màn AMOLED 120Hz, pin 5400mAh, sạc 120W." },
                new Phone { Id = 10, Name = "Vivo V30 Pro", Brand = "Vivo", Price = 13990000, Image = "/images/v30pro.png", Description = "Thiết kế mỏng, camera ánh sáng Aura Ring, sạc nhanh 80W, màn AMOLED 120Hz." },
                new Phone { Id = 11, Name = "OnePlus 12", Brand = "OnePlus", Price = 21990000, Image = "/images/one12.jpg", Description = "Snapdragon 8 Gen 3, camera Hasselblad, pin 5400mAh, sạc nhanh 100W." },
                new Phone { Id = 12, Name = "OnePlus 12R", Brand = "OnePlus", Price = 17990000, Image = "/images/12r.png", Description = "Snapdragon 8 Gen 2, màn 6.7\" AMOLED 120Hz, pin 5500mAh, sạc 80W." },
                new Phone { Id = 13, Name = "Google Pixel 9 Pro", Brand = "Google", Price = 25990000, Image = "/images/pixel9pro.jpg", Description = "Tensor G4, camera AI cực mạnh, Android 15, cập nhật bảo mật 7 năm." },
                new Phone { Id = 14, Name = "Google Pixel 8a", Brand = "Google", Price = 13990000, Image = "/images/pixel8a.jpg", Description = "Tensor G3, màn OLED 120Hz, camera 64MP, pin 4500mAh." },
                new Phone { Id = 15, Name = "realme GT 6 Pro", Brand = "realme", Price = 13990000, Image = "/images/gt6pro.jpg", Description = "Snapdragon 8s Gen 3, camera 50MP, pin 5500mAh, sạc 120W." },
                new Phone { Id = 16, Name = "realme 12 Pro+", Brand = "realme", Price = 10990000, Image = "/images/12pro+.jpg", Description = "Thiết kế đồng hồ sang trọng, camera tiềm vọng 64MP, sạc nhanh 67W." },
                new Phone { Id = 17, Name = "ASUS ROG Phone 8", Brand = "ASUS", Price = 27990000, Image = "/images/ROG8.png", Description = "Gaming flagship, Snapdragon 8 Gen 3, tản nhiệt cực đỉnh, màn AMOLED 165Hz." },
                new Phone { Id = 18, Name = "Tecno Phantom X3", Brand = "Tecno", Price = 9990000, Image = "/images/TPX3.jpg", Description = "MediaTek Dimensity 8200, camera 64MP, màn cong AMOLED 120Hz." },
                new Phone { Id = 19, Name = "Infinix Zero Ultra 5G", Brand = "Infinix", Price = 8990000, Image = "/images/zeroUltra.jpg", Description = "Sạc nhanh 180W, camera 200MP, pin 4500mAh, màn 120Hz." },
                new Phone { Id = 20, Name = "Honor Magic 6 Pro", Brand = "Honor", Price = 23990000, Image = "/images/Magic6pro.jpg", Description = "Snapdragon 8 Gen 3, camera AI, pin 5600mAh, sạc 80W, màn 1.5K 120Hz." },
            };
        }

        public List<Phone> GetAll() => _list;

        public Phone? GetById(int id) => _list.FirstOrDefault(p => p.Id == id);
    }
}
