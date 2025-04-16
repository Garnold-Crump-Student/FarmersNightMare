using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarketButton : MonoBehaviour
{
    public RawImage tablet;
    public Image button;
    public Text market;
    public RawImage tabletMarket;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)){
            tabletMarket.enabled = false;
        }
    }
   public void Click()
    {
        tablet.enabled = false;
        button.enabled = false;
        market.enabled = false;
        tabletMarket.enabled = true;
    }
}
