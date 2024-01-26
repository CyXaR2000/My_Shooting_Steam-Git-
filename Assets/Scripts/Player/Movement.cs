using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;
    public float Gravity = -9.8f;
    private CharacterController PlayerCharacterController;

    void Start()
    {
        PlayerCharacterController = GetComponent<CharacterController>();
        if (PlayerCharacterController == null)
        {
            Debug.Log("CharacterController if NULL");
        }
    }
    void Update()
    {
        float deltaX = Speed * Input.GetAxis("Horizontal");
        float deltaZ = Speed * Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, Speed);
        movement.y = Gravity;

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        PlayerCharacterController.Move(movement);
        // transform.Translate(deltaX, 0, deltaZ);
    }
}
