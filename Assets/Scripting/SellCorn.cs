
using UnityEngine;
using UnityEngine.UI;


public class SellCorn : MonoBehaviour
{
    public CornPickUp cornPickUp;
    public CornPickUp cornPickUp1;
    public CornPickUp cornPickUp2;
    public CornPickUp cornPickUp3;
    public GameObject corn1;
    public GameObject corn2;
    public GameObject corn3;
    public double money;
    public int corn;
    public bool ontrigger;
    public Text moneyAmount;
    public Text moneyAmount1;
    public Text moneyAmount2;
    public Text moneyAmount3;
    public bool complete2;

  

    // Update is called once per frame
    void Update()
    {
        moneyAmount.text = money.ToString(); 
        moneyAmount1.text = money.ToString();
        moneyAmount2.text = money.ToString();
        moneyAmount3.text = money.ToString();

        corn = cornPickUp.cornAmount;
        corn += cornPickUp1.cornAmount;
        corn += cornPickUp2.cornAmount;
        corn += cornPickUp3.cornAmount;

        if(ontrigger == true)
        {
            corn = 0;
            cornPickUp.cornAmount = 0;
            cornPickUp1.cornAmount = 0;
            cornPickUp2.cornAmount = 0;
            cornPickUp3.cornAmount = 0;
           
        }
        if(ontrigger == true && corn == 0)
        {
            ontrigger = false;
           
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        ontrigger = true;

        if (corn > 0)
        {
            complete2 = true;
            for (int i = 0; i <= corn -1; i++)
            {
                money += 2;



            }
          
        }
      

    }
}
