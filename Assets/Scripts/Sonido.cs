using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonido : MonoBehaviour
{
    public AudioClip boton;
    public AudioClip carta;

    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Boton()
    {
        audioSource.PlayOneShot(boton);
    }
    public void Carta()
    {
        audioSource.PlayOneShot(carta);
    }
}
