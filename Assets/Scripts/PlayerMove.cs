using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    void FixedUpdate()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += 0.1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= 0.1f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.z += 0.1f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.z -= 0.1f;
        }
        transform.position = pos;
    }
}
