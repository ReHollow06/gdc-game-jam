using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float velocity = 1f;
    [SerializeField] Rigidbody2D rb;
    private int spawn;

    // Start is called before the first frame update
    void Start()
    {
        spawn = Random.Range(1, 4);
        if (spawn == 1)
        {
            transform.position = new Vector2(10f, 4f);
        }
        else if (spawn == 2)
        {
            transform.position = new Vector2(10f, 0f);
        }
        else
        {
            transform.position = new Vector2(10f, -4f);
        }

    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocity * -1, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag =="city")
        {
            Destroy(gameObject);
        }
    }

}
