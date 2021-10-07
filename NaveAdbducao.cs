using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NaveAdbducao : MonoBehaviour {

    public GameObject spawnPoint;
    public GameObject[] pessoas;
    public int random = -1;
    public bool setado = false;
    public Vector3 destino;

    public GameObject destinoFinal;

    public bool readyToSpawn = false;


    // Use this for initialization
    void Start () {
        pessoas = GameObject.FindGameObjectsWithTag("Pessoa");
        random = Random.Range(0, pessoas.Length);
	}
	
    IEnumerator WaitToNavMesh()
    {
        GetComponent<NavMeshAgent>().enabled = false;
        yield return new WaitForSeconds(1.5f);
        GetComponent<NavMeshAgent>().enabled = true;
        destino.x = destinoFinal.transform.position.x;
        destino.z = destinoFinal.transform.position.z;
        GetComponent<NavMeshAgent>().speed += 20;
        GetComponent<NavMeshAgent>().SetDestination(destino);        

    }

    // Update is called once per frame
    void Update () {

        if(random >= 0)
        {
			
            destino.x = pessoas[random].GetComponentInChildren<Transform>().position.x;
            destino.z = pessoas[random].GetComponentInChildren<Transform>().position.z;
            setado = true;
        }
        
        
        

        if (setado)
        {
			pessoas[random].GetComponentInChildren<WalkIA>().livreToWalk = false;
            GetComponent<NavMeshAgent>().SetDestination(destino);

            if (GetComponentInChildren<NavMeshAgent>().remainingDistance != 0 && GetComponentInChildren<NavMeshAgent>().remainingDistance <= GetComponentInChildren<NavMeshAgent>().stoppingDistance)
            {
                //Debug.Log("teste" + GetComponentInChildren<NavMeshAgent>().remainingDistance.ToString());
                GetComponent<NavMeshAgent>().Stop();
                GetComponentInChildren<MeshRenderer>().enabled = true;
                pessoas[random].GetComponent<PessoasIA>().abduzindo = true;
            }
        }

        




    }


    void OnTriggerExit(Collider collider)
    {
        if (collider.CompareTag("Alien"))
        {
            GetComponentInChildren<MeshRenderer>().enabled = false;
            StartCoroutine("WaitToNavMesh");
        }
    }

    

}
