using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem2.BL
{
    internal class Product
    {
        public string productName;
        public string productCategory;
        public int productPrice;
        public int availableStockQuantity;
        public int minimumStockThreshold;

        public Product(string productName, string productCategory, int productPrice, int availableStockQuantity, int minimumStockThreshold)
        {
            this.productName = productName;
            this.productCategory = productCategory;
            this.productPrice = productPrice;
            this.availableStockQuantity = availableStockQuantity;
            this.minimumStockThreshold = minimumStockThreshold;
        }
        public float CalculateSalesTax()
        {
            if (Category.ToLower() == "grocery")
                return Price * 0.10f;
            else if (Category.ToLower() == "fruit")
                return Price * 0.05f;
            else
                return Price * 0.15f;
        }

        public new string ToString()
        {
            return $"Name: {Name}, Category: {Category}, Price: {Price}, Stock: {StockQuantity}, Threshold: {Threshold}";
        }


    }
}
