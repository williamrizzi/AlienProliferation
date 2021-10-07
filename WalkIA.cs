using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkIA : MonoBehaviour {
	public enum humanState{
		walk,generating,death,followHuman
	}
	public humanState stateHumano;
	public Vector3 destiny;
	public GameObject[] points;
	public int randomPoint;
	public float temporizador;

	public int forceX;
	public int forceZ;

	public bool livreToWalk = true; 

	void Start () {
		
		randomPoint = Random.Range (0, 9);
	}	
	void Update () {
		
		if (temporizador > 0) {
            if(transform.tag == "Pessoa")
            {
                temporizador -= Time.deltaTime;
                GetComponent<Rigidbody>().isKinematic = false;

                GetComponent<Rigidbody>().AddRelativeForce(forceX * Time.deltaTime, 0, forceZ * Time.deltaTime);
                if (temporizador <= 0)
                {
                    GetComponent<Rigidbody>().isKinematic = true;
                }
            }			
		}

		if (stateHumano == humanState.generating) {
			randomPoint = Random.Range (0, 9);
			stateHumano = humanState.walk;
		}
		if (livreToWalk) {
			if (stateHumano == humanState.walk) {
				destiny.x = points [randomPoint].transform.position.x;
				destiny.z = points [randomPoint].transform.position.z;
				GetComponent<NavMeshAgent> ().SetDestination (destiny);
			}
		}
		if (GetComponentInChildren<NavMeshAgent>().remainingDistance <= GetComponentInChildren<NavMeshAgent>().stoppingDistance)
		{
			if (stateHumano == humanState.walk) {
				stateHumano = humanState.generating;
			}
		}
		if (stateHumano == humanState.followHuman) {
			gameObject.GetComponent<AlienAttack> ().FollowHuman ();
		}
	}
}