
using UnityEngine;


public class WaterdPlants : MonoBehaviour
{
    public PickUpWateringCan pickUpWateringCan;
    public ParticleSystem particle;
    public ParticleSystem waterdPlants;
    public bool waterd;
    // Start is called before the first frame update
    void Start()
    {
        waterdPlants.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (pickUpWateringCan.Pickup == true)
        {
            if (Vector3.Distance(transform.position, particle.transform.position) <= 2)
            {
                if (Input.GetMouseButton(0))
                {
                    waterd = true;
                    waterdPlants.Play();
                }
            }

        }
        
    }
}
