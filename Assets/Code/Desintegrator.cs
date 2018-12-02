using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desintegrator : MonoBehaviour {


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PickableObject"))
        {
            Destroy(other.gameObject);
        }
    }
}
