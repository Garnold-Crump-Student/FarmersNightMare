using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Image image;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        image.enabled = false;
        text.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ExitNote()
    {
        image.enabled = false;
        text.enabled = false;
    }
    
}
