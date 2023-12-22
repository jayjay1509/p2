using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAPAr : MonoBehaviour
{
    public bool R_touch;
    private PAPAl cl_L;
    
    void Start()
    {
        cl_L = GetComponentInParent<PAPAl>();
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            cl_L.L_touch = false;
            R_touch = true;
            Debug.Log("papa a vu le trou a droite");
        }
        
    }
}

