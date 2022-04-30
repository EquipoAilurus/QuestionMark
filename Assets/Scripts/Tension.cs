using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tension : MonoBehaviour
{
    public Image barra;
    public float longitudActual;
    public float longitudMaxima;

    void Update()
    {
        barra.fillAmount = longitudActual / longitudMaxima;
        longitudActual -= 3*Time.deltaTime;
        if (longitudActual<=0)
        {
            Debug.Log("PERDISTE putito");
        }
    }
}
