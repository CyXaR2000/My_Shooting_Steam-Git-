using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pointer : MonoBehaviour
{
    [SerializeField] private Transform CameraTransform;
    private Transform _aim;
    public SpriteRenderer GameObjectAim;
    public GameObject AimObject;

    void Start()
    {
        CameraTransform = Camera.main.transform;
        _aim = transform.GetChild(0);
        GameObjectAim = _aim.GetComponent<SpriteRenderer>();
        _aim.GetComponent<SpriteRenderer>().enabled = false;
    }

    void LateUpdate()
    {

        float scale = Vector3.Distance(transform.position, CameraTransform.position);
        transform.LookAt(CameraTransform);
        transform.eulerAngles = new Vector3(0, transform.rotation.y, 0);
    }
}
