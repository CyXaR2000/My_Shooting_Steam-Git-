using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingСamera : MonoBehaviour
{
    public float Amount;
    public float Speed;

    private Vector3 _startPos;
    private float _distantion;
    private Vector3 _rotation = Vector3.zero;

    void Start()
    {
        _startPos = transform.position;
    }

    void Update()
    {
        _distantion += (transform.position - _startPos).magnitude;
        _startPos = transform.position;
        _rotation.z = Mathf.Sin(_distantion * Speed) * Amount;
        transform.localEulerAngles = _rotation;
    }
}
