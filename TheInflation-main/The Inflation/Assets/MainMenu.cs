using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Playgame ()
    {
        SceneManager.LoadScene("Prologue");
    }

    public void GotoSettingsMenu()
    {
        SceneManager.LoadScene("SettingsMenu");
    }

    public void GotoMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Quitgame ()
    {
        Application.Quit();
    }
}
