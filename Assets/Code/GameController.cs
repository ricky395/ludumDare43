using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

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


    public Image panel;
    public Text name;
    public Text description;

    List<GameObject> allPickables;

    private void Start()
    {
        allPickables = GameObject.FindGameObjectsWithTag("PickableObject").ToList();
    }

    public void DeleteObject(GameObject obj)
    {
        allPickables.Remove(obj);
    }
}
