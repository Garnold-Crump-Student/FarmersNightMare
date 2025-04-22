using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightmareLights : MonoBehaviour
{
    public GameObject player;
   
    public Light light1;
    public Light light2;
    public Light light3;
    public float blinkInterval = 1f;
    public float blinkDuration = 0.5f;
    public bool enterd;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enterd)
        {
           
        }
    }
    private void OnTriggerEnter()
    {
        if (player)
        {
            light1.color = Color.red;
            light2.color = Color.red;
            light3.color = Color.red;
            enterd = true;
        }
    }
}
