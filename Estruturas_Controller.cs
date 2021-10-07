using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estruturas_Controller : MonoBehaviour {

    public GameObject player;

    public GameObject estruturaFerro;
    public GameObject estruturaCarvao;
    public GameObject estruturaVidro;
    public GameObject estruturaDiamante;

    public GameObject buttonConstruirFerro;
    public GameObject buttonUpgradeFerro;
    public GameObject buttonConstruirCarvao;
    public GameObject buttonUpgradeCarvao;
    public GameObject buttonConstruirVidro;
    public GameObject buttonUpgradeVidro;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {

	}

    public void ConstruirFerro()
    {
        if(player.GetComponentInChildren<PlayerZorg>().ferro >= 150)
        {
            estruturaFerro.SetActive(true);
            player.GetComponentInChildren<PlayerZorg>().ferro -= 150;
            estruturaFerro.GetComponentInChildren<Ferreiro>().level = 1;
            estruturaFerro.GetComponentInChildren<Ferreiro>().setado = true;
            buttonConstruirFerro.SetActive(false);
            buttonUpgradeFerro.SetActive(true);
        }
        
    }

    public void ConstruirCarvao()
    {
        if (player.GetComponentInChildren<PlayerZorg>().carvao >= 150)
        {
            estruturaCarvao.SetActive(true);
            player.GetComponentInChildren<PlayerZorg>().carvao -= 150;
            estruturaCarvao.GetComponentInChildren<Mines>().level = 1;
            estruturaCarvao.GetComponentInChildren<Mines>().setado = true;
            buttonConstruirCarvao.SetActive(false);
            buttonUpgradeCarvao.SetActive(true);
        }

    }

    public void ConstruirVidro()
    {
        if (player.GetComponentInChildren<PlayerZorg>().vidro >= 150)
        {
            estruturaVidro.SetActive(true);
            player.GetComponentInChildren<PlayerZorg>().vidro -= 150;
            estruturaVidro.GetComponentInChildren<ColetorVidro>().level = 1;
            estruturaVidro.GetComponentInChildren<ColetorVidro>().setado = true;
            buttonConstruirVidro.SetActive(false);
            buttonUpgradeVidro.SetActive(true);
        }

    }

    public void UpgradeFerro()
    {
        if (estruturaFerro.active == true)
        {
            if (player.GetComponentInChildren<PlayerZorg>().ferro >= estruturaFerro.GetComponentInChildren<Ferreiro>().ferroParaUpgrade)
            {
                //Level 1
                if (estruturaFerro.GetComponentInChildren<Ferreiro>().level == 1)
                {
                    estruturaFerro.GetComponentInChildren<Ferreiro>().setado = true;
                    estruturaFerro.GetComponentInChildren<Ferreiro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().ferro -= estruturaFerro.GetComponentInChildren<Ferreiro>().ferroParaUpgrade;
                }
                //Level 2
                else if (estruturaFerro.GetComponentInChildren<Ferreiro>().level == 2)
                {
                    estruturaFerro.GetComponentInChildren<Ferreiro>().setado = true;
                    estruturaFerro.GetComponentInChildren<Ferreiro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().ferro -= estruturaFerro.GetComponentInChildren<Ferreiro>().ferroParaUpgrade;
                }
                //Level 3
                else if (estruturaFerro.GetComponentInChildren<Ferreiro>().level == 3)
                {
                    estruturaFerro.GetComponentInChildren<Ferreiro>().setado = true;
                    estruturaFerro.GetComponentInChildren<Ferreiro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().ferro -= estruturaFerro.GetComponentInChildren<Ferreiro>().ferroParaUpgrade;
                }
                //Level 4
                else if (estruturaFerro.GetComponentInChildren<Ferreiro>().level == 4)
                {
                    estruturaFerro.GetComponentInChildren<Ferreiro>().setado = true;
                    estruturaFerro.GetComponentInChildren<Ferreiro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().ferro -= estruturaFerro.GetComponentInChildren<Ferreiro>().ferroParaUpgrade;
                }
                //Level 5
                else if (estruturaFerro.GetComponentInChildren<Ferreiro>().level == 5)
                {
                    estruturaFerro.GetComponentInChildren<Ferreiro>().setado = true;
                    estruturaFerro.GetComponentInChildren<Ferreiro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().ferro -= estruturaFerro.GetComponentInChildren<Ferreiro>().ferroParaUpgrade;
                }
                //Level 6
                else if (estruturaFerro.GetComponentInChildren<Ferreiro>().level == 6)
                {
                    estruturaFerro.GetComponentInChildren<Ferreiro>().setado = true;
                    estruturaFerro.GetComponentInChildren<Ferreiro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().ferro -= estruturaFerro.GetComponentInChildren<Ferreiro>().ferroParaUpgrade;
                }
                //Level 7
                else if (estruturaFerro.GetComponentInChildren<Ferreiro>().level == 7)
                {
                    estruturaFerro.GetComponentInChildren<Ferreiro>().setado = true;
                    estruturaFerro.GetComponentInChildren<Ferreiro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().ferro -= estruturaFerro.GetComponentInChildren<Ferreiro>().ferroParaUpgrade;
                }
                //Level 8
                else if (estruturaFerro.GetComponentInChildren<Ferreiro>().level == 8)
                {
                    estruturaFerro.GetComponentInChildren<Ferreiro>().setado = true;
                    estruturaFerro.GetComponentInChildren<Ferreiro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().ferro -= estruturaFerro.GetComponentInChildren<Ferreiro>().ferroParaUpgrade;
                }
                //Level 9
                else if (estruturaFerro.GetComponentInChildren<Ferreiro>().level == 9)
                {
                    estruturaFerro.GetComponentInChildren<Ferreiro>().setado = true;
                    estruturaFerro.GetComponentInChildren<Ferreiro>().level += 1;
                    buttonUpgradeFerro.SetActive(false);
                    player.GetComponentInChildren<PlayerZorg>().ferro -= estruturaFerro.GetComponentInChildren<Ferreiro>().ferroParaUpgrade;
                }                
            }
        }        
    }

    public void UpgradeCarvao()
    {
        if (estruturaCarvao.active == true)
        {
            if (player.GetComponentInChildren<PlayerZorg>().carvao >= estruturaCarvao.GetComponentInChildren<Mines>().carvaoParaUpgrade)
            {
                //Level 1
                if (estruturaCarvao.GetComponentInChildren<Mines>().level == 1)
                {
                    estruturaCarvao.GetComponentInChildren<Mines>().setado = true;
                    estruturaCarvao.GetComponentInChildren<Mines>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().carvao -= estruturaCarvao.GetComponentInChildren<Mines>().carvaoParaUpgrade;
                }
                //Level 2
                else if (estruturaCarvao.GetComponentInChildren<Mines>().level == 2)
                {
                    estruturaCarvao.GetComponentInChildren<Mines>().setado = true;
                    estruturaCarvao.GetComponentInChildren<Mines>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().carvao -= estruturaCarvao.GetComponentInChildren<Mines>().carvaoParaUpgrade;
                }
                //Level 3
                else if (estruturaCarvao.GetComponentInChildren<Mines>().level == 3)
                {
                    estruturaCarvao.GetComponentInChildren<Mines>().setado = true;
                    estruturaCarvao.GetComponentInChildren<Mines>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().carvao -= estruturaCarvao.GetComponentInChildren<Mines>().carvaoParaUpgrade;
                }
                //Level 4
                else if (estruturaCarvao.GetComponentInChildren<Mines>().level == 4)
                {
                    estruturaCarvao.GetComponentInChildren<Mines>().setado = true;
                    estruturaCarvao.GetComponentInChildren<Mines>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().carvao -= estruturaCarvao.GetComponentInChildren<Mines>().carvaoParaUpgrade;
                }
                //Level 5
                else if (estruturaCarvao.GetComponentInChildren<Mines>().level == 5)
                {
                    estruturaCarvao.GetComponentInChildren<Mines>().setado = true;
                    estruturaCarvao.GetComponentInChildren<Mines>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().carvao -= estruturaCarvao.GetComponentInChildren<Mines>().carvaoParaUpgrade;
                }
                //Level 6
                else if (estruturaCarvao.GetComponentInChildren<Mines>().level == 6)
                {
                    estruturaCarvao.GetComponentInChildren<Mines>().setado = true;
                    estruturaCarvao.GetComponentInChildren<Mines>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().carvao -= estruturaCarvao.GetComponentInChildren<Mines>().carvaoParaUpgrade;
                }
                //Level 7
                else if (estruturaCarvao.GetComponentInChildren<Mines>().level == 7)
                {
                    estruturaCarvao.GetComponentInChildren<Mines>().setado = true;
                    estruturaCarvao.GetComponentInChildren<Mines>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().carvao -= estruturaCarvao.GetComponentInChildren<Mines>().carvaoParaUpgrade;
                }
                //Level 8
                else if (estruturaCarvao.GetComponentInChildren<Mines>().level == 8)
                {
                    estruturaCarvao.GetComponentInChildren<Mines>().setado = true;
                    estruturaCarvao.GetComponentInChildren<Mines>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().carvao -= estruturaCarvao.GetComponentInChildren<Mines>().carvaoParaUpgrade;
                }
                //Level 9
                else if (estruturaCarvao.GetComponentInChildren<Mines>().level == 9)
                {
                    estruturaCarvao.GetComponentInChildren<Mines>().setado = true;
                    estruturaCarvao.GetComponentInChildren<Mines>().level += 1;
                    buttonUpgradeCarvao.SetActive(false);
                    player.GetComponentInChildren<PlayerZorg>().carvao -= estruturaCarvao.GetComponentInChildren<Mines>().carvaoParaUpgrade;
                }
            }
        }
    }

    public void UpgradeVidro()
    {
        if (estruturaVidro.active == true)
        {
            if (player.GetComponentInChildren<PlayerZorg>().vidro >= estruturaVidro.GetComponentInChildren<ColetorVidro>().vidroParaUpgrade)
            {
                //Level 1
                if (estruturaVidro.GetComponentInChildren<ColetorVidro>().level == 1)
                {
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().setado = true;
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().vidro -= estruturaVidro.GetComponentInChildren<ColetorVidro>().vidroParaUpgrade;
                }
                //Level 2
                else if (estruturaVidro.GetComponentInChildren<ColetorVidro>().level == 2)
                {
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().setado = true;
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().vidro -= estruturaVidro.GetComponentInChildren<ColetorVidro>().vidroParaUpgrade;
                }
                //Level 3
                else if (estruturaVidro.GetComponentInChildren<ColetorVidro>().level == 3)
                {
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().setado = true;
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().vidro -= estruturaVidro.GetComponentInChildren<ColetorVidro>().vidroParaUpgrade;
                }
                //Level 4
                else if (estruturaVidro.GetComponentInChildren<ColetorVidro>().level == 4)
                {
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().setado = true;
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().vidro -= estruturaVidro.GetComponentInChildren<ColetorVidro>().vidroParaUpgrade;
                }
                //Level 5
                else if (estruturaVidro.GetComponentInChildren<ColetorVidro>().level == 5)
                {
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().setado = true;
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().vidro -= estruturaVidro.GetComponentInChildren<ColetorVidro>().vidroParaUpgrade;
                }
                //Level 6
                else if (estruturaVidro.GetComponentInChildren<ColetorVidro>().level == 6)
                {
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().setado = true;
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().vidro -= estruturaVidro.GetComponentInChildren<ColetorVidro>().vidroParaUpgrade;
                }
                //Level 7
                else if (estruturaVidro.GetComponentInChildren<ColetorVidro>().level == 7)
                {
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().setado = true;
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().vidro -= estruturaVidro.GetComponentInChildren<ColetorVidro>().vidroParaUpgrade;
                }
                //Level 8
                else if (estruturaVidro.GetComponentInChildren<ColetorVidro>().level == 8)
                {
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().setado = true;
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().level += 1;
                    player.GetComponentInChildren<PlayerZorg>().vidro -= estruturaVidro.GetComponentInChildren<ColetorVidro>().vidroParaUpgrade;
                }
                //Level 9
                else if (estruturaVidro.GetComponentInChildren<ColetorVidro>().level == 9)
                {
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().setado = true;
                    estruturaVidro.GetComponentInChildren<ColetorVidro>().level += 1;
                    buttonUpgradeVidro.SetActive(false);
                    player.GetComponentInChildren<PlayerZorg>().vidro -= estruturaVidro.GetComponentInChildren<ColetorVidro>().vidroParaUpgrade;
                }
            }
        }
    }




}
