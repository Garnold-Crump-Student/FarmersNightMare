using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSum : MonoBehaviour
{
    
    public FireOut[] fireStoped;
    public FireOut fireOut1;
    public FireOut fireOut2;
    public FireOut fireOut3;
    public FireOut fireOut4;
    public FireOut fireOut5;    
    public FireOut fireOut6;
    public FireOut fireOut7;
    public FireOut fireOut8;
    public FireOut fireOut9;
    public FireOut fireOut10;
    public FireOut fireOut11;
    public FireOut fireOut12;
    public FireOut fireOut13;     
    public FireOut fireOut14;
    public FireOut fireOut15;
    public FireOut fireOut16;
    public FireOut fireOut17;
    public FireOut fireOut18;   
public FireOut fireOut19;
    public FireOut fireOut20;
    public FireOut fireOut21;
    public FireOut fireOut22;
    public FireOut fireOut23;
    public FireOut fireOut24;       
    public FireOut fireOut25;
    public FireOut fireOut26;       
    public FireOut fireOut27;
    public FireOut fireOut28;
    public FireOut fireOut29;
    public FireOut fireOut30;
    public FireOut fireOut31;
    public FireOut fireOut32;
        public FireOut fireOut33;
    public FireOut fireOut34;
    public FireOut fireOut35;
    public FireOut fireOut36;
        public FireOut fireOut37;
    public float num = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
            num += fireOut1.sum; fireOut1.sum = 0;
            num += fireOut2.sum; fireOut2.sum = 0;
            num += fireOut3.sum; fireOut3.sum = 0;
            num += fireOut4.sum; fireOut4.sum = 0;
            num += fireOut5.sum; fireOut5.sum = 0;
            num += fireOut6.sum; fireOut6.sum = 0;
            num += fireOut7.sum; fireOut7.sum = 0;
            num += fireOut8.sum; fireOut8.sum = 0;
            num += fireOut9.sum; fireOut9.sum = 0;
            num += fireOut10.sum; fireOut10.sum = 0;
            num += fireOut11.sum; fireOut11.sum = 0;
            num += fireOut12.sum; fireOut12.sum = 0;
            num += fireOut13.sum; fireOut13.sum = 0;
            num += fireOut14.sum; fireOut14.sum = 0;
            num += fireOut15.sum; fireOut15.sum = 0;
            num += fireOut16.sum; fireOut16.sum = 0;
            num += fireOut17.sum; fireOut17.sum = 0;
            num += fireOut18.sum; fireOut18.sum = 0;
            num += fireOut19.sum; fireOut19.sum = 0;
            num += fireOut20.sum; fireOut20.sum = 0;
            num += fireOut21.sum; fireOut21.sum = 0;
            num += fireOut22.sum; fireOut22.sum = 0;
            num += fireOut23.sum; fireOut23.sum = 0;
            num += fireOut24.sum; fireOut24.sum = 0;
            num += fireOut25.sum; fireOut25.sum = 0;
            num += fireOut26.sum; fireOut26.sum = 0;
            num += fireOut27.sum; fireOut27.sum = 0;
            num += fireOut28.sum; fireOut28.sum = 0;
            num += fireOut29.sum; fireOut29.sum = 0;
            num += fireOut30.sum; fireOut30.sum = 0;
            num += fireOut31.sum; fireOut31.sum = 0;
            num += fireOut32.sum; fireOut32.sum = 0;
            num += fireOut33.sum; fireOut33.sum = 0;
            num += fireOut34.sum; fireOut34.sum = 0;
            num += fireOut35.sum; fireOut35.sum = 0;
            num += fireOut36.sum; fireOut36.sum = 0;
            num += fireOut37.sum; fireOut37.sum = 0;
          

        
        if(num == 37)
        {
            Debug.Log("Fire stopped");
        }
    }

}
