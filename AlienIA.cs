using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AlienIA : MonoBehaviour {

        
    public int life;

    public GameObject alvo;
    public bool liberadoParaAtaque;
    public Vector3 destino;

    public float tempoSort;

    public bool primeiroAlvo;

	// Use this for initialization
	void Start () {
        primeiroAlvo = true;
        life = 50;
        liberadoParaAtaque = true;
        tempoSort = 30;
        GetComponentInChildren<NavMeshAgent>().stoppingDistance = 2;
    }
	
	// Update is called once per frame
	void Update () {

        if(transform.position.y >= 1.0f)
        {
            DescerDaNave();
            SetDestino();
        }
        else
        {
            if (primeiroAlvo)
            {
                tempoSort += 30;
                primeiroAlvo = false;
                SetDestino();
                GetComponent<NavMeshAgent>().enabled = true;
            }
            else
            {
                SetDestino();
                GetComponent<NavMeshAgent>().SetDestination(destino);
            }
         
        }
         

    }

    public void SetDestino()
    {        
        if (alvo) {
            destino.x = alvo.transform.position.x;
            destino.z = alvo.transform.position.z;
            GetComponent<NavMeshAgent>().speed = 5.0f;
            if (GetComponentInChildren<NavMeshAgent>().remainingDistance < 2)
            {
                Destroy(alvo);
                liberadoParaAtaque = true;
            }
        }
        else
        {
            GetComponent<NavMeshAgent>().speed = 3.5f;
            tempoSort += Time.deltaTime;
            Walk();
        }
        
    }

     public void Walk()
    {
        if (tempoSort >= 0)
        {            
            if (tempoSort >= 30)
            {
                destino.x = Random.Range(-130, 50);
                destino.z = Random.Range(-100, 50);
                tempoSort = 0;
            }
            if (GetComponentInChildren<NavMeshAgent>().remainingDistance < 3)
            {
                destino.x = Random.Range(-130, 50);
                destino.z = Random.Range(-100, 50);
                tempoSort = 0;
            }
        }        

    }

    
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Pessoa") && liberadoParaAtaque == true)
        {
            alvo = collider.gameObject;
            alvo.GetComponentInChildren<PessoasIA>().alienFollowMe = gameObject;
            liberadoParaAtaque = false;            
        }   
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("Atacando");
    //    if (collision.gameObject.CompareTag("Pessoa"))
    //    {
            
    //        Destroy(alvo);
    //        liberadoParaAtaque = true;
    //        tempoSort = 30;
    //    }
        
    //}

    void DescerDaNave()
    {

        transform.position -= new Vector3(0, 10 * Time.deltaTime, 0);

    }


}
