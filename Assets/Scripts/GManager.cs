using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GManager : MonoBehaviour
{
    public Vector3[] indexAndPosString;
    public int[] waveString;
    public GameObject[] enemiesBox;
    public int battlePhase;
    GameObject[] enemy;
    public GameObject panel;
    public SceneChanger sceneChanger_;
    void Start()
    {
        battlePhase = 0;
        panel.SetActive(false);
        for(int i = 0; i < transform.childCount; i++)
        {
            if(transform.GetChild(i).GetComponent<Enemy>() != null)
            {
                Array.Resize(ref enemiesBox, enemiesBox.Length + 1);
                enemiesBox[enemiesBox.Length - 1] = transform.GetChild(i).gameObject;
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        enemy = GameObject.FindGameObjectsWithTag("Enemy");

        if(enemy.Length == 0)
        {
            if (battlePhase >= waveString.Length)
            {
                panel.SetActive(true);
                sceneChanger_.enabled = true;
            }
            else
            {
                int beforeTotalEnemyNum = 0;
                for (int i = 0; i < battlePhase; i++)
                {
                    beforeTotalEnemyNum += waveString[i];
                }
                for (int i = 0; i < waveString[battlePhase]; i++)
                {
                    if (beforeTotalEnemyNum + i < indexAndPosString.Length)
                    {
                        GameObject spawnedEnemy = Instantiate(enemiesBox[Mathf.RoundToInt(indexAndPosString[beforeTotalEnemyNum + i].z)]
                            , new Vector3(indexAndPosString[beforeTotalEnemyNum + i].x, 0, indexAndPosString[beforeTotalEnemyNum + i].y)
                            , Quaternion.identity);
                        spawnedEnemy.SetActive(true);
                    }
                }
                battlePhase++;
            }
        }
        else
        {
            panel.SetActive(false);
            sceneChanger_.enabled = false;
        }
    }
}
