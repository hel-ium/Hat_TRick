using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class scoredecrese: MonoBehaviour
{

    public int  score;
    public Text scoreText;


    void Update()
    {
        scoreText.text = score.ToString();

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
        else if(target.tag =="bg")
        {
            score--;
        }
    }
}
