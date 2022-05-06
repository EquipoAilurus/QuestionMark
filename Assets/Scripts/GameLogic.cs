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
                preguntas.text = "¿Hay algún conocido común entre la víctima y usted?";
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

            else if (pregunta == 10)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Tomas estupefacientes?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 11)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Eres consciente de que muchos testigos te vieron cerca del escenario del crimen?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 12)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Te consideras una persona sociable?";
                soltado = false;
                pregunta++;
            }

            else if (pregunta == 13)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Eres el asesino?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 14)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Presentas un abogado?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 15)//Cura
            {
                CambioCura();
                t.longitudActual = 60;
                preguntas.text = "¿Aceptas la palabra de Dios?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 16)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Te arrepientes de tus pecados?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 17)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Vas los domingos a misa?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 18)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Sueles rezar?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 19)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Has leído la biblia?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 20)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Consideras que tus pecados son perdonables?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 21)
            {
                t.longitudActual = 60;
                preguntas.text = "Hijo, ¿te confesarás conmigo?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 22)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Alguna vez dudaste de la palabra de cristo?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 23)
            {
                t.longitudActual = 60;
                preguntas.text = "¡Oh, acepta tus pecados y ve con cristo!";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 24)
            {
                t.longitudActual = 60;
                preguntas.text = "Padre nuestro...";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 25)
            {
                t.longitudActual = 60;
                preguntas.text = "Hijo, Dios perdona todo, dime, eres culpable?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 26)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Consideras que tus pecados son perdonables?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 27)
            {
                t.longitudActual = 60;
                preguntas.text = "¿2 + 4?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 28)//Científico
            {
                CambioCientifico();
                t.longitudActual = 60;
                preguntas.text = "¿Te someterías al suero de la verdad?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 29)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Eres conscinete de que se ha encontrado tu ADN en la escena del crimen?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 30)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Darías positivo en un test de drogas?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 31)
            {
                t.longitudActual = 60;
                preguntas.text = "Según estos papeles, aún estás bajo los efectos de diversas drogas.";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 32)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Eres propenso a degustar carnes rojas?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 33)
            {
                t.longitudActual = 60;
                preguntas.text = "Recapitulando, según la parte de la primera parte correlacionada con la parte tercera, entonces, ¿si?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 34)
            {
                t.longitudActual = 60;
                preguntas.text = "Las leyes federales me indican que afirme que el consumo de cualquier sustancia psicotrópica está prohibido durante el interrogatorio.";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 35)
            {
                t.longitudActual = 60;
                preguntas.text = "¿De pequeño solias dañar animales?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 36)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Prefieres el color rojo o el azul?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 37)
            {
                t.longitudActual = 60;
                preguntas.text = "¿Sueles tener un horario específico?";
                soltado = false;
                pregunta++;
            }
            else if (pregunta == 38)
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

    void CambioCura()
    {
        spriteActual.sprite = cura;
    }

    void CambioCientifico()
    {
        spriteActual.sprite = cientifico;
    }

    void DetectiveFia()
    {
        if (pregunta < 15 && f.longitudActual < 50)
        {
            spriteActual.sprite = detectivefia;
        }
        else if (pregunta < 15 && f.longitudActual >= 50)
        {
            spriteActual.sprite = detective;
        }
    }

    void CuraFia()
    {
        if (pregunta >= 15 && pregunta < 28 && f.longitudActual < 50)
        {
            spriteActual.sprite = curafia;
        }
        else if (pregunta >= 15 && pregunta < 28 && f.longitudActual >= 50)
        {
            spriteActual.sprite = cura;
        }
    }

    void CientificoFia()
    {
        if (pregunta >= 28 && f.longitudActual < 50)
        {
            spriteActual.sprite = cientificofia;
        } 
        else if (pregunta >= 28 && f.longitudActual >= 50)
        {
            spriteActual.sprite = cientifico;
        }
    }
}
