using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour
{
    [SerializeField]
    Slider healthBar;
    [SerializeField]
    Text healthText;
    public Button restartButton;
    public Button quitButton;
    public GameObject gameOverText;



    float maxHealth = 3;
    float curHealth;

     void Start()
    {
        healthBar.value = maxHealth;
        curHealth = healthBar.value;
    }
     void Update()
    {
        if (healthBar.value <= 0)
        {
        
            Destroy(gameObject);
            gameOverText.gameObject.SetActive(true);

            restartButton.gameObject.SetActive(true);
            quitButton.gameObject.SetActive(true);
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bomb")
        {
            healthBar.value -=.20f;
            curHealth = healthBar.value;
        }
        else if(collision.gameObject.tag == "Life")
        {
            healthBar.value += .20f;
            curHealth = healthBar.value;
        }
        
    }
    


}
