using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    public string nextScene;
    int wait;
    bool keyTrig;

    void Start()
    {
        keyTrig = true;
        wait = 60;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && !keyTrig && wait <= 0)
        {
            SceneManager.LoadScene(nextScene);
        }
        keyTrig = Input.GetKey(KeyCode.Space);
        wait--;
    }
}