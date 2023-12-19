using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PAPAl : MonoBehaviour
{

    public bool L_touch;
    private PAPAr cl_R;
    
    void Start()
    {
        cl_R = GetComponentInChildren<PAPAr>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            cl_R.R_touch = false;
            L_touch = true;
            Debug.Log("papa a vu le trou a gauche");
        }
        
    }
}
