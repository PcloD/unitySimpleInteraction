using UnityEngine;
using System.Collections;

public class mouseDrag : MonoBehaviour {

	#region Unity callbacks
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		_mouseDownScreenPosition = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		
		_objectOffset = gameObject.transform.position - 
			Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _mouseDownScreenPosition.z));
	}

	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, _mouseDownScreenPosition.z);

		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + _objectOffset;
		transform.position = curPosition;	
	}
	#endregion

	#region private members
	private Vector3 _mouseDownScreenPosition;
	private Vector3 _objectOffset;
	#endregion
}
