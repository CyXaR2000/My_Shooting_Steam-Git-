using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.GetComponent<Enemy>())
        {

        SceneManager.LoadScene(0);

        }

    }


}
