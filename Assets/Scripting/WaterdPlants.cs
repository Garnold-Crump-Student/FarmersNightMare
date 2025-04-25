
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterdPlants : MonoBehaviour
{
    public PickUpWateringCan pickUpWateringCan;
    public ParticleSystem particle;
    public ParticleSystem waterdPlants;
    public bool waterd;
    public bool particlePlay;
    public Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
      
        waterdPlants.Stop();
       
      

    }
   

    // Update is called once per frame
    void Update()
    {
        string currnet = SceneManager.GetActiveScene().name;
        if (currnet == "Day2")
        {
            if (waterd == true)
            {
                this.transform.position = targetPosition;
                Debug.Log("Waterd");
            }
        }
        if (waterd == false ) { waterdPlants.Stop(); }
        if (pickUpWateringCan.Pickup == true)
        {
            if (Vector3.Distance(transform.position, particle.transform.position) <= 2)
            {
                if (Input.GetMouseButton(0))
                {
                    waterd = true;
                    waterdPlants.Play();
                    particlePlay = true;
                }
            }

        }
        
    }
}
