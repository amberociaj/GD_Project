using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Warrok : MonoBehaviour
{
    int WP = 20;
    public Slider warrokhealthBar;
    public Animator animator;

    public void TakeDamage(int damageAmount)

    {
        WP -= damageAmount;
        if (WP <= 1)
        {
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
            Destroy(gameObject,5);
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
        warrokhealthBar.value = WP;

    }
}
