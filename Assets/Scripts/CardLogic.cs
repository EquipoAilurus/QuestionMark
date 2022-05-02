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
            tmpr.text = "Caca";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 2)
        {
            tmpr.text = "Macedonia";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 3)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 4)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 5)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 6)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 7)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 8)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 9)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }

        else if (gl.pregunta == 10) //Científico
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 11)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 12)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }

        else if (gl.pregunta == 13) //Cura
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 14)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 15)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 16)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 17)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 18)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 19)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 20)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
        else if (gl.pregunta == 21)
        {
            tmpr.text = "¡Si!";
            tmpl.text = "";
            vc = 100;
            vf = 10;
        }
    }

    public void InduceLeft()
    {
        if (gl.pregunta == 1) //Detective
        {
            tmpl.text = "Sacacorchos";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 2)
        {
            tmpl.text = "Muteado";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 3)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 4)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 5)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 6)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 7)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 8)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 9)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }

        else if (gl.pregunta == 10) //Científico
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 11)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 12)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }

        else if (gl.pregunta == 13) //Cura
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 14)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 15)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 16)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 17)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 18)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 19)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 20)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
        else if (gl.pregunta == 21)
        {
            tmpl.text = "¡No!";
            tmpr.text = "";
            vc = -100;
            vf = -10;
        }
    }
}
