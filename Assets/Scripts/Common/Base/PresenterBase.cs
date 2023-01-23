
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Common.Base
{
    // 处理逻辑
    public class PresenterBase<T>:Singleton<T> where T : new()
    {
        public void ShowToast(string tips)
        {
            
        }
    }
}