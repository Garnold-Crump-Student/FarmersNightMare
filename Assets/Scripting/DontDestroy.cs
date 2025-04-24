using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    public GameObject all;
 
  
    private string sceneToDestroyIn = "NightMare";

    // Start is called before the first frame update
    void Start()
    {
       DontDestroyOnLoad(all);
    }

    // Update is called once per frame

     void Update()
    {
        if (bool.Parse(sceneToDestroyIn))
        {

            GameObject objectToDestroy = all;

            if (objectToDestroy != null)
            {
                Destroy(objectToDestroy);
            }
        }
    }
 
}


