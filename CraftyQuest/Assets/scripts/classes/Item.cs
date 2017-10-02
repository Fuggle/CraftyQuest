using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {
	private string name;
	private int id;
	private int value;
	private string description;
	private Rarity rarity;

	public int getId(){
		int r = id;
		return r;
	}

	override public string ToString(){
		return id + ":" +name + " ("+rarity+"), val: $"+ value + ", desc: " + description;
	}

}

public class Consumable : Item {
	private Effect effect;

} 

public enum Effect {
	Heal,
	Buff
}