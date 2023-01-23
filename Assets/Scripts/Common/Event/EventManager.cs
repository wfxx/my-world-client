using System;
using Common.Base;
using UnityEngine;

namespace Common.Event
{
    // 事件管理器
    internal sealed class EventManager : Singleton<EventManager>
    {
        private EventPool pool;
        public void Init()
        {
            pool = new EventPool();
        }
        
        // 增加
        public void AddEventListener(string name, Component comp, string func)
        {
            if (pool == null) Init();
            
            var listener = EventListener.Create(comp, func);
            pool.Push(name, listener);
        }

        // 设置
        public void SetEventListener(string name, Component comp, string func)
        {
            if (pool == null) Init();

            RemoveEventListener(name, comp);
            
            var listener = EventListener.Create(comp, func);
            pool.Push(name, listener);
        }

        public void PatchEvent(string name, params object[] args)
        {
            pool.Call(name, args);
        }
        
        public void RemoveEventListener(string name, Component comp)
        {
            pool.Pop(name, comp);
        }

        // 移除同一事件的监听
        public void CleanEventListener(string name)
        {
            pool.Clear(name);
        }
        
        // 移除同一组件的监听
        public void CleanEventListener(Component comp)
        {
            pool.Clear(comp);
        }
    }
}
