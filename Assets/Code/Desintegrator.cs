﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desintegrator : MonoBehaviour {


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickableObject"))
        {
            GameController.instance.DeleteObject(other.gameObject);
            Destroy(other.gameObject);
        }
    }
}
