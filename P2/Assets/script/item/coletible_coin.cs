using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coletible_coin : MonoBehaviour
{

    private comptagepiece _Cp;
    // Start is called before the first frame update
    void Start()
    {
        _Cp = GetComponentInParent<comptagepiece>();
    }
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.gameObject.SetActive(false);
            Debug.Log("piece coletcted");
            _Cp.CoinCollected();
        }
    }
    
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
