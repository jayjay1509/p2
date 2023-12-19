using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderL : MonoBehaviour
{

    public bool L_touch;
    private colliderR cl_R;
    
    void Start()
    {
        cl_R = GetComponentInChildren<colliderR>();
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            cl_R.R_touch = false;
            L_touch = true;
        }
        
    }
}
