using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject Player;
    public GameObject spawnPoint;

    public bool Day1 = true;
    public bool Day2 = true;
    public bool ran = false;
    void Start()
    {




    }
    private void Update()
    {
        if (Day2 == false) if (ran == false) { { Player.transform.position = spawnPoint.transform.position; Day2 = true; } }
      
            string current = SceneManager.GetActiveScene().name;
        if (current == "Day2")
        { Invoke("spawnP2", 0f); ran = true; }
            if (current == "Day2")
        {
            if (Day1 == true)
            {
                Invoke("spawnP", 0f);

            }
        }


    }
    public void spawnP()
    {
        Player.transform.position = spawnPoint.transform.position;
        Day1 = false;



    }
    public void spawnP2()
    {
        
        Day2 = false;
    }
}
