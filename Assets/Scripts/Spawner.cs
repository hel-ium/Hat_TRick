using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] fruits;
    public GameObject bomb;
    public GameObject coin;
    public GameObject Life;
    private bool playing;
    public float xBounds, yBounds;
 
    void Start()
    {
        playing = false;
        StartCoroutine(SpawnRandomGameObject());
    }
    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(2, 3));
        playing = true;
        int randomFruit = Random.Range(0, fruits.Length);

        if (Random.value <= .8f)
            Instantiate(fruits[randomFruit], new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity);
        else if (Random.value <= .4f)
            Instantiate(coin, new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity);
        else if (Random.value <= .2f)
            Instantiate(Life, new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity);
        else
            Instantiate(bomb, new Vector2(Random.Range(-xBounds, xBounds), yBounds), Quaternion.identity);

        StartCoroutine(SpawnRandomGameObject());
    }
}
