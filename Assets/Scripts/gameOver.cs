using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameOver : MonoBehaviour

{

    public Text gameoverText;
    public void Quit()
    {
        Debug.Log("APPLICATION QUIT!");
         Application.Quit();
    }
   
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
    }
}
