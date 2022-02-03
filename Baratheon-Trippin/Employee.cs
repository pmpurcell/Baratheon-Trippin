using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//something above the title

namespace Baratheon_Trippin
{
	public enum Title
	{
		DistMgr = 0,
		StoreMgr = 1,
		AstStrMgr = 2,
		Associate = 3,
	}
	internal class Employee
	{
		public Employee(Title title, string name, string sales)
		{
			Title = title;
			Name = name;
			Sales = sales;
		}

		public string Name { get; set; }
		public string Sales { get; set; }
		public Title @Title { get; set; }
	}
}