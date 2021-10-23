using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamikazeBehavior : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float velocity;
    [SerializeField] private Animator animator;

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
        if (collision.gameObject.tag == "city")

        {
            StartCoroutine(explsnAnim(gameObject));
            
        }

        if (collision.gameObject.tag == "shield attack")

        {
            StartCoroutine(deathAnim(gameObject));
        }


    }

    IEnumerator explsnAnim(GameObject gameObject)
    {
        animator.SetBool("IsTouchingCity", true);
        Debug.Log("I boom");
        FindObjectOfType<AudioManager>().Play("EnemyDeath");
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }

    IEnumerator deathAnim(GameObject gameObject)
    {
        animator.SetBool("IsHittingShield", true);
        Debug.Log("I boom");
        FindObjectOfType<AudioManager>().Play("EnemyDeathByShield");
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }


}
