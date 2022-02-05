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

            var revsuccess = int.TryParse(revyearly, out var revint);
            var revquarterly = revint / 4;
            var gassuccess = int.TryParse(gasyearly, out var gasint);
            var gasquarterly = gasint / 4;

            var output = $@"Sales Report
____________________________
Store: {storenumber}
Gas Yearly: {gasyearly}
Gas Quarterly: {gasquarterly}
Revenue Yearly: {revyearly}
Revenue Quarterly: {revquarterly};
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
