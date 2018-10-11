using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideSwipe : MonoBehaviour {

	public Card cardProp;
	

	void OnEnterTrigger2D(Collider2D c){
		if (c.tag == "LeftSwipe"){
			
			Destroy(gameObject);
		}else if (c.tag == "RightSwipe"){

			Destroy(gameObject);
		}
	}
}
