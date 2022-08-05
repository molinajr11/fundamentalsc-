using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BLayer.Repositorys
{
    public class ProductRepository
    {
       public Product Retrive(int productId)
        {
            Product product = new Product(productId);
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size set of 4 bright";
                product.CurrentPrice = 20.5M;
            }
            return product;
        }
        public bool Save(Product product) { return true; }
    }
}
