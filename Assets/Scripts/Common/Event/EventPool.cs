using System.Collections.Generic;
using UnityEngine;

namespace Common.Event
{
    public class EventPool
    {
        private Dictionary<string, EventList> dict;
        public void Push(string name, EventCallback call)
        {
            if (!dict.ContainsKey(name))
            {
                var list = new EventList();
                dict.Add(name, list);
            }
            dict[name].Push(call);
        }

        public void Pop(string name, EventCallback call)
        {
            if (!dict.ContainsKey(name))
            {
                return;
            }
            dict[name].Pop(call);
        }

        public void Call(string name, params object[] args)
        {
            if (!dict.ContainsKey(name))
            {
                return;
            }
            dict[name].Call(args);
        }
        
        public void Clear(string name)
        {
            
        }
    }
}