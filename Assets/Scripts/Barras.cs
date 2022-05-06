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
    public CardLogic cl;
    public Fiabilidad f;
    public MainMenu mm;
    public int valor;

    void Update()
    {
        
        if(gl.pregunta > 21 && longitudActual >= 750)
        {
            mm.Ganar();
        }
        else if(gl.pregunta > 21)
        {
            mm.Perder();
        }

        if(gl.pregunta == 1)
        {
            longitudActual = 500;
        }
        else if (valor != gl.pregunta)
        {
            longitudActual -= (cl.vc * (f.longitudActual / 100)) + cl.vc;
            valor = gl.pregunta;
        }

        if (longitudActual >= 1000)
        {
            mm.Ganar();
        }

        if (longitudActual <= 0)
        {
            mm.Perder();
        }

        barra.fillAmount = longitudActual / longitudMaxima;
    }
}
