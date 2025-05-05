using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public float time = 20;
    public bool start;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (start == true)
        {
            time -= Time.deltaTime;
        }
        if(Input.GetKeyUp(KeyCode.B)) { start = true; }
        if(time <= 0)
        {
            Debug.Log("Attack");
        }
    }
}
