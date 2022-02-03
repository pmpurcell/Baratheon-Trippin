using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baratheon_Trippin.Models
{
    internal class District
    {

        public string DistrictName { get; set; }
        private string DistrictManager { get; set; }


        public Dictionary<string, List<int>> DistrictDetails { get; set; }


        public void addNewDistrict(string name, List<int> )
        {
            if (DistrictDetails == null)
            {
                DistrictDetails = new Dictionary<string, List<int>>();
            }
            DistrictDetails.Add(name, null);
        }

       // Method to intake info from user once Add District is selected
       public void DistrictDetailsPrint()
        {
            Console.WriteLine("Please input new districts name:");
            DistrictName = Console.ReadLine();
            //addNewDistrict(DistrictName);
        }

    }
}
