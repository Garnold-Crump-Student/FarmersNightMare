using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopFollowing : MonoBehaviour
{
    public NightmareLights nightmareLights;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        nightmareLights.enterd = false;
        Invoke("Cube", 1f);

    }
    void Cube()
    {
        cube.SetActive(true);
    }
}
