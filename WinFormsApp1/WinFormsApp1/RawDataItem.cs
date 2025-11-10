using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class RawDataItem
    {
        public String Name { get; set; }
        public int Group { get; set; }
        public double Count { get; set; }

        public double PurchasePrice { get; set; }
        public double SalePrice { get; set; }
        public double SummPurchasePrice
        {
            get { return Count * PurchasePrice; }
        }
        public double SummSalePrice
        {
            get { return Count * SalePrice; }
        }
    }
}
