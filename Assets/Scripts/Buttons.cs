using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void ToFoodMenu()
    {
        SceneManager.LoadScene("FoodMenuScene");
    }

    public void ToSettings()
    {
        SceneManager.LoadScene("SettingsScene");
    }

    public void ToHelp()
    {
        SceneManager.LoadScene("HelpScene");
    }
}
