<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
	public class ClickMove : MonoBehaviour {



		float distance = 1.25f;
		public AudioClip TestSound;

		public SteamVR_Action_Boolean Pickup;

		void Update () 
		{
			if (Pickup.GetState(SteamVR_Input_Sources.Any))
			{

				Vector3 pos = GameObject.Find("Controller (right)").transform.position;
				Quaternion rot = GameObject.Find("Controller (right)").transform.rotation;
				transform.position = pos;
				transform.rotation = rot;
			}
		}


		void OnMouseDrag () {
			Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
			Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
			transform.position = objPosition;

			}

		}
	}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMove : MonoBehaviour {

	float distance = 1.25f;

	public AudioClip Artifact;
	public float Volume;
	AudioSource audioSource;
	public bool SoundPlayed = false;

	void OnMouseDrag () {
		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
		transform.position = objPosition;


	}

	void Start(){
		audioSource = GetComponent<AudioSource> ();
	}

	void OnMouseDown ()
	{
		if (!SoundPlayed) {
			audioSource.PlayOneShot (Artifact, Volume);
			SoundPlayed = true;
		}
	}

	void OnMouseUp ()
	{
		if (SoundPlayed == true) {
			audioSource.Stop();
			SoundPlayed = false;
		}
	}

}
>>>>>>> master
