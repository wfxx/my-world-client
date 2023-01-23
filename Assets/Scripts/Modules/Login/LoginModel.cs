using Common.Base;
using Const.Login;
using Myworld;
using UnityEngine;

namespace Modules.Login
{
    public class LoginModel : ModelBase<LoginModel>
    {
        protected override void RegisterCmd()
        {
            BindCmd(typeof(RegisterResponse), OnRegisterResponse);
            BindCmd(typeof(LoginResponse), OnLoginResponse);
        }
    
        public void InitData()
        {
            PlayerPrefs.GetString(LoginConst.LastPassword);
            PlayerPrefs.GetString(LoginConst.LastPassword);
        }

        public void OnSendRegisterRequest(string username, string password)
        {
            RegisterRequest request = new RegisterRequest
            {
                Type = AccountType.Tourist,
                Username = username,
                Password = password
            };
            SendCmd(request);
        }

        public void OnSendLoginRequest(string username, string password)
        {
            LoginRequest request = new LoginRequest
            {
                Username = username,
                Password = password
            };
            SendCmd(request);
        }
    
        private void OnRegisterResponse(object data)
        {
            RegisterResponse response = data as RegisterResponse;
            LoginPresenter.instance.OnRegisterResponse(response);
        }
    
        private void OnLoginResponse(object data)
        {
            LoginResponse response = data as LoginResponse;
            LoginPresenter.instance.OnLoginResponse(response);
        }
    }
}
