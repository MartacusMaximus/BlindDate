using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expand : MonoBehaviour {

    bool Expanding = false;
    float timer = 0.2f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            if (timer > 0)
            {
                transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
                timer = timer - Time.deltaTime;
            }
        }
        else
        {
            Expanding = false;
            timer = 0.2f;
        }
		
	}
}
