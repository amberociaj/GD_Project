using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullletProjectile : MonoBehaviour
{
    private Rigidbody bulletRigidBody;
    [SerializeField] private Transform vfxHitGreen;
    [SerializeField] private Transform vfxHitRed;

    private void Awake()
    {
        bulletRigidBody = GetComponent<Rigidbody>();

    }

    private void Start()
    {
        float speed = 40f;
        bulletRigidBody.velocity = transform.forward * speed;

    }

    private void OnTriggerEnter(Collider other)
    {
        if ( other.GetComponent<BulletTarget>() != null)
        {
            //hit target
            //Instantiate(vfxHitGreen, transform.position, Quaternion.identity);
        }
        else
        {
            //hit something else
            //Instantiate(vfxHitRed, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
    }
}
