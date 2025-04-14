using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    CharacterController controller;
    public float moveSpeed = 5f;
    public float sprintSpeed = 8f;
    private Vector3 moveDirection;
    [SerializeField] private float sprintTime = 5f;
    private float minSprint = 0.8f;
    public bool isSprinting;
    public Slider slider;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        slider.value = sprintTime;
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
        
        if(sprintTime <= 0)
        {
            sprintTime = 0;
            moveSpeed = 3;
        }
        if(sprintTime >= 5) { sprintTime = 5;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprintTime -= minSprint * Time.deltaTime;
            isSprinting = true;

        }
       
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
             moveSpeed =  sprintSpeed;
          
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed -= 5f;
            isSprinting = false;
        }
        else if (isSprinting == false)
        {
            Invoke("SprintRegan", 1f);
        }
        
    }

    void SprintRegan()
    {
        sprintTime += minSprint * Time.deltaTime;
    }

   
}
