using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory {
	private List<Item> container; //Array of Items

	/**
	 * Add given item to the inventory
	**/
	public void addItem(Item item){
		
	}

	/**
	 * Remove the given item from the inventory
	**/
	public void removeItem(Item item) {
	
	}

	/**
	 * Remove the amount of given item from the inventory
	**/
	public void removeItem(Item item, int amount) {
		
	}

	public int itemCount() {
		return container.Count;
	}

	/**
	 * Count how many of given ID
	**/
	public int howMany (int id) {
		var count = 0;
		for (var i = 0; i < this.container.Count; i++) {
			if (this.container[i].getId() == id) {
				count++;
			}
		}
		return count;
	}

	/**
	 * Count how many of given Item
	**/
	public int howMany (Item item) {
		var id = item.getId ();
		var count = 0;
		for (var i = 0; i < this.container.Count; i++) {
			if (this.container[i].getId() == id) {
				count++;
			}
		}
		return count;
	}

	public Item getItemAtIndex(int index){
		return this.container[index];
	}

	/**
	 * add multiple items to the inventory at once
	**/
	public void fill(List<Item> items) {
		for (var i = 0; i < items.Count;i++) {
			this.container.Add (items[i]);
		}
	}

	/**
	 * Checks if ALL of the given items are in the inventory
	**/
	public bool hasItems(List<Item> items) {
		bool result = false;
		for (var i = 0; i < items.Count; i++){
			result = false;
			for (var ind = 0; ind < this.container.Count; ind++){
				if (this.container [ind] == items [i]) {
					result = true;
					break;
				}
			}
			if (!result) {
				return result;
			}
		}
		return result;
	}

	/**
	 * Returns array of items
	**/
	public List<Item> returnItems(){
		List<Item> r = this.container;
		return r;
	}
		
	override public string ToString(){
		var r = "";
		if (this.container.Count == 0) {
			r = "There are no items in your inventory.";
		} else {
			for (var i = 0; i < this.container.Count; i++){
				r += this.container [i].ToString () + "\n";
			}
		}
		return r;
	}
}
