using Common.Base;
using Common.Event;
using Const;
using Const.Login;
using Myworld;

namespace Modules.Login
{
    public class LoginPresenter : PresenterBase<LoginPresenter>
    {
        protected LoginScene currScene;
        
        public void RegisterUI(LoginScene scene)
        {
            currScene = scene;
        }
        
        public void ShowLoginView()
        {
            currScene.ShowDialog(PrefabPath.LoginDialog);
        }

        public void ShowEidtorView()
        {
            currScene.ShowDialog(PrefabPath.EditorDialog);
        }

        public void EnterHall()
        {
            EventManager.instance.PatchEvent(EventConst.SceneChange, SceneType.Hall);
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
                currScene.ShowWidget(LoginWidgetType.Start);
            }
            else
            {
                ShowToast(response.Tips);
            }
        }

        public void OnLoginResponse(LoginResponse response)
        {
            if (response.Issuccess)
            {
                currScene.ShowWidget(LoginWidgetType.Start);
            }
            else
            {
                ShowToast(response.Tips);
            }
        }
    }
}
