using onlineShop.Data;
using onlineShop.Models;
using System.Linq;

namespace onlineShop
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new ShopContext())
            {
               
                context.Bins.Add(new Bin());
                context.Items.Add(new Item { Name = "Milk", Price = 357});
                context.Items.Add(new Item { Name = "Nibba", Price = 4500 });
                context.Items.Add(new Item { Name = "PayPal", Price = 1465 });
                context.Items.Add(new Item { Name = "Shshs", Price = 1045 });
                context.SaveChanges();               
            }
            
        }
    }
}
