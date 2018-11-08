using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {

    public GameObject linkedPortal;
    public Transform portalPosition;

    public void Collide(Collision collision)
    {
        collision.collider.transform.position = linkedPortal.GetComponent<Portal>().portalPosition.position;
        collision.collider.transform.rotation = portalPosition.rotation;
    }
}
