using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace Valve.VR.InteractionSystem.Sample
{
	public class BalSpawner : MonoBehaviour {

	    public GameObject balPrefab;
	    public GameObject spawnpoint;
	    public int maxAantalBallen = 10;
	    public float balLeeftijd = 5f;
		public SteamVR_Action_Boolean spawnAction;

	    List<GameObject> ballenLijst;


		// Use this for initialization
		void Start () {
	        ballenLijst = new List<GameObject>();
		}
		
		// Update is called once per frame
		void Update () {

			if (spawnAction.GetState(SteamVR_Input_Sources.Any))
	        {
	            GameObject gespawndeBal = Instantiate(balPrefab, spawnpoint.transform.position, Quaternion.identity);
	            ballenLijst.Add(gespawndeBal);

	            Destroy(gespawndeBal, balLeeftijd);

	            if (ballenLijst.Count > maxAantalBallen)
	            {
	                GameObject eersteBal = ballenLijst[0];
	                ballenLijst.Remove(eersteBal);
	                Destroy(eersteBal);
	            }
	        }
	        
		}
	}
}