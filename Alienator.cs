using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alienator : MonoBehaviour {

    public int random;
    public string direcao;
    public string nextDirecao;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}




    void OnTriggerEnter(Collider collider)
    {

        if (collider.CompareTag("Trigger4Lados"))
        {
            random = Random.Range(1, 3);      
            switch (random)
            {
                

            }
        }


    }




}
