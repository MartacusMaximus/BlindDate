using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace Valve.VR.InteractionSystem.Sample
{
	public class Paint : MonoBehaviour {

	    public GameObject stroke;
	    public int refreshRate;
		public SteamVR_Action_Boolean drawAction;

	    private int frames = 0;
		private int colour = 0;

	    // Use this for initialization
	    void Start ()
	    {
	       

		}
		
		// Update is called once per frame
		void Update () 
		{
			if (drawAction.GetState(SteamVR_Input_Sources.Any))
     		{
			//	if (drawAction.GetState(SteamVR_Input_Sources.Any))     
	//			if (frames == refreshRate)
	 //           {
	                frames = 0;
	                Vector3 pos = this.transform.position;
	                Quaternion rot = this.transform.rotation;
	                Instantiate(stroke, pos, rot);	
	  //          }
	//			frames++;
			}

		}
	}
}
