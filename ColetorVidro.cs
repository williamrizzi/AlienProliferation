using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetorVidro : MonoBehaviour {

    public int level;
    public int life;
    public int lifeBase;
    public int lifeMultiplier;

    public int vidroParaUpgrade;
    public int vidroUpBase;
    public int vidroUpMultiplier;

    public GameObject player;

    public float tempExtrair;

    public float speed;

    public bool setado = false;

    // Use this for initialization
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {

        Leveling();
        if (gameObject.active == true)
        {
            tempExtrair += Time.deltaTime;
            if (tempExtrair >= speed)
            {
                tempExtrair -= speed;
                player.GetComponentInChildren<PlayerZorg>().vidro += 1;
            }
        }
    }

    public void Leveling()
    {
        if (gameObject.active == true)
        {
            if (level == 1 && setado)
            {
                speed = 60;
                life = lifeBase * lifeMultiplier;
                setado = false;
                vidroParaUpgrade = vidroParaUpgrade + vidroUpBase * vidroUpMultiplier;
            }
            if (level == 2 && setado)
            {
                speed = 50;
                life = lifeBase * lifeMultiplier;
                setado = false;
                vidroParaUpgrade = vidroParaUpgrade + vidroUpBase * vidroUpMultiplier;
            }
            if (level == 3 && setado)
            {
                speed = 40;
                life = lifeBase * lifeMultiplier;
                setado = false;
                vidroParaUpgrade = vidroParaUpgrade + vidroUpBase * vidroUpMultiplier;
            }
            if (level == 4 && setado)
            {
                speed = 30;
                life = lifeBase * lifeMultiplier;
                setado = false;
                vidroParaUpgrade = vidroParaUpgrade + vidroUpBase * vidroUpMultiplier;
            }
            if (level == 5 && setado)
            {
                speed = 20;
                life = lifeBase * lifeMultiplier;
                setado = false;
                vidroParaUpgrade = vidroParaUpgrade + vidroUpBase * vidroUpMultiplier;
            }
            if (level == 6 && setado)
            {
                speed = 10;
                life = lifeBase * lifeMultiplier;
                setado = false;
                vidroParaUpgrade = vidroParaUpgrade + vidroUpBase * vidroUpMultiplier;
            }
            if (level == 7 && setado)
            {
                speed = 5;
                life = lifeBase * lifeMultiplier;
                setado = false;
                vidroParaUpgrade = vidroParaUpgrade + vidroUpBase * vidroUpMultiplier;
            }
            if (level == 8 && setado)
            {
                speed = 4;
                life = lifeBase * lifeMultiplier;
                setado = false;
                vidroParaUpgrade = vidroParaUpgrade + vidroUpBase * vidroUpMultiplier;
            }
            if (level == 9 && setado)
            {
                speed = 2;
                life = lifeBase * lifeMultiplier;
                setado = false;
                vidroParaUpgrade = vidroParaUpgrade + vidroUpBase * vidroUpMultiplier;
            }
            if (level == 10 && setado)
            {
                speed = 1;
                life = lifeBase * lifeMultiplier;
                setado = false;
                vidroParaUpgrade = vidroParaUpgrade + vidroUpBase * vidroUpMultiplier;
            }
        }
    }
}
