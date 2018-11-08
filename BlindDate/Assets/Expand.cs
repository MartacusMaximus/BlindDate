using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expand : MonoBehaviour {

    public float timer;
    bool Expanding = false;
    float timerrestart;

    // Use this for initialization
    void Start () {
        timerrestart = timer;
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
            timer = timerrestart;
        }
    }
}
