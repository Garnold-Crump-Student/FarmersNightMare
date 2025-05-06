using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float time = 20;
    public bool start;
    public Text countdownDisplay;
    public bool chase;
    public GameObject enemy;
    public Complete complete;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(complete.Completed == true) { start = true;
           
            
        }
        if(time <= 0)
        {
         
            countdownDisplay.enabled = false;
            chase = true;
            enemy.SetActive(true);
           
        }
        if(start == false) { enemy.SetActive(false); }
        if (start == true)
        {
            time -= Time.deltaTime;
            int rounded = Convert.ToInt32(time);
            countdownDisplay.text = rounded.ToString();
        }
        

    }
}
