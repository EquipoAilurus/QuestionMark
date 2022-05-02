using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Cartas()
    {
        SceneManager.LoadScene("Cartas");
    }

    public void Ayuda()
    {
        SceneManager.LoadScene("Ayuda");
    }
        
    public void Opciones()
    {
        SceneManager.LoadScene("Opciones");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Perder()
    {
        SceneManager.LoadScene("Perder");
    }

    public void Ganar()
    {
        SceneManager.LoadScene("Ganar");
    }
}
