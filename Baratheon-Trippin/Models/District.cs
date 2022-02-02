using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baratheon_Trippin.Models
{
    internal class District
    {
        public District(string districtName, string managerName)
        {
            _districtName = districtName;
            _districtManager = districtName;
        }

        private string _districtName;
        private string _districtManager;


        public List<int> DistrictDetails { get; set; }


        public void addNewDistrict(int store)
        {
            if (DistrictDetails == null)
            {
                DistrictDetails = new List<int>();
            }
            DistrictDetails.Add(store);
        }

    }
}
