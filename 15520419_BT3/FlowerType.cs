using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BT3_15520419
{
    public class FlowerType
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
