using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CityStats : MonoBehaviour {

	public int population;
	public int aliensInTown;
	public int aliensTotal;

	public GameObject popText;
	public GameObject alienText;
	public GameObject buyUpSpawnerText;
	public GameObject buyUpCdVelocity;
	public GameObject buyUpDamage;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		Exibir ();
		if (aliensInTown > aliensTotal) {
			aliensTotal = aliensInTown;		
		}	
	}

	public void Exibir(){
		popText.GetComponent<Text> ().text = "" + population.ToString ();
		alienText.GetComponent<Text> ().text = aliensTotal.ToString ();
	}

	public void BuySpawner(){
	
	
	}

	public void BuyVelocity(){
	
	}

	public void BuyDamage(){
	
	}

}
