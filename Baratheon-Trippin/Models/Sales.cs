using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baratheon_Trippin
{
    internal class Sales
    {
        public void EnterSales()
        {
            Console.WriteLine("Enter Store Number");
            var storenumber = Console.ReadLine();
            Console.WriteLine("Enter Gas Yearly");
            var gasyearly = Console.ReadLine();
            Console.WriteLine("Enter Revenue Yearly");
            var revyearly = Console.ReadLine();

            var output = $@"Sales Report
____________________________
Store: {storenumber}
Gas Yearly: {gasyearly}
Revenue Yearly: {revyearly}
____________________________";

            Console.WriteLine(output);
        }
        public int sales { get; } = GenerateSales();

        private static int GenerateSales()
        {
            int _min = 1000;
            int _max = 9999;
            Random random = new Random();
            return random.Next(_min, _max);
        }
    }
}
