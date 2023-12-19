using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    public bool is_dead;
    void Start()
    {
        
    }
    
private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ennemy"))
        {
            is_dead = true;
            Debug.Log("le player est mort");
            
        }
        
    }
    
    void Update()
    {
        
    }
}
