using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCollision : MonoBehaviour {

    Portal portalScript;

	// Use this for initialization
	void Start () {
        portalScript = transform.parent.GetComponent<Portal>();	
	}

    private void OnCollisionEnter(Collision collision)
    {
        portalScript.Collide(collision);
    }
}
