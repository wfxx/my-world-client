using System;
using System.Reflection;
using Grpc.Core;
using UnityEngine;

namespace Common.Event
{
    public class EventListener
    {
        private Component comp;
        private string func;

        public static EventListener Create(Component comp, string func)
        {
            var listener = new EventListener();
            listener.func = func;
            listener.comp = comp;
            return listener;
        }

        void Call(params object[] args)
        {
            MethodInfo method = comp.GetType().GetMethod(func);
            method!.Invoke(comp, args);
        }
    }
}