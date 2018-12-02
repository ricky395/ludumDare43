using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGrabObjects : MonoBehaviour
{

    public Transform finalTransform;

    private GameObject pickedObject;

    private bool objectPicked;

    //private void OnTriggerStay(Collider other)
    //{
    //   if(other.CompareTag("PickableObject") && Input.GetKeyDown(KeyCode.E))
    //    {
    //        pickedObject = other.gameObject;
    //    }

    //}

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PickableObject"))
        {
            pickedObject = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PickableObject"))
        {
            pickedObject = null;
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
                if (finalTransform.childCount > 0)
                    pickedObject = finalTransform.GetChild(0).gameObject;

                pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                pickedObject.transform.SetParent(null);

            }
            // Coge el obj
            else if(pickedObject != null)
            {
                objectPicked = true;
                pickedObject.GetComponent<Rigidbody>().isKinematic = true;
                pickedObject.transform.position = finalTransform.position;
                pickedObject.transform.SetParent(finalTransform);
            }
        }
       
        //if( pickedObject != null)
        //{

        //    pickedObject.GetComponent<Rigidbody>().isKinematic = true;
        //    pickedObject.transform.position = finalTransform.position;

        //    if (Input.GetKeyDown(KeyCode.E)) {
        //        // aqui entra cuando lo coges >:D
        //        print("soltar");
        //    }
        //}
        //else
        //{
        //    pickedObject.GetComponent<Rigidbody>().isKinematic = false;
        //    pickedObject   = null;
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
