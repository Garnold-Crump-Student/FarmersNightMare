using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Follow2 : MonoBehaviour
{
    public float speed = 5.0f;
    public float minDist = 1f;
    public Transform target;
  
    public float rotationSpeed = 5f;
    public GameObject enemy;
    public CountDown countDown;
    void Start()
    {
        if (target == null)
        {
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                target = player.transform;
            }
        }
    }

    void Update()
    {
        if (countDown.chase == false || target == null)
            return;

        Vector3 direction = (target.position - transform.position).normalized;
        direction.y = 0f;

        
        Quaternion lookRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);

        float distance = Vector3.Distance(transform.position, target.position);
        if (distance > minDist)
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }

    public void SetTarget(Transform newTarget)
    {
        target = newTarget;
    }
}