using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CardLogic : MonoBehaviour
{
    public TMP_Text tmpl;
    public TMP_Text tmpr;
    public bool isMouseOver = false;
    public int vc;
    public int vf;
    public GameLogic gl;

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
        if (gl.pregunta == 1) //Detective
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 50;
            vf = 0;
        }
        else if (gl.pregunta == 2)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 0;
            vf = -10;
        }
        else if (gl.pregunta == 3)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 100;
            vf = 0;
        }
        else if (gl.pregunta == 4)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = -50;
            vf = 10;
        }
        else if (gl.pregunta == 5)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 50;
            vf = -10;
        }
        else if (gl.pregunta == 6)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = -50;
            vf = 10;
        }
        else if (gl.pregunta == 7)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 150;
            vf = 10;
        }
        else if (gl.pregunta == 8)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 50;
            vf = 0;
        }
        else if (gl.pregunta == 9)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 50;
            vf = 0;
        }
        else if (gl.pregunta == 10)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 150;
            vf = 0;
        }
        else if (gl.pregunta == 11)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 100;
            vf = 20;
        }
        else if (gl.pregunta == 12)
        {
            tmpr.text = "Será otra persona.";
            tmpl.text = "";
            vc = 0;
            vf = -10;
        }
        else if (gl.pregunta == 13)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 0;
            vf = 15;
        }
        else if (gl.pregunta == 14)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 999;
            vf = 0;
        }
        else if (gl.pregunta == 15)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 0;
            vf = 15;
        }
        else if (gl.pregunta == 16) //Cura
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = -50;
            vf = 10;
        }
        else if (gl.pregunta == 17)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = -50;
            vf = 10;
        }
        else if (gl.pregunta == 18)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = -50;
            vf = 10;
        }
        else if (gl.pregunta == 19)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = -50;
            vf = 10;
        }
        else if (gl.pregunta == 20)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = -50;
            vf = 10;
        }
        else if (gl.pregunta == 21)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = -50;
            vf = 10;
        }
        else if (gl.pregunta == 22)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = -50;
            vf = 10;
        }
        else if (gl.pregunta == 23)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 50;
            vf = 10;
        }
        else if (gl.pregunta == 24)
        {
            tmpr.text = "Sí, padre.";
            tmpl.text = "";
            vc = 999;
            vf = 0;
        }
        else if (gl.pregunta == 25)
        {
            tmpr.text = "...que estás en los cielos.";
            tmpl.text = "";
            vc = -50;
            vf = 15;
        }
        else if (gl.pregunta == 26)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 999;
            vf = 0;
        }
        else if (gl.pregunta == 27)
        {
            tmpr.text = "¿6?";
            tmpl.text = "";
            vc = 150;
            vf = -15;
        }
        else if (gl.pregunta == 28)//Científico
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 150;
            vf = 0;
        }
        else if (gl.pregunta == 29)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 50;
            vf = 10;
        }
        else if (gl.pregunta == 30)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 100;
            vf = 15;
        }
        else if (gl.pregunta == 31)
        {
            tmpr.text = "Debe ser un error.";
            tmpl.text = "";
            vc = 0;
            vf = 10;
        }
        else if (gl.pregunta == 32)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 50;
            vf = 0;
        }
        else if (gl.pregunta == 33)
        {
            tmpr.text = "Evidentemente.";
            tmpl.text = "";
            vc = 0;
            vf = -15;
        }
        else if (gl.pregunta == 34)
        {
            tmpr.text = "Por favor, habla bien.";
            tmpl.text = "";
            vc = 0;
            vf = 10;
        }
        else if (gl.pregunta == 35)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 100;
            vf = -15;
        }
        else if (gl.pregunta == 36)
        {
            tmpr.text = "Rojo.";
            tmpl.text = "";
            vc = 100;
            vf = 0;
        }
        else if (gl.pregunta == 37)
        {
            tmpr.text = "Sí.";
            tmpl.text = "";
            vc = 0;
            vf = 15;
        }
    }

    public void InduceLeft()
    {
        if (gl.pregunta == 1) //Detective
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 0;
            vf = -10;
        }
        else if (gl.pregunta == 2)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 0;
            vf = 0;
        }
        else if (gl.pregunta == 3)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 0;
            vf = 0;
        }
        else if (gl.pregunta == 4)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 100;
            vf = -15;
        }
        else if (gl.pregunta == 5)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = -50;
            vf = 15;
        }
        else if (gl.pregunta == 6)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 100;
            vf = -15;
        }
        else if (gl.pregunta == 7)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 0;
            vf = 0;
        }
        else if (gl.pregunta == 8)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 0;
            vf = -20;
        }
        else if (gl.pregunta == 9)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 0;
            vf = -20;
        }
        else if (gl.pregunta == 10)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = -150;
            vf = 0;
        }
        else if (gl.pregunta == 11)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = -50;
            vf = 0;
        }
        else if (gl.pregunta == 12)
        {
            tmpl.text = "Mienten.";
            tmpr.text = "";
            vc = 50;
            vf = -15;
        }
        else if (gl.pregunta == 13)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 0;
            vf = -10;
        }
        else if (gl.pregunta == 14)
        {
            tmpl.text = "¿Qué?";
            tmpr.text = "";
            vc = 0;
            vf = 0;
        }
        else if (gl.pregunta == 15)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = -100;
            vf = 15;
        }
        else if (gl.pregunta == 16)//Cura
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 150;
            vf = -15;
        }
        else if (gl.pregunta == 17)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 150;
            vf = -15;
        }
        else if (gl.pregunta == 18)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 150;
            vf = -15;
        }
        else if (gl.pregunta == 19)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 150;
            vf = -15;
        }
        else if (gl.pregunta == 20)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 150;
            vf = -15;
        }
        else if (gl.pregunta == 21)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 150;
            vf = -15;
        }
        else if (gl.pregunta == 22)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 150;
            vf = -15;
        }
        else if (gl.pregunta == 23)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = -150;
            vf = -15;
        }
        else if (gl.pregunta == 24)
        {
            tmpl.text = "No soy culpable.";
            tmpr.text = "";
            vc = -50;
            vf = 0;
        }
        else if (gl.pregunta == 25)
        {
            tmpl.text = "...dale a tu cuerpo alegría macarena.";
            tmpr.text = "";
            vc = 250;
            vf = -20;
        }
        else if (gl.pregunta == 26)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 50;
            vf = 15;
        }
        else if (gl.pregunta == 27)
        {
            tmpl.text = "7";
            tmpr.text = "";
            vc = -50;
            vf = -10;
        }
        else if (gl.pregunta == 28)//Científico
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 200;
            vf = -15;
        }
        else if (gl.pregunta == 29)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 0;
            vf = -10;
        }
        else if (gl.pregunta == 30)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 0;
            vf = 10;
        }
        else if (gl.pregunta == 31)
        {
            tmpl.text = "waBleWAblE dAbdaB";
            tmpr.text = "";
            vc = 200;
            vf = -20;
        }
        else if (gl.pregunta == 32)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 0;
            vf = 10;
        }
        else if (gl.pregunta == 33)
        {
            tmpl.text = "¿Qué?";
            tmpr.text = "";
            vc = 0;
            vf = 0;
        }
        else if (gl.pregunta == 34)
        {
            tmpl.text = "*Sacar un porro*";
            tmpr.text = "";
            vc = 250;
            vf = -25;
        }
        else if (gl.pregunta == 35)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 0;
            vf = 10;
        }
        else if (gl.pregunta == 36)
        {
            tmpl.text = "Azul.";
            tmpr.text = "";
            vc = 0;
            vf = 15;
        }
        else if (gl.pregunta == 37)
        {
            tmpl.text = "No.";
            tmpr.text = "";
            vc = 0;
            vf = -15;
        }
    }
}
