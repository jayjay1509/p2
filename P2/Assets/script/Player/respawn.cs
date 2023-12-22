using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    public Vector3 respawn_;
    public Transform start_postion;
    public Transform player_postion;
    public Transform win_postion;
    public Transform death_postion;
    private cunt_death _resp;
    private Rigidbody2D _rb;
    private SpriteRenderer _sp;
    private finish_lane _fl;

    private Dead _dd;
    // Start is called before the first frame update
    void Start()
    {
        
        respawn_ = start_postion.position;
        _dd = GetComponentInChildren<Dead>();
        _resp = FindObjectOfType<cunt_death>();
        _rb = GetComponent<Rigidbody2D>();
        _sp = GetComponent<SpriteRenderer>();
        _fl = FindObjectOfType<finish_lane>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_dd.is_dead)
        {
            _dd.is_dead = false;
            _resp.deaht_count();
            player_postion.transform.position = respawn_;
            Debug.Log("tu es teleporte par ce que tu est mort ");
        }

        if (_resp.deaht == 3)
        {
            //player_postion.transform.position = death_postion.position;
            this.gameObject.SetActive(false);
            
        }

        if (_fl.is_finhis)
        {
           // player_postion.transform.position = win_postion.position;
            this.gameObject.SetActive(false);
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
