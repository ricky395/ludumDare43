using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGrabObjects : MonoBehaviour
{

    public Transform finalTransform;

    private GameObject pickedObject;

    private bool objectPicked;
    

    private void OnTriggerEnter(Collider other)
    {
        // Stores object to pick
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
            // Drop the object
            if (objectPicked)
            {
                objectPicked = false;
                if (finalTransform.childCount > 0)
                    pickedObject = finalTransform.GetChild(0).gameObject;

                pickedObject.GetComponent<Rigidbody>().isKinematic = false;
                pickedObject.transform.SetParent(null);

            }
            // Take the object
            else if(pickedObject != null)
            {
                // Set the object position and parent
                objectPicked = true;
                pickedObject.GetComponent<Rigidbody>().isKinematic = true;
                pickedObject.transform.position = finalTransform.position;
                pickedObject.transform.SetParent(finalTransform);

                // Disables object description
                GameController.instance.panel.gameObject.SetActive(false);
            }
        }
    }
    
}
