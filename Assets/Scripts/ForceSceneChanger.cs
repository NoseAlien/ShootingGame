using UnityEngine.SceneManagement;
using UnityEngine;

public class ForceSceneChanger : MonoBehaviour
{
    public string nextScene;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
