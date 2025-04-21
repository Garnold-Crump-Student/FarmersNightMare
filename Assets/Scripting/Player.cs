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
   public float sprintTime = 5f;
    private float minSprint = 0.8f;
    public bool isSprinting;
    public float sprintTime1;
    public Slider slider;
    public PurhcaseButton purchaseButton;


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        sprintTime1 = sprintTime;
        slider.value = sprintTime;
        slider.maxValue = purchaseButton.fix;
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
        if (purchaseButton.Sold == false && purchaseButton.sold2 == false && purchaseButton.sold3 == false) { if (sprintTime >= 5) { sprintTime = 5; } 
        }
        if(purchaseButton.Sold == true) {  if (sprintTime >= 7) { sprintTime = 7; } }
        if(purchaseButton.sold2 == true) {if(sprintTime >= 9) {  sprintTime = 9; } }
        if(purchaseButton.sold3 == true) { if(sprintTime >= 10) {  sprintTime = 10; } }
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
