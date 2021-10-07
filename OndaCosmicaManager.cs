using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OndaCosmicaManager : MonoBehaviour {

	public bool active;

	public GameObject citySpot;

	public float contador;

	public bool direction;

	public float speed;

	public GameObject button;

	public GameObject spot1;
	public GameObject spot2;

	// Use this for initialization
	void Start () {
		contador = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (active) {
			contador += Time.deltaTime;

				if (direction == true) {
					float step = speed * Time.deltaTime;
					if (transform.position.x < spot1.transform.position.x) {
						transform.position = Vector3.MoveTowards(transform.position, spot1.transform.position, step);
					} else {
						direction = false;
					}
				}
				if (direction == false) {
					float step = speed * Time.deltaTime;
					if (transform.position.x > spot2.transform.position.x) {
						transform.position = Vector3.MoveTowards(transform.position, spot2.transform.position, step);
					}else {
						direction = true;
					}
				}

		}
	}


	public void ActiveCosmicWave(){
		if (citySpot.GetComponent<CityStats> ().aliensInTown >= 120) {
			active = true;
			button.SetActive (false);
		}
	}
}
