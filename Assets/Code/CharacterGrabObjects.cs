using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGrabObjects : MonoBehaviour
{

    public Transform finalTransform;

    private GameObject pickObject;

    private bool objectPicked;

    //private void OnTriggerStay(Collider other)
    //{
    //   if(other.CompareTag("PickableObject") && Input.GetKeyDown(KeyCode.E))
    //    {
    //        pickObject = other.gameObject;
    //    }

    //}

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PickableObject"))
        {
            pickObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PickableObject"))
        {
            pickObject = null;
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Suelta el obj
            if (objectPicked)
            {
                objectPicked = false;
                pickObject.GetComponent<Rigidbody>().isKinematic = false;
                pickObject.transform.SetParent(null);

            }
            // Coge el obj
            else if(pickObject != null)
            {
                objectPicked = true;
                pickObject.GetComponent<Rigidbody>().isKinematic = true;
                pickObject.transform.position = finalTransform.position;
                pickObject.transform.SetParent(finalTransform);
            }
        }
       
        //if( pickObject != null)
        //{

        //    pickObject.GetComponent<Rigidbody>().isKinematic = true;
        //    pickObject.transform.position = finalTransform.position;

        //    if (Input.GetKeyDown(KeyCode.E)) {
        //        // aqui entra cuando lo coges >:D
        //        print("soltar");
        //    }
        //}
        //else
        //{
        //    pickObject.GetComponent<Rigidbody>().isKinematic = false;
        //    pickObject   = null;
        //}
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



}
