using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerAlienDefault : MonoBehaviour {

    public GameObject spawnPoint;

    public GameObject alienDefault;

    public float temporizador;

	public GameObject citySpot;

	public int maxTemporizador;

	public GameObject buttonManager;

	// Use this for initialization
	void Start () {

        temporizador = 0;

	}
	
	// Update is called once per frame
	void Update () {

        temporizador += 1 * Time.deltaTime;
		if(temporizador >= maxTemporizador)
        {
            Spawn();
			temporizador -= maxTemporizador;
        }


	}

    public void Spawn()
    {

        Instantiate(alienDefault, spawnPoint.transform.position, spawnPoint.transform.rotation);
		citySpot.GetComponent<CityStats> ().aliensInTown += 1;


    }

	public void UpgradeSpawner(){
		if (buttonManager.GetComponent<ButtonManager> ().spawnerLevel == 1 && citySpot.GetComponent<CityStats> ().aliensInTown >= 10) {
			buttonManager.GetComponent<ButtonManager> ().spawnerLevel += 1;
		} 
		else if (buttonManager.GetComponent<ButtonManager> ().spawnerLevel == 2 && citySpot.GetComponent<CityStats> ().aliensInTown >= 30) {
			buttonManager.GetComponent<ButtonManager> ().spawnerLevel += 1;
		} 
		else if (buttonManager.GetComponent<ButtonManager> ().spawnerLevel == 3 && citySpot.GetComponent<CityStats> ().aliensInTown >= 50) {
			buttonManager.GetComponent<ButtonManager> ().spawnerLevel += 1;
		} 
		else if (buttonManager.GetComponent<ButtonManager> ().spawnerLevel == 4 && citySpot.GetComponent<CityStats> ().aliensInTown >= 70) {
			buttonManager.GetComponent<ButtonManager> ().spawnerLevel += 1;
		} 
		else if (buttonManager.GetComponent<ButtonManager> ().spawnerLevel == 5 && citySpot.GetComponent<CityStats> ().aliensInTown >= 90) {
			buttonManager.GetComponent<ButtonManager> ().spawnerLevel += 1;
		} 
		else if (buttonManager.GetComponent<ButtonManager> ().spawnerLevel == 6 && citySpot.GetComponent<CityStats> ().aliensInTown >= 100) {
			buttonManager.GetComponent<ButtonManager> ().spawnerLevel += 1;
		} 	

	}
}
