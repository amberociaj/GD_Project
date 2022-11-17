using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyfists : MonoBehaviour
{
    private Rigidbody fistsRigidBody;
    //[SerializeField] private Transform vfxHitGreen;
    //[SerializeField] private Transform vfxHitRed;
    public int damageAmount = 20;

    private void Awake()
    {
        fistsRigidBody = GetComponent<Rigidbody>();


    }

    private void Start()
    {

        //float speed = 40f;
        //fistsRigidBody.velocity = transform.forward * speed;
        //Destroy(gameObject, 5);

    }

    private void OnTriggerEnter(Collider other)
    {
        // if ( other.GetComponent<BulletTarget>() != null)
        // {
        //hit target
        //Instantiate(vfxHitGreen, transform.position, Quaternion.identity);
        // }
        // else
        // {
        //hit something else
        //Instantiate(vfxHitRed, transform.position, Quaternion.identity);
        // }
        // Destroy(gameObject);


        Destroy(transform.GetComponent<Rigidbody>());
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerHealth>().TakeDamage(damageAmount);
        }
    }
}
