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
               
                context.Items.Add(new Item { Name = "Vlad", Price = 100000});
                context.Users.Add(new User { Name = "vlad", Age = 16 });
                context.SaveChanges();               
            }
            
        }
    }
}
