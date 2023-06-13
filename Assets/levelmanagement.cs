using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelmanagement : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Panel2;

    public void StartGame()
    {
        Panel1.SetActive(true);

    }

    public void CloseChooseLevel()
    {
        Panel1.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartCredit()
    {
        Panel2.SetActive(true);
    }

    public void CloseStartCredit()
    {
        Panel2.SetActive(false);
    }

}
