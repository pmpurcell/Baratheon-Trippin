using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baratheon_Trippin
{
    internal class Sales
    {
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
