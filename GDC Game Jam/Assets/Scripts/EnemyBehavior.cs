using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float velocity = 1f;
    [SerializeField] private Rigidbody2D rbody;

    public Score _score;

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(velocity * -1, rbody.velocity.y);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "shield attack")
        {
            Debug.Log("Collided");
            Destroy(gameObject);
            _score.IncrementScore(2);
        }

        if (collision.gameObject.tag == "projectile")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "city")
        {
            Destroy(gameObject);
        }

    }

}
