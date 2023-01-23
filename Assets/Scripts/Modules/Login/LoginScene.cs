using System;
using System.Collections;
using System.Collections.Generic;
using Common.Base;
using UnityEngine;

public class LoginScene : SceneBase
{
    [SerializeField] private GameObject _widgetParent;
    [SerializeField] private GameObject _dialogParent;
    [SerializeField] private GameObject _downloadWidget;
    [SerializeField] private GameObject _loginWidget;
    [SerializeField] private GameObject _startWidget;

    protected override void InitUI()
    {
        LoginPresenter.instance.RegisterUI(this);
        
        _downloadWidget.SetActive(false);
        _loginWidget.SetActive(true);
        _startWidget.SetActive(false);
    }

    protected override void InitEvent()
    {
        
    }
}
