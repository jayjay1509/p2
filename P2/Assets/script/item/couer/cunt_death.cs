using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cunt_death : MonoBehaviour
{
    private Animator _life1;
    private Animator _life2;
    private Animator _life3;
    public int deaht;
    [SerializeField] private GameObject you_death;
    
    
    // Start is called before the first frame update
    void Start()
    {
        you_death.SetActive(false);
        // Obtenez tous les composants Animator enfants
        Animator[] enfantsAnimators = GetComponentsInChildren<Animator>();
        

        // Parcourez chaque composant Animator trouvé
        foreach (Animator animator in enfantsAnimators)
        {
            // Identifiez l'enfant en fonction de certains critères (par exemple, le nom)
            if (animator.gameObject.name == "life_1")
            {
                // Liez l'Animator au bon objet de jeu
                _life1 = animator;
            }
            else if (animator.gameObject.name == "life_2")
            {
                // Liez l'Animator au bon objet de jeu
                _life2 = animator;
            }
            else if (animator.gameObject.name == "life_3")
            {
                // Liez l'Animator au bon objet de jeu
                _life3 = animator;
            }
            
        }
    }
    public void deaht_count()
    {
        deaht++;
    }

    // Update is called once per frame
    void Update()
    {
        if (deaht == 1 )
        {
            _life1.SetTrigger("life_1");
        }
        
        if (deaht == 2 )
        {
            _life2.SetTrigger("life_2");
        }
        
        if (deaht == 3 )
        {
            _life3.SetTrigger("life_3");
            you_death.SetActive(true);
            
        }
        
    }
}
