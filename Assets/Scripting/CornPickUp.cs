using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornPickUp : MonoBehaviour
{
    public GameObject player;
    public GameObject corn;
    public Vector3 destinationPosition;
    float maxDistance = 2f;
    public int cornAmount;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= maxDistance)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                corn.SetActive(false);
                cornAmount += 1;
            }
        }
    }
}