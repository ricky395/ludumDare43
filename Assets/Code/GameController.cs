using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using DG.Tweening;
using UnityEngine.SceneManagement;

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
    public Text objName;
    public Text description;

    public Transform puerta;
    public Transform cam;

    List<GameObject> allPickables;

    private void Start()
    {
        numeroDeDesintegraciones = 0;
        allPickables = GameObject.FindGameObjectsWithTag("PickableObject").ToList();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(0);
        }
    }

    /// <summary>
    /// Deletes an object from the list
    /// </summary>
    /// <param name="obj"></param>
    public void DeleteObject(GameObject obj)
    {
        allPickables.Remove(obj);
    }

    /// <summary>
    /// Count of "sacrified" things and door trigger
    /// </summary>
    public void IncrementarNumeroDeDesintegraciones()
    {
        ++numeroDeDesintegraciones;
        if (numeroDeDesintegraciones == 3)
        {
            puerta.DORotate(new Vector3(0, 90, 0), 0.4f);
            cam.DOMoveX(25, 1f);
        }
    }
}
