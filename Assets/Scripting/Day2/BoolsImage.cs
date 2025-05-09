using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoolsImage : MonoBehaviour
{ public PlantsGrow plantsGrow;
    public Canvas canvas;
    public Player player;
    public Canvas canvas2;
    public bool enable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DontDestroyOnLoad(this);
        if(plantsGrow.t == true)
        {
canvas.enabled = true;

        }
        if(plantsGrow.t == false)
        {
            canvas.enabled = false;
            
        }
        if (player.upgraded == true) {
            if(Input.GetKeyDown(KeyCode.Tab)) { enable = true;  }
        }
        if (player.upgraded == false)
        {
            player.upgraded = false;
            if (Input.GetKeyDown(KeyCode.Escape)) { enable = false; }
        }
        if(enable == true) { canvas2.enabled = true; }
        if(enable == false) { canvas2.enabled = false; }
    }
}
