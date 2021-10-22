using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float velocity = 1f;
    [SerializeField] Rigidbody2D rbody;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(velocity * -1, rbody.velocity.y);

    }
}
