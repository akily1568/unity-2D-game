using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayController1 : MonoBehaviour
{
    public static GamePlayController1 instance; //khai báo hàm instance để truy xuất các hàm dưới dạng public

    void Awake()
    {
        MakeInstance();
    }

    void MakeInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    [SerializeField]
    private GameObject pausePanel, gameOverPanel;

    public void PauseGameButton()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeButton()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OptionsButton()
    {
        Application.LoadLevel("Menu");  
    }

    public void ReStartButton()
    {
        gameOverPanel.SetActive(false);
        Application.LoadLevel("GamePlay");
    }

    public void PlaneDiedShowPanel()
    {
        gameOverPanel.SetActive(true);
    }

}
