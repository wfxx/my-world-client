using System;
using System.Collections;
using System.Collections.Generic;
using Common.Event;
using Const.Login;
using UnityEngine;
using UnityEngine.UI;

public class LoginWidget : MonoBehaviour
{
    [SerializeField] private GameObject _btnGroup;
    [SerializeField] private Button _btnGameCenter;
    [SerializeField] private Button _btnFaceBook;
    [SerializeField] private Button _btnGoogle;
    [SerializeField] private Button _btnGuest;

    private void Start()
    {
        _btnGameCenter.onClick.AddListener(ClickGameCenter);
        _btnFaceBook.onClick.AddListener(ClickFacebook);
        _btnGoogle.onClick.AddListener(ClickGoogle);
        _btnGuest.onClick.AddListener(ClickGuest);
    }

    public void ShowLoginButton(bool isShow)
    {
        _btnGroup.SetActive(isShow);
    }

    public void ClickGameCenter()
    {
        
    }
    
    public void ClickFacebook()
    {
        
    }

    public void ClickGoogle()
    {
        
    }

    public void ClickGuest()
    {
        LoginPresenter.instance.ShowLoginView();
    }
}
