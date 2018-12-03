using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desintegrator : MonoBehaviour
{

    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TriggerEnter");
        if (other.CompareTag("PickableObject"))
        {
            Debug.Log("DELETE OBJ!");
            GameController.instance.DeleteObject(other.gameObject);
            Destroy(other.gameObject);
            GameController.instance.incrementarNumeroDeDesintegraciones();
        }
    }
}
