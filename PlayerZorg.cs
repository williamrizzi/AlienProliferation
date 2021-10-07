using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerZorg : MonoBehaviour {

    // DADOS BASICOS DO JOGADOR
    public float vida;
    public int dano = 10;

	public float velocidade = 3.5f;
     
    public float vidro;
     
    public float carvao;

    public float ferro;

    public float diamante;

    public float rubi;

    public float esmeralda;

    public float ouro;

    public float lixo;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SetTexts();
       
	}

    public void SetTexts()
    {

        //GameObject.Find("TextFerro").GetComponent<Text>().text = "" + ferro.ToString();
        //GameObject.Find("TextCarvao").GetComponent<Text>().text = "" + carvao.ToString();
        //GameObject.Find("TextVidro").GetComponent<Text>().text = "" + vidro.ToString();
        //GameObject.Find("TextDiamante").GetComponent<Text>().text = "" + diamante.ToString();


    }
}
