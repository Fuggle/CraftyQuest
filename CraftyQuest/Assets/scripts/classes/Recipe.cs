using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe {
	private string name;
	private int id;
	private ArrayList ingredients;
	private int creates;
	private Rarity rarity;

	public string getName(){
		string r = name;
		return r;
	}

	public ArrayList getIngredients(){
		ArrayList r = ingredients;
		return r;
	}

	override public string ToString(){
		string r = "";
		r += this.name + "["+this.id+"]: "+ this.ingredients;
		return r;
	}

}

public enum Rarity {
	Common,
	Uncommon,
	Rare,
	Epic
}
