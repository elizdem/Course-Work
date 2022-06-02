using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Entities
{
    class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Article { get; set; }
        public int Cost { get; set; }
        public string Brand { get; set; }
        public int Size { get; set; }
    }
}
