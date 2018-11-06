using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paint : MonoBehaviour {

    public GameObject stroke;
    public int refreshRate;
    private int frames = 0;

    // Use this for initialization
    void Start ()
    {
       

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("LTrigger")>0)
        {
			if (frames == refreshRate)               
            {
                frames = 0;
                Vector3 pos = this.transform.position;
                Quaternion rot = this.transform.rotation;
                Instantiate(stroke, pos, rot);
				
            }
			frames++;
        }
	}
}
