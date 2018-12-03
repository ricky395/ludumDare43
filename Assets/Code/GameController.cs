using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using DG.Tweening;

public class GameController : MonoBehaviour
{

    #region Singleton
    public static GameController instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;

        else if (instance != this)
            Destroy(gameObject);

    }
    #endregion


    public int numeroDeDesintegraciones = 0;
    public Image panel;
    public Text name;
    public Text description;

    public Transform puerta;
    public Transform camera;

    List<GameObject> allPickables;

    private void Start()
    {
        allPickables = GameObject.FindGameObjectsWithTag("PickableObject").ToList();
    }

    public void DeleteObject(GameObject obj)
    {
        allPickables.Remove(obj);
    }

    public void IncrementarNumeroDeDesintegraciones()
    {
        ++numeroDeDesintegraciones;
        if (numeroDeDesintegraciones == 3)
        {
            puerta.DORotate(new Vector3(0, 90, 0), 0.4f);
            camera.DOMoveX(25, 1f);
        }
    }
}
