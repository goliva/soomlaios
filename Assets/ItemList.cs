using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemList{
	public List<Item> items = new List<Item>();
	public ItemList (){
		items.Add (new Item("Carta uno!"));
		items.Add (new Item("Carta dos"));
		items.Add (new Item("Carta tres!"));
		Debug.Log ("hola");
	}
	
}