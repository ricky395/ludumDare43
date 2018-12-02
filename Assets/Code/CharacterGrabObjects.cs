using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGrabObjects : MonoBehaviour {

    public Transform finalTransform;

    private GameObject pickObject;

  

    private void OnTriggerStay(Collider other)
    {
       if(other.CompareTag("PickableObject") && Input.GetKeyDown(KeyCode.E))
        {
            pickObject = other.gameObject;
        }

    }





    //    　　　　　　　　▄█▀█▀█▄
    //　　　　　　　　▄█▀　　█　　▀█▄
    //　　　　　　　▄█▀　　　　　　　▀█▄
    //　　　　　　　█　　　　　　　　　█
    //　　　　　　　█　　　　　　　　　█
    //　　　　　　　▀█▄▄　　█　　　▄█▀
    //　　　　　　　　　█　　▄▀▄　　█
    //　　　　　　　　　█　▀　　　▀　█
    //　　　　　　　　　█　　　　　　　█
    //　　　　　　　　　█　　　　　　　█
    //　　　　　　　　　█　　　　 　　 █
    //　　　　　　　　　█　　　　　　　█
    //　　　　　　　　　█　　　　　　　█
    //　　　▄█▀▀█▄█▀▀▀▀　　　　　　　█▄█▀█▄
    //　▄█▀▀　　　　      　　　　　　　　　▀▀█
    //█▀　　　　　　　　　　　　　　　　　　　▀█
    //█　　　　　　　　　　　　　　　　　　　　　█
    //█　　　　　　　　　　　▄█▄　　　　　　　　　█
    //▀█　　　　　　　　　█▀　▀█　　　　　　　　█▀
    //　▀█▄　　　　　　█▀　　　▀█　　　　　▄█▀
    //　　　▀█▄▄▄█▀　　　　　　▀█▄▄▄█▀




    private void Update()
    {
       
       
        if( pickObject != null)
        {

            pickObject.GetComponent<Rigidbody>().isKinematic = true;
            pickObject.transform.position = finalTransform.position;

            if (Input.GetKeyDown(KeyCode.E)) {
                // aqui entra cuando lo coges >:D
                print("soltar");
            }
        }
        else
        {
            pickObject.GetComponent<Rigidbody>().isKinematic = false;
            pickObject   = null;
        }
    }


}
