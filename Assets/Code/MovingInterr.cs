using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingInterr : MonoBehaviour
{
    public Transform camera;

    public Transform door;

    private float speed = 40;

    void Start ()
    {
        transform.DOMoveY(3.30f, 1).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.OutCirc);
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, transform.eulerAngles.z + Time.deltaTime * speed));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            camera.DOMoveX(25, 1f);
            door.DORotate(Vector2.zero, 0.3f);
        }
    }
}
