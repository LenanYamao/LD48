using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct ItemAmount
{
	public Item item;
	[Range(1, 999)]
	public int amount;
}
public class InventoryTracker
{
    public static List<ItemAmount> items = new List<ItemAmount>();

	public static List<ItemAmount> Items
	{
		get
		{
			return items;
		}
		set
		{
			items = value;
		}
	}
}
