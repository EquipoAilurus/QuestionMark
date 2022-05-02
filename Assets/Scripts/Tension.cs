using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tension : MonoBehaviour
{
    public Image barra;
    public float longitudActual;
    public float longitudMaxima;
    public MainMenu mm;
    public CambiarDificultad cd;
    public int aux;
    
    void Start()
    {
        aux = cd.LoadData();
    }

    void Update()
    {
        barra.fillAmount = longitudActual / longitudMaxima;
        longitudActual -= aux * Time.deltaTime;
        if (longitudActual <= 0)
        {
            mm.Perder();
        }
    }
}
