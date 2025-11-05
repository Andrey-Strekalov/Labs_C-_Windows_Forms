using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class RawDataItem
    {
        public String name { get; set; }
        public int Group {  get; set; }
        public String Part {  get; set; }
        public float Price { get; set; }
        public float Count { get; set; }
        public float Summ
        {
            get { return Count * Price; }
        }
    }
}
