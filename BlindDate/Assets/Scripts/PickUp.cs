using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace Valve.VR.InteractionSystem.Sample
{
	public class PickUp : MonoBehaviour
	{

		public SteamVR_Action_Boolean grabAction;
		public SteamVR_Action_Pose velo;
		private SphereCollider colController;


		// Use this for initialization
		void Start ()
		{
			colController = gameObject.GetComponent<SphereCollider> ();
		}
		
		// Update is called once per frame
		void Update ()
		{
		}


		void OnTriggerStay (Collider col)
		{
			Debug.Log(velo.GetVelocity (SteamVR_Input_Sources.RightHand));
			GameObject grabObject = col.gameObject;
			print (colController.GetComponent<Rigidbody>().velocity);
			if (col.gameObject.CompareTag ("Pickup") && grabAction.GetState (SteamVR_Input_Sources.Any)) {
				
				grabObject.transform.SetParent (gameObject.transform);
				grabObject.GetComponent<Rigidbody> ().isKinematic = true;
			} else if (col.gameObject.CompareTag ("Pickup") && grabAction.GetState (SteamVR_Input_Sources.Any)==false)  {
				grabObject.transform.SetParent (GameObject.Find("Interactable").transform);
				grabObject.GetComponent<Rigidbody> ().isKinematic = false;
				grabObject.GetComponent<Rigidbody> ().velocity = velo.GetVelocity (SteamVR_Input_Sources.RightHand);
			}
		}

		
	}
}

