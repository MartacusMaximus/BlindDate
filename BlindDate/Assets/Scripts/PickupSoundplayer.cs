using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    private GameObject pickedupObject;
    private Rigidbody pickedupRigidbody;
    public AudioClip collectSound;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (pickedupObject == null)
            {
                int layerMask = 1 << 10;
                RaycastHit hitInfo;
                if (Physics.Raycast(transform.position + transform.forward, transform.forward, out hitInfo, 3.0f, layerMask))
                {
                    pickedupObject = hitInfo.collider.gameObject;

                    pickedupObject.transform.parent = transform;
                    AudioSource.PlayClipAtPoint(collectSound, transform.position);
                    pickedupRigidbody = (Rigidbody)pickedupObject.GetComponent(typeof(Rigidbody));
                    pickedupRigidbody.isKinematic = true;

                }
            }
            else
            {
                pickedupRigidbody.isKinematic = false;
                pickedupObject.transform.parent = null;
                pickedupObject = null;

            }
        }
    }
}
