using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void PlayGameButton()
    {
        Application.LoadLevel("GamePlay");
    }

    public void QuitGameButton()
    {
        Application.Quit();
    } 
}
