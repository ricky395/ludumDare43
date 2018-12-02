﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour {

    public PickableObjectSriptableObject scriptableobject;



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameController.instance.name.text = scriptableobject.name;
            GameController.instance.description.text = scriptableobject.textoEmergente;

            GameController.instance.panel.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameController.instance.panel.gameObject.SetActive(false);
        }
    }
}