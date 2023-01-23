using System;
using Common.Event;
using Const;
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
        
        EventManager.instance.AddEventListener(EventConst.SceneChange, OnSceneChange);
    }

    private void OnSceneChange(params object[] args)
    {
        var type = (SceneType)args[0];
        ChangeScene(type);
    }
    
    private void ChangeScene(SceneType type)
    {
        int idx = (int)type;
        SceneManager.LoadSceneAsync(idx);
    }
}
