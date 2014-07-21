using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Menu : MonoBehaviour {
	
	ItemList item = new ItemList();
	static bool select = false;
	static int item_id = 0;
	List<Item> items;

	void Start(){

	}
	
	
	void OnGUI(){
		if (select) {
			GUI.Window (item_id, new Rect (Screen.width / 2 - 200, Screen.height / 2 - 200, 400, 400), ItemView, "Item View");
		} else {
			GUI.Window (0, new Rect (Screen.width / 2 - 200, Screen.height / 2 - 200, 400, 400), ListItems, "Items Menu");
		}
		
	}
	
	void ListItems(int id){
		items = item.items;
		for (int i=0; i<items.Count; i++) {
			GUI.Label (new Rect (10, 30*(i+1), 3000, 20), "Carta "+items[i].title);
			if (GUI.Button (new Rect (310, 30*(i+1), 80, 20), "Buy")) {
				select = true;
				item_id = i;
			}
		}
		
	}
	
	void ItemView(int id){
		GUI.Label (new Rect (10, 30, 3000, 20), "Comprando la carta..."+items[id].title);
		if (GUI.Button (new Rect (310, 30, 80, 20), "Confirmar")) {
			select = false;
		}
		
		
	}
	
	
}