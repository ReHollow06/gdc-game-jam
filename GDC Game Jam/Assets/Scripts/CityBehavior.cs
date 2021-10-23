using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityBehavior : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Debug.Log("Hit by enemy");
        }

        if(collision.gameObject.tag == "EnemyProjectile")
        {
            Debug.Log("hit by projectile");
            // needs to damage the city
        }
    }
}
