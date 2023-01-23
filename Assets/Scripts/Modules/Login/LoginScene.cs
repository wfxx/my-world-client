using Common.Base;
using Const.Login;
using UnityEngine;

namespace Modules.Login
{
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
        
            ShowWidget(LoginWidgetType.Login);
        }

        protected override void InitEvent()
        {
        
        }

        public void ShowWidget(LoginWidgetType type)
        {
            _downloadWidget.SetActive(type == LoginWidgetType.Download);
            _loginWidget.SetActive(type == LoginWidgetType.Login);
            _startWidget.SetActive(type == LoginWidgetType.Start);
        }
    }
}
