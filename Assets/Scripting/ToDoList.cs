using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ToDoList : MonoBehaviour
{
    private float range = 1.5f;
    public GameObject player;
    public Text ToDo;
    public Image ListGraphics;
    public MeshRenderer ListRenderer;
  [SerializeField]  private bool ListPickedUp;
   [SerializeField] private bool DisableText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ListPickedUp == true)
        {
            Note();
            if(DisableText == true)
            {
                ExitNote();
            }
        }
       
     else   if(Vector3.Distance(transform.position, player.transform.position) <= range)
        {
            if(Input.GetKeyDown(KeyCode.E)) {
              ListRenderer.enabled = false;
                ListPickedUp = true; 
            }
            
        }

       
    }
    void Note()
    {
        if (ListPickedUp == true)
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                ListGraphics.enabled = true;
                DisableText = true;
               
                ToDo.enabled = true;
               
              

            }
        }
      
    }
    void ExitNote()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ListGraphics.enabled = false;
            ToDo.enabled = false;
        }
    }
}
