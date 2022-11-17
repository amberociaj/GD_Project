using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gainhealth : MonoBehaviour
{
    public int healing;
    PlayerHealth playerhealth;

    private void OnTriggerEnter(Collider other)
    {
       if(other.transform.tag == "Player" )
        {
            other.transform.GetComponent<PlayerHealth>().GainHealth(healing);
            Destroy(this.gameObject);
        }
    }
}
