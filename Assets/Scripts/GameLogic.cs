using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GameObject card;
    public CardLogic cl;
    SpriteRenderer sr;
    public float fMovingSpeed;
    public TMP_Text preguntas;
    public int pregunta = 0;

    // Start is called before the first frame update
    void Start()
    {
        sr = card.GetComponent<SpriteRenderer>();
        preguntas.text = "Estás siendo interrogado.";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && cl.isMouseOver)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            card.transform.position = pos;
        }
        else
        {
            card.transform.position = Vector2.MoveTowards(card.transform.position, new Vector2(0,0), fMovingSpeed*Time.deltaTime);
        }
        if(card.transform.position.x > 2)
        {
            sr.color = Color.green;
            if (!Input.GetMouseButton(0))
            {
                cl.InduceRight();
            }
        }
        else if(card.transform.position.x < -2)
        {
            sr.color = Color.red;
            if (!Input.GetMouseButton(0))
            {
                cl.InduceLeft();
            }
        }
        else
        {
            sr.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(pregunta == 0)
            {
                preguntas.text = "¿Sueles frecuentar los parques de noche?";
                pregunta++;
            }
            else if(pregunta == 1)
            {
                preguntas.text = "¿Alguien puede confirmar que no estuvieras en tu casa?";
                pregunta++;
            }
            else if (pregunta == 2)
            {
                preguntas.text = "¿Conocías a la víctima?";
                pregunta++;
            }
            else if (pregunta == 3)
            {
                preguntas.text = "¿Fuiste al trabajo la noche del 23?";
                pregunta++;
            }
            else if (pregunta == 4)
            {
                preguntas.text = "¿Habías cometido algún crimen antes?";
                pregunta = 0;
            }
        }
    }
}
