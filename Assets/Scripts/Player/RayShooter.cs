using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShooter : MonoBehaviour
{
    private Camera PlayerCamera;

    void Start()
    {
        PlayerCamera = GetComponent<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2, 0);

            Ray ray = PlayerCamera.ScreenPointToRay(screenCenter);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                GameObject hitObject = hit.transform.gameObject;
                ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();

                if (target != null)
                {
                    target.ReactToHit();
                }
                else
                {
                    StartCoroutine(SphereInicatorCoroutine(hit.point));
                    Debug.DrawLine(this.transform.position, hit.point, Color.red, 5);
                }
            }
        }
    }

    private void OnGUI()
    {
        int size = 12;
        float posX = PlayerCamera.pixelWidth / 2 - size / 4;
        float posY = PlayerCamera.pixelHeight / 2 - size / 4;
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }

    private IEnumerator SphereInicatorCoroutine(Vector3 pos)
    {
        GameObject aim = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        aim.transform.position = pos;

        yield return new WaitForSeconds(5);
        Destroy(aim);
    }
}
