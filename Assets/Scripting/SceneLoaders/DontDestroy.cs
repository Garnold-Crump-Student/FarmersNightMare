using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public GameObject all;
   
  
    

    // Start is called before the first frame update
    void Start()
    {
       
       
        
    }

    // Update is called once per frame

    void Update()
    {
        string current = SceneManager.GetActiveScene().name;
        if (current == "NightMare")
        {
            all.SetActive(false);
        }
        if(current == "Day2") { all.SetActive(true); }
       DontDestroyOnLoad(all); 
       
        
    }
 
}


