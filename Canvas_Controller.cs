using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canvas_Controller : MonoBehaviour {

    public GameObject estruturas;

    public GameObject recursosRef;
    public GameObject proliferacaoRef;
    public GameObject defesasRef;

   

	// Use this for initialization
	void Start () {

        estruturas = GameObject.FindGameObjectWithTag("Tela_Recursos");      
        gameObject.GetComponent<Canvas>().enabled = true;
        estruturas.GetComponent<Canvas>().enabled = false;
       

    }
	
	// Update is called once per frame
	void Update () {
		
        

	}

    public void TelaEstruturas()
    {
        GameObject.Find("MainCamera").GetComponentInChildren<CameraMovement>().liberado = false;
        estruturas.GetComponent<Canvas>().enabled = true;
        gameObject.GetComponent<Canvas>().enabled = false;
        AbaRecursos();        
    }    

    public void AbaRecursos()
    {
        GameObject.Find("Tab1").GetComponentInChildren<CanvasGroup>().alpha = 1;
        GameObject.Find("Tab1").GetComponentInChildren<CanvasGroup>().blocksRaycasts = true;
        GameObject.Find("Tab2").GetComponentInChildren<CanvasGroup>().alpha = 0;
        GameObject.Find("Tab2").GetComponentInChildren<CanvasGroup>().blocksRaycasts = false;
        GameObject.Find("Tab3").GetComponentInChildren<CanvasGroup>().alpha = 0;
        GameObject.Find("Tab3").GetComponentInChildren<CanvasGroup>().blocksRaycasts = false;
    }
    public void AbaProliferacao()
    {
        GameObject.Find("Tab1").GetComponentInChildren<CanvasGroup>().alpha = 0;
        GameObject.Find("Tab1").GetComponentInChildren<CanvasGroup>().blocksRaycasts = false;
        GameObject.Find("Tab2").GetComponentInChildren<CanvasGroup>().alpha = 1;
        GameObject.Find("Tab2").GetComponentInChildren<CanvasGroup>().blocksRaycasts = true;
        GameObject.Find("Tab3").GetComponentInChildren<CanvasGroup>().alpha = 0;
        GameObject.Find("Tab3").GetComponentInChildren<CanvasGroup>().blocksRaycasts = false;
    }
    public void AbaDefesas()
    {
        GameObject.Find("Tab1").GetComponentInChildren<CanvasGroup>().alpha = 0;
        GameObject.Find("Tab1").GetComponentInChildren<CanvasGroup>().blocksRaycasts = false;
        GameObject.Find("Tab2").GetComponentInChildren<CanvasGroup>().alpha = 0;
        GameObject.Find("Tab2").GetComponentInChildren<CanvasGroup>().blocksRaycasts = false;
        GameObject.Find("Tab3").GetComponentInChildren<CanvasGroup>().alpha = 1;
        GameObject.Find("Tab3").GetComponentInChildren<CanvasGroup>().blocksRaycasts = true;
    }



    public void FecharAll()
    {
        GameObject.Find("MainCamera").GetComponentInChildren<CameraMovement>().liberado = true;
        gameObject.GetComponent<Canvas>().enabled = true;
        estruturas.GetComponent<Canvas>().enabled = false;
    }

    




}
