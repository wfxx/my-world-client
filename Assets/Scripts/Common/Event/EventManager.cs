using System;
using Common.Base;
using UnityEngine;
using UnityEngine.Events;

namespace Common.Event
{
    // 事件管理器
    public delegate void EventCallback(object[] type);
    internal sealed class EventManager : Singleton<EventManager>
    {
        private EventPool pool;
        public void Init()
        {
            pool = new EventPool();
        }
        
        // 增加
        public void AddEventListener(string name, EventCallback call)
        {
            if (pool == null) Init();
            
            pool.Push(name, call);
        }

        // 设置
        public void SetEventListener(string name, EventCallback call)
        {
            if (pool == null) Init();

            pool.Clear(name);

            pool.Push(name, call);
        }

        public void DelEventListener(string name, EventCallback call)
        {
            pool.Pop(name, call);
        }

        public void PatchEvent(string name, params object[] args)
        {
            pool.Call(name, args);
        }
        
        public void CleanEventListener(string name)
        {
            pool.Clear(name);
        }
    }
}
