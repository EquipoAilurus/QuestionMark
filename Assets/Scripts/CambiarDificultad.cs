using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CambiarDificultad : MonoBehaviour
{
    public int dificultad;
    public string prefsDificultad;
    public Dropdown Dropdown;

    void Start()
    {
        List<string> opciones = new List<string>() {"Inocente", "Con Antecedentes", "Hitler" };
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        if (currentScene.name == "Opciones")
        {
            this.Dropdown.AddOptions(opciones);
        }
    }

    public void Selected()
    {
        if (this.Dropdown.captionText.text == "Inocente")
        {
            dificultad = 1;
        }
        else if (this.Dropdown.captionText.text == "Con Antecedentes")
        {
            dificultad = 2;
        }
        else if (this.Dropdown.captionText.text == "Hitler")
        {
            dificultad = 6;
        }
        PlayerPrefs.SetInt(prefsDificultad, dificultad);
    }

    public int LoadData()
    {
        dificultad = PlayerPrefs.GetInt(prefsDificultad, 2);
        return dificultad;
    }

}
