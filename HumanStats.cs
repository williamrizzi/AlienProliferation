using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanStats : MonoBehaviour {

	public int life;
	public GameObject alienToSpawn;
	public GameObject citySpot;

	// Use this for initialization
	void Start () {
		citySpot = GameObject.Find ("CitySpot");
	}
	
	// Update is called once per frame
	void Update () {
		if (life <= 0) {
			gameObject.GetComponentInChildren<WalkIA> ().stateHumano = WalkIA.humanState.death;
			citySpot.GetComponent<CityStats> ().population -= 1;
			citySpot.GetComponent<CityStats> ().aliensInTown += 1;
			Instantiate (alienToSpawn,transform.position, transform.rotation);		
			Destroy (gameObject);
		}	
	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("collidiu");
		if (other.transform.tag == "OndaCosmica") {
			life -= 100;
		}

	}
}
