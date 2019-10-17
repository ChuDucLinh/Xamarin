using System;
using System.Collections.Generic;
using System.Text;

namespace BT2_15520419
{
    public class FlowerType: List<Flower>
    {
        public string Name { get; set; }

        public IList<FlowerType> FlowerTypes { get; set; }

        private FlowerType(string name)
        {
            Name = name;
        }
        
        public FlowerType()
        {
            List<FlowerType> list = new List<FlowerType>();

            list.Add(new FlowerType("Hoa cúc")
            {
                new Flower
                {
                    Name = "Đón xuân",
                    Price = 50000,
                    Image = "don_xuan.jpg",
                    Description = "Hoa cúc các màu: trắng, vàng, cam"
                },
                new Flower
                {
                    Name = "Hồn nhiên",
                    Price = 60000,
                    Image = "hon_nhien.jpg",
                    Description = "Hoa cúc các vàng, cam, lá măng"
                },
                new Flower
                {
                    Name = "Tím thủy chung",
                    Price = 45000,
                    Image = "tim_thuy_chung.jpg",
                    Description = "Hoa cúc tím"
                }
            });

            list.Add(new FlowerType("Hoa cưới")
            {
                new Flower
                {
                    Name = "Dây tơ hồng",
                    Price = 250000,
                    Image = "day_to_hong.jpg",
                    Description = "Hoa hồng màu hồng đậm, hoa hồng xanh, các loại lá măng"
                },
                new Flower
                {
                    Name = "Cầu thủy tinh",
                    Price = 220000,
                    Image = "cau_thuy_tinh.jpg",
                    Description = "Hoa hồng và hoa thủy tiên trắng"
                },
                new Flower
                {
                    Name = "Duyên thầm",
                    Price = 260000,
                    Image = "duyen_tham.jpg",
                    Description = "Hoa cúc trắng, baby, lá măng"
                }
            });

            FlowerTypes = list;
        }
    }
}
