using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Transform TransformA;

    public Transform TransformB;

    public float Speed;

    public int Health = 3;

    void Start()
    {

        TransformB = FindObjectOfType<Player>().gameObject.transform;

    }

    void Update()
    {

        Vector3 fromAtoB = TransformB.position - TransformA.position;

        Vector3 fromAtoBNormalized = fromAtoB.normalized;

        TransformA.position += fromAtoBNormalized * Speed * Time.deltaTime;


        transform.LookAt(TransformB);


    }
}
