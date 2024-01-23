using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{

    public AudioSource Ringig;

    public float RotationSpeed = 5f;

    void Start()
    {

        Ringig = gameObject.GetComponent<AudioSource>();

        Ringig.enabled = false;


    }

    void Update()
    {

        transform.Rotate(0, 0, RotationSpeed * Time.deltaTime);

        float distane = Vector3.Distance(transform.position, FindObjectOfType<Player>().transform.position);

        if (distane < 2f)
        {

            Ringig.enabled = true;

            Destroy(gameObject, 1.1f);

        }

    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<Player>())
        {

            Ringig.enabled = true;


        }

    }

}
