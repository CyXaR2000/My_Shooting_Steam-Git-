using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    public float Speed;
    public int Damage;

    void Update()
    {
        transform.Translate(0, 0, Speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        PlayerCharacter player = other.GetComponent<PlayerCharacter>();
        if (player != null)
        {
            player.Hurt(Damage);
        }
    }
}
