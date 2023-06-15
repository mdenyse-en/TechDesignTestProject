using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_loader : MonoBehaviour
{
    public void ChangeScene(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
    }

    public void GetFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
