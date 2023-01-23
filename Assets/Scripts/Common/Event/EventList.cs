using System.Collections.Generic;

namespace Common.Event
{
    public class EventList
    {
        private List<EventCallback> list = new List<EventCallback>();
        
        public void Push(EventCallback call)
        {
            Pop(call);
            list.Add(call);
        }

        public void Pop(EventCallback call)
        {
            if (list.Contains(call))
            {
                list.Remove(call);
            }
        }

        public void Call(params object[] args)
        {
            foreach (var callback in list)
            {
                callback(args);
            }
        }
    }
}