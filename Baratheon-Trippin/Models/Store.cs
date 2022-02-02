using System;
using System.Collections.Generic;

public class Store
{
	public Store(int storeNum, int gasYearly, int gasQtr, int retailYearly, int retailQtr)
	{
		_storeNum = storeNum;
		_gasYearly = gasYearly;
		_gasQtr = gasQtr;
		_retailYearly = retailYearly;
		_retailQtr = retailQtr;

	}

	private int _storeNum;
	private int _gasYearly;
	private int _gasQtr;
	private int _retailYearly;
	private int _retailQtr;

	private Dictionary<int, List<string>> Employees;

	public List<Store> Stores { get; set; } = new List<Store>();

    public void CreateNewStore()
    {
		var question1 = "Enter New Store Number:";
		Console.WriteLine(question1);
		var storeNum = Console.ReadLine();

		var newStore = new Store(storeNum);
		return newStore;

    }
}
