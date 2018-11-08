using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billboard : MonoBehaviour {

	private GameObject target;
	private int timer;

	// Use this for initialization
	void Start () {
		target = GameObject.Find("RightEye (eye)");
		timer = 0;
	}

	// Update is called once per frame
	void Update () {
		
	//	Quaternion angle = target.transform.rotation;
	//	angle.z = 0;
		transform.rotation = target.transform.rotation;
		timer++;
		if (timer == 10800) //two minutes destroy timer
		{
			Destroy (gameObject);
		}
			
	}
}
