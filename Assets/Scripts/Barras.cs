using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barras : MonoBehaviour
{
    public Image barra;
    public float longitudActual;
    public float longitudMaxima;
    public GameLogic gl;
    public int valor;

    void Update()
    {
        Debug.Log(gl.pregunta);
        if (valor != gl.pregunta)
        {
            longitudActual += Random.Range(-200,200);
            valor = gl.pregunta;
        }
        if (longitudActual >longitudMaxima)
        {
            longitudActual = 1000;
        }
        if (longitudActual < 0)
        {
            longitudActual = 0;
        }
        barra.fillAmount = longitudActual / longitudMaxima;
    }
}
