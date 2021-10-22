using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    [SerializeField] private GameObject shield;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Jump"))
        {
            shield.tag = "shield attack";
        }
        else
        {
            shield.tag = "shield";
        }


    }
}
