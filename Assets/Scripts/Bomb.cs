using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    bool bombTrig = false;
    public GameObject paticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.B) && !bombTrig)
        {
            GameObject[] enemyBulletObjects =
                GameObject.FindGameObjectsWithTag("EnemyBullet");
            for (int i = 0; i < enemyBulletObjects.Length; i++)
            {
                Destroy(enemyBulletObjects[i]);
            }
            Instantiate(paticle,Vector3.zero,Quaternion.identity);
        }
        bombTrig = Input.GetKey(KeyCode.B);
    }
}
