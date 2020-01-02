using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public GameObject hat;
    public Text highscore;
    public GameObject gameOverText;
    public Text timerText;
    public Text gameovertext;
    public Button restartButton;
    public Button quitButton;
    public GameObject splashscreen;
    public GameObject startbutton;
    private bool playing;
    public GameObject LevelUpText;
    public GameObject SpwanerStop;
    public GameObject pausemenu;
    public GameObject menu;
    public GameObject quit;
    public static bool GameIsPaused = false;


    public void StartGame()
    {
        splashscreen.SetActive(false);
        startbutton.SetActive(false);

    }
    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
        
    }
   
    public void Pause()
    {
        
        Time.timeScale = 0;
        GameIsPaused = true;

    }

   

    void Update()
    {
        scoreText.text = score.ToString();
         if(score > PlayerPrefs.GetInt("highscore",0))
        {
            PlayerPrefs.SetInt("highscore", score);
            highscore.text = score.ToString();
        }

    }
    
    void OnTriggerExit2D(Collider2D target)
    
    {
        if (target.tag == "Fruit")
        {
            FindObjectOfType<AudioManager>().Play("fruitsound");
            Destroy(target.gameObject);
            score+=2;
        }
        else if (target.tag == "coin")
        {
            FindObjectOfType<AudioManager>().Play("lnc");
            Destroy(target.gameObject);
            score = score + 5;
        }
        else if (target.tag == "Life")
        {
            FindObjectOfType<AudioManager>().Play("lnc");
            Destroy(target.gameObject);
        }
        else if (target.tag == "Bomb")
        {
            FindObjectOfType<AudioManager>().Play("bombsound");
            Destroy(target.gameObject);
        }
      
       
        if(score>=30)
        {
            pausemenu.SetActive(false);
            quit.SetActive(false);
            menu.SetActive(false);
            SpwanerStop.SetActive(false);
            LevelUpText.SetActive(true);
           
           
            
            Destroy(hat.gameObject);





        }
       


    }
    


}
