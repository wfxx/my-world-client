using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneType
{
    None,
    Login,
    Hall,
    Game
}

public class MainLauncher : MonoBehaviour
{
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        ChangeScene(SceneType.Login);
    }

    public void ChangeScene(SceneType type)
    {
        int idx = (int)type;
        SceneManager.LoadSceneAsync(idx);
    }
}
