using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Entities
{
    class SoldProductsStatistic : IEntity
    {
        public int Id { get; set; }
        public int Sum { get; set; }
        public DateTime Date { get; set; }
    }
}
