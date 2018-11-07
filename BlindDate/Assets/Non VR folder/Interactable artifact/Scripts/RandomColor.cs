using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour {

	Color myColour = new Color(0f,0f,0f);

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0,1f+1),Random.Range(0,1f+1),Random.Range(0,1f+1));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
