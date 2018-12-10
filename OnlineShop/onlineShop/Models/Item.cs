using System.Collections.Generic;

namespace onlineShop.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }        
        public int Price { get; set; }
        public ICollection<Bin> Bins { get; set; }
    }
}
