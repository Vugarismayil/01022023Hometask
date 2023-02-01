using System;
using System.Collections.Generic;
using System.Text;

namespace _01022023HomeTaskend
{
    internal class ProductNotFoundException:Exception
    {
        public ProductNotFoundException() : base("Eyni element elave edile bilmez!")
        {
        }

        
    }
}
