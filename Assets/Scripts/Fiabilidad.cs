using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fiabilidad : MonoBehaviour
{
    public Image barra;
    public float longitudActual;
    public float longitudMaxima;
    public CardLogic cl;
    public GameLogic gl;
    public int valor;

    void Update()
    {
        barra.fillAmount = longitudActual / longitudMaxima;

        if (gl.pregunta == 1)
        {
            longitudActual = 50;
        }
        else if (valor != gl.pregunta)
        {
            longitudActual += cl.vf;
            valor = gl.pregunta;
        }

        if (longitudActual > longitudMaxima)
        {
            longitudActual = 100;
        }

        if (longitudActual < 0)
        {
            longitudActual = 0;
        }
        
    }
}
