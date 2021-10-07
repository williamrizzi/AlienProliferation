using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawerCentral : MonoBehaviour {

	public float timer;
	public int cdSpawn;
	public int rand;
	public GameObject alienRef;
	public GameObject[] spawns;



	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= cdSpawn) {
			timer = 0;	
			Spawn ();
		}

	}

	public void Spawn(){
		rand = Random.Range (0, 4);
		Instantiate (alienRef, spawns [rand].transform.position, spawns [rand].transform.rotation);
	}

}
