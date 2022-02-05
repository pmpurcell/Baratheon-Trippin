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

        public List<string> Districts { get; set; }  = new List<string>();
         public Dictionary<string, List<Store>> DistrictDetails { get; set; } = new Dictionary<string, List<Store>>();

        // Method to add District to List
        public void AddNewDistrict(string name)
        {
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
            //if (Districts != null)
            //{
                for (int i = 0; i < Districts.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {Districts[i]}");
                }

        }

        // Method to add store to district dictionary
        public void AddStoreToDistrict(string name, Store store)
        {
            if (DistrictDetails.ContainsKey(name))
            {
                DistrictDetails[name].Add(store);
            }
            else
            {
                DistrictDetails.Add(name, new List<Store> { store });
            }
        }

        public void PrintDistrictDetails()
        {
            foreach (string name in DistrictDetails.Keys)
            {
                Console.WriteLine($"You have added the store to District: {name}.");
            }
        }
    }
}
