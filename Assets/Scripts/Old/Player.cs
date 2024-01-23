using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody PlayerRigidbody;
    public float Speed;
    public float RotationSpeed;
    public bool Grounded;

    void Start()
    {
        PlayerRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        PlayerRigidbody.velocity += transform.forward * Speed * Input.GetAxis("Vertical");
        PlayerRigidbody.velocity += transform.right * Speed * Input.GetAxis("Horizontal");
        // transform.Rotate(0f, Input.GetAxis("Mouse X") * RotationSpeed, 0f);

        if (Input.GetKeyDown(KeyCode.Space) && Grounded == true)
        {
            PlayerRigidbody.velocity += new Vector3(0f, 5f, 0f);
        }
        PlayerRigidbody.velocity -= new Vector3(PlayerRigidbody.velocity.x, 0f, PlayerRigidbody.velocity.z) * 0.1f;
    }

    private void OnCollisionStay(Collision collision)
    {
        Grounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        Grounded = false;
    }
}
