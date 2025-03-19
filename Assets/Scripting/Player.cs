using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController controller;
    public float moveSpeed = 5f;
    public float sprintSpeed = 8f;
    private Vector3 moveDirection;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        moveDirection.Normalize();
        moveDirection.y = -1f;

        controller.Move(moveDirection * moveSpeed * Time.deltaTime);

    }
    public void AddMoveInput(float forwardInput, float rightInput)
    {
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        moveDirection = (forward * forwardInput) + (rightInput * right);
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
             moveSpeed =  sprintSpeed;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed -= 5f;
        }
    }
}
