using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardLogic : MonoBehaviour
{
    public TMP_Text tmp;
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
        tmp.text = "¡Si!";
    }

    public void InduceLeft()
    {
        tmp.text = "¡No!";
    }
}
