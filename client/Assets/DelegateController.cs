using UnityEngine;
using System.Collections;

// A simple example of an object that observes another object by
// using a delegate (callback).
public class DelegateController : MonoBehaviour {

	IEnumerator Start () {
		// Just a little hack to make sure the found object is set.
		// Unity is going to have race conditions when all objects are added
		// to the scene on start up, you don't know order scripts will execute in
		yield return new WaitForEndOfFrame();

		GameObject foundObj = gameObject.GetComponent<Finder>().FoundObject;
		if(foundObj) {
			foundObj.GetComponent<ObservableObject>().SomeEvent += Handler;
		}
	}

	void Handler() {
		// This handler is cheap. Its only called when the event is raised and you can
		// pass optional parameters in to more complex handlers.
		Debug.Log("Some event occured, do something here to update the game state");
	}
}
