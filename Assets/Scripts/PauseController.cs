using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject PausePanel;
    public void PauseGame()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ResumeGame()
    {
        PausePanel.SetActive(false);
        Time.timeScale = -1f;
    }
}
