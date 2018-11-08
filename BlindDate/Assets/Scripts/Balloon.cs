using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace Valve.VR.InteractionSystem.Sample
{
	public class Balloon : MonoBehaviour
	{
	    GameObject ballon;
	    public GameObject ballonPrefab;
		public SteamVR_Action_Boolean balloonAction;
	//    public Vector3 location;
	    bool Create = false;
	    // Use this for initialization
	    void Start()
	    {

	    }

	    // Update is called once per frame
	    void Update()
	    {
			if (balloonAction.GetState(SteamVR_Input_Sources.Any) && Create == false)
	        {
	            if (ballon != null)
	            {
	                ballon.GetComponent<Expand>().enabled = false;
	            }
				Vector3 location = this.transform.position;
	            ballon = Instantiate(ballonPrefab, location, Quaternion.identity);
	            Create = true;
	        }
			if (balloonAction.GetState(SteamVR_Input_Sources.Any)==false)
	        {
	            Create = false;
	        }
	    }
	}
}