using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Warrok : MonoBehaviour
{
    public int WP = 100;
    public Slider warrokhealthBar;
    public Animator animator;

    public void TakeDamage(int damageAmount)

    {
        WP -= damageAmount;
        if (WP <= 0)
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
        warrokhealthBar.value = WP;

    }
}
