using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Sonido s;

    public void Cartas()
    {
        s.Boton();
        SceneManager.LoadScene("Cartas");
    }

    public void Ayuda()
    {
        s.Boton();
        SceneManager.LoadScene("Ayuda");
    }
        
    public void Opciones()
    {
        s.Boton();
        SceneManager.LoadScene("Opciones");
    }

    public void Menu()
    {
        s.Boton();
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
