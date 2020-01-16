using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTooLow();
    }

    public void Explode()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddExplosionForce(10,new Vector3(0,0,0),100, 0, ForceMode.Impulse );
    }

    void CheckIfTooLow()
    {
        if (transform.position.y < -25)
        {
            transform.position = new Vector3(0,10,0);
        }
    }
}
