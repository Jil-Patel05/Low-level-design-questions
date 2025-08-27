using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Low_Level_Design_questions.VendingMachineDesign
{
    public class Shelf
    {
        public Product product;
        public string shelfId;
        public Shelf(Product product, string shelfId)
        {
            this.product = product;
            this.shelfId = shelfId;
        }
    }
}