
using UnityEngine;
using UnityEngine.UI;
public class Ontrigger : MonoBehaviour
{
    public Image check1;
    public Image img;
    private bool exit;
    public Image line;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (exit == true)
        {
            if (img.enabled == true)
            {
                check1.enabled = true;
                line.enabled = true;
            }
            if (img.enabled == false)
            {
                check1.enabled = false;
                line.enabled = false;
            }
        }
}
    private void OnTriggerEnter(Collider other)
    {
        exit = true;
    }

   
}
