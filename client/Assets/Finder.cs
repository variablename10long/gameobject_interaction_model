using UnityEngine;
using System.Collections;

// Example class focused on finding a specific object. I would not
// do this in real life, and it only exists for the purposes of this
// example.
public class Finder : MonoBehaviour {

	public GameObject FoundObject { get; set; }

	void Start () {
		FoundObject = GameObject.Find("ObjectToObserve");
	}
}
