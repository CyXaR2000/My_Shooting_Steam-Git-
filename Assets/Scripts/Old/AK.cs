using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK : MonoBehaviour
{

    public Transform point1; 
    
    public Transform point2; 

    public float Speed;

    bool CanGo = true;

    public float waitTime = 5f;

     public GameObject AK_47;

    void Start()
    {

        gameObject.transform.position = new Vector3(point1.position.x, point1.position.y, transform.position.z);
        
    }


    void Update()
    {
         if ( Input.GetMouseButton(0))
        {
        

        transform.position = Vector3.MoveTowards(transform.position, point1.position, Speed * Time.deltaTime);


        }

        Transform t = point1; 
        point1 = point2; 
        point2 = t; 
        CanGo = false; 
        StartCoroutine(Waiting());

         IEnumerator Waiting() 
        {

            yield return new WaitForSeconds(waitTime); 
        
            CanGo = true;

        }
        
    }
}
