using UnityEngine;
using UnityEngine.UI;

public class Bomb : MonoBehaviour
{
    float coolTime;
    bool bombTrig = false;
    public GameObject paticle;
    public Text BombIndicator;
    // Start is called before the first frame update
    void Start()
    {
        coolTime = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (coolTime <= 0)
        {
            if (Input.GetKey(KeyCode.B) && !bombTrig)
            {
                GameObject[] enemyBulletObjects =
                    GameObject.FindGameObjectsWithTag("EnemyBullet");
                for (int i = 0; i < enemyBulletObjects.Length; i++)
                {
                    Destroy(enemyBulletObjects[i]);
                }
                Instantiate(paticle, Vector3.zero, Quaternion.identity);

                coolTime = 10;
            }
            BombIndicator.text = "[ B ] : Bomb";
        }
        else
        {
            BombIndicator.text = "      " + Mathf.RoundToInt(coolTime + 0.5f).ToString();
            coolTime -= Time.deltaTime;
        }
        bombTrig = Input.GetKey(KeyCode.B);
        
    }
}
