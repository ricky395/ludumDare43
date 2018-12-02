using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "PickableObjects", order = 1)]
public class PickableObjectSriptableObject : ScriptableObject
{

    public string objectName;

    public int importancia;

    public string textoEmergente;

    public GameObject prefab;

    public PickableObject po;

}




