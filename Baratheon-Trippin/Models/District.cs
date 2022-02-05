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

        public List<string> Districts { get; set; }
        // public Dictionary<string, List<int>> DistrictDetails { get; set; }


        public void AddNewDistrict(string name)
        {
            //var storName = name;
            //var title = (Title)Enum.Parse(typeof(Title),
            if (Districts == null)
            {
                Districts = new List<string>();
            }
            Districts.Add(name);
        }

       // Method to intake info from user once Add District is selected
       public void DistrictDetailsPrint()
        {
            Console.WriteLine("Please input new districts name:");
            DistrictName = Console.ReadLine();
            AddNewDistrict(DistrictName);
            Console.WriteLine(Districts.Count.ToString());
        }

    }
}
