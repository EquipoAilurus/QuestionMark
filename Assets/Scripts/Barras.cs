using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barras : MonoBehaviour
{
    public Image barraOtra;
    public Image barraFiabilidad;
    public Image barraCulpabilidad;
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
        barraFiabilidad.fillAmount = longitudActual / longitudMaxima;
        barraOtra.fillAmount = (longitudActual / longitudMaxima) / 3;
        barraCulpabilidad.fillAmount = (longitudActual / longitudMaxima) / 2;

    }
}
