using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int PH = 100;
    public Slider playerhealthBar;
    public Animator animator;

    public void TakeDamage(int damageAmount)

    {
        PH -= damageAmount;
        if (PH <= 0)
        {
            animator.SetTrigger("die");
            //GetComponent<Collider>().enabled = false;
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
        playerhealthBar.value = PH;
    }
}
