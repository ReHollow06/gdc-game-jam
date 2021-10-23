using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    private Vector2 screenBounds; 
    //[SerializeField] private int timerLowBound = 6;
    //[SerializeField] private int timerHighBound = 9;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(enemyWave());
    }

    // Update is called once per frame
    void Update()
    {

    
    }

    private void SpawnNewEnemy()
    {
        GameObject newEnemy = Instantiate(enemyPrefab) as GameObject;
        int yRange = 3 * Random.Range(-1, 2);

        newEnemy.transform.position = new Vector2(screenBounds.x, (1/2 * screenBounds.y) + yRange);
    }

    IEnumerator enemyWave()
    {
        while (true)
        {
            int respawnTime = Random.Range(6,10);
            yield return new WaitForSeconds(respawnTime);
            SpawnNewEnemy();
        }
    }
}
