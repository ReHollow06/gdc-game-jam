using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    [SerializeField] private float velocity = 1f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject kamikazePrefab;
    public Score _score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocity * -1, rb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "shield" || collision.gameObject.tag == "shield attack")

        {
            Destroy(gameObject);
            Score.scoreValue += 10;
        }

        if (collision.gameObject.tag == "city")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);

            Vector2 currentPos = transform.position;

            GameObject newKamikaze = Instantiate(kamikazePrefab);

            newKamikaze.transform.position = currentPos;

        }


    }
}
