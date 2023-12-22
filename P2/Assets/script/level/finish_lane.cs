using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish_lane : MonoBehaviour
{

    public bool is_finhis;
    [SerializeField] private GameObject finishGO_;
    
    void Start()
    {
        finishGO_.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            is_finhis = true;
            finishGO_.SetActive(is_finhis);
            Debug.Log("tu a fini");
        }
        
    }
}
