using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeChange : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && (gameObject.transform.localScale.x > 0) )
        {
            gameObject.transform.localScale += new Vector3(-0.01f, -0.01f, 0);
        }
    }
}
