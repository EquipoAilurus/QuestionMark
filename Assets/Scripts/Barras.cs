using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barras : MonoBehaviour
{
    public Image barra;
    public float longitudActual;
    public float longitudMaxima;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("right"))
        {
            longitudActual += Random.Range(10,200);
        }
        if (Input.GetKeyDown("left"))
        {
            longitudActual -= Random.Range(10, 200);
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
