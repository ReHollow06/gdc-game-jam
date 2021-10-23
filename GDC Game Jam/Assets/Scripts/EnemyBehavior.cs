using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float velocity = 1f;
    [SerializeField] private Rigidbody2D rbody;
    [SerializeField] private Animator animator;

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
            StartCoroutine(deathAnim(gameObject));
 
            _score.IncrementScore(2);
        }

        if (collision.gameObject.tag == "projectile")
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "city")
        {
            StartCoroutine(explsnAnim(gameObject));

        }

    }

    IEnumerator deathAnim(GameObject gameObject)
    {
        animator.SetBool("isHitByShield", true);
        Debug.Log("I ded");
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
    }
    IEnumerator explsnAnim(GameObject gameObject)
    {
        animator.SetBool("IsTouchingCity", true);
        Debug.Log("I boom");
        yield return new WaitForSeconds(0.66f);
        Destroy(gameObject);
    }

}
