using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopAppPractice3
{
    class Shop
    {
        public Shop()
        {
            products = new List<Product>(); 
        }
        public string Name { get; set; }
        public string Address { get; set; }

        private List<Product> products;

        public bool AddProduct(Product product)
        {
            int i = 0;
            while (true)
            {
                if (products.Count == 0)//& products[i].Id == product.Id
                {
                    products.Add(product);
                    products[i].Quantity = products[i].Quantity + product.Quantity;
                    i++;
                }
                if()
                else
                {
                    products.Add(product);
                    break;
                }
            }

            return true;

        }

        public string ShowDetails()
        {
            string message = "";
            string show = "product ID\t\t" + "Quantity\n";
            string info = "";
            foreach(Product product in products)
            {
                info = info + product.Id + "\t\t" + product.Quantity+"\n";

            }

            message = message + show + info;
            return message;
        }
        
    }
}
