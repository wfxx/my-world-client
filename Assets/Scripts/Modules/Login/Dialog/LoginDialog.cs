using UnityEngine;
using UnityEngine.UI;

namespace Modules.Login.Dialog
{
    public class LoginDialog : MonoBehaviour
    {
        [SerializeField] private InputField _inputUsername;
        [SerializeField] private InputField _inputPassword;
        [SerializeField] private Button _btnLogin;
        [SerializeField] private Button _btnToLogin;
        [SerializeField] private Button _btnRegister;
        [SerializeField] private Button _btnToRegister;

        private void Start()
        {
            InitUI();
            InitEvent();
        }

        private void InitUI()
        {
        
        }
    
        private void InitEvent()
        {
            _btnLogin.onClick.AddListener(OnClickLogin);
            _btnToLogin.onClick.AddListener(OnClickToLogin);
            _btnRegister.onClick.AddListener(OnClickRegister);
            _btnToRegister.onClick.AddListener(OnClickToRegister);
        }

        private void OnClickLogin()
        {
            var username = _inputUsername.text;
            var password = _inputPassword.text;
            LoginPresenter.instance.OnSendLoginRequest(username, password);
        }
    
        private void OnClickToLogin()
        {
            ShowLogin();
        }
    
        private void OnClickRegister()
        {
            var username = _inputUsername.text;
            var password = _inputPassword.text;
            LoginPresenter.instance.OnSendRegisterRequest(username, password);
        }
    
        private void OnClickToRegister()
        {
            ShowRegister();
        }
    
        private void ShowRegister()
        {
            _btnLogin.gameObject.SetActive(false);
            _btnToLogin.gameObject.SetActive(true);
            _btnRegister.gameObject.SetActive(true);
            _btnToRegister.gameObject.SetActive(false);
        }

        private void ShowLogin()
        {
            _btnLogin.gameObject.SetActive(true);
            _btnToLogin.gameObject.SetActive(false);
            _btnRegister.gameObject.SetActive(false);
            _btnToRegister.gameObject.SetActive(true);
        }
    }
}
