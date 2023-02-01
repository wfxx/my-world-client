using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class CommonDialog : MonoBehaviour
{
    [SerializeField] private Text _commonTips;
    [SerializeField] private GameObject _objTypeOne;
    [SerializeField] private GameObject _objTypeTwo;
    [SerializeField] private Button _btnLeft;
    [SerializeField] private Button _btnRight;
    [SerializeField] private Button _btnCenter;
    [SerializeField] private Text _txtLeft;
    [SerializeField] private Text _txtRight;
    [SerializeField] private Text _txtCenter;

    public void ShowDialog(CommonDialogData data)
    {
        _commonTips.text = data.tips;

        if (data.data.Count == 1)
        {
            _objTypeOne.SetActive(true);
            _objTypeTwo.SetActive(false);
        
            _BindButtonData(_btnCenter, _txtCenter, data.data[0]);
        }
        else
        {
            _objTypeOne.SetActive(false);
            _objTypeTwo.SetActive(true);
        
            _BindButtonData(_btnLeft, _txtLeft, data.data[0]);
            _BindButtonData(_btnRight, _txtRight, data.data[1]);
        }
    }

    private void _BindButtonData(Button btn, Text txt, CommonButtonData data)
    {
        btn.onClick.RemoveAllListeners();
        btn.onClick.AddListener(()=>
        {
            if (data.func != null) data.func();
        });

        txt.text = data.tips;
    }
}
