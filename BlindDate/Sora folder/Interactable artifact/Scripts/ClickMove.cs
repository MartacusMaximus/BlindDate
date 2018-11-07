using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour {

	float distance = 1.25f;
	public AudioClip TestSound;
	//bool isPlaying = false;

	void OnMouseDrag () {
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
		transform.position = objPosition;

			//if (isPlaying != true) {
			//	AudioSource.PlayClipAtPoint (TestSound, transform.position);
			//	isPlaying = true;
		//	} 
		//	else
		//	{
		//		isPlaying = false;
		//	}

	}
	public class OnMouseOverExample : MonoBehaviour
	{
		void OnMouseOver()
		{
			//If your mouse hovers over the GameObject with the script attached, output this message
			Debug.Log("Mouse is over GameObject.");
		}

		void OnMouseExit()
		{
			//The mouse is no longer hovering over the GameObject so output this message each frame
			Debug.Log("Mouse is no longer on GameObject.");

		}
	}
}