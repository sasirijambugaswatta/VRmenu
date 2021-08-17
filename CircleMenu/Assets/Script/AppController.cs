using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppController : MonoBehaviour
{
    public GameObject InfoPanel;
    private bool show = false;

    public void ShowInfo()
    {
        if (!show)
        {
            InfoPanel.SetActive(true);
            show = true;
        }
        else
        {
            InfoPanel.SetActive(false);
            show = false;
        }
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
