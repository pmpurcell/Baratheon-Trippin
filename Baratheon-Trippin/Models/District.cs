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
         public Dictionary<string, int> DistrictDetails { get; set; }

        // Method to add District to List
        public void AddNewDistrict(string name)
        {
            if (Districts == null)
            {
                Districts = new List<string>();
            }
            Districts.Add(name);
        }

       // Method to intake info from user once Add District is selected
       public void DistrictMenuPrint()
        {
            Console.WriteLine("Please input new districts name:");
            DistrictName = Console.ReadLine();
            AddNewDistrict(DistrictName);
            Console.WriteLine($"You have added a new District: {DistrictName}");
        }

        // Method for loop to print all districts
        public void PrintCurrentDistricts()
        {
            for (int i = 0; i < Districts.Count; i++)
            {
                Console.WriteLine($"{i}) {Districts[i]}");
            }
        }

        // Method to add store to district dictionary
        public void AddStoreToDistrict(string name, int store)
        {
            if (DistrictDetails == null)
            {
                DistrictDetails = new Dictionary<string, int>();
            }
            DistrictDetails.Add(DistrictName, store);
        }
    }
}
