using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    // VARIABLES GLOBALES
    public GameObject card;
    public CardLogic cl;
    public Tension t;
    public Fiabilidad f;
    public Sonido s;

    // VARIABLES LOCALES
    SpriteRenderer sr;

    public float fMovingSpeed;

    public TMP_Text preguntas;

    public int pregunta = 0;
    public bool soltado = true;

    public SpriteRenderer spriteActual;
    public Sprite cientifico;
    public Sprite cura;
    public Sprite detective;
    public Sprite cientificofia;
    public Sprite curafia;
    public Sprite detectivefia;




    // START
    void Start()
    {
        sr = card.GetComponent<SpriteRenderer>();
        soltado = true;
    }

    // UPDATE
    void Update()
    {
        DetectiveFia();
        CientificoFia();
        CuraFia();
        if (Input.GetMouseButton(0) && cl.isMouseOver)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            card.transform.position = pos;
        }
        else
        {
            card.transform.position = Vector2.MoveTowards(card.transform.position, new Vector2(0, 0), fMovingSpeed*Time.deltaTime);
        }

        if (card.transform.position.x > 2)
        {
            cl.InduceRight();
            sr.color = Color.green;
            if (Input.GetMouseButtonUp(0))
            {
                s.Carta();
                soltado = true;
            }
        }
        else if (card.transform.position.x < -2)
        {
            cl.InduceLeft();
            sr.color = Color.red;
            if (Input.GetMouseButtonUp(0))
            {
                s.Carta();
                soltado = true;
            }
        }
        else
        {
            sr.color = Color.white;
        }

        if (soltado == true)
        {
            if (pregunta == 0) //Detective
            {
                t.longitudActual = 60;
                preguntas.text = "¿Conocías a la víctima?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 1)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Hay algún conocido común?";
                pregunta++;
                soltado = false;
            }
            else if (pregunta == 2)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Sueles frecuentar bares de noche?";
                pregunta++;
                soltado = false;
            }
            else if (pregunta == 3)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Alguien puede corraborar tu coartada?";
                pregunta++;
                soltado = false;
            }
            else if (pregunta == 4)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Estabas solo la noche del crimen?";
                pregunta++;
                soltado = false;
            }
            else if (pregunta == 5)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Fuiste al trabajo la noche del 23?";
                pregunta++;
                soltado = false;
            }
            else if (pregunta == 6)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Tienes antecedentes?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 7)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Te sorprende ser sospechoso?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 8)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Estás nervioso?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 9)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Tienes licencia de armas?";
                soltado = false;
                pregunta++;
            }

            else if (pregunta == 10) //Científico
            {
                t.longitudActual = 60;
                CambioCientifico();
                preguntas.text = "¿Te someterías al suero de la verdad?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 11)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Eres conscinete de que se ha encontrado tu ADN en la escena del crimen?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 12)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Sueles consumir estupefacientes?";
                soltado = false;
                pregunta++;
            }

            else if (pregunta == 13) //Cura
            {
                t.longitudActual = 60;
                CambioCura();
                preguntas.text = "¿Aceptas la palabra de Dios?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 14)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Te arrepientes de tus pecados?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 15)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Vas los domingos a misa?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 16)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Sueles rezar?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 17)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Has leído la biblia?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 18)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Consideras que tus pecados son perdonables?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 19)
            {
                t.longitudActual = 60;
                preguntas.text = "Hijo, ¿te confesarás conmigo?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 20)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Alguna vez dudaste?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 21)
            {
                t.longitudActual = 60;
                preguntas.text = "Coco https://youtu.be/mCdA4bJAGGk"; 
                soltado = false;
                pregunta++;
            }
        }
    }

    void CambioDetective()
    {
        spriteActual.sprite = detective;
    }

    void CambioCientifico()
    {
        spriteActual.sprite = cientifico;
    }

    void CambioCura()
    {
        spriteActual.sprite = cura;
    }

    void DetectiveFia()
    {
        if (pregunta < 10 && f.longitudActual < 50)
        {
            spriteActual.sprite = detectivefia;
        }
        else if (pregunta < 10 && f.longitudActual >= 50)
        {
            spriteActual.sprite = detective;
        }
    }

    void CientificoFia()
    {
        if (pregunta >= 10 && pregunta < 13 && f.longitudActual < 50)
        {
            spriteActual.sprite = cientificofia;
        }
        else if (pregunta >= 10 && pregunta < 13 && f.longitudActual >= 50)
        {
            spriteActual.sprite = cientifico;
        }
    }

    void CuraFia()
    {
        if (pregunta >= 13 && f.longitudActual < 50)
        {
            spriteActual.sprite = curafia;
        } 
        else if (pregunta >= 13 && f.longitudActual >= 50)
        {
            spriteActual.sprite = cura;
        }
    }
}
