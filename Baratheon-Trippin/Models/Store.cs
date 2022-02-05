using System;
using System.Collections.Generic;

public class Store
{
	public Store(int storeNum, int gasYearly, int gasQtr, int retailYearly, int retailQtr)
	{
		StoreNum = storeNum;
		_gasYearly = gasYearly;
		_gasQtr = gasQtr;
		_retailYearly = retailYearly;
		_retailQtr = retailQtr;

	}

	public int StoreNum;
	private int _gasYearly;
	private int _gasQtr;
	private int _retailYearly;
	private int _retailQtr;

	private Dictionary<int, List<string>> Employees;

	public List<Store> Stores { get; set; } = new List<Store>();

	public void PrintCurrentDistricts(List<string> Districts)
	{
		if (Districts != null)
		{
			for (int i = 0; i < Districts.Count; i++)
			{
				Console.WriteLine($"{i}) {Districts[i]}");
			}
		}
		else
		{
			Console.WriteLine("Please add a District first.");
		}

	}
}

