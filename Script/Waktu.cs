using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waktu : MonoBehaviour
{
    Text text;
    public static float timeLeft = 15f;
    public GameObject timesUpText;

    void Start()
    {
        text = GetComponent<Text>();

    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
            timeLeft = 0;
            text.text = "Time Left : " + Mathf.Round(timeLeft);
    
    }
}


