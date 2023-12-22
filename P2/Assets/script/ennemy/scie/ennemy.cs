using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemy : MonoBehaviour
{
    private Rigidbody2D rb;
    private colliderL cl_L;
    private colliderR cl_R;
    [SerializeField] private float moventspeed = 5000f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cl_L = GetComponentInChildren<colliderL>();
        cl_R = GetComponentInChildren<colliderR>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (cl_R.R_touch)
        {
            moventspeed = -5f;
            rb.velocityX = moventspeed;

        }
        
        if (cl_L.L_touch)
        {
            moventspeed = 5f;
            rb.velocityX = moventspeed;
        }
        
    }
}
