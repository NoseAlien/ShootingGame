using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject Bullet;
    int shotInterval = 0;
    void FixedUpdate()
    {
        if (shotInterval <= 0)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                GameObject bullet_ = Instantiate(Bullet, transform.position, Quaternion.identity);
                bullet_.GetComponent<Bullet>().player = transform.parent.gameObject;
                shotInterval = 4;
            }
        }
        else
        {
            shotInterval--;
        }
    }
}
