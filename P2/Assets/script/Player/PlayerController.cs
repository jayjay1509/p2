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
    public SpriteRenderer _sr;

    private AudioSource audio_jump;

    private Animator _anim;
    // Start is called before the first frame update
    
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        grounded = GetComponentInChildren<Grounded>();
        _anim = GetComponent<Animator>();
        _sr = GetComponent<SpriteRenderer>();
        audio_jump = GetComponentInChildren<AudioSource>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.velocity.x <= -0.1f)
    {
        _sr.flipX = false;
    }
    else if (rb.velocity.x >= 0.1f)
    {
        _sr.flipX = true;
    } 

        
        
        rb.velocityX = (Input.GetAxis("Horizontal") * Time.deltaTime * moventspeed);
            
        if (grounded.jump_ok)
        {
            rb.velocityY = (Input.GetAxis("Jump") * Time.deltaTime * jumspeed);
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            audio_jump.Play();
        }

        if (Mathf.Abs(rb.velocityX) >= 0.01f)
        {
            _anim.SetBool("is_run", true);
        }
        else
        {
            _anim.SetBool("is_run", false);
        }


        if (rb.velocityY >= 1000)
        {
            rb.velocityY = 1000;
        }
    }
}
