using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public Vector3 respawn_;
    public Transform start_postion;
    public Transform player_postion;

    private Dead _dd;
    // Start is called before the first frame update
    void Start()
    {
        
        respawn_ = start_postion.position;
        _dd = GetComponentInChildren<Dead>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_dd.is_dead)
        {
            _dd.is_dead = false;
            player_postion.transform.position = respawn_;
            Debug.Log("tu es teleporte par ce que tu est mort ");
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("check"))
        {
            respawn_ = other.transform.position;
            Debug.Log("nouvelle postioon ");
        }
        
    }
    
    
}
