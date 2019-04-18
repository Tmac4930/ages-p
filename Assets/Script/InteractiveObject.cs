﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class InteractiveObject : MonoBehaviour, IInteractive
{
    [SerializeField]
    private string displayText = nameof(InteractiveObject);

    public string DisplayText => displayText;
    private AudioSource audioSource;

    


    
     private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void InteractWith()
    {
        try
        {
        audioSource.Play();
        }
        catch (System.Exception)
        {

            throw new System.Exception("Missing audiosource component requires an audio Source component.");
        }
    
        Debug.Log($"Player just interaacted with {gameObject.name}.");
    }

   
}
