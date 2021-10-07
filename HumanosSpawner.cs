using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanosSpawner : MonoBehaviour {

	public GameObject[] spawnPoints;

    public GameObject pessoaPrefab;

	public GameObject citySpot;

    public int pessoas;

    public float contador;
    public int random;

	public int speedSpawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        contador += Time.deltaTime;
		if (contador >= speedSpawn && pessoas < 200 && citySpot.GetComponent<CityStats>().population > 0) {
			contador -= speedSpawn;
            pessoas += 1;
            random = Random.Range(0, 8);
            Instantiate(pessoaPrefab, spawnPoints[random].transform.position, spawnPoints[random].transform.rotation);
        }

        

	}
}
