using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CornPickUp : MonoBehaviour
{
    public GameObject player;
    public GameObject corn;
    public Text text;

  
    public Vector3 destinationPosition;
    float maxDistance = 2f;
    public int cornAmount;
    private bool ff;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
        if (Vector3.Distance(transform.position, player.transform.position) <= maxDistance)

        if (Vector3.Distance(transform.position, player.transform.position) >= maxDistance)
        {
            text.enabled = false;
        }
            if (Vector3.Distance(transform.position, player.transform.position) <= maxDistance)

        {
            ff = true;

            text.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                corn.SetActive(false);
                cornAmount += 1;
                text.enabled = false;
            }
        }
        if (ff == true)
        {
            if (Vector3.Distance(transform.position, player.transform.position) > maxDistance)
            {
                text.enabled = false;
            }
        }

    }
}