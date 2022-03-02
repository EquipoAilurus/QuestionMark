using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barras : MonoBehaviour
{
    public Image barraCulpabilidad;
    public Image barraFiabilidad;
    public Image barraTension;
    public float longitudActual;
    public float longitudMaxima;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right"))
        {
            longitudActual++;
        }
        if (Input.GetKey("left"))
        {
            longitudActual--;
        }
        barraCulpabilidad.fillAmount = longitudActual / longitudMaxima;
        barraFiabilidad.fillAmount = (longitudActual / longitudMaxima) / 3;
        barraTension.fillAmount = (longitudActual / longitudMaxima) / 2;

    }
}
