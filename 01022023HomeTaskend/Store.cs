using System;
using System.Collections.Generic;
using System.Text;

namespace _01022023HomeTaskend
{
    internal class Store
    {
        Product[] Products = new Product[0];
        public void AddProduct(Product pr)
        {
            if (!HasProductByNo(pr.ProductNumber))
            {
                Array.Resize(ref Products, Products.Length + 1);
                Products[Products.Length - 1] = pr;
            }
            else
            {
                Console.WriteLine("Error_S19:Mehsul Elave Edildi");
            }
        }
        public bool HasProductByNo(string no)
        {
            foreach (Product pr in Products)
            {
                if (pr.ProductNumber == no)
                    return true;
            }
            return false;
        }

        internal void HasProductByNo(string v, object no)
        {
            throw new NotImplementedException();
        }
    }
}
