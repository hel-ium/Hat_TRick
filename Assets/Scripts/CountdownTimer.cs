using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float timeStart = 10;
    public Text textBox;
    public Text timerText;
    public Text gameovertext;
    public Button restartbutton;
    public Button quitButton;
    public GameObject hat;
    private bool playing;
    void Start()
 {
        playing = false;
    textBox.text = timeStart.ToString();
 }
    private void Update()
    {
      
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();
        if (timeStart <= 0f)
        {
        
            Destroy(hat.gameObject);
            timerText.gameObject.SetActive(false);
            gameovertext.gameObject.SetActive(true);
            restartbutton.gameObject.SetActive(true);
            quitButton.gameObject.SetActive(true);
        }
    }
}
