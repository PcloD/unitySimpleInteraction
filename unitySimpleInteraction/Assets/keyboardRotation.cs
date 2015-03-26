using UnityEngine;
using System.Collections;

public class keyboardRotation : MonoBehaviour {
	#region pubic data
	public Vector3 rotationSteps = new Vector3(5, 5, 5);
	#endregion
	#region Unity callbacks
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.W) == true || Input.GetKeyUp(KeyCode.UpArrow) == true) {
			transform.Rotate(new Vector3(rotationSteps.x, 0, 0));
		} else if (Input.GetKeyUp (KeyCode.S) == true || Input.GetKeyUp(KeyCode.DownArrow) == true) {
			transform.Rotate(new Vector3(-rotationSteps.x, 0, 0));
		} else if (Input.GetKeyUp (KeyCode.A) == true || Input.GetKeyUp(KeyCode.LeftArrow) == true) {
			transform.Rotate(new Vector3(0, rotationSteps.y, 0));
		} else if (Input.GetKeyUp (KeyCode.D) == true || Input.GetKeyUp(KeyCode.RightArrow) == true) {
			transform.Rotate(new Vector3(0, -rotationSteps.y, 0));
	}
}
	#endregion
}
