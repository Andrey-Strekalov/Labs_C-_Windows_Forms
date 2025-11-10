using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Utils
    {
        private static Dictionary<int, string> dict;
        static Utils()
        {
            if (dict == null)
            {
                dict = new Dictionary<int, string>(5);
                dict.Add(0, "Продукты");
                dict.Add(1, "Химия");
            }
        }
        public static string GetGroupByNumber(int number)
        {
            if (dict.ContainsKey(number))
            {
                return dict[number];

            }
            else
            {
                return "???";
            }
        }
    }
}
