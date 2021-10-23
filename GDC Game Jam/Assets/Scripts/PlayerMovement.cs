using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private bool isMoving;
    private Vector3 currentPos, targetPos;
    [SerializeField] private float moveTime = 0.05f;
    [SerializeField] private int maxDistance = 3;
    [SerializeField] private Animator animator;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        animator.SetBool("isMoving", false);
        if (Input.GetKeyDown("w") && !isMoving)
        {
            if (transform.position.y < maxDistance)
            {
                StartCoroutine(MovePlayer(new Vector3(0, maxDistance, 0)));
            }
                
        }

        if (Input.GetKeyDown("s") && !isMoving)
        {
            if (transform.position.y > -maxDistance)
            {
                StartCoroutine(MovePlayer(new Vector3(0, -maxDistance, 0)));
            }
            
        }


    }



    private IEnumerator MovePlayer(Vector3 direction)
    {
        isMoving = true;

        float elapsedTime = 0;

        currentPos = transform.position;
        targetPos = currentPos + direction;

        while (elapsedTime < moveTime)
        {
            transform.position = Vector3.Lerp(currentPos, targetPos, elapsedTime / moveTime);
            elapsedTime += Time.deltaTime;
            animator.SetBool("isMoving", true);

            yield return null;
        }

        transform.position = targetPos;
        animator.SetBool("isMoving", false);

        isMoving = false;

    }




}
