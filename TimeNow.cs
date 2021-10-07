using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class TimeNow : MonoBehaviour {

    public Text clockText;

	// Use this for initialization
	void Start () {
        clockText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        System.DateTime time = System.DateTime.Now;
        string hour = LeadingZero(time.Hour);
        string minute = LeadingZero(time.Minute);
        clockText.text = hour + ":" + minute;

	}

    string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}
