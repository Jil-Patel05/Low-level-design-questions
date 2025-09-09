using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.InventoryManagementDesign
{
    public class InventoryManager
    {
        private IList<Warehouse> warehouses = new List<Warehouse>();
        public static InventoryManager instance;
        private static Object obj = new Object();

        private InventoryManager()
        {

        }

        public InventoryManager getInstance()
        {
            if (instance != null)
            {
                lock (obj)
                {
                    if (instance != null)
                    {
                        instance = new InventoryManager();
                    }
                }

            }
            return instance;
        }

        public void addWareHouse(Warehouse warehouse)
        {
            this.warehouses.Add(warehouse);
        }
        public void removeWareHouse(Warehouse warehouse)
        {
            this.warehouses.Remove(warehouse);
        }

        public void getAvailableStocks()
        {
            foreach (Warehouse item in this.warehouses)
            {
                item.getAvailableProducts();
            }
        }

        public void removeProduct(Product product, int number)
        {
            foreach (Warehouse item in this.warehouses)
            {
                Product? findProduct = item.getProduct(product);
                if (product != null)
                {
                    product.removeProduct(number);
                }
            }
        }
        public void addProduct(Product product, int number)
        {
            foreach (Warehouse item in this.warehouses)
            {
                Product? findProduct = item.getProduct(product);
                if (product != null)
                {
                    product.addProduct(number);
                }
            }
        }
    }
}