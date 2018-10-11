using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDisplay : MonoBehaviour {

	public Character character;

	public Text characterName;
	public Text characterDescription;

	// Use this for initialization
	void Start () {
		characterName.text = character.name;
		characterDescription.text = character.description;
	}
	
	
}
