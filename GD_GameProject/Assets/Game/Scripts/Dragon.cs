using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dragon : MonoBehaviour
{
    public int HP = 100;
    public Slider healthBar;
    public Animator animator;

    public void TakeDamage (int damageAmount)

    {
        HP -= damageAmount;
        if( HP <= 0)
        {
            animator.SetTrigger("die");
            
            GetComponent<Collider>().enabled = false;
        }
        else
        {
            animator.SetTrigger("damage");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = HP;
        
    }
}
