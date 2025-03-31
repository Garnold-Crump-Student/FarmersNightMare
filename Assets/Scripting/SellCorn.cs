using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellCorn : MonoBehaviour
{
    public CornPickUp cornPickUp;
    public double money;
    public int corn;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        corn = cornPickUp.cornAmount;
    }
    private void OnTriggerEnter(Collider other)
    {
       for(int i = 0; i < corn; i++)
        {
            money += 1.5;
            cornPickUp.cornAmount = 0;
        }
        
    }
}
