using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    [SerializeField] private GameObject shield;
    [SerializeField] private float attackTime;
    [SerializeField] private Animator animator;

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
        animator.SetBool("isAttacking", true);
        yield return new WaitForSeconds(attackTime);
        animator.SetBool("isAttacking", false);
        shield.tag = "shield";
    }

}
