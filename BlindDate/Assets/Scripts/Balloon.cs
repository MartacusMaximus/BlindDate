using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    GameObject ballon;
    public GameObject ballonPrefab;
    public Vector3 location;
    bool Create = false;
    private float time;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && Create == false)
        {
            if (ballon != null)
            {
                ballon.GetComponent<Expand>().enabled = false;
            }
            ballon = Instantiate(ballonPrefab, location, Quaternion.identity);
            Create = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            time++;
            Create = false;
        }
    }
}
