using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moventspeed = 5000f;
    [SerializeField] private float jumspeed = 10000f;
    public bool run_ok = true;

    private Rigidbody2D rb;
    private Grounded grounded;
    // Start is called before the first frame update
    
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        grounded = GetComponentInChildren<Grounded>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocityX = (Input.GetAxis("Horizontal") * Time.deltaTime * moventspeed);
            
        if (grounded.jump_ok)
        {
            rb.velocityY = (Input.GetAxis("Jump") * Time.deltaTime * jumspeed);
        }


        if (rb.velocityY >= 10)
        {
            rb.velocityY = 10;
        }
    }
}
