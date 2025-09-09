using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.InventoryManagementDesign
{
    public enum PRODUCT_TYPES
    {
        ELECTRONICS,
        KITCHEN,
        SKIN
    }

    public enum PRODUCT_TYPES_THRESHHOLD
    {
        ELECTRONICS = 10,
        KITCHEN = 5,
        SKIN = 20

    }
    public class Product
    {
        public Guid id;
        public string name;
        public PRODUCT_TYPES productType;
        public int productQuantity;
        public double price;
        public int threshHold;

        public Product(string name, PRODUCT_TYPES productType, int productQuantity, double price)
        {
            this.name = name;
            this.productType = productType;
            this.productQuantity = productQuantity;
            this.price = price;
            this.threshHold = this.getThresholdValue(productType);
        }

        private int getThresholdValue(PRODUCT_TYPES productType)
        {
            switch (productType)
            {
                case PRODUCT_TYPES.ELECTRONICS:
                    return (int)PRODUCT_TYPES_THRESHHOLD.ELECTRONICS;
                case PRODUCT_TYPES.KITCHEN:
                    return (int)PRODUCT_TYPES_THRESHHOLD.KITCHEN;
                case PRODUCT_TYPES.SKIN:
                    return (int)PRODUCT_TYPES_THRESHHOLD.SKIN;
                default:
                    return 0;
            }
        }

        public void addProduct(int number)
        {
            this.productQuantity += number;
        }

        public void removeProduct(int number)
        {
            this.productQuantity -= number;
            if (this.productQuantity <= this.threshHold)
            {
                // We have to add observer here to get alert for low product
            }
        }
    }
}