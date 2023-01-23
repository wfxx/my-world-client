using System;
using UnityEngine;

namespace Common.Base
{
    public class SceneBase : MonoBehaviour
    {
        private GameObject dialogParent;
        private GameObject widgetParent;
        private void Awake()
        {
            InitUI();
            InitEvent();
        }

        protected virtual void InitUI()
        {
            
        }
        
        protected virtual void InitEvent()
        {
            
        }
        
        public void ShowDialog(string path)
        {
            GameObject go = Resources.Load(path) as GameObject;
            go!.transform.parent = dialogParent.transform;
        }

        public void ShowWidget(string path)
        {
            GameObject go = Resources.Load(path) as GameObject;
            go!.transform.parent = widgetParent.transform;
        }
    }
}