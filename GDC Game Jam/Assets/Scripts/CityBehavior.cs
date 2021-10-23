using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityBehavior : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);    
        }

        if(collision.gameObject.tag == "enemy projectile")
        {
            Debug.Log("hit by projectile");
        }
    }
}
