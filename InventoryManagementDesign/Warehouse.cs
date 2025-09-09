using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.InventoryManagementDesign
{
    public class Location
    {
        public string city;
        public string pincode;

        public Location(string city, string pincode)
        {
            this.city = city;
            this.pincode = pincode;
        }
    }
    public class Warehouse
    {
        public IList<Product> products = new List<Product>();
        public Location location;

        public Warehouse()
        {

        }

        public Product? getProduct(Product product)
        {
            Product? neededProduct = this.products.Where((p) => p.id == product.id).FirstOrDefault();
            return neededProduct;
        }

        public void AddProducts(Product product)
        {
            products.Add(product);
        }

        public void removeProduct(Product product)
        {
            products.Remove(product);
        }

        public void getAvailableProducts()
        {
            // We have to list down all products here with relavant information
        }

        public void addProductQuantity(Product product, int number)
        {
            try
            {
                Product? productToBeUpdated = this.getProduct(product);
                if (productToBeUpdated != null)
                {
                    product.addProduct(number);
                }
                else
                {
                    throw new Exception("Id not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public void removeProductQuantity(Product product, int number)
        {
            try
            {
                Product? productToBeUpdated = this.getProduct(product);
                if (productToBeUpdated != null)
                {
                    product.removeProduct(number);
                }
                else
                {
                    throw new Exception("Id not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}