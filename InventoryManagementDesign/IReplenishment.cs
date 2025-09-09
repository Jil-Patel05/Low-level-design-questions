using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.InventoryManagementDesign
{
    public interface IReplenishment
    {
        public void replenish(Product product);
    }

    public class JustInTimeReplenishment : IReplenishment
    {
        public void replenish(Product product)
        {
            Console.WriteLine("Justin time replenishment");
        }
    }
    public class BulkReplenishment : IReplenishment
    {
        public void replenish(Product product)
        {
            Console.WriteLine("Bulk replenishment");
        }
    }
}