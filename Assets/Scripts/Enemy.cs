using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int enemyHp;
    // Start is called before the first frame update
    void Start()
    {
        if (enemyHp < 3)
        {
            enemyHp = 3;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(enemyHp <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Damage()
    {
        enemyHp--;
    }
}
