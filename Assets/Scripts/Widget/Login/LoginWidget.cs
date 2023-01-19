using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginWidget : MonoBehaviour
{
    [SerializeField] private Button LoginGuest;
    [SerializeField] private Button LoginGameCenter;
    [SerializeField] private Button LoginFacebook;
    [SerializeField] private Button LoginGoogle;
    // Start is called before the first frame update
    void Start()
    {
        LoginGuest.onClick.AddListener(ClickGuestLogin);
        LoginGameCenter.onClick.AddListener(ClickGameCenterLogin);
        LoginFacebook.onClick.AddListener(ClickFacebookLogin);
        LoginGoogle.onClick.AddListener(ClickGoogleLogin);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ClickGuestLogin()
    {
        // 弹出账号密码登录
    }

    void ClickGameCenterLogin()
    {
        // 游戏中心登录
    }

    void ClickFacebookLogin()
    {
        // Facebook登录
    }

    void ClickGoogleLogin()
    {
        // Google登录
    }
}
