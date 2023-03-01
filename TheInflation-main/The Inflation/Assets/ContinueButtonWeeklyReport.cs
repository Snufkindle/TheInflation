using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class ContinueButtonWeeklyReport : MonoBehaviour
{
    public void Skip()
    {
            SceneManager.LoadScene("Week2");
    }

    public void GotoSkipButton()
    {
        SceneManager.LoadScene("Skip Button Group");
    }

}
