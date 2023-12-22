using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{

    private respawn _rpn;
    private Animator _anim;
    private AudioSource _audio;
    
    // Start is called before the first frame update
    void Start()
    {
        _rpn = GetComponent<respawn>();
        _anim = GetComponent<Animator>();
        _audio = GetComponent<AudioSource>();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //_rpn.respawn_ = this.transform.position;
            _anim.SetTrigger("dra_active");
            _audio.Play();

        }
        
    }
    
}
