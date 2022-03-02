using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardLogic : MonoBehaviour
{
    public TMP_Text tmpl;
    public TMP_Text tmpr;
    public bool isMouseOver = false;

    private void OnMouseOver()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }

    public void InduceRight()
    {
        tmpr.text = "¡Si!";
        tmpl.text = "";
    }

    public void InduceLeft()
    {
        tmpl.text = "¡No!";
        tmpr.text = "";
    }
}
