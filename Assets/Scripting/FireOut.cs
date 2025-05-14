using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireOut : MonoBehaviour
{
    public float sum;
    public ParticleSystem particle;
    public ParticleSystem fire;
    public GameObject fires;
    public bool stoped;
    
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    { 
        DontDestroyOnLoad(fires);
        string current = SceneManager.GetActiveScene().name;
        if(current != "Day3")
        {
            fires.SetActive(false);
        }
        if (current == "Day3")
        {
            fires.SetActive(true);

            if (Vector3.Distance(transform.position, particle.transform.position) <= 2)
            {
                if (Input.GetMouseButton(0))
                {
                    fire.Stop();
                  stoped = true;
              if(fire.isStopped == true){      if (stoped == true)
                        {
                            sum += 1;
                            stoped = false;
                            if (sum > 1)
                            {
                                sum = 1;
                            }
                        }
                    } 
                }
            }
        }
    }
}