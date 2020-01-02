using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitDestroyer : MonoBehaviour
{

    public int  score;
    // Start is called before the first frame updat

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Fruit")
        {
    
            Destroy(target.gameObject);
            score += 2;
        }
        else if (target.tag == "coin")
        {

            Destroy(target.gameObject);
            score = score + 5;
        }
        else if (target.tag == "Life")
        {
 
            Destroy(target.gameObject);
        }
        else if (target.tag == "Bomb")
        {
            Destroy(target.gameObject);
        }
    }
}
