using System;
using System.Collections.Generic;
using System.Text;

namespace _01022023HomeTaskend
{
    internal class Product
    {
        private string _productNo;
        public string Category;
        public double Price;

        public string ProductNumber
        {
            get => _productNo;
            set
            {
                if (GetProductBuNo(value))
                    _productNo = value;
            }
        }
        public static bool GetProductBuNo(string num)
        {
            if (string.IsNullOrWhiteSpace(num))
                return false;
            if (!char.IsLetter(num[0]))
                return false;
            for (int i = 1; i < num.Length; i++)
            {
                if (!char.IsDigit(num[i]))
                    return false;
            }
            return true;
        }
    }
        
}
