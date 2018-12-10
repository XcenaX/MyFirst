using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.Models
{
   public class Bin
    {
        public int Id { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
