using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.InteractionSystem.Sample
{
	public class ClickMoveVR : MonoBehaviour {

		float distance = 1.25f;

		public AudioClip Artifact;
		public float Volume;
		AudioSource audioSource;
		public bool SoundPlayed = false;

		public SteamVR_Action_Boolean PickupAction;

		void Start(){
			audioSource = GetComponent<AudioSource> ();
		}

		void Update()
		{
			if (PickupAction.GetState(SteamVR_Input_Sources.Any))
			{
				Vector3 Pos = this.transform.position;
				Quaternion rot = this.transform.rotation;
			}
		}


		void OnMouseDrag () {
			Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
			Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
			transform.position = objPosition;


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
}