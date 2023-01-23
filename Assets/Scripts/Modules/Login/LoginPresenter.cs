using UnityEngine;
using Common.Base;
using Common.Event;
using Const;
using Const.Login;
using Modules.Login;
using Myworld;

public class LoginPresenter : PresenterBase<LoginPresenter>
{
    public void ShowLoginView()
    {
        currScene.ShowDialog(PrefabPath.LoginDialog);
    }
    
    public void OnSendRegisterRequest(string username, string password)
    {
        LoginModel.instance.OnSendRegisterRequest(username, password);
    }
    
    public void OnSendLoginRequest(string username, string password)
    {
        LoginModel.instance.OnSendLoginRequest(username, password);
    }

    public void OnRegisterResponse(RegisterResponse response)
    {
        if (response.Issuccess)
        {
            // 注册成功，进入大厅
        }
        else
        {
            
        }
    }

    public void OnLoginResponse(LoginResponse response)
    {
        if (response.Issuccess)
        {
            
        }
        else
        {
            
        }
    }
}
