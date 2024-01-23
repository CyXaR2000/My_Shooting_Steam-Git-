using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Transform Pointer;
    [SerializeField] private LayerMask LayerLight;
    [SerializeField] private float Speed;

    void LateUpdate()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 20000, LayerLight))
        {
            Pointer.position = hit.point;
            Vector3 toTarget = Pointer.position - transform.position;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(toTarget), Speed * Time.deltaTime);
        }
    }
}
