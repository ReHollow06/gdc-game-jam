using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    [SerializeField] private GameObject objects;
    [SerializeField] private float spawnRate = 2f;
    private int spawn;
    private float nextSpawn = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            Location();
            Instantiate(objects, transform.position, Quaternion.identity);

        }
    }

    void Location()
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
}
