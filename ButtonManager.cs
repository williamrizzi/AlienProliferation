using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {



	public GameObject spawner;
	public GameObject spawnerText;
	public GameObject spawnerDescription;
	public int spawnerLevel;
	public bool setado;
	public GameObject buyButton;
	public GameObject upgradeButton;
	public GameObject spawnerNumbAlienText;

	// Use this for initialization
	void Start () {
		setado = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (spawnerLevel == 0) {
			spawnerNumbAlienText.GetComponent<Text> ().text = "Gratuito";
		} else if (spawnerLevel == 1) {
			spawner.GetComponent<SpawnerAlienDefault> ().maxTemporizador = 30;
			spawnerNumbAlienText.GetComponent<Text> ().text = "Precisa de 10 aliens para dar Upgrade.";
			spawnerDescription.GetComponent<Text> ().text = "SPAWNER: Gera 1 alien a cada " + spawner.GetComponent<SpawnerAlienDefault> ().maxTemporizador.ToString () + " segundos.";
		} else if (spawnerLevel == 2) {
			spawner.GetComponent<SpawnerAlienDefault> ().maxTemporizador = 25;
			spawnerNumbAlienText.GetComponent<Text> ().text = "Precisa de 30 aliens para dar Upgrade.";
			spawnerDescription.GetComponent<Text> ().text = "SPAWNER: Gera 1 alien a cada " + spawner.GetComponent<SpawnerAlienDefault> ().maxTemporizador.ToString () + " segundos.";
		} else if (spawnerLevel == 3) {
			spawner.GetComponent<SpawnerAlienDefault> ().maxTemporizador = 20;
			spawnerNumbAlienText.GetComponent<Text> ().text = "Precisa de 50 aliens para dar Upgrade.";
			spawnerDescription.GetComponent<Text> ().text = "SPAWNER: Gera 1 alien a cada " + spawner.GetComponent<SpawnerAlienDefault> ().maxTemporizador.ToString () + " segundos.";
		} else if (spawnerLevel == 4) {
			spawner.GetComponent<SpawnerAlienDefault> ().maxTemporizador = 15;
			spawnerNumbAlienText.GetComponent<Text> ().text = "Precisa de 70 aliens para dar Upgrade.";
			spawnerDescription.GetComponent<Text> ().text = "SPAWNER: Gera 1 alien a cada " + spawner.GetComponent<SpawnerAlienDefault> ().maxTemporizador.ToString () + " segundos.";
		} else if (spawnerLevel == 5) {
			spawner.GetComponent<SpawnerAlienDefault> ().maxTemporizador = 10;
			spawnerNumbAlienText.GetComponent<Text> ().text = "Precisa de 90 aliens para dar Upgrade.";
			spawnerDescription.GetComponent<Text> ().text = "SPAWNER: Gera 1 alien a cada " + spawner.GetComponent<SpawnerAlienDefault> ().maxTemporizador.ToString () + " segundos.";
		} else if (spawnerLevel == 6) {
			spawner.GetComponent<SpawnerAlienDefault> ().maxTemporizador = 5;
			spawnerNumbAlienText.GetComponent<Text> ().text = "Precisa de 100 aliens para dar Upgrade.";
			spawnerDescription.GetComponent<Text> ().text = "SPAWNER: Gera 1 alien a cada " + spawner.GetComponent<SpawnerAlienDefault> ().maxTemporizador.ToString () + " segundos.";

		} else if (spawnerLevel == 7) {
			spawner.GetComponent<SpawnerAlienDefault> ().maxTemporizador = 2;
			spawnerNumbAlienText.GetComponent<Text> ().text = "Nivel Máximo";
			spawnerDescription.GetComponent<Text> ().text = "SPAWNER: Gera 1 alien a cada " + spawner.GetComponent<SpawnerAlienDefault> ().maxTemporizador.ToString () + " segundos.";
			upgradeButton.SetActive (false);
		}
	}

	public void SpawnerBuy(){
			spawner.SetActive (true);
			buyButton.SetActive (false);
			upgradeButton.SetActive (true);
			spawnerLevel += 1;		
	}
}
