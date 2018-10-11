using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class Card : ScriptableObject {

	public int cardIndex;

	public new string name;
	public string description;

	public Sprite artwork;

	public int social;
	public int grades;
	public int selfcare;

	public void calculate(){
		
	}
}
