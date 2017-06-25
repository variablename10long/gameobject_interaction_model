using UnityEngine;
using System.Collections;
using System;

public class ObservableObject : MonoBehaviour {

	public bool SomeFlag { get; private set;}
	public Action SomeEvent { get; set; }

	void Update () {

		// When the space key is pushed state is updated.
		// This could be anything: when life reaches 0. when
		// a path is completed. when an object is added to the scene. etc.
		if(Input.GetKeyDown(KeyCode.Space)) {

			// One approach. Set a flag. Other objects interestd in this
			// objects state can just check the value of this flag.
			SomeFlag = true;

			if(SomeEvent != null) {
				// Another approach. Envoke a generic callback.
				// Multiple callbacks can be triggered at once by
				// Simply having more objects observe this one.
				SomeEvent();
			}
		}
	}
}
