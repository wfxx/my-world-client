using System;
using Google.Protobuf;
using NetWork;

namespace Common.Base
{
    // 处理数据
    public class ModelBase<T>:Singleton<T> where T : new()
    {
        void Init()
        {
            RegisterCmd();
        }
        
        protected virtual void RegisterCmd()
        {
            // 注册事件
        }
        
        protected void BindCmd(Type type, Handler handler)
        {
            NetManager.Instance.AddHandler(type, handler);
        }

        protected void SendCmd(IMessage obj)
        {
            NetManager.Instance.SendMessage(obj);
        }
    }
}