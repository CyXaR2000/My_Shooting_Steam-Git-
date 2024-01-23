using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    
    public GameObject Enemy;

    public Transform EnemyPosition;

    private float _timer = 0f;

    void Start()
    {
        
    }


    void Update()
    {

        _timer += Time.deltaTime;

        if ( _timer > 5f)
    {

        GameObject newEnemy = Instantiate(Enemy, EnemyPosition.position, Quaternion.identity);
        // newBullet.GetComponent<Rigidbody>().velocity = Spawn.forward * BulletSpeed

         _timer = 0f;

    }
        
    }
}
