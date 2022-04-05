using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barras : MonoBehaviour
{
    public Image barra;
    public float longitudActual;
    public float longitudMaxima;
    public bool cambioBarras;

    // Update is called once per frame
    void Update()
    {
        GameLogic variable = GetComponent<GameLogic>();
        cambioBarras = variable.cambio;

        if (cambioBarras == true)
        {
            longitudActual += Random.Range(-200,200);
            cambio = false;
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
