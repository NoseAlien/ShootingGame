using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public GameObject Bullet;
    bool shotTrig = false;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && !shotTrig)
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
        shotTrig = Input.GetKey(KeyCode.Space);
    }
}
