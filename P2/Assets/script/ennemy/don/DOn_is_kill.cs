using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOn_is_kill : MonoBehaviour
{

    private PAPAPAPA Don;
    // Start is called before the first frame update
    void Start()
    {
        Don = GetComponentInParent<PAPAPAPA>();
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Don.gameObject.SetActive(false);
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
