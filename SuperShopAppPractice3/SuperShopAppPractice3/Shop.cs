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

        public void AddProduct(Product product)
        {
            int check = 0;



            for (int i = 0; i < products.Count; i++)
            {
                if (products.Count == 0)//& products[i].Id == product.Id
                {
                    products.Add(product);
                    check++;
                    break;

                }
                if (products[i].Id == product.Id)
                {
                    products[i].Quantity = products[i].Quantity + product.Quantity;
                    i++;
                    check++;
                    break;

                }

            }



            if (check == 0)
            {
                products.Add(product);
            }

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
