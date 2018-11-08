using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingBalloon : MonoBehaviour {

    public float floatStrength;
    float die = 0;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().AddForce(Vector3.up * (floatStrength/1000000));
        die++;
        if (die >= 1000)
        {
            Destroy(gameObject);
        }
    }
}
