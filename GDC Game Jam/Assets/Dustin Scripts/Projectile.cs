using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float velocity = 1f;
    [SerializeField] Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new 
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocity * -1, rb.velocity.y);
    }
}
