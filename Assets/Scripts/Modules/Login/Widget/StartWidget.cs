using UnityEngine;
using UnityEngine.UI;

namespace Modules.Login.Widget
{
    public class StartWidget : MonoBehaviour
    {
        [SerializeField] private Button _btnEditor;

        [SerializeField] private Button _btnEnter;

        private void Start()
        {
            _btnEnter.onClick.AddListener(OnClickEnter);
            _btnEditor.onClick.AddListener(OnClickEditor);
        }

        private void OnClickEnter()
        {
            LoginPresenter.instance.EnterHall();
        }

        private void OnClickEditor()
        {
            LoginPresenter.instance.ShowEidtorView();
        }
    }
}
