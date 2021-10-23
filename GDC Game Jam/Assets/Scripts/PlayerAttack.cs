using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    [SerializeField] private GameObject shield;
    [SerializeField] private float attackTime;

    private void Start()
    {
        shield.tag = "shield";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            StartCoroutine(ShieldAttack());
        }

    }

    IEnumerator ShieldAttack()
    {
        shield.tag = "shield attack";

        yield return new WaitForSeconds(attackTime);
        
        shield.tag = "shield";
    }

}
