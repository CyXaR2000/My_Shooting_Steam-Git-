using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   
   public float Speed; 

   public int Health = 3;

   void Start()
   {
       
   }

    void Update()
    {

         transform.Rotate(Vector3.right * Speed * Time.deltaTime, Space.Self);
        
    }

       private void OnCollisionEnter(Collision collision)
    {

       if (collision.gameObject.GetComponent<Enemy>())
       {

           collision.gameObject.GetComponent<Enemy>().Health -= 1;

            if(collision.gameObject.GetComponent<Enemy>().Health == 0)
            {

            Destroy(collision.gameObject);

            }

       }
       
    }

}
