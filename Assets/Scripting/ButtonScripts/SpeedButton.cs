using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SpeedButton : MonoBehaviour
{
    public Image SpeedUpgrades;
    public Image buttonPurchase;
    public Text purchase;
    public Button Purchase;
    public Text SpeedText;
    public Text SpeedDescripton;
    public RawImage marketButton;
    public Image button;
    public Text buttontxt;
    public Button button2;
    public Image box;
    public Image stick;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (marketButton.enabled == false)
        {
            SpeedDescripton.enabled = false;
            SpeedText.enabled = false;
            SpeedUpgrades.enabled = false;
            Purchase.enabled = false;
            purchase.enabled = false;
            buttonPurchase.enabled = false;
            button.enabled = false;
            button2.enabled = false;
            buttontxt.enabled = false;
            box.enabled = false;
            stick.enabled = false;
        }
        if(marketButton.enabled == true)
        {
            button.enabled = true;
            button2.enabled = true;  buttontxt.enabled = true;
          
        }
    }
    public void OnClick() {

        SpeedUpgrades.enabled = true;
        Purchase.enabled = true;
        buttonPurchase.enabled = true;
        purchase.enabled = true;
        SpeedText.enabled = true;
        SpeedDescripton.enabled = true;
      
        box.enabled = true;
        stick.enabled = true;
    }
}
