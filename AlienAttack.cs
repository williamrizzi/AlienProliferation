using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AlienAttack : MonoBehaviour {

	public GameObject target;
	public Vector3 destiny;

	public float dano;
	public float velocidade;

	public bool xy;
	public bool xx;
	public bool yy;
	public bool yx;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {		
	
	}



	void OnTriggerEnter(Collider other){		
		if (other.transform.tag == "Pessoa") {
			if (gameObject.GetComponent<WalkIA> ().stateHumano != WalkIA.humanState.followHuman) {
				gameObject.GetComponent<WalkIA> ().stateHumano = WalkIA.humanState.followHuman;
				target = other.gameObject;
			}
		}	
	}

	public void FollowHuman(){	
		if (target) {	
			PositionAtTarget ();
			destiny.x = target.transform.position.x;
			destiny.z = target.transform.position.z;
			GetComponent<NavMeshAgent> ().SetDestination (destiny);
		}

		if (gameObject.GetComponent<WalkIA> ().stateHumano == WalkIA.humanState.followHuman && target == null) {
			gameObject.GetComponent<WalkIA> ().stateHumano = WalkIA.humanState.generating;
		}
		if (GetComponentInChildren<NavMeshAgent> ().remainingDistance <= GetComponentInChildren<NavMeshAgent> ().stoppingDistance) {
			if (target) {
				Damage ();
			}
		}
	}

	public void Damage(){
		if (target.GetComponent<WalkIA> ().temporizador <= 0) {
			target.GetComponent<HumanStats> ().life -= 10;
			target.GetComponent<WalkIA> ().temporizador = 1;
		}

	}

	public void PositionAtTarget(){
		if (gameObject.transform.position.x > target.transform.position.x) {
			target.GetComponent<WalkIA> ().forceX = -1000;
			if (gameObject.transform.position.z > target.transform.position.z) {				
				target.GetComponent<WalkIA> ().forceZ = -1000;
			} else {				
				target.GetComponent<WalkIA> ().forceZ = +1000;
			}
		}
		if (gameObject.transform.position.x < target.transform.position.x) {
			target.GetComponent<WalkIA> ().forceX = 1000;
			if (gameObject.transform.position.z > target.transform.position.z) {				
				target.GetComponent<WalkIA> ().forceZ = -1000;
			} else {				
				target.GetComponent<WalkIA> ().forceZ = 1000;
			}
		}
	
	}



}
