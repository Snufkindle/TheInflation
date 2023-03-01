using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipButtonPrologue : MonoBehaviour
{
    public void Skip()
    {
        SceneManager.LoadScene("Entername");
    }

    public void GotoSkipButton()
    {
        SceneManager.LoadScene("Skip Button Group");
    }

}
