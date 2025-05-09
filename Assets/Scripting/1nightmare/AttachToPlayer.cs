using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttachToPlayer : MonoBehaviour
{
    void Start()
    {
        // Find the object tagged as "Player"
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if (player != null)
        {
            // Make this object a child of the player
            transform.SetParent(player.transform);
        }
        else
        {
            Debug.LogWarning("No object with tag 'Player' found.");
        }
        
    }
    private void Update()
    {
        
        }
    
   
  
}