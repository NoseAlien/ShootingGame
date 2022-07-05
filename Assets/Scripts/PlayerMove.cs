using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    int score;
    int godMode;
    public Text scoreText;
    void Start()
    {
        score = 0;
        godMode = 0;
    }
        void FixedUpdate()
    {
        float speed = 0.3f;
        if (Input.GetKey(KeyCode.Space))
        {
            speed = 0.15f;
        }

        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.z += speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.z -= speed;
        }

        if(pos.x > 18)
        {
            pos.x = 18;
        }
        if (pos.x < -18)
        {
            pos.x = -18;
        }
        if (pos.z > 10)
        {
            pos.z = 10;
        }
        if (pos.z < -10)
        {
            pos.z = -10;
        }

        transform.position = pos;

        if(godMode > 0)
        {
            godMode--;
        }
        if(godMode > 100)
        {
            scoreText.color = new Color(1,1 - (godMode - 100)/20f, 1 - (godMode - 100) / 20f, 1);
        }
        else
        {
            scoreText.color = Color.white;
        }
        scoreText.text = "SCORE : " + (score * 10).ToString();
    }

    public void Damage()
    {
        if(godMode <= 0)
        {
            score /= 2;
            godMode = 120;
        }
    }

    public void TakeScore()
    {
        score += 10;
    }
}
