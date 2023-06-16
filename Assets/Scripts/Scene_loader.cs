using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_loader : MonoBehaviour
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
