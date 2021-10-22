using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private bool isMoving;
    private Vector3 currentPos, targetPos;
    [SerializeField] private float moveTime = 0.05f;
    [SerializeField] private bool atEdge;
    [SerializeField] private int maxDistance = 4;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Input.GetKeyDown("w") && !isMoving)
        {
            if (transform.position.y < maxDistance)
            {
                StartCoroutine(MovePlayer(Vector3.up * 4));
            }
                
        }

        if (Input.GetKeyDown("s") && !isMoving)
        {
            if (transform.position.y > -maxDistance)
            {
                StartCoroutine(MovePlayer(Vector3.down * 4));
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
            yield return null;
        }

        transform.position = targetPos;
        isMoving = false;

    }




}
