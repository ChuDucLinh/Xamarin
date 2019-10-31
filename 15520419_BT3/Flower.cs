using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT3_15520419
{
    public class Flower
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
