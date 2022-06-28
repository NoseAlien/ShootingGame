using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFixedShot : MonoBehaviour
{
    private GameObject player;
    public GameObject bullet;
    public int bulletWayNum = 3;
    public float bulletWaySpace = 30;
    public float bulletWayAxis = 0;
    public float time = 1;
    public float delayTime = 1;
    float nowTime = 0;

    void Start()
    {
        nowTime = delayTime;
    }
    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        nowTime -= Time.deltaTime;
        if (nowTime <= 0)
        {
            float bulletWaySpaceSplit = 0;
            for (int i = 0; i < bulletWayNum; i++)
            {
                CreateShotObject(bulletWaySpace - bulletWaySpaceSplit + bulletWayAxis - transform.localEulerAngles.y);
                bulletWaySpaceSplit += (bulletWaySpace / (bulletWayNum - 1) * 2);
            }
            nowTime = time;
        }
    }
    private void CreateShotObject(float axis)
    {
        GameObject bulletClone = Instantiate(bullet, transform.position, Quaternion.identity);
        var bulletObject = bulletClone.GetComponent<EnemyBullet>();
        bulletObject.SetCharacterObject(gameObject);
        bulletObject.SetForwardAxis(Quaternion.AngleAxis(axis, Vector3.up));
    }
}
