using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace Valve.VR.InteractionSystem.Sample
{
	public class Expand : MonoBehaviour {

	    public float timer;
	    bool Expanding = false;
		public SteamVR_Action_Boolean balloonAction;
	    float timerrestart;

	    // Use this for initialization
	    void Start () {
	        timerrestart = timer;
		}
		
		// Update is called once per frame
		void Update () {
			if (balloonAction.GetState(SteamVR_Input_Sources.Any))
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
}