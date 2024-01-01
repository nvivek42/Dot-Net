﻿using System;
using ShoppingCart;
public class Cart
{
	private List<Item> items = new List<Item>();
	public List	 <Item> Items
	{
		get { return items; }
	}
	public void AddToCart(Item item)
	{
		items.Add(item);
	}
	public void RemoveFromCart(Item item)
	{
		items.Remove(item);
	}
}
