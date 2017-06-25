using UnityEngine;
using System.Collections;

// A simple example of an object that observes another object by
// constantly polling the state of the observed object in the update loop
public class UpdateController : MonoBehaviour {

	private ObservableObject objToObserve = null;

	IEnumerator Start () {
		// Just a little hack to make sure the found object is set.
		// Unity is going to have race conditions when all objects are added
		// to the scene on start up, you don't know order scripts will execute in
		yield return new WaitForEndOfFrame();

		GameObject foundObj = gameObject.GetComponent<Finder>().FoundObject;
		if(foundObj) {
			objToObserve = foundObj.GetComponent<ObservableObject>();
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		// The down side of this pattern is this is going to be called every frame.
		// This is expensive and you have manually deal with no repeating the logic over 
		// and over. As you'll see, once the flag is set this message is printed over and over.
		if(objToObserve != null && objToObserve.SomeFlag == true) {
			Debug.Log("Some flag is set, update the game state as a result");
		}
	}
}
