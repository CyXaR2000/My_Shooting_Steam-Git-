using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // public float Speed;
    // public bool Grounded;
    public enum Axes
    {
        XandY,
        X,
        Y
    }
    public Axes _axes = Axes.XandY;
    public float RotationSpeedX;
    public float RotationSpeedY;

    public float MaxVert = 45f;
    public float MinVert = -45f;
    private float _rotationX = 0;
    public Rigidbody PlayerRigidbody;

    void Start()
    {
        PlayerRigidbody = GetComponent<Rigidbody>();
        if (PlayerRigidbody != null)
        {
            PlayerRigidbody.freezeRotation = true;
        }
    }

    void Update()
    {

        if (_axes == Axes.XandY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * RotationSpeedY;
            _rotationX = Mathf.Clamp(_rotationX, MinVert, MaxVert);

            float delta = Input.GetAxis("Mouse X") * RotationSpeedX;
            float _rotationY = transform.localEulerAngles.y + delta;

            transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
        }

        else if (_axes == Axes.X)
        {
            transform.Rotate(0f, Input.GetAxis("Mouse X") * RotationSpeedX, 0f);
        }

        else if (_axes == Axes.Y)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * RotationSpeedY;
            _rotationX = Mathf.Clamp(_rotationX, MinVert, MaxVert);

            float _rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, _rotationY, 0);
        }

    }
}
