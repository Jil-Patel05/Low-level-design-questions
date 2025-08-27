using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Low_Level_Design_questions.VendingMachineDesign
{
    public class Product
    {
        public string productName;
        public double productPrice;
        public double quantity;

        public Product(string productName, double productPrice, int quantity)
        {
            this.productName = productName;
            this.productPrice = productPrice;
            this.quantity = quantity;
        }

        public bool isEnoughtQuantity(int quantity)
        {
            return this.quantity >= quantity;
        }

        public void setProductQuantity(int takenProducts)
        {
            this.quantity -= takenProducts;
        }
        // Change product name
        // Change product price
    }
}