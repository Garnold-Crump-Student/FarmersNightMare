using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public GameObject player;
    public Collider collider2;
    public GameObject door;
    [SerializeField] private float changeRate = 5f; // Speed of rotation
    private Vector3 initialRotate; // Starting rotation
    private bool isRotated = false;

    float maxDistance = 2f;
    private void Start()
    {
        
    }
 
    private void OnMouseDown()
    {
        if (Vector3.Distance(transform.position, player.transform.position) <= maxDistance)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                door.
                    
               
            }
        }
        else
        {
            Debug.Log("Player GameObject not assigned!");
        }
    }
}

