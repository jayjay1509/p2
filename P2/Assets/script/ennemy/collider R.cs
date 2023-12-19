using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderR : MonoBehaviour
{
    public bool R_touch;
    private colliderL cl_L;
    
    void Start()
    {
        cl_L = GetComponentInParent<colliderL>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            cl_L.L_touch = false;
            R_touch = true;
            
        }
        
    }
}

